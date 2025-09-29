using Pepro.Presentation.Controls.Atoms;

namespace Pepro.Presentation;

partial class MainForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        sidebarPanel = new Panel();
        functionListPanel = new Panel();
        optionPanel = new Panel();
        dormitoryButton = new PeproIconButton();
        attendanceButton = new PeproIconButton();
        payrollButton = new PeproIconButton();
        progressButton = new PeproIconButton();
        documentButton = new PeproIconButton();
        assignmentButton = new PeproIconButton();
        projectButton = new PeproIconButton();
        departmentButton = new PeproIconButton();
        employeeButton = new PeproIconButton();
        accountButton = new PeproIconButton();
        appNameLabel = new Label();
        logoutButton = new PeproIconButton();
        personalPanel = new Panel();
        employeeLabel = new Label();
        positionLabel = new Label();
        imageUserPictureBox = new PictureBox();
        workplacePanel = new Panel();
        roleButton = new PeproIconButton();
        sidebarPanel.SuspendLayout();
        functionListPanel.SuspendLayout();
        personalPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)imageUserPictureBox).BeginInit();
        SuspendLayout();
        // 
        // sidebarPanel
        // 
        sidebarPanel.BackColor = Color.FromArgb(29, 29, 29);
        sidebarPanel.Controls.Add(functionListPanel);
        sidebarPanel.Controls.Add(appNameLabel);
        sidebarPanel.Controls.Add(logoutButton);
        sidebarPanel.Controls.Add(personalPanel);
        sidebarPanel.Dock = DockStyle.Left;
        sidebarPanel.Location = new Point(0, 0);
        sidebarPanel.Name = "sidebarPanel";
        sidebarPanel.Size = new Size(200, 681);
        sidebarPanel.TabIndex = 0;
        // 
        // functionListPanel
        // 
        functionListPanel.AutoScroll = true;
        functionListPanel.Controls.Add(optionPanel);
        functionListPanel.Controls.Add(dormitoryButton);
        functionListPanel.Controls.Add(attendanceButton);
        functionListPanel.Controls.Add(payrollButton);
        functionListPanel.Controls.Add(progressButton);
        functionListPanel.Controls.Add(documentButton);
        functionListPanel.Controls.Add(assignmentButton);
        functionListPanel.Controls.Add(projectButton);
        functionListPanel.Controls.Add(departmentButton);
        functionListPanel.Controls.Add(employeeButton);
        functionListPanel.Controls.Add(roleButton);
        functionListPanel.Controls.Add(accountButton);
        functionListPanel.Dock = DockStyle.Fill;
        functionListPanel.Location = new Point(0, 56);
        functionListPanel.Name = "functionListPanel";
        functionListPanel.Size = new Size(200, 521);
        functionListPanel.TabIndex = 0;
        // 
        // optionPanel
        // 
        optionPanel.BackColor = Color.White;
        optionPanel.Location = new Point(0, 0);
        optionPanel.Name = "optionPanel";
        optionPanel.Size = new Size(8, 40);
        optionPanel.TabIndex = 0;
        optionPanel.Visible = false;
        // 
        // dormitoryButton
        // 
        dormitoryButton.Dock = DockStyle.Top;
        dormitoryButton.Location = new Point(0, 360);
        dormitoryButton.Name = "dormitoryButton";
        dormitoryButton.Padding = new Padding(16, 0, 0, 0);
        dormitoryButton.Size = new Size(200, 40);
        dormitoryButton.TabIndex = 11;
        dormitoryButton.Text = "   Dormitory";
        dormitoryButton.Click += SidebarLockedFeatureButton_Click;
        // 
        // attendanceButton
        // 
        attendanceButton.Dock = DockStyle.Top;
        attendanceButton.Location = new Point(0, 320);
        attendanceButton.Name = "attendanceButton";
        attendanceButton.Padding = new Padding(16, 0, 0, 0);
        attendanceButton.Size = new Size(200, 40);
        attendanceButton.TabIndex = 10;
        attendanceButton.Text = "   Attendance";
        attendanceButton.Click += SidebarLockedFeatureButton_Click;
        // 
        // payrollButton
        // 
        payrollButton.Dock = DockStyle.Top;
        payrollButton.Location = new Point(0, 280);
        payrollButton.Name = "payrollButton";
        payrollButton.Padding = new Padding(16, 0, 0, 0);
        payrollButton.Size = new Size(200, 40);
        payrollButton.TabIndex = 9;
        payrollButton.Text = "   Payroll";
        payrollButton.Click += SidebarButton_Click;
        // 
        // progressButton
        // 
        progressButton.Dock = DockStyle.Top;
        progressButton.Location = new Point(0, 240);
        progressButton.Name = "progressButton";
        progressButton.Padding = new Padding(16, 0, 0, 0);
        progressButton.Size = new Size(200, 40);
        progressButton.TabIndex = 8;
        progressButton.Text = "   Progress";
        progressButton.Click += SidebarButton_Click;
        // 
        // documentButton
        // 
        documentButton.Dock = DockStyle.Top;
        documentButton.Location = new Point(0, 200);
        documentButton.Name = "documentButton";
        documentButton.Padding = new Padding(16, 0, 0, 0);
        documentButton.Size = new Size(200, 40);
        documentButton.TabIndex = 7;
        documentButton.Text = "   Document";
        documentButton.Click += SidebarButton_Click;
        // 
        // assignmentButton
        // 
        assignmentButton.Dock = DockStyle.Top;
        assignmentButton.Location = new Point(0, 160);
        assignmentButton.Name = "assignmentButton";
        assignmentButton.Padding = new Padding(16, 0, 0, 0);
        assignmentButton.Size = new Size(200, 40);
        assignmentButton.TabIndex = 6;
        assignmentButton.Text = "   Assignment";
        assignmentButton.Click += SidebarButton_Click;
        // 
        // projectButton
        // 
        projectButton.Dock = DockStyle.Top;
        projectButton.Location = new Point(0, 120);
        projectButton.Name = "projectButton";
        projectButton.Padding = new Padding(16, 0, 0, 0);
        projectButton.Size = new Size(200, 40);
        projectButton.TabIndex = 5;
        projectButton.Text = "   Project";
        projectButton.Click += SidebarButton_Click;
        // 
        // departmentButton
        // 
        departmentButton.Dock = DockStyle.Top;
        departmentButton.Location = new Point(0, 80);
        departmentButton.Name = "departmentButton";
        departmentButton.Padding = new Padding(16, 0, 0, 0);
        departmentButton.Size = new Size(200, 40);
        departmentButton.TabIndex = 4;
        departmentButton.Text = "   Department";
        departmentButton.Click += SidebarButton_Click;
        // 
        // employeeButton
        // 
        employeeButton.Dock = DockStyle.Top;
        employeeButton.Location = new Point(0, 40);
        employeeButton.Name = "employeeButton";
        employeeButton.Padding = new Padding(16, 0, 0, 0);
        employeeButton.Size = new Size(200, 40);
        employeeButton.TabIndex = 3;
        employeeButton.Text = "   Employee";
        employeeButton.Click += SidebarButton_Click;
        // 
        // accountButton
        // 
        accountButton.Dock = DockStyle.Top;
        accountButton.Location = new Point(0, 0);
        accountButton.Name = "accountButton";
        accountButton.Padding = new Padding(16, 0, 0, 0);
        accountButton.Size = new Size(200, 40);
        accountButton.TabIndex = 1;
        accountButton.Text = "   Account";
        accountButton.Click += SidebarButton_Click;
        // 
        // appNameLabel
        // 
        appNameLabel.Cursor = Cursors.Hand;
        appNameLabel.Dock = DockStyle.Top;
        appNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
        appNameLabel.ImageAlign = ContentAlignment.MiddleLeft;
        appNameLabel.Location = new Point(0, 0);
        appNameLabel.Name = "appNameLabel";
        appNameLabel.Padding = new Padding(16, 0, 0, 0);
        appNameLabel.Size = new Size(200, 56);
        appNameLabel.TabIndex = 0;
        appNameLabel.Text = "          Pepro";
        appNameLabel.TextAlign = ContentAlignment.MiddleLeft;
        appNameLabel.Click += AppNameLabel_Click;
        // 
        // logoutButton
        // 
        logoutButton.Dock = DockStyle.Bottom;
        logoutButton.Location = new Point(0, 577);
        logoutButton.Name = "logoutButton";
        logoutButton.Padding = new Padding(16, 0, 0, 0);
        logoutButton.Size = new Size(200, 40);
        logoutButton.TabIndex = 12;
        logoutButton.Text = "   Logout";
        logoutButton.Click += LogoutButton_Click;
        // 
        // personalPanel
        // 
        personalPanel.BackColor = Color.Transparent;
        personalPanel.Controls.Add(employeeLabel);
        personalPanel.Controls.Add(positionLabel);
        personalPanel.Controls.Add(imageUserPictureBox);
        personalPanel.Cursor = Cursors.Hand;
        personalPanel.Dock = DockStyle.Bottom;
        personalPanel.Location = new Point(0, 617);
        personalPanel.Name = "personalPanel";
        personalPanel.Size = new Size(200, 64);
        personalPanel.TabIndex = 0;
        personalPanel.MouseClick += Personal_MouseClick;
        personalPanel.MouseEnter += Personal_MouseEnter;
        personalPanel.MouseLeave += Personal_MouseLeave;
        // 
        // employeeLabel
        // 
        employeeLabel.AutoSize = true;
        employeeLabel.BackColor = Color.Transparent;
        employeeLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
        employeeLabel.Location = new Point(60, 11);
        employeeLabel.Margin = new Padding(4, 0, 0, 4);
        employeeLabel.Name = "employeeLabel";
        employeeLabel.Size = new Size(56, 21);
        employeeLabel.TabIndex = 0;
        employeeLabel.Text = "Name";
        employeeLabel.MouseClick += Personal_MouseClick;
        employeeLabel.MouseEnter += Personal_MouseEnter;
        employeeLabel.MouseLeave += Personal_MouseLeave;
        // 
        // positionLabel
        // 
        positionLabel.AutoSize = true;
        positionLabel.BackColor = Color.Transparent;
        positionLabel.ForeColor = Color.Silver;
        positionLabel.Location = new Point(60, 36);
        positionLabel.Margin = new Padding(4, 0, 0, 0);
        positionLabel.Name = "positionLabel";
        positionLabel.Size = new Size(35, 19);
        positionLabel.TabIndex = 0;
        positionLabel.Text = "Role";
        positionLabel.MouseClick += Personal_MouseClick;
        positionLabel.MouseEnter += Personal_MouseEnter;
        positionLabel.MouseLeave += Personal_MouseLeave;
        // 
        // imageUserPictureBox
        // 
        imageUserPictureBox.Location = new Point(8, 8);
        imageUserPictureBox.Margin = new Padding(8, 8, 0, 8);
        imageUserPictureBox.Name = "imageUserPictureBox";
        imageUserPictureBox.Size = new Size(48, 48);
        imageUserPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
        imageUserPictureBox.TabIndex = 0;
        imageUserPictureBox.TabStop = false;
        imageUserPictureBox.MouseClick += Personal_MouseClick;
        imageUserPictureBox.MouseEnter += Personal_MouseEnter;
        imageUserPictureBox.MouseLeave += Personal_MouseLeave;
        // 
        // workplacePanel
        // 
        workplacePanel.AccessibleRole = AccessibleRole.None;
        workplacePanel.BackColor = Color.FromArgb(15, 15, 15);
        workplacePanel.Dock = DockStyle.Fill;
        workplacePanel.Location = new Point(200, 0);
        workplacePanel.Name = "workplacePanel";
        workplacePanel.Size = new Size(1064, 681);
        workplacePanel.TabIndex = 0;
        // 
        // roleButton
        // 
        roleButton.Dock = DockStyle.Top;
        roleButton.Location = new Point(0, 400);
        roleButton.Name = "roleButton";
        roleButton.Padding = new Padding(16, 0, 0, 0);
        roleButton.Size = new Size(200, 40);
        roleButton.TabIndex = 2;
        roleButton.Text = "   Role";
        roleButton.Click += SidebarButton_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1264, 681);
        Controls.Add(workplacePanel);
        Controls.Add(sidebarPanel);
        ForeColor = Color.White;
        MinimumSize = new Size(960, 540);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Pepro";
        FormClosing += MenuForm_FormClosing;
        Load += MenuForm_Load;
        sidebarPanel.ResumeLayout(false);
        functionListPanel.ResumeLayout(false);
        personalPanel.ResumeLayout(false);
        personalPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)imageUserPictureBox).EndInit();
        ResumeLayout(false);

    }

    #endregion

    private Panel sidebarPanel;
    private Panel workplacePanel;
    private PictureBox imageUserPictureBox;
    private Label employeeLabel;
    private Label positionLabel;
    private Panel personalPanel;
    private PeproIconButton assignmentButton;
    private PeproIconButton progressButton;
    private PeproIconButton documentButton;
    private PeproIconButton projectButton;
    private Label appNameLabel;
    private PeproIconButton employeeButton;
    private PeproIconButton dormitoryButton;
    private PeproIconButton payrollButton;
    private PeproIconButton attendanceButton;
    private Panel optionPanel;
    private PeproIconButton logoutButton;
    private Panel functionListPanel;
    private PeproIconButton departmentButton;
    private PeproIconButton accountButton;
    private PeproIconButton roleButton;
}
