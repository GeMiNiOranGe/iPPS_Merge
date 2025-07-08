using Pepro.Business;
using Pepro.DTOs;

namespace Pepro.Presentation.Controls;

public partial class EmployeeInformationControl : UserControl
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
        employeeIdTextBox.Text = employee.EmployeeId;
        employeeNameTextBox.Text = employee.FirstName + " " + employee.MiddleName + " " + employee.LastName;

        RadioButton genderRadioButton = employee.Gender switch {
            true => maleRadioButton,
            false => femaleRadioButton,
            _ => otherRadioButton
        };
        genderRadioButton.Checked = true;

        dateOfBirthDateTimePicker.Value = employee.DateOfBirth;
        citizenIdTextBox.Text = employee.CitizenId;
        /*
        CRole getRole = EmployeeBusiness.Instance.GetRolebyEmployeeID(_employeeId);
        roleTextBox.Text = getRole.Name;
        */
        Department department = DepartmentBusiness.Instance.GetDepartmentByDepartmentId(employee.DepartmentId);
        departmentTextBox.Text = department.Name;

        string[] projectNames = ProjectBusiness.Instance.GetProjectsByEmployeeId(employee.EmployeeId);
        projectComboBox.Items.AddRange(projectNames);
        projectComboBox.Text = projectComboBox.Items[0]?.ToString();

        string[] phoneNumbers = EmployeeBusiness.Instance.GetPhoneNumberListByEmployeeId(_employeeId);
        phoneNumberComboBox.Items.AddRange(phoneNumbers);
        phoneNumberComboBox.Text = phoneNumberComboBox.Items[0]?.ToString();
    }
}
