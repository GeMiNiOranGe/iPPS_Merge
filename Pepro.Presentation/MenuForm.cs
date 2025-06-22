using Microsoft.Data.SqlClient;
using Pepro.Presentation.Controls;
using Svg;
using System.ComponentModel;

namespace Pepro.Presentation;

public partial class MenuForm : Form {
    private readonly SqlConnection conn = new(
        @"Data Source=.;Initial Catalog=Pepro;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"
    );
    private string? userId;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string? UserId {
        get => userId;
        set => userId = value;
    }

    public MenuForm() {
        InitializeComponent();
        LoadSidebarButtonImage();
    }

    private void LoadSidebarButtonImage() {
        //SetSidebarButtonImages(progressButton, "DoughnutChart");
        SetSidebarButtonImages(documentButton, "MultiplePages");
        SetSidebarButtonImages(projectButton, "Folder");
        SetSidebarButtonImages(taskButton, "Task");
    }

    private void SetSidebarButtonImages(PeproSidebarButton button, string iconName) {
        SvgColourServer whiteColor = new(Color.White);
        button.Image = IconProvider.GetIcon(iconName, colorServer: whiteColor);
        button.PressedImage = IconProvider.GetIcon(iconName, "Bold", colorServer: whiteColor);
    }

    private void OpenChildControl(UserControl child) {
        workplacePanel.Controls.Clear();
        child.Dock = DockStyle.Fill;
        workplacePanel.Controls.Add(child);
        child.BringToFront();
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
                OpenChildControl(new AdminTaskControl());
            }
            else {
                OpenChildControl(new EmployeeTaskControl());
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
                OpenChildControl(new AdminProjectControl());
            }
            else {
                OpenChildControl(new EmployeeProjectControl());
            }
        }
        conn.Close();
    }

    private void DocumentButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(documentButton.Location.Y);

        OpenChildControl(new DocumentControl());
    }

    private void ProgressButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(progressButton.Location.Y);

        OpenChildControl(new ProgressControl());
    }

    private void EmployeeButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(employeeButton.Location.Y);

        OpenChildControl(new EmployeeControl());
    }

    private void AttendanceButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(attendanceButton.Location.Y);

        OpenChildControl(new AttendanceControl());
    }

    private void SalaryButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(salaryButton.Location.Y);

        OpenChildControl(new SalaryControl());
    }

    private void DormitoryButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(dormitoryButton.Location.Y);

        //OpenChildForm(new AttendanceForm());
    }

    #region account info
    private void Account_MouseClick(object sender, MouseEventArgs e) {
        OpenChildControl(new EmployeeInformationControl(userId));
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
