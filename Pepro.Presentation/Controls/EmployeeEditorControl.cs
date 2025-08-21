using Pepro.Business;
using Pepro.DTOs;
using System.ComponentModel;

namespace Pepro.Presentation.Controls;

public partial class EmployeeEditorControl : PeproEditorControlBase, IEditorUserControl<EmployeeDto> {
    private EmployeeDto _item = null!;
    private EditorMode _mode;

    public EmployeeEditorControl() {
        Initialize();
    }

    public EmployeeEditorControl(IMediator mediator) : base(mediator) {
        Initialize();
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public required EmployeeDto Item {
        get => _item;
        set {
            _item = value ?? throw new ArgumentNullException(nameof(Item));
            employeeIdInputField.Text = _item.EmployeeId.ToString();
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
            taxCodeInputField.Text = _item.TaxCode;
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

        saveButton.ApplyFlatStyle();
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

        departmentIdInputField.BindTextToValue(departmentComboBoxField);
        positionIdInputField.BindTextToValue(positionComboBoxField);
        salaryScaleIdInputField.BindTextToValue(salaryScaleComboBoxField);
        salaryLevelIdInputField.BindTextToValue(salaryLevelComboBoxField);

        departmentComboBoxField.DisplayMember = nameof(DepartmentDto.Name);
        departmentComboBoxField.ValueMember = nameof(DepartmentDto.DepartmentId);

        positionComboBoxField.DisplayMember = nameof(PositionDto.Title);
        positionComboBoxField.ValueMember = nameof(PositionDto.PositionId);

        salaryScaleComboBoxField.DisplayMember = nameof(SalaryScaleDto.Name);
        salaryScaleComboBoxField.ValueMember = nameof(SalaryScaleDto.SalaryScaleId);

        salaryLevelComboBoxField.DisplayMember = nameof(SalaryLevelDto.Level);
        salaryLevelComboBoxField.ValueMember = nameof(SalaryLevelDto.SalaryLevelId);

        departmentComboBoxField.DataSource = DepartmentBusiness.Instance.GetDepartments();
        positionComboBoxField.DataSource = PositionBusiness.Instance.GetPositions();

        switch (_mode) {
        case EditorMode.Create:
            salaryScaleComboBoxField.ExecuteWithoutEvent(
                nameof(PeproComboBoxField.SelectedIndexChanged),
                SalaryScaleComboBoxField_SelectedIndexChanged,
                () => salaryScaleComboBoxField.DataSource = SalaryScaleBusiness.Instance.GetSalaryScales()
            );
            SetupCreateMode();
            break;
        case EditorMode.Edit:
            // FIXME: The condition `SalaryScaleId != 1` is not optimized.
            // It causes the `GetSalaryLevelsBySalaryScaleId` method to be called twice.
            // It does not affect functionality but may reduce performance slightly.
            salaryScaleComboBoxField.DataSource = SalaryScaleBusiness.Instance.GetSalaryScales();
            SetupEditMode();
            break;
        }
    }

    private void SetupCreateMode() {
        departmentComboBoxField.SelectedIndex = -1;
        positionComboBoxField.SelectedIndex = -1;
        salaryScaleComboBoxField.SelectedIndex = -1;
    }

    private void SetupEditMode() {
        departmentComboBoxField.SelectedValue = _item.DepartmentId;
        positionComboBoxField.SelectedValue = _item.PositionId;

        SalaryScaleDto? salaryScale = SalaryScaleBusiness.Instance.GetSalaryScaleBySalaryLevelId(
            _item.SalaryLevelId
        );
        if (salaryScale != null)
        {
            salaryScaleComboBoxField.SelectedValue = salaryScale.SalaryScaleId;
        }
        salaryLevelComboBoxField.SelectedValue = _item.SalaryLevelId;
    }

    private void SalaryScaleComboBoxField_SelectedIndexChanged(object? sender, EventArgs e) {
        if (!int.TryParse(salaryScaleComboBoxField.SelectedValue?.ToString(), out int salaryScaleId)) {
            return;
        }

        List<SalaryLevelDto> salaryLevels = SalaryLevelBusiness.Instance.GetSalaryLevelsBySalaryScaleId(
            salaryScaleId
        );
        salaryLevelComboBoxField.DataSource = salaryLevels;
        salaryLevelComboBoxField.SelectedIndex = -1;
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
            return;
        }

        if (!int.TryParse(salaryLevelComboBoxField.SelectedValue?.ToString(), out int salaryLevelId)) {
            return;
        }

        if (!int.TryParse(employeeIdInputField.Text, out int employeeId)) {
            return;
        }

        EmployeeDto employee = new() {
            EmployeeId = employeeId,
            FirstName = firstNameInputField.Text.Trim(),
            MiddleName = middleNameInputField.Text.Trim(),
            LastName = lastNameInputField.Text.Trim(),
            DateOfBirth = dateOfBirthDateTimePicker.Value,
            Gender = gender,
            TaxCode = taxCodeInputField.Text.Trim(),
            CitizenId = citizenIdInputField.Text.Trim(),
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
                NotifyDataChanged();
                Close();

                MessageBox.Show("Thêm Nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        else {
            UpdateStaff();
        }
    }

    public void UpdateStaff() {
        bool? gender = null;
        if (maleRadioButton.Checked)
        {
            gender = true;
        }

        if (femaleRadioButton.Checked)
        {
            gender = false;
        }

        if (
            !int.TryParse(
                positionComboBoxField.SelectedValue?.ToString(),
                out int positionId
            )
            || !int.TryParse(
                salaryLevelComboBoxField.SelectedValue?.ToString(),
                out int salaryLevelId
            )
            || !int.TryParse(employeeIdInputField.Text, out int employeeId)
        )
        {
            return;
        }

        EmployeeDto employee = new()
        {
            EmployeeId = employeeId,
            FirstName = firstNameInputField.Text.Trim(),
            MiddleName = middleNameInputField.Text.Trim(),
            LastName = lastNameInputField.Text.Trim(),
            DateOfBirth = dateOfBirthDateTimePicker.Value,
            Gender = gender,
            TaxCode = taxCodeInputField.Text.Trim(),
            CitizenId = citizenIdInputField.Text.Trim(),
            DepartmentId = departmentComboBoxField.SelectedValue?.ToString() ?? "",
            PositionId = positionId,
            SalaryLevelId = salaryLevelId,
        };
        int result = EmployeeBusiness.Instance.UpdateEmployee(employee);
        if (result == 0)
        {
            return;
        }
        NotifyDataChanged();
        Close();

        MessageBox.Show("Cập nhật nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
