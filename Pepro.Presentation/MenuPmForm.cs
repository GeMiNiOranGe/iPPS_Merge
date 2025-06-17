using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pepro.Presentation
{
    public partial class MenuPmForm : Form
    {
        private int _roleID;
        public MenuPmForm(int roleID)
        {
            InitializeComponent();
            _roleID = roleID;
            lbRole.Text ="RoleID: "+roleID.ToString();
            checkPermission(_roleID);
     
        }

        private void picLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Log out?", "Confirm", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close(); 
                LoginForm loginForm = new();
                loginForm.Show();
            }

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
           
           pnMenu.Controls.Clear();
            EmployeeForm employee = new EmployeeForm(_roleID);
            employee.TopLevel = false;
            employee.Dock = DockStyle.Fill;
            employee.FormBorderStyle = FormBorderStyle.None;
            pnMenu.Controls.Add(employee);
            employee.Show();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            DepartmentForm fdp= new DepartmentForm();
            fdp.TopLevel = false;
            fdp.Dock = DockStyle.Fill;
            fdp.FormBorderStyle = FormBorderStyle.None;
            pnMenu.Controls.Add(fdp);
            fdp.Show();
        }

        private void btnGrant_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            GrantRoleForm gr = new GrantRoleForm(_roleID);
            gr.TopLevel = false;
            gr.Dock = DockStyle.Fill;
            gr.FormBorderStyle = FormBorderStyle.None;
            pnMenu.Controls.Add(gr);
            gr.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
        private void checkPermission(int roleid)
        {
            if (roleid != 1)
            {
                btnDepartment.Visible = false;
                btnAR.Visible = false;
                btnGrant.Visible = false;
            }
        }

        private void btnAR_Click(object sender, EventArgs e)
        {
            pnMenu.Controls.Clear();
            AccountRoleForm far=new AccountRoleForm();
            far.TopLevel = false;
            far.Dock = DockStyle.Fill;
            far.FormBorderStyle = FormBorderStyle.None;
            pnMenu.Controls.Add(far);
            far.Show();
        }
    }
}
