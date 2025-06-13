using Microsoft.Data.SqlClient;
using System.ComponentModel;

namespace Pepro.Presentation;

public partial class FormMenuGUI : Form {
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

    public FormMenuGUI() {
        InitializeComponent();
    }

    private void OpenChildForm(Form childForm) {
        currentFormChild?.Close();
        currentFormChild = childForm;
        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;
        PnlWorkplace.Controls.Add(childForm);
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
        LbUsername.Text = GetFullname();
        LbRole.Text = GetRole();
    }

    private void FormMenu_FormClosed(object sender, FormClosedEventArgs e) {
        DialogResult dialogResulth = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dialogResulth == DialogResult.Yes) {
            Application.Exit();
        }
    }

    #region button job
    private void BtnJob_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(BtnJob.Location.Y);

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

    private void BtnJob_MouseDown(object sender, MouseEventArgs e) {
        BtnJob.Image = Properties.Resources.PasteClipboardFill;
        BtnJob.ForeColor = Color.FromArgb(29, 29, 29);
    }

    private void BtnJob_MouseUp(object sender, MouseEventArgs e) {
        BtnJob.Image = Properties.Resources.PasteClipboard;
        BtnJob.ForeColor = Color.White;
    }
    #endregion

    #region button project
    private void BtnProject_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(BtnProject.Location.Y);

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

    private void BtnProject_MouseDown(object sender, MouseEventArgs e) {
        BtnProject.Image = Properties.Resources.FolderFill;
        BtnProject.ForeColor = Color.FromArgb(29, 29, 29);
    }

    private void BtnProject_MouseUp(object sender, MouseEventArgs e) {
        BtnProject.Image = Properties.Resources.Folder;
        BtnProject.ForeColor = Color.White;
    }
    #endregion

    #region button document
    private void BtnDocument_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(BtnDocument.Location.Y);

        OpenChildForm(new FormDocument());
    }

    private void BtnDocument_MouseDown(object sender, MouseEventArgs e) {
        BtnDocument.Image = Properties.Resources.MultiplePagesFill;
        BtnDocument.ForeColor = Color.FromArgb(29, 29, 29);
    }

    private void BtnDocument_MouseUp(object sender, MouseEventArgs e) {
        BtnDocument.Image = Properties.Resources.MultiplePages;
        BtnDocument.ForeColor = Color.White;
    }
    #endregion

    #region button progress
    private void BtnProgress_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(BtnProgress.Location.Y);

        OpenChildForm(new FormProgress());
    }

    private void BtnProgress_MouseDown(object sender, MouseEventArgs e) {
        BtnProgress.Image = Properties.Resources.DoughnutChartFill;
        BtnProgress.ForeColor = Color.FromArgb(29, 29, 29);
    }

    private void BtnProgress_MouseUp(object sender, MouseEventArgs e) {
        BtnProgress.Image = Properties.Resources.DoughnutChart;
        BtnProgress.ForeColor = Color.White;
    }
    #endregion

    #region employee
    private void EmployeeButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(employeeButton.Location.Y);

        OpenChildForm(new FormStaff());
    }

    private void EmployeeButton_MouseDown(object sender, MouseEventArgs e) {
        employeeButton.ForeColor = Color.FromArgb(29, 29, 29);
    }

    private void EmployeeButton_MouseUp(object sender, MouseEventArgs e) {
        employeeButton.ForeColor = Color.White;
    }
    #endregion

    #region attendance
    private void AttendanceButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(attendanceButton.Location.Y);

        OpenChildForm(new formChamCong());
    }

    private void AttendanceButton_MouseDown(object sender, MouseEventArgs e) {
        attendanceButton.ForeColor = Color.FromArgb(29, 29, 29);
    }

    private void AttendanceButton_MouseUp(object sender, MouseEventArgs e) {
        attendanceButton.ForeColor = Color.White;
    }
    #endregion

    #region salary
    private void SalaryButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(salaryButton.Location.Y);

        OpenChildForm(new formTinhLuong());
    }

    private void SalaryButton_MouseDown(object sender, MouseEventArgs e) {
        salaryButton.ForeColor = Color.FromArgb(29, 29, 29);
    }

    private void SalaryButton_MouseUp(object sender, MouseEventArgs e) {
        salaryButton.ForeColor = Color.White;
    }
    #endregion

    #region dormitory
    private void DormitoryButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(dormitoryButton.Location.Y);

        OpenChildForm(new formKTX());
    }

    private void DormitoryButton_MouseDown(object sender, MouseEventArgs e) {
        dormitoryButton.ForeColor = Color.FromArgb(29, 29, 29);
    }

    private void DormitoryButton_MouseUp(object sender, MouseEventArgs e) {
        dormitoryButton.ForeColor = Color.White;
    }
    #endregion

    #region account info
    private void Account_MouseClick(object sender, MouseEventArgs e) {
        OpenChildForm(new frmInfo(userId));
    }

    private void Account_MouseDown(object sender, MouseEventArgs e) {
        PnlAccount.BackColor = Color.FromArgb(34, 130, 253);
        LbUsername.ForeColor = Color.Black;
    }

    private void Account_MouseUp(object sender, MouseEventArgs e) {
        PnlAccount.BackColor = Color.Transparent;
        LbUsername.ForeColor = Color.White;
    }

    private void Account_MouseEnter(object sender, EventArgs e) {
        PnlAccount.BackColor = Color.FromArgb(34, 130, 253);
    }

    private void Account_MouseLeave(object sender, EventArgs e) {
        PnlAccount.BackColor = Color.Transparent;
    }
    #endregion

    private void LbAppName_Click(object sender, EventArgs e) {
        currentFormChild?.Close();
    }
}
