
using Pepro.Presentation.Controls;

namespace Pepro.Presentation {
    partial class MenuForm {
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
        private void InitializeComponent() {
            sidebarPanel = new Panel();
            functionListPanel = new Panel();
            optionPanel = new Panel();
            dormitoryButton = new PeproSidebarButton();
            salaryButton = new PeproSidebarButton();
            attendanceButton = new PeproSidebarButton();
            employeeButton = new PeproSidebarButton();
            progressButton = new PeproSidebarButton();
            documentButton = new PeproSidebarButton();
            projectButton = new PeproSidebarButton();
            taskButton = new PeproSidebarButton();
            appNameLabel = new Label();
            logoutButton = new PeproSidebarButton();
            accountPanel = new Panel();
            usernameLabel = new Label();
            roleLabel = new Label();
            imageUserPictureBox = new PictureBox();
            workplacePanel = new Panel();
            sidebarPanel.SuspendLayout();
            functionListPanel.SuspendLayout();
            accountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageUserPictureBox).BeginInit();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(29, 29, 29);
            sidebarPanel.Controls.Add(functionListPanel);
            sidebarPanel.Controls.Add(appNameLabel);
            sidebarPanel.Controls.Add(logoutButton);
            sidebarPanel.Controls.Add(accountPanel);
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
            functionListPanel.Controls.Add(salaryButton);
            functionListPanel.Controls.Add(attendanceButton);
            functionListPanel.Controls.Add(employeeButton);
            functionListPanel.Controls.Add(progressButton);
            functionListPanel.Controls.Add(documentButton);
            functionListPanel.Controls.Add(projectButton);
            functionListPanel.Controls.Add(taskButton);
            functionListPanel.Dock = DockStyle.Fill;
            functionListPanel.Location = new Point(0, 80);
            functionListPanel.Name = "functionListPanel";
            functionListPanel.Size = new Size(200, 489);
            functionListPanel.TabIndex = 29;
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
            dormitoryButton.Cursor = Cursors.Hand;
            dormitoryButton.FlatAppearance.BorderSize = 0;
            dormitoryButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 145, 255);
            dormitoryButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 145, 255);
            dormitoryButton.Location = new Point(0, 336);
            dormitoryButton.Name = "dormitoryButton";
            dormitoryButton.Padding = new Padding(16, 0, 0, 0);
            dormitoryButton.Size = new Size(200, 48);
            dormitoryButton.TabIndex = 27;
            dormitoryButton.Text = "   Ký túc xá";
            dormitoryButton.UseVisualStyleBackColor = false;
            dormitoryButton.MouseClick += DormitoryButton_MouseClick;
            // 
            // salaryButton
            // 
            salaryButton.Cursor = Cursors.Hand;
            salaryButton.FlatAppearance.BorderSize = 0;
            salaryButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 145, 255);
            salaryButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 145, 255);
            salaryButton.Location = new Point(0, 288);
            salaryButton.Name = "salaryButton";
            salaryButton.Padding = new Padding(16, 0, 0, 0);
            salaryButton.Size = new Size(200, 48);
            salaryButton.TabIndex = 26;
            salaryButton.Text = "   Lương";
            salaryButton.UseVisualStyleBackColor = false;
            salaryButton.MouseClick += SalaryButton_MouseClick;
            // 
            // attendanceButton
            // 
            attendanceButton.Cursor = Cursors.Hand;
            attendanceButton.FlatAppearance.BorderSize = 0;
            attendanceButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 145, 255);
            attendanceButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 145, 255);
            attendanceButton.Location = new Point(0, 240);
            attendanceButton.Name = "attendanceButton";
            attendanceButton.Padding = new Padding(16, 0, 0, 0);
            attendanceButton.Size = new Size(200, 48);
            attendanceButton.TabIndex = 25;
            attendanceButton.Text = "   Chấm công";
            attendanceButton.UseVisualStyleBackColor = false;
            attendanceButton.MouseClick += AttendanceButton_MouseClick;
            // 
            // employeeButton
            // 
            employeeButton.Cursor = Cursors.Hand;
            employeeButton.FlatAppearance.BorderSize = 0;
            employeeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 145, 255);
            employeeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 145, 255);
            employeeButton.Location = new Point(0, 192);
            employeeButton.Name = "employeeButton";
            employeeButton.Padding = new Padding(16, 0, 0, 0);
            employeeButton.Size = new Size(200, 48);
            employeeButton.TabIndex = 24;
            employeeButton.Text = "   Nhân viên";
            employeeButton.UseVisualStyleBackColor = false;
            employeeButton.MouseClick += EmployeeButton_MouseClick;
            // 
            // progressButton
            // 
            progressButton.Cursor = Cursors.Hand;
            progressButton.FlatAppearance.BorderSize = 0;
            progressButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 145, 255);
            progressButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 145, 255);
            progressButton.Location = new Point(0, 144);
            progressButton.Name = "progressButton";
            progressButton.Padding = new Padding(16, 0, 0, 0);
            progressButton.Size = new Size(200, 48);
            progressButton.TabIndex = 20;
            progressButton.Text = "   Tiến độ";
            progressButton.UseVisualStyleBackColor = false;
            progressButton.MouseClick += ProgressButton_MouseClick;
            // 
            // documentButton
            // 
            documentButton.Cursor = Cursors.Hand;
            documentButton.FlatAppearance.BorderSize = 0;
            documentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 145, 255);
            documentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 145, 255);
            documentButton.Location = new Point(0, 96);
            documentButton.Name = "documentButton";
            documentButton.Padding = new Padding(16, 0, 0, 0);
            documentButton.Size = new Size(200, 48);
            documentButton.TabIndex = 19;
            documentButton.Text = "   Tài liệu";
            documentButton.UseVisualStyleBackColor = false;
            documentButton.MouseClick += DocumentButton_MouseClick;
            // 
            // projectButton
            // 
            projectButton.Cursor = Cursors.Hand;
            projectButton.FlatAppearance.BorderSize = 0;
            projectButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 145, 255);
            projectButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 145, 255);
            projectButton.Location = new Point(0, 48);
            projectButton.Name = "projectButton";
            projectButton.Padding = new Padding(16, 0, 0, 0);
            projectButton.Size = new Size(200, 48);
            projectButton.TabIndex = 21;
            projectButton.Text = "   Dự án";
            projectButton.UseVisualStyleBackColor = false;
            projectButton.MouseClick += ProjectButton_MouseClick;
            // 
            // taskButton
            // 
            taskButton.Cursor = Cursors.Hand;
            taskButton.FlatAppearance.BorderSize = 0;
            taskButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 145, 255);
            taskButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 145, 255);
            taskButton.Location = new Point(0, 0);
            taskButton.Name = "taskButton";
            taskButton.Padding = new Padding(16, 0, 0, 0);
            taskButton.Size = new Size(200, 48);
            taskButton.TabIndex = 18;
            taskButton.Text = "   Công việc";
            taskButton.UseVisualStyleBackColor = false;
            taskButton.MouseClick += TaskButton_MouseClick;
            // 
            // appNameLabel
            // 
            appNameLabel.Cursor = Cursors.Hand;
            appNameLabel.Dock = DockStyle.Top;
            appNameLabel.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            appNameLabel.ForeColor = Color.White;
            appNameLabel.Location = new Point(0, 0);
            appNameLabel.Name = "appNameLabel";
            appNameLabel.Size = new Size(200, 80);
            appNameLabel.TabIndex = 23;
            appNameLabel.Text = "iPPS Ver.0";
            appNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            appNameLabel.Click += AppNameLabel_Click;
            // 
            // logoutButton
            // 
            logoutButton.Dock = DockStyle.Bottom;
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(35, 145, 255);
            logoutButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 145, 255);
            logoutButton.Location = new Point(0, 569);
            logoutButton.Name = "logoutButton";
            logoutButton.Padding = new Padding(16, 0, 0, 0);
            logoutButton.Size = new Size(200, 48);
            logoutButton.TabIndex = 28;
            logoutButton.Text = "   Đăng xuất";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += LogoutButton_Click;
            // 
            // accountPanel
            // 
            accountPanel.BackColor = Color.Transparent;
            accountPanel.Controls.Add(usernameLabel);
            accountPanel.Controls.Add(roleLabel);
            accountPanel.Controls.Add(imageUserPictureBox);
            accountPanel.Cursor = Cursors.Hand;
            accountPanel.Dock = DockStyle.Bottom;
            accountPanel.Location = new Point(0, 617);
            accountPanel.Name = "accountPanel";
            accountPanel.Size = new Size(200, 64);
            accountPanel.TabIndex = 12;
            accountPanel.MouseClick += Account_MouseClick;
            accountPanel.MouseEnter += Account_MouseEnter;
            accountPanel.MouseLeave += Account_MouseLeave;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            usernameLabel.ForeColor = Color.White;
            usernameLabel.Location = new Point(60, 11);
            usernameLabel.Margin = new Padding(4, 0, 0, 4);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(56, 21);
            usernameLabel.TabIndex = 8;
            usernameLabel.Text = "Name";
            usernameLabel.MouseClick += Account_MouseClick;
            usernameLabel.MouseEnter += Account_MouseEnter;
            usernameLabel.MouseLeave += Account_MouseLeave;
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
            roleLabel.TabIndex = 8;
            roleLabel.Text = "Role";
            roleLabel.MouseClick += Account_MouseClick;
            roleLabel.MouseEnter += Account_MouseEnter;
            roleLabel.MouseLeave += Account_MouseLeave;
            // 
            // imageUserPictureBox
            // 
            imageUserPictureBox.Image = Properties.Resources.AccImage;
            imageUserPictureBox.Location = new Point(8, 8);
            imageUserPictureBox.Margin = new Padding(8, 8, 0, 8);
            imageUserPictureBox.Name = "imageUserPictureBox";
            imageUserPictureBox.Size = new Size(48, 48);
            imageUserPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageUserPictureBox.TabIndex = 10;
            imageUserPictureBox.TabStop = false;
            imageUserPictureBox.MouseClick += Account_MouseClick;
            imageUserPictureBox.MouseEnter += Account_MouseEnter;
            imageUserPictureBox.MouseLeave += Account_MouseLeave;
            // 
            // workplacePanel
            // 
            workplacePanel.AccessibleRole = AccessibleRole.None;
            workplacePanel.BackColor = Color.FromArgb(15, 15, 15);
            workplacePanel.Dock = DockStyle.Fill;
            workplacePanel.Location = new Point(200, 0);
            workplacePanel.Name = "workplacePanel";
            workplacePanel.Size = new Size(1064, 681);
            workplacePanel.TabIndex = 2;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(workplacePanel);
            Controls.Add(sidebarPanel);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            MinimumSize = new Size(960, 540);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bảng điều khiển";
            FormClosing += MenuForm_FormClosing;
            Load += MenuForm_Load;
            sidebarPanel.ResumeLayout(false);
            functionListPanel.ResumeLayout(false);
            accountPanel.ResumeLayout(false);
            accountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imageUserPictureBox).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Panel sidebarPanel;
        private Panel workplacePanel;
        private PictureBox imageUserPictureBox;
        private Label usernameLabel;
        private Label roleLabel;
        private Panel accountPanel;
        private PeproSidebarButton taskButton;
        private PeproSidebarButton progressButton;
        private PeproSidebarButton documentButton;
        private PeproSidebarButton projectButton;
        private Label appNameLabel;
        private PeproSidebarButton employeeButton;
        private PeproSidebarButton dormitoryButton;
        private PeproSidebarButton salaryButton;
        private PeproSidebarButton attendanceButton;
        private Panel optionPanel;
        private PeproSidebarButton logoutButton;
        private Panel functionListPanel;
    }
}

