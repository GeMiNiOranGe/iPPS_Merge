using Pepro.Business;
using Pepro.DTOs;
using System.ComponentModel;

namespace Pepro.Presentation.Controls;

public partial class EmployeeInformationControl : PeproMediatedUserControl
{
    private int _employeeId;

    public EmployeeInformationControl()
    {
        InitializeComponent();
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public required int EmployeeId
    {
        get => _employeeId;
        set => _employeeId = value;
    }

    private void EmployeeInformationControl_Load(object sender, EventArgs e)
    {
        EmployeeDto? employee = EmployeeBusiness.Instance.GetEmployeeByEmployeeId(_employeeId);
        if (employee == null)
        {
            MessageBox.Show("Employee not found");
            return;
        }

        employeeIdInputField.Text = employee.EmployeeId.ToString();
        fullNameInputField.Text = employee.FullName;
        (
            employee.Gender switch
            {
                true => maleRadioButton,
                false => femaleRadioButton,
                _ => otherRadioButton,
            }
        ).Checked = true;
        dateOfBirthDateTimePicker.SetValue(employee.DateOfBirth);
        citizenIdInputField.Text = employee.CitizenId;

        positionInputField.Text = PositionBusiness.Instance.GetPositionTitleByEmployeeId(_employeeId);

        DepartmentDto? department = DepartmentBusiness.Instance.GetDepartmentByDepartmentId(employee.DepartmentId);
        if (department != null)
        {
            departmentInputField.Text = department.Name;
        }
        else
        {
            departmentInputField.Text = "Department not found";
        }

        string[] projectNames = ProjectBusiness.Instance.GetProjectNamesByEmployeeId(_employeeId);
        assignedProjectsComboBoxField.DataSource = projectNames.Length != 0 ? projectNames : ["Không tìm thấy"];

        string[] phoneNumbers = EmployeeBusiness.Instance.GetPhoneNumbersByEmployeeId(_employeeId);
        phoneNumberComboBoxField.DataSource = phoneNumbers.Length != 0 ? phoneNumbers : ["Không tìm thấy"];
    }
}
