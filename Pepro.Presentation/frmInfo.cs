using Pepro.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace Pepro.Presentation
{
    public partial class frmInfo : Form
    {
        string strId;
        public frmInfo(string employeeID)
        {
            InitializeComponent();
            strId = employeeID;
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {
            CEmployee getEmployee = CEmployeeInfoBLL.getEmployeebyEmployeeID(strId);
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
            CRole getRole = CEmployeeInfoBLL.getRolebyEmployeeID(strId);
            txtRole.Text = getRole.Name;
            string departmentID = getEmployee.DepartmentId;
            CDepartment getDepartment = CEmployeeInfoBLL.getDepartmentbyDepartmentID(departmentID);
            txtDepartment.Text = getDepartment.Name;
            List<CEmployeeBelongToProject> listProjectID = CEmployeeInfoBLL.getProjectIDbyEmployeeID(strId);
            if (listProjectID.Count > 0)
            {
                foreach (CEmployeeBelongToProject projectID in listProjectID)
                {
                    CProject getProject = CEmployeeInfoBLL.getProjectbyProjectID(projectID.ProjectId);
                    cbProject.Items.Add(getProject.Name);
                }
                cbProject.Text = cbProject.Items[0].ToString();
            }
            else
            {
                cbProject.Items.Add("Không có");
                cbProject.Text = cbProject.Items[0].ToString();
            }
            List<CEmployeePhoneNumber> listPhoneNumber = CEmployeeInfoBLL.getPhoneNumberbyEmployeeID(strId);
            foreach(CEmployeePhoneNumber phoneNumber in listPhoneNumber)
            {
                cbSDT.Items.Add(phoneNumber.PhoneNumber);
            }
            cbSDT.Text = cbSDT.Items[0].ToString();
        }
    }
}
