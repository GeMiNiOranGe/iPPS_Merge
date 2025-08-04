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
        departmentComboBoxField.SelectedIndex = -1;

        List<EmployeePosition> positions = PositionBusiness.Instance.GetPositions();
        positionComboBoxField.DataSource = positions;
        positionComboBoxField.SelectedIndex = -1;

        _suppressSalaryLevelReload = true;
        List<SalaryScale> salaryScale = SalaryScaleBusiness.Instance.GetSalaryScales();
        salaryScaleComboBoxField.DataSource = salaryScale;
        salaryScaleComboBoxField.SelectedIndex = -1;
        _suppressSalaryLevelReload = false;
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
        string insertQuery = "INSERT INTO NHANVIEN (MANV, HOTENNV, GIOITINH, NGAYSINH, NOISINH, QUEQUAN, TRINHDOVANHOA, DANTOC, TONGIAO, DOANVIEN, DANGVIEN, CONGDOANVIEN, MAPB, MACV, MANL, MABL) " +
                             "VALUES (@MANV, @HOTENNV, @GIOITINH, @NGAYSINH, @NOISINH, @QUEQUAN, @TRINHDOVANHOA, @DANTOC, @TONGIAO, @DOANVIEN, @DANGVIEN, @CONGDOANVIEN, @MAPB, @MACV, @MANL, @MABL)";

        sqlConnection.Open();

        sqlCommand = new SqlCommand(insertQuery, sqlConnection);
        sqlCommand.Parameters.AddWithValue("@MANV", employeeIdInputField.Text);
        sqlCommand.Parameters.AddWithValue("@HOTENNV", fullNameInputField.Text);
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
    }

    private void SaveButton_Click(object sender, EventArgs e) {
        if (Mode == EditorMode.Create) {
            if (string.IsNullOrEmpty(departmentIdInputField.Text) ||
                string.IsNullOrEmpty(positionIdInputField.Text) ||
                string.IsNullOrEmpty(salaryScaleIdInputField.Text) ||
                string.IsNullOrEmpty(salaryLevelIdInputField.Text)) {
                MessageBox.Show("Mời điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                InsertStaff();

                MessageBox.Show("Thêm Nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        else {
            UpdateStaff();
        }
    }

    public void UpdateStaff() {
        sqlConnection.Open();
        sqlCommand = new SqlCommand("UPDATE NHANVIEN SET HOTENNV = @HOTENNV, GIOITINH = @GIOITINH, NGAYSINH = @NGAYSINH, @NOISINH = NOISINH, QUEQUAN = @QUEQUAN, TRINHDOVANHOA = @TRINHDOVANHOA, DANTOC = @DANTOC, TONGIAO = @TONGIAO, DOANVIEN = @DOANVIEN, DANGVIEN = @DANGVIEN, CONGDOANVIEN = @CONGDOANVIEN, MAPB = @MAPB, MACV = @MACV, MANL = @MANL, MABL = @MABL WHERE MANV = @MANV", sqlConnection);
        sqlCommand.Parameters.AddWithValue("@MANV", employeeIdInputField.Text);
        sqlCommand.Parameters.AddWithValue("@HOTENNV", fullNameInputField.Text);
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
