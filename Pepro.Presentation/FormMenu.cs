using Microsoft.Data.SqlClient;
using System.ComponentModel;

namespace Pepro.Presentation;

public partial class FormMenu : Form {
    private readonly SqlConnection conn = new(
        @"Data Source=.;Initial Catalog=Pepro;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"
    );
    private Form? currentFormChild;
    private string? userId;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string? UserId {
        get => userId;
        set => userId = value;
    }

    public FormMenu() {
        InitializeComponent();
    }

    private void OpenChildForm(Form childForm) {
        currentFormChild?.Close();
        currentFormChild = childForm;
        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;
        workplacePanel.Controls.Add(childForm);
        childForm.BringToFront();
        childForm.Show();
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

    private void FormMenu_Load(object sender, EventArgs e) {
        usernameLabel.Text = GetFullname();
        roleLabel.Text = GetRole();
    }

    private void FormMenu_FormClosed(object sender, FormClosedEventArgs e) {
        DialogResult dialogResulth = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dialogResulth == DialogResult.Yes) {
            Application.Exit();
        }
    }

    private void BtnJob_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(taskButton.Location.Y);

        string query = $"select * from EMPLOYEE inner join ROLE on EMPLOYEE.ID = ROLE.EMPLOYEE_ID where EMPLOYEE.ID = N'{userId}'";
        conn.Open();
        var sqlCommand = new SqlCommand(query, conn);
        var sqlDataReader = sqlCommand.ExecuteReader();
        if (sqlDataReader.Read()) {
            if ((byte)sqlDataReader["PERMISSION_LEVEL"] <= 1) {
                OpenChildForm(new AdminTasks());
            }
            else {
                OpenChildForm(new EmployeeTasks());
            }
        }
        conn.Close();
    }

    private void BtnProject_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(projectButton.Location.Y);

        string query = $"select * from EMPLOYEE inner join ROLE on EMPLOYEE.ID = ROLE.EMPLOYEE_ID where EMPLOYEE.ID = N'{userId}'";
        conn.Open();
        var sqlCommand = new SqlCommand(query, conn);
        var sqlDataReader = sqlCommand.ExecuteReader();
        if (sqlDataReader.Read()) {
            if ((byte)sqlDataReader["PERMISSION_LEVEL"] <= 1) {
                OpenChildForm(new AdminProjects());
            }
            else {
                OpenChildForm(new EmployeeProjects());
            }
        }
        conn.Close();
    }

    private void BtnDocument_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(documentButton.Location.Y);

        OpenChildForm(new FormDocument());
    }

    private void BtnProgress_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(progressButton.Location.Y);

        OpenChildForm(new FormProgress());
    }

    private void EmployeeButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(employeeButton.Location.Y);

        OpenChildForm(new FormStaff());
    }

    private void AttendanceButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(attendanceButton.Location.Y);

        OpenChildForm(new formChamCong());
    }

    private void SalaryButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(salaryButton.Location.Y);

        OpenChildForm(new formTinhLuong());
    }

    private void DormitoryButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(dormitoryButton.Location.Y);

        OpenChildForm(new formKTX());
    }

    #region account info
    private void Account_MouseClick(object sender, MouseEventArgs e) {
        OpenChildForm(new frmInfo(userId));
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

    private void LbAppName_Click(object sender, EventArgs e) {
        currentFormChild?.Close();
    }
}
