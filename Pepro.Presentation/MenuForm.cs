using Microsoft.Data.SqlClient;
using Pepro.Presentation.Controls;
using Svg;
using System.ComponentModel;

namespace Pepro.Presentation;

public partial class MenuForm : PeproForm {
    private readonly SqlConnection conn = new(
        @"Data Source=.;Initial Catalog=Pepro;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"
    );
    private string _userId = "";

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public required string UserId {
        get => _userId;
        set => _userId = value;
    }

    public MenuForm() {
        InitializeComponent();
        LoadSidebarButtonImage();
        
        imageUserPictureBox.Image = IconProvider.GetIcon(
            "Profile",
            colorServer: new SvgColourServer(Color.White),
            size: 48
        );
    }

    private void LoadSidebarButtonImage() {
        SetSidebarButtonImages(taskButton, "Task");
        SetSidebarButtonImages(projectButton, "Folder");
        SetSidebarButtonImages(documentButton, "MultiplePages");
        SetSidebarButtonImages(progressButton, "DoughnutChart");
        SetSidebarButtonImages(employeeButton, "Group");
        SetSidebarButtonImages(attendanceButton, "CalendarCheck");
        SetSidebarButtonImages(salaryButton, "UserSalary");
        SetSidebarButtonImages(dormitoryButton, "BunkBed");

        logoutButton.Image = IconProvider.GetIcon(
            "LogOut",
            colorServer: new SvgColourServer(ThemeColors.Text)
        );
    }

    private void SetSidebarButtonImages(PeproSidebarButton button, string iconName) {
        SvgColourServer baseColor = new(ThemeColors.Text);
        button.Image = IconProvider.GetIcon(iconName, colorServer: baseColor);
        button.PressedImage = IconProvider.GetIcon(iconName, "Bold", colorServer: baseColor);
    }

    private void OpenChildControl(UserControl child) {
        workplacePanel.Controls.Clear();
        child.Dock = DockStyle.Fill;
        workplacePanel.Controls.Add(child);
        child.BringToFront();
    }

    public string GetFullname() {
        string strFullname;
        string query = $"SELECT FirstName, MiddleName, LastName FROM Employee WHERE Employee.EmployeeId = N'{_userId}'";
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

        string query = $"select * from EMPLOYEE inner join ROLE on EMPLOYEE.ID = ROLE.EMPLOYEE_ID where EMPLOYEE.ID = N'{_userId}'";
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

        string query = $"select * from EMPLOYEE inner join ROLE on EMPLOYEE.ID = ROLE.EMPLOYEE_ID where EMPLOYEE.ID = N'{_userId}'";
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

    private void Account_MouseClick(object sender, MouseEventArgs e) {
        OpenChildControl(new EmployeeInformationControl(_userId));
    }

    private void Account_MouseEnter(object sender, EventArgs e) {
        accountPanel.BackColor = ThemeColors.Accent.Base;
    }

    private void Account_MouseLeave(object sender, EventArgs e) {
        accountPanel.BackColor = Color.Transparent;
    }

    private void AppNameLabel_Click(object sender, EventArgs e) {
        workplacePanel.Controls.Clear();
    }

    private void LogoutButton_Click(object sender, EventArgs e) {
        DialogResult = DialogResult.Retry;
        Close();
    }
}
