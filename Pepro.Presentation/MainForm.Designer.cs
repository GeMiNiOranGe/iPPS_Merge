using Pepro.Presentation.Controls.Atoms;

namespace Pepro.Presentation {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            salaryButton = new PeproIconButton();
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
            usernameLabel = new Label();
            roleLabel = new Label();
            imageUserPictureBox = new PictureBox();
            workplacePanel = new Panel();
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
            functionListPanel.Controls.Add(salaryButton);
            functionListPanel.Controls.Add(progressButton);
            functionListPanel.Controls.Add(documentButton);
            functionListPanel.Controls.Add(assignmentButton);
            functionListPanel.Controls.Add(projectButton);
            functionListPanel.Controls.Add(departmentButton);
            functionListPanel.Controls.Add(employeeButton);
            functionListPanel.Controls.Add(accountButton);
            functionListPanel.Dock = DockStyle.Fill;
            functionListPanel.Location = new Point(0, 80);
            functionListPanel.Name = "functionListPanel";
            functionListPanel.Size = new Size(200, 489);
            functionListPanel.TabIndex = 0;
            // 
            // optionPanel
            // 
            optionPanel.BackColor = Color.White;
            optionPanel.Location = new Point(0, 0);
            optionPanel.Name = "optionPanel";
            optionPanel.Size = new Size(8, 48);
            optionPanel.TabIndex = 0;
            // 
            // dormitoryButton
            // 
            dormitoryButton.Dock = DockStyle.Top;
            dormitoryButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            dormitoryButton.Location = new Point(0, 432);
            dormitoryButton.Name = "dormitoryButton";
            dormitoryButton.Padding = new Padding(16, 0, 0, 0);
            dormitoryButton.Size = new Size(200, 48);
            dormitoryButton.TabIndex = 10;
            dormitoryButton.Text = "   Ký túc xá";
            dormitoryButton.MouseClick += DormitoryButton_MouseClick;
            // 
            // attendanceButton
            // 
            attendanceButton.Dock = DockStyle.Top;
            attendanceButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            attendanceButton.Location = new Point(0, 384);
            attendanceButton.Name = "attendanceButton";
            attendanceButton.Padding = new Padding(16, 0, 0, 0);
            attendanceButton.Size = new Size(200, 48);
            attendanceButton.TabIndex = 9;
            attendanceButton.Text = "   Chấm công";
            attendanceButton.MouseClick += AttendanceButton_MouseClick;
            // 
            // salaryButton
            // 
            salaryButton.Dock = DockStyle.Top;
            salaryButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            salaryButton.Location = new Point(0, 336);
            salaryButton.Name = "salaryButton";
            salaryButton.Padding = new Padding(16, 0, 0, 0);
            salaryButton.Size = new Size(200, 48);
            salaryButton.TabIndex = 8;
            salaryButton.Text = "   Lương";
            salaryButton.MouseClick += SalaryButton_MouseClick;
            // 
            // progressButton
            // 
            progressButton.Dock = DockStyle.Top;
            progressButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            progressButton.Location = new Point(0, 288);
            progressButton.Name = "progressButton";
            progressButton.Padding = new Padding(16, 0, 0, 0);
            progressButton.Size = new Size(200, 48);
            progressButton.TabIndex = 7;
            progressButton.Text = "   Tiến độ";
            progressButton.MouseClick += ProgressButton_MouseClick;
            // 
            // documentButton
            // 
            documentButton.Dock = DockStyle.Top;
            documentButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            documentButton.Location = new Point(0, 240);
            documentButton.Name = "documentButton";
            documentButton.Padding = new Padding(16, 0, 0, 0);
            documentButton.Size = new Size(200, 48);
            documentButton.TabIndex = 6;
            documentButton.Text = "   Tài liệu";
            documentButton.MouseClick += DocumentButton_MouseClick;
            // 
            // assignmentButton
            // 
            assignmentButton.Dock = DockStyle.Top;
            assignmentButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            assignmentButton.Location = new Point(0, 192);
            assignmentButton.Name = "assignmentButton";
            assignmentButton.Padding = new Padding(16, 0, 0, 0);
            assignmentButton.Size = new Size(200, 48);
            assignmentButton.TabIndex = 5;
            assignmentButton.Text = "   Công việc";
            assignmentButton.MouseClick += AssignmentButton_MouseClick;
            // 
            // projectButton
            // 
            projectButton.Dock = DockStyle.Top;
            projectButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            projectButton.Location = new Point(0, 144);
            projectButton.Name = "projectButton";
            projectButton.Padding = new Padding(16, 0, 0, 0);
            projectButton.Size = new Size(200, 48);
            projectButton.TabIndex = 4;
            projectButton.Text = "   Dự án";
            projectButton.MouseClick += ProjectButton_MouseClick;
            // 
            // departmentButton
            // 
            departmentButton.Dock = DockStyle.Top;
            departmentButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            departmentButton.Location = new Point(0, 96);
            departmentButton.Name = "departmentButton";
            departmentButton.Padding = new Padding(16, 0, 0, 0);
            departmentButton.Size = new Size(200, 48);
            departmentButton.TabIndex = 3;
            departmentButton.Text = "   Phòng ban";
            departmentButton.Click += DepartmentButton_Click;
            // 
            // employeeButton
            // 
            employeeButton.Dock = DockStyle.Top;
            employeeButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            employeeButton.Location = new Point(0, 48);
            employeeButton.Name = "employeeButton";
            employeeButton.Padding = new Padding(16, 0, 0, 0);
            employeeButton.Size = new Size(200, 48);
            employeeButton.TabIndex = 2;
            employeeButton.Text = "   Nhân viên";
            employeeButton.MouseClick += EmployeeButton_MouseClick;
            // 
            // accountButton
            // 
            accountButton.Dock = DockStyle.Top;
            accountButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            accountButton.Location = new Point(0, 0);
            accountButton.Name = "accountButton";
            accountButton.Padding = new Padding(16, 0, 0, 0);
            accountButton.Size = new Size(200, 48);
            accountButton.TabIndex = 1;
            accountButton.Text = "   Tài khoản";
            accountButton.Click += AccountButton_Click;
            // 
            // appNameLabel
            // 
            appNameLabel.Cursor = Cursors.Hand;
            appNameLabel.Dock = DockStyle.Top;
            appNameLabel.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            appNameLabel.Location = new Point(0, 0);
            appNameLabel.Name = "appNameLabel";
            appNameLabel.Size = new Size(200, 80);
            appNameLabel.TabIndex = 0;
            appNameLabel.Text = "iPPS Ver.0";
            appNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            appNameLabel.Click += AppNameLabel_Click;
            // 
            // logoutButton
            // 
            logoutButton.Dock = DockStyle.Bottom;
            logoutButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            logoutButton.Location = new Point(0, 569);
            logoutButton.Name = "logoutButton";
            logoutButton.Padding = new Padding(16, 0, 0, 0);
            logoutButton.Size = new Size(200, 48);
            logoutButton.TabIndex = 11;
            logoutButton.Text = "   Đăng xuất";
            logoutButton.Click += LogoutButton_Click;
            // 
            // personalPanel
            // 
            personalPanel.BackColor = Color.Transparent;
            personalPanel.Controls.Add(usernameLabel);
            personalPanel.Controls.Add(roleLabel);
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
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            usernameLabel.Location = new Point(60, 11);
            usernameLabel.Margin = new Padding(4, 0, 0, 4);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(56, 21);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Name";
            usernameLabel.MouseClick += Personal_MouseClick;
            usernameLabel.MouseEnter += Personal_MouseEnter;
            usernameLabel.MouseLeave += Personal_MouseLeave;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.BackColor = Color.Transparent;
            roleLabel.ForeColor = Color.Silver;
            roleLabel.Location = new Point(60, 36);
            roleLabel.Margin = new Padding(4, 0, 0, 0);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(35, 19);
            roleLabel.TabIndex = 0;
            roleLabel.Text = "Role";
            roleLabel.MouseClick += Personal_MouseClick;
            roleLabel.MouseEnter += Personal_MouseEnter;
            roleLabel.MouseLeave += Personal_MouseLeave;
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
            Text = "Bảng điều khiển";
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
        private Label usernameLabel;
        private Label roleLabel;
        private Panel personalPanel;
        private PeproIconButton assignmentButton;
        private PeproIconButton progressButton;
        private PeproIconButton documentButton;
        private PeproIconButton projectButton;
        private Label appNameLabel;
        private PeproIconButton employeeButton;
        private PeproIconButton dormitoryButton;
        private PeproIconButton salaryButton;
        private PeproIconButton attendanceButton;
        private Panel optionPanel;
        private PeproIconButton logoutButton;
        private Panel functionListPanel;
        private PeproIconButton departmentButton;
        private PeproIconButton accountButton;
    }
}

