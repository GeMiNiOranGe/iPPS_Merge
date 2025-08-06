using Microsoft.Data.SqlClient;
using Pepro.Business;
using Pepro.DTOs;
using System.ComponentModel;

namespace Pepro.Presentation.Controls;

public partial class EmployeeEditorControl : PeproEditorControlBase, IEditorUserControl<Employee> {
    private Employee _item = null!;
    private EditorMode _mode;
    private bool _suppressSalaryLevelReload = false;
    SqlConnection sqlConnection = new(Config.CONNECTION_STRING);
    SqlCommand sqlCommand;

    public EmployeeEditorControl() {
        Initialize();
    }

    public EmployeeEditorControl(IMediator mediator) : base(mediator) {
        Initialize();
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public required Employee Item {
        get => _item;
        set {
            _item = value ?? throw new ArgumentNullException(nameof(Item));
            employeeIdInputField.Text = _item.EmployeeId;
            firstNameInputField.Text = _item.FirstName;
            middleNameInputField.Text = _item.MiddleName;
            lastNameInputField.Text = _item.LastName;
            dateOfBirthDateTimePicker.SetValue(_item.DateOfBirth);
            RadioButton genderRadioButton = _item.Gender switch {
                true => maleRadioButton,
                false => femaleRadioButton,
                _ => otherRadioButton,
            };
            genderRadioButton.Checked = true;
            // TODO: handle `_item.TaxCode`;
            taxCodeInputField.Text = "0000000000";
            citizenIdInputField.Text = _item.CitizenId;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public required EditorMode Mode {
        get => _mode;
        set {
            _mode = value;
            HeaderText = _mode switch {
                EditorMode.Create => "Create a new employee",
                EditorMode.Edit => "Edit employee",
                _ => throw new InvalidEnumArgumentException(nameof(Mode), (int)_mode, typeof(EditorMode)),
            };
        }
    }

    private void Initialize() {
        InitializeComponent();

        saveButton.SetupRuntimeFlatStyle();
    }

    private void EmployeeEditorControl_Load(object sender, EventArgs e) {
        if (string.IsNullOrEmpty(departmentIdInputField.Text) ||
            string.IsNullOrEmpty(positionIdInputField.Text) ||
            string.IsNullOrEmpty(salaryScaleIdInputField.Text) ||
            string.IsNullOrEmpty(salaryLevelIdInputField.Text)) {
            lbCheck1.ForeColor = Color.Red;
            lbCheck2.ForeColor = Color.Red;
            lbCheck3.ForeColor = Color.Red;
            lbCheck4.ForeColor = Color.Red;
        }

        departmentIdInputField.DataBindings.Add(
            nameof(departmentIdInputField.Text),
            departmentComboBoxField,
            nameof(departmentComboBoxField.SelectedValue)
        );

        positionIdInputField.DataBindings.Add(
            nameof(positionIdInputField.Text),
            positionComboBoxField,
            nameof(positionComboBoxField.SelectedValue)
        );

        salaryScaleIdInputField.DataBindings.Add(
            nameof(salaryScaleIdInputField.Text),
            salaryScaleComboBoxField,
            nameof(salaryScaleComboBoxField.SelectedValue)
        );

        salaryLevelIdInputField.DataBindings.Add(
            nameof(salaryLevelIdInputField.Text),
            salaryLevelComboBoxField,
            nameof(salaryLevelComboBoxField.SelectedValue)
        );

        departmentComboBoxField.DisplayMember = nameof(Department.Name);
        departmentComboBoxField.ValueMember = nameof(Department.DepartmentId);

        positionComboBoxField.DisplayMember = nameof(EmployeePosition.Title);
        positionComboBoxField.ValueMember = nameof(EmployeePosition.PositionId);

        salaryScaleComboBoxField.DisplayMember = nameof(SalaryScale.Name);
        salaryScaleComboBoxField.ValueMember = nameof(SalaryScale.SalaryScaleId);

        salaryLevelComboBoxField.DisplayMember = nameof(SalaryLevel.Level);
        salaryLevelComboBoxField.ValueMember = nameof(SalaryLevel.SalaryLevelId);

        List<Department> departments = DepartmentBusiness.Instance.GetDepartments();
        departmentComboBoxField.DataSource = departments;

        List<EmployeePosition> positions = PositionBusiness.Instance.GetPositions();
        positionComboBoxField.DataSource = positions;

        List<SalaryScale> salaryScales = SalaryScaleBusiness.Instance.GetSalaryScales();

        if (_mode == EditorMode.Create) {
            departmentComboBoxField.SelectedIndex = -1;
            positionComboBoxField.SelectedIndex = -1;

            _suppressSalaryLevelReload = true;
            salaryScaleComboBoxField.DataSource = salaryScales;
            salaryScaleComboBoxField.SelectedIndex = -1;
            _suppressSalaryLevelReload = false;
        }
        if (_mode == EditorMode.Edit) {
            departmentComboBoxField.SelectedValue = _item.DepartmentId;
            positionComboBoxField.SelectedValue = _item.PositionId;

            SalaryScale salaryScale = SalaryScaleBusiness.Instance.GetSalaryScaleBySalaryLevelId(
                _item.SalaryLevelId
            );
            salaryScaleComboBoxField.DataSource = salaryScales;
            salaryScaleComboBoxField.SelectedValue = salaryScale.SalaryScaleId;
            salaryLevelComboBoxField.SelectedValue = _item.SalaryLevelId;
        }
    }

    private void SalaryScaleComboBoxField_SelectedIndexChanged(object sender, EventArgs e) {
        if (_suppressSalaryLevelReload) {
            return;
        }

        if (int.TryParse(salaryScaleComboBoxField.SelectedValue?.ToString(), out int salaryScaleId)) {
            List<SalaryLevel> salaryLevels = SalaryLevelBusiness.Instance.GetSalaryLevelsBySalaryScaleId(
                salaryScaleId
            );
            salaryLevelComboBoxField.DataSource = salaryLevels;
            salaryLevelComboBoxField.SelectedIndex = -1;
        }
    }

    public void InsertStaff() {
        bool? gender = null;
        if (maleRadioButton.Checked) {
            gender = true;
        }
        if (femaleRadioButton.Checked) {
            gender = false;
        }

        if (!int.TryParse(positionComboBoxField.SelectedValue?.ToString(), out int positionId)) {
            positionId = 0;
        }

        if (!int.TryParse(salaryLevelComboBoxField.SelectedValue?.ToString(), out int salaryLevelId)) {
            salaryLevelId = 0;
        }

        Employee employee = new() {
            EmployeeId = employeeIdInputField.Text,
            FirstName = firstNameInputField.Text,
            MiddleName = middleNameInputField.Text,
            LastName = lastNameInputField.Text,
            DateOfBirth = dateOfBirthDateTimePicker.Value,
            Gender = gender,
            // TODO: handle `_item.TaxCode`;
            TaxCode = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            CitizenId = citizenIdInputField.Text,
            DepartmentId = departmentComboBoxField.SelectedValue?.ToString() ?? "",
            PositionId = positionId,
            SalaryLevelId = salaryLevelId,
        };
        _ = EmployeeBusiness.Instance.InsertEmployee(employee);
    }

    private void SaveButton_Click(object sender, EventArgs e) {
        if (Mode == EditorMode.Create) {
            if (string.IsNullOrWhiteSpace(citizenIdInputField.Text) ||
                string.IsNullOrEmpty(departmentIdInputField.Text) ||
                string.IsNullOrEmpty(positionIdInputField.Text) ||
                string.IsNullOrEmpty(salaryScaleIdInputField.Text) ||
                string.IsNullOrEmpty(salaryLevelIdInputField.Text)) {
                MessageBox.Show("Mời điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                InsertStaff();
                Close();

                MessageBox.Show("Thêm Nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        else {
            UpdateStaff();
            Close();
        }
    }

    public void UpdateStaff() {
        sqlConnection.Open();
        sqlCommand = new SqlCommand("UPDATE NHANVIEN SET HOTENNV = @HOTENNV, GIOITINH = @GIOITINH, NGAYSINH = @NGAYSINH, @NOISINH = NOISINH, QUEQUAN = @QUEQUAN, TRINHDOVANHOA = @TRINHDOVANHOA, DANTOC = @DANTOC, TONGIAO = @TONGIAO, DOANVIEN = @DOANVIEN, DANGVIEN = @DANGVIEN, CONGDOANVIEN = @CONGDOANVIEN, MAPB = @MAPB, MACV = @MACV, MANL = @MANL, MABL = @MABL WHERE MANV = @MANV", sqlConnection);
        sqlCommand.Parameters.AddWithValue("@MANV", employeeIdInputField.Text);
        sqlCommand.Parameters.AddWithValue("@HOTENNV", firstNameInputField.Text);
        if (maleRadioButton.Checked) {
            sqlCommand.Parameters.AddWithValue("@GIOITINH", "1");
        }
        else {
            sqlCommand.Parameters.AddWithValue("@GIOITINH", "0");
        }
        dateOfBirthDateTimePicker.Format = DateTimePickerFormat.Custom;
        dateOfBirthDateTimePicker.CustomFormat = "yyyyMMdd";
        sqlCommand.Parameters.AddWithValue("@NGAYSINH", dateOfBirthDateTimePicker.Text);
        sqlCommand.Parameters.AddWithValue("@MAPB", departmentIdInputField.Text);
        sqlCommand.Parameters.AddWithValue("@MACV", positionIdInputField.Text);
        sqlCommand.Parameters.AddWithValue("@MANL", salaryScaleIdInputField.Text);
        sqlCommand.Parameters.AddWithValue("@MABL", salaryLevelIdInputField.Text);
        sqlCommand.ExecuteNonQuery();

        sqlConnection.Close();

        MessageBox.Show("Cập nhật nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
