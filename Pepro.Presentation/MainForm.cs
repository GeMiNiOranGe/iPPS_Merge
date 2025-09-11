using Microsoft.Data.SqlClient;
using Pepro.Business;
using Pepro.Presentation.Base;
using Pepro.Presentation.Extensions;
using Pepro.Presentation.Payloads;
using Pepro.Presentation.Utilities;
using System.ComponentModel;

namespace Pepro.Presentation;

public partial class MainForm : PeproFormBase {
    private readonly SqlConnection conn = new(
        @"Data Source=.;Initial Catalog=Pepro;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"
    );
    private int _employeeId;
    private readonly ControlUiMediator _mediator;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public required int EmployeeId {
        get => _employeeId;
        set => _employeeId = value;
    }

    public MainForm() {
        InitializeComponent();
        InitializeRuntimeComponents();

        _mediator = new ControlUiMediator(workplacePanel);
    }

    private void InitializeRuntimeComponents() {
        assignmentButton.SetSidebarButtonImages("Task");
        projectButton.SetSidebarButtonImages("Folder");
        documentButton.SetSidebarButtonImages("MultiplePages");
        progressButton.SetSidebarButtonImages("DoughnutChart");
        employeeButton.SetSidebarButtonImages("User");
        attendanceButton.SetSidebarButtonImages("CalendarCheck");
        salaryButton.SetSidebarButtonImages("UserSalary");
        dormitoryButton.SetSidebarButtonImages("BunkBed");
        departmentButton.SetSidebarButtonImages("Group");

        logoutButton.ApplyFlatStyleNoBackColor();
        logoutButton.ApplyIcon("LogOut", color: ThemeColors.Text);

        imageUserPictureBox.Image = IconProvider.GetIcon(
            "Profile",
            color: Color.White,
            size: 48
        );
    }

    private void OpenChildControl(UserControl child) {
        workplacePanel.Controls.Clear();
        child.Dock = DockStyle.Fill;
        workplacePanel.Controls.Add(child);
        child.BringToFront();
    }

    private void MenuForm_Load(object sender, EventArgs e) {
        usernameLabel.Text = EmployeeBusiness.Instance.GetDisplayNameByEmployeeId(_employeeId);
        roleLabel.Text = PositionBusiness.Instance.GetPositionTitleByEmployeeId(_employeeId);
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

    private void AssignmentButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(assignmentButton.Location.Y);

        _mediator.Notify(this, ControlUiEvent.NavigateAssignmentControl);
        /*
        string query = $"select * from EMPLOYEE inner join ROLE on EMPLOYEE.ID = ROLE.EMPLOYEE_ID where EMPLOYEE.ID = N'{_employeeId}'";
        conn.Open();
        var sqlCommand = new SqlCommand(query, conn);
        var sqlDataReader = sqlCommand.ExecuteReader();
        if (sqlDataReader.Read()) {
            if ((byte)sqlDataReader["PERMISSION_LEVEL"] <= 1) {
                OpenChildControl(new AssignmentControl());
            }
            else {
                OpenChildControl(new EmployeeTaskControl());
            }
        }
        conn.Close();
        */
    }

    private void ProjectButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(projectButton.Location.Y);

        _mediator.Notify(this, ControlUiEvent.NavigateProjectControl);
        /*
        string query = $"select * from EMPLOYEE inner join ROLE on EMPLOYEE.ID = ROLE.EMPLOYEE_ID where EMPLOYEE.ID = N'{_employeeId}'";
        conn.Open();
        var sqlCommand = new SqlCommand(query, conn);
        var sqlDataReader = sqlCommand.ExecuteReader();
        if (sqlDataReader.Read()) {
            if ((byte)sqlDataReader["PERMISSION_LEVEL"] <= 1) {
                OpenChildControl(new ProjectControl());
            }
            else {
                OpenChildControl(new EmployeeProjectControl());
            }
        }
        conn.Close();
        */
    }

    private void DocumentButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(documentButton.Location.Y);

        _mediator.Notify(this, ControlUiEvent.NavigateDocumentControl);
    }

    private void ProgressButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(progressButton.Location.Y);

        _mediator.Notify(this, ControlUiEvent.NavigateProgressControl);
    }

    private void EmployeeButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(employeeButton.Location.Y);

        _mediator.Notify(this, ControlUiEvent.NavigateEmployeeControl);
    }

    private void AttendanceButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(attendanceButton.Location.Y);

        workplacePanel.Controls.Clear();
        MessageBoxWrapper.ShowInformation("TreasureFoundPremiumUnlock3");
    }

    private void SalaryButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(salaryButton.Location.Y);

        _mediator.Notify(this, ControlUiEvent.NavigatePayrollControl);
    }

    private void DormitoryButton_MouseClick(object sender, MouseEventArgs e) {
        optionPanel.SetLocationY(dormitoryButton.Location.Y);

        workplacePanel.Controls.Clear();
        MessageBoxWrapper.ShowInformation("TreasureFoundPremiumUnlock3");
    }

    private void DepartmentButton_Click(object sender, EventArgs e) {
        optionPanel.SetLocationY(departmentButton.Location.Y);

        _mediator.Notify(this, ControlUiEvent.NavigateDepartmentControl);
    }

    private void Account_MouseClick(object sender, MouseEventArgs e) {
        _mediator.Notify(this, ControlUiEvent.NavigateEmployeeInformationControl, new EmployeeInformationControlPayload() {
            EmployeeId = _employeeId,
        });
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
