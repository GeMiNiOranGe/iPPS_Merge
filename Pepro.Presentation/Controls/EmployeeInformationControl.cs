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
        /*
        CEmployee getEmployee = EmployeeBusiness.Instance.GetEmployeebyEmployeeID(_employeeId);
        empoyeeIdTextBox.Text = getEmployee.Id;
        employeeNameTextBox.Text = getEmployee.FirstName + " " + getEmployee.MiddleName + " " + getEmployee.LastName;
        bool bSex = getEmployee.Sex;
        if (bSex)
        {
            maleRadioButton.Checked = true;
        }
        else
        {
            femaleRadioButton.Checked = true;
        }
        string employeeBirthday = getEmployee.DateOfBirth.ToString();
        dateOfBirthDateTimePicker.Value = DateTime.Parse(employeeBirthday);
        citizenIdTextBox.Text = getEmployee.CitizenIdNumber;
        CRole getRole = EmployeeBusiness.Instance.GetRolebyEmployeeID(_employeeId);
        roleTextBox.Text = getRole.Name;
        string departmentID = getEmployee.DepartmentId;
        CDepartment getDepartment = EmployeeBusiness.Instance.GetDepartmentbyDepartmentID(departmentID);
        departmentTextBox.Text = getDepartment.Name;
        List<CEmployeeBelongToProject> listProjectID = EmployeeBusiness.Instance.GetProjectIDbyEmployeeID(_employeeId);
        if (listProjectID.Count > 0)
        {
            foreach (CEmployeeBelongToProject projectID in listProjectID)
            {
                CProject getProject = EmployeeBusiness.Instance.GetProjectbyProjectID(projectID.ProjectId);
                projectComboBox.Items.Add(getProject.Name);
            }
            projectComboBox.Text = projectComboBox.Items[0].ToString();
        }
        else
        {
            projectComboBox.Items.Add("Không có");
            projectComboBox.Text = projectComboBox.Items[0].ToString();
        }
        List<CEmployeePhoneNumber> listPhoneNumber = EmployeeBusiness.Instance.GetPhoneNumberbyEmployeeID(_employeeId);
        foreach(CEmployeePhoneNumber phoneNumber in listPhoneNumber)
        {
            phoneNumberComboBox.Items.Add(phoneNumber.PhoneNumber);
        }
        phoneNumberComboBox.Text = phoneNumberComboBox.Items[0].ToString();
        */
    }
}
