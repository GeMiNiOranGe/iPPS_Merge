using Pepro.Business;
using Pepro.DTOs;

namespace Pepro.Presentation.Controls;

public partial class EmployeeInformationControl : PeproUserControl
{
    private readonly string _employeeId;

    public EmployeeInformationControl(string employeeId)
    {
        InitializeComponent();
        _employeeId = employeeId;
    }

    private void EmployeeInformationControl_Load(object sender, EventArgs e)
    {
        Employee employee = EmployeeBusiness.Instance.GetEmployeeByEmployeeId(_employeeId);
        employeeIdInputField.Text = employee.EmployeeId;
        fullNameInputField.Text = employee.FirstName + " " + employee.MiddleName + " " + employee.LastName;

        RadioButton genderRadioButton = employee.Gender switch {
            true => maleRadioButton,
            false => femaleRadioButton,
            _ => otherRadioButton
        };
        genderRadioButton.Checked = true;

        dateOfBirthDateTimePicker.Value = employee.DateOfBirth;
        citizenIdInputField.Text = employee.CitizenId;
        /*
        CRole getRole = EmployeeBusiness.Instance.GetRolebyEmployeeID(_employeeId);
        roleTextBox.Text = getRole.Name;
        */
        Department department = DepartmentBusiness.Instance.GetDepartmentByDepartmentId(employee.DepartmentId);
        departmentInputField.Text = department.Name;

        string[] projectNames = ProjectBusiness.Instance.GetProjectsByEmployeeId(_employeeId);
        assignedProjectsComboBoxField.Items.AddRange(projectNames);
        assignedProjectsComboBoxField.Text = assignedProjectsComboBoxField.Items[0]?.ToString();

        string[] phoneNumbers = EmployeeBusiness.Instance.GetPhoneNumberListByEmployeeId(_employeeId);
        phoneNumberComboBoxField.Items.AddRange(phoneNumbers);
        phoneNumberComboBoxField.Text = phoneNumberComboBoxField.Items[0]?.ToString();
    }
}
