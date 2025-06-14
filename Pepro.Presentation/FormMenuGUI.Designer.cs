
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
            dormitoryButton = new Button();
            salaryButton = new Button();
            attendanceButton = new Button();
            employeeButton = new Button();
            accountPanel = new Panel();
            usernameLabel = new Label();
            roleLabel = new Label();
            imageUserPictureBox = new PictureBox();
            progressButton = new Button();
            documentButton = new Button();
            projectButton = new Button();
            taskButton = new Button();
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
            sidebarPanel.Controls.Add(dormitoryButton);
            sidebarPanel.Controls.Add(salaryButton);
            sidebarPanel.Controls.Add(attendanceButton);
            sidebarPanel.Controls.Add(employeeButton);
            sidebarPanel.Controls.Add(accountPanel);
            sidebarPanel.Controls.Add(progressButton);
            sidebarPanel.Controls.Add(documentButton);
            sidebarPanel.Controls.Add(projectButton);
            sidebarPanel.Controls.Add(taskButton);
            sidebarPanel.Controls.Add(appNameLabel);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(231, 720);
            sidebarPanel.TabIndex = 0;
            // 
            // optionPanel
            // 
            optionPanel.BackColor = Color.White;
            optionPanel.Location = new Point(0, 100);
            optionPanel.Name = "optionPanel";
            optionPanel.Size = new Size(10, 60);
            optionPanel.TabIndex = 0;
            // 
            // dormitoryButton
            // 
            dormitoryButton.BackColor = Color.Transparent;
            dormitoryButton.Cursor = Cursors.Hand;
            dormitoryButton.Dock = DockStyle.Top;
            dormitoryButton.FlatAppearance.BorderSize = 0;
            dormitoryButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 130, 253);
            dormitoryButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 130, 253);
            dormitoryButton.FlatStyle = FlatStyle.Flat;
            dormitoryButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dormitoryButton.ForeColor = Color.White;
            dormitoryButton.Image = Properties.Resources.Dormitory;
            dormitoryButton.ImageAlign = ContentAlignment.MiddleLeft;
            dormitoryButton.Location = new Point(0, 520);
            dormitoryButton.Name = "dormitoryButton";
            dormitoryButton.Padding = new Padding(24, 5, 0, 5);
            dormitoryButton.Size = new Size(231, 60);
            dormitoryButton.TabIndex = 27;
            dormitoryButton.Text = "   Ký túc xá";
            dormitoryButton.TextAlign = ContentAlignment.MiddleLeft;
            dormitoryButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            dormitoryButton.UseVisualStyleBackColor = false;
            dormitoryButton.MouseClick += DormitoryButton_MouseClick;
            dormitoryButton.MouseDown += DormitoryButton_MouseDown;
            dormitoryButton.MouseUp += DormitoryButton_MouseUp;
            // 
            // salaryButton
            // 
            salaryButton.BackColor = Color.Transparent;
            salaryButton.Cursor = Cursors.Hand;
            salaryButton.Dock = DockStyle.Top;
            salaryButton.FlatAppearance.BorderSize = 0;
            salaryButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 130, 253);
            salaryButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 130, 253);
            salaryButton.FlatStyle = FlatStyle.Flat;
            salaryButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            salaryButton.ForeColor = Color.White;
            salaryButton.Image = Properties.Resources.salary;
            salaryButton.ImageAlign = ContentAlignment.MiddleLeft;
            salaryButton.Location = new Point(0, 460);
            salaryButton.Name = "salaryButton";
            salaryButton.Padding = new Padding(24, 5, 0, 5);
            salaryButton.Size = new Size(231, 60);
            salaryButton.TabIndex = 26;
            salaryButton.Text = "   Lương";
            salaryButton.TextAlign = ContentAlignment.MiddleLeft;
            salaryButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            salaryButton.UseVisualStyleBackColor = false;
            salaryButton.MouseClick += SalaryButton_MouseClick;
            salaryButton.MouseDown += SalaryButton_MouseDown;
            salaryButton.MouseUp += SalaryButton_MouseUp;
            // 
            // attendanceButton
            // 
            attendanceButton.BackColor = Color.Transparent;
            attendanceButton.Cursor = Cursors.Hand;
            attendanceButton.Dock = DockStyle.Top;
            attendanceButton.FlatAppearance.BorderSize = 0;
            attendanceButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 130, 253);
            attendanceButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 130, 253);
            attendanceButton.FlatStyle = FlatStyle.Flat;
            attendanceButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            attendanceButton.ForeColor = Color.White;
            attendanceButton.Image = Properties.Resources.Chamcong;
            attendanceButton.ImageAlign = ContentAlignment.MiddleLeft;
            attendanceButton.Location = new Point(0, 400);
            attendanceButton.Name = "attendanceButton";
            attendanceButton.Padding = new Padding(24, 5, 0, 5);
            attendanceButton.Size = new Size(231, 60);
            attendanceButton.TabIndex = 25;
            attendanceButton.Text = "   Chấm công";
            attendanceButton.TextAlign = ContentAlignment.MiddleLeft;
            attendanceButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            attendanceButton.UseVisualStyleBackColor = false;
            attendanceButton.MouseClick += AttendanceButton_MouseClick;
            attendanceButton.MouseDown += AttendanceButton_MouseDown;
            attendanceButton.MouseUp += AttendanceButton_MouseUp;
            // 
            // employeeButton
            // 
            employeeButton.BackColor = Color.Transparent;
            employeeButton.Cursor = Cursors.Hand;
            employeeButton.Dock = DockStyle.Top;
            employeeButton.FlatAppearance.BorderSize = 0;
            employeeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 130, 253);
            employeeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 130, 253);
            employeeButton.FlatStyle = FlatStyle.Flat;
            employeeButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeeButton.ForeColor = Color.White;
            employeeButton.Image = Properties.Resources.employee;
            employeeButton.ImageAlign = ContentAlignment.MiddleLeft;
            employeeButton.Location = new Point(0, 340);
            employeeButton.Name = "employeeButton";
            employeeButton.Padding = new Padding(24, 5, 0, 5);
            employeeButton.Size = new Size(231, 60);
            employeeButton.TabIndex = 24;
            employeeButton.Text = "   Nhân viên";
            employeeButton.TextAlign = ContentAlignment.MiddleLeft;
            employeeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            employeeButton.UseVisualStyleBackColor = false;
            employeeButton.MouseClick += EmployeeButton_MouseClick;
            employeeButton.MouseDown += EmployeeButton_MouseDown;
            employeeButton.MouseUp += EmployeeButton_MouseUp;
            // 
            // accountPanel
            // 
            accountPanel.BackColor = Color.Transparent;
            accountPanel.Controls.Add(usernameLabel);
            accountPanel.Controls.Add(roleLabel);
            accountPanel.Controls.Add(imageUserPictureBox);
            accountPanel.Cursor = Cursors.Hand;
            accountPanel.Dock = DockStyle.Bottom;
            accountPanel.Location = new Point(0, 648);
            accountPanel.Name = "accountPanel";
            accountPanel.Size = new Size(231, 72);
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
            // progressButton
            // 
            progressButton.BackColor = Color.Transparent;
            progressButton.Cursor = Cursors.Hand;
            progressButton.Dock = DockStyle.Top;
            progressButton.FlatAppearance.BorderSize = 0;
            progressButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 130, 253);
            progressButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 130, 253);
            progressButton.FlatStyle = FlatStyle.Flat;
            progressButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            progressButton.ForeColor = Color.White;
            progressButton.Image = Properties.Resources.DoughnutChart;
            progressButton.ImageAlign = ContentAlignment.MiddleLeft;
            progressButton.Location = new Point(0, 280);
            progressButton.Name = "progressButton";
            progressButton.Padding = new Padding(24, 5, 0, 5);
            progressButton.Size = new Size(231, 60);
            progressButton.TabIndex = 20;
            progressButton.Text = "   Tiến độ";
            progressButton.TextAlign = ContentAlignment.MiddleLeft;
            progressButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            progressButton.UseVisualStyleBackColor = false;
            progressButton.MouseClick += BtnProgress_MouseClick;
            progressButton.MouseDown += BtnProgress_MouseDown;
            progressButton.MouseUp += BtnProgress_MouseUp;
            // 
            // documentButton
            // 
            documentButton.BackColor = Color.Transparent;
            documentButton.Cursor = Cursors.Hand;
            documentButton.Dock = DockStyle.Top;
            documentButton.FlatAppearance.BorderSize = 0;
            documentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 130, 253);
            documentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 130, 253);
            documentButton.FlatStyle = FlatStyle.Flat;
            documentButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            documentButton.ForeColor = Color.White;
            documentButton.Image = Properties.Resources.MultiplePages;
            documentButton.ImageAlign = ContentAlignment.MiddleLeft;
            documentButton.Location = new Point(0, 220);
            documentButton.Name = "documentButton";
            documentButton.Padding = new Padding(24, 5, 0, 5);
            documentButton.Size = new Size(231, 60);
            documentButton.TabIndex = 19;
            documentButton.Text = "   Tài liệu";
            documentButton.TextAlign = ContentAlignment.MiddleLeft;
            documentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            documentButton.UseVisualStyleBackColor = false;
            documentButton.MouseClick += BtnDocument_MouseClick;
            documentButton.MouseDown += BtnDocument_MouseDown;
            documentButton.MouseUp += BtnDocument_MouseUp;
            // 
            // projectButton
            // 
            projectButton.BackColor = Color.Transparent;
            projectButton.Cursor = Cursors.Hand;
            projectButton.Dock = DockStyle.Top;
            projectButton.FlatAppearance.BorderSize = 0;
            projectButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 130, 253);
            projectButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 130, 253);
            projectButton.FlatStyle = FlatStyle.Flat;
            projectButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            projectButton.ForeColor = Color.White;
            projectButton.Image = Properties.Resources.Folder;
            projectButton.ImageAlign = ContentAlignment.MiddleLeft;
            projectButton.Location = new Point(0, 160);
            projectButton.Name = "projectButton";
            projectButton.Padding = new Padding(24, 5, 0, 5);
            projectButton.Size = new Size(231, 60);
            projectButton.TabIndex = 21;
            projectButton.Text = "   Dự án";
            projectButton.TextAlign = ContentAlignment.MiddleLeft;
            projectButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            projectButton.UseVisualStyleBackColor = false;
            projectButton.MouseClick += BtnProject_MouseClick;
            projectButton.MouseDown += BtnProject_MouseDown;
            projectButton.MouseUp += BtnProject_MouseUp;
            // 
            // taskButton
            // 
            taskButton.BackColor = Color.Transparent;
            taskButton.Cursor = Cursors.Hand;
            taskButton.Dock = DockStyle.Top;
            taskButton.FlatAppearance.BorderSize = 0;
            taskButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 130, 253);
            taskButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 130, 253);
            taskButton.FlatStyle = FlatStyle.Flat;
            taskButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            taskButton.ForeColor = Color.White;
            taskButton.Image = Properties.Resources.PasteClipboard;
            taskButton.ImageAlign = ContentAlignment.MiddleLeft;
            taskButton.Location = new Point(0, 100);
            taskButton.Name = "taskButton";
            taskButton.Padding = new Padding(24, 5, 0, 5);
            taskButton.Size = new Size(231, 60);
            taskButton.TabIndex = 18;
            taskButton.Text = "   Công việc";
            taskButton.TextAlign = ContentAlignment.MiddleLeft;
            taskButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            taskButton.UseVisualStyleBackColor = false;
            taskButton.MouseClick += BtnJob_MouseClick;
            taskButton.MouseDown += BtnJob_MouseDown;
            taskButton.MouseUp += BtnJob_MouseUp;
            // 
            // appNameLabel
            // 
            appNameLabel.Cursor = Cursors.Hand;
            appNameLabel.Dock = DockStyle.Top;
            appNameLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appNameLabel.ForeColor = Color.White;
            appNameLabel.Location = new Point(0, 0);
            appNameLabel.Name = "appNameLabel";
            appNameLabel.Size = new Size(231, 100);
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
            workplacePanel.Location = new Point(231, 0);
            workplacePanel.Name = "workplacePanel";
            workplacePanel.Size = new Size(1049, 720);
            workplacePanel.TabIndex = 2;
            // 
            // FormMenuGUI
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(workplacePanel);
            Controls.Add(sidebarPanel);
            Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2);
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

        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel workplacePanel;
        private System.Windows.Forms.PictureBox imageUserPictureBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Panel accountPanel;
        private System.Windows.Forms.Button taskButton;
        private System.Windows.Forms.Button progressButton;
        private System.Windows.Forms.Button documentButton;
        private System.Windows.Forms.Button projectButton;
        private System.Windows.Forms.Label appNameLabel;
        private Button employeeButton;
        private Button dormitoryButton;
        private Button salaryButton;
        private Button attendanceButton;
        private Panel optionPanel;
    }
}

