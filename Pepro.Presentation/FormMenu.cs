using Microsoft.Data.SqlClient;
using System.ComponentModel;

namespace Pepro.Presentation;

public partial class FormMenu : Form {
    private readonly SqlConnection conn = new(
        @"Data Source=.;Initial Catalog=Pepro;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"
    );
    private string? userId;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string? UserId {
        get => userId;
        set => userId = value;
    }

    public FormMenu() {
        InitializeComponent();
    }

    private void OpenChildControl(UserControl child) {
        workplacePanel.Controls.Clear();
        child.Dock = DockStyle.Fill;
        workplacePanel.Controls.Add(child);
        child.BringToFront();
        //child.Show();
    }

    public string GetFullname() {
        string strFullname;
        string query = $"SELECT FirstName, MiddleName, LastName FROM Employee WHERE Employee.EmployeeId = N'{userId}'";
        conn.Open();
        var sqlCommand = new SqlCommand(query, conn);
        var sqlDataReader = sqlCommand.ExecuteReader();
        sqlDataReader.Read();
        strFullname = sqlDataReader["FirstName"] + ", " + sqlDataReader["LastName"];
        conn.Close();
        return strFullname;
    }

    public string GetRole() {
        //string strRole;
        //string query = $"select NAME from ROLE where EMPLOYEE_ID = N'{userId}'";
        //conn.Open();
        //var sqlCommand = new SqlCommand(query, conn);
        //var sqlDataReader = sqlCommand.ExecuteReader();
        //sqlDataReader.Read();
        //strRole = sqlDataReader["NAME"].ToString();
        //conn.Close();
        //return strRole;
        return "Test";
    }

    private void MenuForm_Load(object sender, EventArgs e) {
        usernameLabel.Text = GetFullname();
        roleLabel.Text = GetRole();
    }

    private void MenuForm_FormClosing(object sender, FormClosingEventArgs e) {
        DialogResult dialogResult = MessageBox.Show(
            "Bạn có chắc muốn thoát không?",
            "Thông báo",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );
        if (dialogResult == DialogResult.No) {
            e.Cancel = true;
        }
    }

    private void TaskButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(taskButton.Location.Y);

        string query = $"select * from EMPLOYEE inner join ROLE on EMPLOYEE.ID = ROLE.EMPLOYEE_ID where EMPLOYEE.ID = N'{userId}'";
        conn.Open();
        var sqlCommand = new SqlCommand(query, conn);
        var sqlDataReader = sqlCommand.ExecuteReader();
        if (sqlDataReader.Read()) {
            if ((byte)sqlDataReader["PERMISSION_LEVEL"] <= 1) {
                OpenChildControl(new AdminTasks());
            }
            else {
                OpenChildControl(new EmployeeTasks());
            }
        }
        conn.Close();
    }

    private void ProjectButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(projectButton.Location.Y);

        string query = $"select * from EMPLOYEE inner join ROLE on EMPLOYEE.ID = ROLE.EMPLOYEE_ID where EMPLOYEE.ID = N'{userId}'";
        conn.Open();
        var sqlCommand = new SqlCommand(query, conn);
        var sqlDataReader = sqlCommand.ExecuteReader();
        if (sqlDataReader.Read()) {
            if ((byte)sqlDataReader["PERMISSION_LEVEL"] <= 1) {
                OpenChildControl(new AdminProjects());
            }
            else {
                OpenChildControl(new EmployeeProjects());
            }
        }
        conn.Close();
    }

    private void DocumentButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(documentButton.Location.Y);

        OpenChildControl(new FormDocument());
    }

    private void ProgressButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(progressButton.Location.Y);

        OpenChildControl(new FormProgress());
    }

    private void EmployeeButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(employeeButton.Location.Y);

        OpenChildControl(new FormStaff());
    }

    private void AttendanceButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(attendanceButton.Location.Y);

        OpenChildControl(new formChamCong());
    }

    private void SalaryButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(salaryButton.Location.Y);

        OpenChildControl(new formTinhLuong());
    }

    private void DormitoryButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(dormitoryButton.Location.Y);

        //OpenChildForm(new formKTX());
    }

    #region account info
    private void Account_MouseClick(object sender, MouseEventArgs e) {
        OpenChildControl(new frmInfo(userId));
    }

    private void Account_MouseDown(object sender, MouseEventArgs e) {
        accountPanel.BackColor = Color.FromArgb(34, 130, 253);
        usernameLabel.ForeColor = Color.Black;
    }

    private void Account_MouseUp(object sender, MouseEventArgs e) {
        accountPanel.BackColor = Color.Transparent;
        usernameLabel.ForeColor = Color.White;
    }

    private void Account_MouseEnter(object sender, EventArgs e) {
        accountPanel.BackColor = Color.FromArgb(34, 130, 253);
    }

    private void Account_MouseLeave(object sender, EventArgs e) {
        accountPanel.BackColor = Color.Transparent;
    }
    #endregion

    private void AppNameLabel_Click(object sender, EventArgs e) {
        workplacePanel.Controls.Clear();
    }

    private void LogoutButton_Click(object sender, EventArgs e) {
        DialogResult = DialogResult.Retry;
        Close();
    }
}
