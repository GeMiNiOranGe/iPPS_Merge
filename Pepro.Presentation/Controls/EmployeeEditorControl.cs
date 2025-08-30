using Pepro.Business;
using Pepro.Business.Utilities;
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
            EmployeeHelper.SelectGenderRadio(
                _item.Gender,
                maleRadioButton,
                femaleRadioButton,
                otherRadioButton
            ).Checked = true;
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

    private void SaveButton_Click(object sender, EventArgs e)
    {
        if (!ValidateInputs())
        {
            MessageBoxWrapper.ShowInformation("FillInformation");
            return;
        }

        if (
            !int.TryParse(employeeIdInputField.Text, out int employeeId)
            || !int.TryParse(
                positionComboBoxField.SelectedValue?.ToString(),
                out int positionId
            )
            || !int.TryParse(
                salaryLevelComboBoxField.SelectedValue?.ToString(),
                out int salaryLevelId
            )
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
            DateOfBirth = DateOnly.FromDateTime(dateOfBirthDateTimePicker.Value),
            Gender = EmployeeHelper.GetSelectedGender(
                maleRadioButton,
                femaleRadioButton
            ),
            TaxCode = taxCodeInputField.Text.Trim(),
            CitizenId = citizenIdInputField.Text.Trim(),
            DepartmentId = departmentComboBoxField.SelectedValue?.ToString() ?? "",
            PositionId = positionId,
            SalaryLevelId = salaryLevelId,
        };

        int result = _mode switch
        {
            EditorMode.Create => EmployeeBusiness.Instance.InsertEmployee(employee),
            EditorMode.Edit => EmployeeBusiness.Instance.UpdateEmployee(employee),
            _ => throw new InvalidEnumArgumentException(nameof(Mode), (int)_mode, typeof(EditorMode)),
        };

        if (result > 0)
        {
            NotifyDataChanged();
            Close();
            MessageBoxWrapper.ShowInformation("SaveSuccess");
        }
        else
        {
            MessageBoxWrapper.ShowError("SaveFailed");
        }
    }

    private bool ValidateInputs()
    {
        return !string.IsNullOrWhiteSpace(citizenIdInputField.Text)
            && !string.IsNullOrWhiteSpace(firstNameInputField.Text)
            && !string.IsNullOrWhiteSpace(lastNameInputField.Text)
            && !string.IsNullOrWhiteSpace(
                departmentComboBoxField.SelectedValue?.ToString()
            )
            && !string.IsNullOrWhiteSpace(
                positionComboBoxField.SelectedValue?.ToString()
            )
            && !string.IsNullOrWhiteSpace(
                salaryLevelComboBoxField.SelectedValue?.ToString()
            );
    }
}
