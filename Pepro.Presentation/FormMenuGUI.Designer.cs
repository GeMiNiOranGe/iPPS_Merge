
using Pepro.Presentation.Controls;

namespace Pepro.Presentation {
    partial class FormMenuGUI {
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
            optionPanel = new Panel();
            accountPanel = new Panel();
            usernameLabel = new Label();
            roleLabel = new Label();
            imageUserPictureBox = new PictureBox();
            dormitoryButton = new PeproSidebarButton();
            salaryButton = new PeproSidebarButton();
            attendanceButton = new PeproSidebarButton();
            employeeButton = new PeproSidebarButton();
            progressButton = new PeproSidebarButton();
            documentButton = new PeproSidebarButton();
            projectButton = new PeproSidebarButton();
            taskButton = new PeproSidebarButton();
            appNameLabel = new Label();
            workplacePanel = new Panel();
            sidebarPanel.SuspendLayout();
            accountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageUserPictureBox).BeginInit();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(29, 29, 29);
            sidebarPanel.Controls.Add(optionPanel);
            sidebarPanel.Controls.Add(accountPanel);
            sidebarPanel.Controls.Add(dormitoryButton);
            sidebarPanel.Controls.Add(salaryButton);
            sidebarPanel.Controls.Add(attendanceButton);
            sidebarPanel.Controls.Add(employeeButton);
            sidebarPanel.Controls.Add(progressButton);
            sidebarPanel.Controls.Add(documentButton);
            sidebarPanel.Controls.Add(projectButton);
            sidebarPanel.Controls.Add(taskButton);
            sidebarPanel.Controls.Add(appNameLabel);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(200, 729);
            sidebarPanel.TabIndex = 0;
            // 
            // optionPanel
            // 
            optionPanel.BackColor = Color.White;
            optionPanel.Location = new Point(0, 80);
            optionPanel.Name = "optionPanel";
            optionPanel.Size = new Size(8, 60);
            optionPanel.TabIndex = 0;
            // 
            // accountPanel
            // 
            accountPanel.BackColor = Color.Transparent;
            accountPanel.Controls.Add(usernameLabel);
            accountPanel.Controls.Add(roleLabel);
            accountPanel.Controls.Add(imageUserPictureBox);
            accountPanel.Cursor = Cursors.Hand;
            accountPanel.Dock = DockStyle.Bottom;
            accountPanel.Location = new Point(0, 657);
            accountPanel.Name = "accountPanel";
            accountPanel.Size = new Size(200, 72);
            accountPanel.TabIndex = 12;
            accountPanel.MouseClick += Account_MouseClick;
            accountPanel.MouseDown += Account_MouseDown;
            accountPanel.MouseEnter += Account_MouseEnter;
            accountPanel.MouseLeave += Account_MouseLeave;
            accountPanel.MouseUp += Account_MouseUp;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = Color.White;
            usernameLabel.Location = new Point(66, 12);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(64, 25);
            usernameLabel.TabIndex = 8;
            usernameLabel.Text = "Name";
            usernameLabel.MouseClick += Account_MouseClick;
            usernameLabel.MouseDown += Account_MouseDown;
            usernameLabel.MouseEnter += Account_MouseEnter;
            usernameLabel.MouseLeave += Account_MouseLeave;
            usernameLabel.MouseUp += Account_MouseUp;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.BackColor = Color.Transparent;
            roleLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roleLabel.ForeColor = Color.Silver;
            roleLabel.Location = new Point(67, 40);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(39, 20);
            roleLabel.TabIndex = 8;
            roleLabel.Text = "Role";
            roleLabel.MouseClick += Account_MouseClick;
            roleLabel.MouseDown += Account_MouseDown;
            roleLabel.MouseEnter += Account_MouseEnter;
            roleLabel.MouseLeave += Account_MouseLeave;
            roleLabel.MouseUp += Account_MouseUp;
            // 
            // imageUserPictureBox
            // 
            imageUserPictureBox.Image = Properties.Resources.AccImage;
            imageUserPictureBox.Location = new Point(12, 12);
            imageUserPictureBox.Name = "imageUserPictureBox";
            imageUserPictureBox.Size = new Size(48, 48);
            imageUserPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageUserPictureBox.TabIndex = 10;
            imageUserPictureBox.TabStop = false;
            imageUserPictureBox.MouseClick += Account_MouseClick;
            imageUserPictureBox.MouseDown += Account_MouseDown;
            imageUserPictureBox.MouseEnter += Account_MouseEnter;
            imageUserPictureBox.MouseLeave += Account_MouseLeave;
            imageUserPictureBox.MouseUp += Account_MouseUp;
            // 
            // dormitoryButton
            // 
            dormitoryButton.Cursor = Cursors.Hand;
            dormitoryButton.FlatAppearance.BorderSize = 0;
            dormitoryButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 130, 253);
            dormitoryButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 130, 253);
            dormitoryButton.Image = Properties.Resources.Dormitory;
            dormitoryButton.Location = new Point(0, 500);
            dormitoryButton.Name = "dormitoryButton";
            dormitoryButton.Padding = new Padding(16, 4, 0, 4);
            dormitoryButton.Size = new Size(200, 60);
            dormitoryButton.TabIndex = 27;
            dormitoryButton.Text = "   Ký túc xá";
            dormitoryButton.UseVisualStyleBackColor = false;
            dormitoryButton.MouseClick += DormitoryButton_MouseClick;
            // 
            // salaryButton
            // 
            salaryButton.Cursor = Cursors.Hand;
            salaryButton.FlatAppearance.BorderSize = 0;
            salaryButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 130, 253);
            salaryButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 130, 253);
            salaryButton.Image = Properties.Resources.salary;
            salaryButton.Location = new Point(0, 440);
            salaryButton.Name = "salaryButton";
            salaryButton.Padding = new Padding(16, 4, 0, 4);
            salaryButton.Size = new Size(200, 60);
            salaryButton.TabIndex = 26;
            salaryButton.Text = "   Lương";
            salaryButton.UseVisualStyleBackColor = false;
            salaryButton.MouseClick += SalaryButton_MouseClick;
            // 
            // attendanceButton
            // 
            attendanceButton.Cursor = Cursors.Hand;
            attendanceButton.FlatAppearance.BorderSize = 0;
            attendanceButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 130, 253);
            attendanceButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 130, 253);
            attendanceButton.Image = Properties.Resources.Chamcong;
            attendanceButton.Location = new Point(0, 380);
            attendanceButton.Name = "attendanceButton";
            attendanceButton.Padding = new Padding(16, 4, 0, 4);
            attendanceButton.Size = new Size(200, 60);
            attendanceButton.TabIndex = 25;
            attendanceButton.Text = "   Chấm công";
            attendanceButton.UseVisualStyleBackColor = false;
            attendanceButton.MouseClick += AttendanceButton_MouseClick;
            // 
            // employeeButton
            // 
            employeeButton.Cursor = Cursors.Hand;
            employeeButton.FlatAppearance.BorderSize = 0;
            employeeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 130, 253);
            employeeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 130, 253);
            employeeButton.Image = Properties.Resources.employee;
            employeeButton.Location = new Point(0, 320);
            employeeButton.Name = "employeeButton";
            employeeButton.Padding = new Padding(16, 4, 0, 4);
            employeeButton.Size = new Size(200, 60);
            employeeButton.TabIndex = 24;
            employeeButton.Text = "   Nhân viên";
            employeeButton.UseVisualStyleBackColor = false;
            employeeButton.MouseClick += EmployeeButton_MouseClick;
            // 
            // progressButton
            // 
            progressButton.Cursor = Cursors.Hand;
            progressButton.FlatAppearance.BorderSize = 0;
            progressButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 130, 253);
            progressButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 130, 253);
            progressButton.Image = Properties.Resources.DoughnutChart;
            progressButton.Location = new Point(0, 260);
            progressButton.Name = "progressButton";
            progressButton.Padding = new Padding(16, 4, 0, 4);
            progressButton.PressedImage = Properties.Resources.DoughnutChartFill;
            progressButton.Size = new Size(200, 60);
            progressButton.TabIndex = 20;
            progressButton.Text = "   Tiến độ";
            progressButton.UseVisualStyleBackColor = false;
            progressButton.MouseClick += BtnProgress_MouseClick;
            // 
            // documentButton
            // 
            documentButton.Cursor = Cursors.Hand;
            documentButton.FlatAppearance.BorderSize = 0;
            documentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 130, 253);
            documentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 130, 253);
            documentButton.Image = Properties.Resources.MultiplePages;
            documentButton.Location = new Point(0, 200);
            documentButton.Name = "documentButton";
            documentButton.Padding = new Padding(16, 4, 0, 4);
            documentButton.PressedImage = Properties.Resources.MultiplePagesFill;
            documentButton.Size = new Size(200, 60);
            documentButton.TabIndex = 19;
            documentButton.Text = "   Tài liệu";
            documentButton.UseVisualStyleBackColor = false;
            documentButton.MouseClick += BtnDocument_MouseClick;
            // 
            // projectButton
            // 
            projectButton.Cursor = Cursors.Hand;
            projectButton.FlatAppearance.BorderSize = 0;
            projectButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 130, 253);
            projectButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 130, 253);
            projectButton.Image = Properties.Resources.Folder;
            projectButton.Location = new Point(0, 140);
            projectButton.Name = "projectButton";
            projectButton.Padding = new Padding(16, 4, 0, 4);
            projectButton.PressedImage = Properties.Resources.FolderFill;
            projectButton.Size = new Size(200, 60);
            projectButton.TabIndex = 21;
            projectButton.Text = "   Dự án";
            projectButton.UseVisualStyleBackColor = false;
            projectButton.MouseClick += BtnProject_MouseClick;
            // 
            // taskButton
            // 
            taskButton.Cursor = Cursors.Hand;
            taskButton.FlatAppearance.BorderSize = 0;
            taskButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 130, 253);
            taskButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 130, 253);
            taskButton.Image = Properties.Resources.PasteClipboard;
            taskButton.Location = new Point(0, 80);
            taskButton.Name = "taskButton";
            taskButton.Padding = new Padding(16, 4, 0, 4);
            taskButton.PressedImage = Properties.Resources.PasteClipboardFill;
            taskButton.Size = new Size(200, 60);
            taskButton.TabIndex = 18;
            taskButton.Text = "   Công việc";
            taskButton.UseVisualStyleBackColor = false;
            taskButton.MouseClick += BtnJob_MouseClick;
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
            appNameLabel.Click += LbAppName_Click;
            // 
            // workplacePanel
            // 
            workplacePanel.AccessibleRole = AccessibleRole.None;
            workplacePanel.BackColor = Color.FromArgb(15, 15, 15);
            workplacePanel.Dock = DockStyle.Fill;
            workplacePanel.Location = new Point(200, 0);
            workplacePanel.Name = "workplacePanel";
            workplacePanel.Size = new Size(1150, 729);
            workplacePanel.TabIndex = 2;
            // 
            // FormMenuGUI
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(workplacePanel);
            Controls.Add(sidebarPanel);
            Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2);
            MinimumSize = new Size(1280, 600);
            Name = "FormMenuGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bảng điều khiển";
            FormClosed += FormMenu_FormClosed;
            Load += FormMenu_Load;
            sidebarPanel.ResumeLayout(false);
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
    }
}

