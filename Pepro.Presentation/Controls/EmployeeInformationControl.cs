using Pepro.Business;
using Pepro.DTOs;

namespace Pepro.Presentation.Controls;

public partial class EmployeeInformationControl : UserControl
{
    string strId;
    public EmployeeInformationControl(string employeeID)
    {
        InitializeComponent();
        strId = employeeID;
    }

    private void frmInfo_Load(object sender, EventArgs e)
    {
        CEmployee getEmployee = EmployeeBusiness.Instance.getEmployeebyEmployeeID(strId);
        txtEmpoyeeID.Text = getEmployee.Id;
        txtEmployeeName.Text = getEmployee.FirstName + " " + getEmployee.MiddleName + " " + getEmployee.LastName;
        bool bSex = getEmployee.Sex;
        if (bSex)
        {
            rdoMale.Checked = true;
        }
        else
        {
            rdoFemale.Checked = true;
        }
        string employeeBirthday = getEmployee.DateOfBirth.ToString();
        dtpEmployeeBirthday.Value = DateTime.Parse(employeeBirthday);
        txtCCCD.Text = getEmployee.CitizenIdNumber;
        CRole getRole = EmployeeBusiness.Instance.getRolebyEmployeeID(strId);
        txtRole.Text = getRole.Name;
        string departmentID = getEmployee.DepartmentId;
        CDepartment getDepartment = EmployeeBusiness.Instance.getDepartmentbyDepartmentID(departmentID);
        txtDepartment.Text = getDepartment.Name;
        List<CEmployeeBelongToProject> listProjectID = EmployeeBusiness.Instance.getProjectIDbyEmployeeID(strId);
        if (listProjectID.Count > 0)
        {
            foreach (CEmployeeBelongToProject projectID in listProjectID)
            {
                CProject getProject = EmployeeBusiness.Instance.getProjectbyProjectID(projectID.ProjectId);
                cbProject.Items.Add(getProject.Name);
            }
            cbProject.Text = cbProject.Items[0].ToString();
        }
        else
        {
            cbProject.Items.Add("Không có");
            cbProject.Text = cbProject.Items[0].ToString();
        }
        List<CEmployeePhoneNumber> listPhoneNumber = EmployeeBusiness.Instance.getPhoneNumberbyEmployeeID(strId);
        foreach(CEmployeePhoneNumber phoneNumber in listPhoneNumber)
        {
            cbSDT.Items.Add(phoneNumber.PhoneNumber);
        }
        cbSDT.Text = cbSDT.Items[0].ToString();
    }
}
