
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
            PnlLeft = new Panel();
            optionPanel = new Panel();
            dormitoryButton = new Button();
            salaryButton = new Button();
            attendanceButton = new Button();
            employeeButton = new Button();
            PnlAccount = new Panel();
            LbUsername = new Label();
            LbRole = new Label();
            PcbImageUser = new PictureBox();
            BtnProgress = new Button();
            BtnDocument = new Button();
            BtnProject = new Button();
            BtnJob = new Button();
            lbAppName = new Label();
            PnlWorkplace = new Panel();
            PnlLeft.SuspendLayout();
            PnlAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PcbImageUser).BeginInit();
            SuspendLayout();
            // 
            // PnlLeft
            // 
            PnlLeft.BackColor = Color.FromArgb(29, 29, 29);
            PnlLeft.Controls.Add(optionPanel);
            PnlLeft.Controls.Add(dormitoryButton);
            PnlLeft.Controls.Add(salaryButton);
            PnlLeft.Controls.Add(attendanceButton);
            PnlLeft.Controls.Add(employeeButton);
            PnlLeft.Controls.Add(PnlAccount);
            PnlLeft.Controls.Add(BtnProgress);
            PnlLeft.Controls.Add(BtnDocument);
            PnlLeft.Controls.Add(BtnProject);
            PnlLeft.Controls.Add(BtnJob);
            PnlLeft.Controls.Add(lbAppName);
            PnlLeft.Dock = DockStyle.Left;
            PnlLeft.Location = new Point(0, 0);
            PnlLeft.Name = "PnlLeft";
            PnlLeft.Size = new Size(231, 720);
            PnlLeft.TabIndex = 0;
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
            // PnlAccount
            // 
            PnlAccount.BackColor = Color.Transparent;
            PnlAccount.Controls.Add(LbUsername);
            PnlAccount.Controls.Add(LbRole);
            PnlAccount.Controls.Add(PcbImageUser);
            PnlAccount.Cursor = Cursors.Hand;
            PnlAccount.Dock = DockStyle.Bottom;
            PnlAccount.Location = new Point(0, 648);
            PnlAccount.Name = "PnlAccount";
            PnlAccount.Size = new Size(231, 72);
            PnlAccount.TabIndex = 12;
            PnlAccount.MouseClick += Account_MouseClick;
            PnlAccount.MouseDown += Account_MouseDown;
            PnlAccount.MouseEnter += Account_MouseEnter;
            PnlAccount.MouseLeave += Account_MouseLeave;
            PnlAccount.MouseUp += Account_MouseUp;
            // 
            // LbUsername
            // 
            LbUsername.AutoSize = true;
            LbUsername.BackColor = Color.Transparent;
            LbUsername.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbUsername.ForeColor = Color.White;
            LbUsername.Location = new Point(66, 12);
            LbUsername.Name = "LbUsername";
            LbUsername.Size = new Size(64, 25);
            LbUsername.TabIndex = 8;
            LbUsername.Text = "Name";
            LbUsername.MouseClick += Account_MouseClick;
            LbUsername.MouseDown += Account_MouseDown;
            LbUsername.MouseEnter += Account_MouseEnter;
            LbUsername.MouseLeave += Account_MouseLeave;
            LbUsername.MouseUp += Account_MouseUp;
            // 
            // LbRole
            // 
            LbRole.AutoSize = true;
            LbRole.BackColor = Color.Transparent;
            LbRole.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbRole.ForeColor = Color.Silver;
            LbRole.Location = new Point(67, 40);
            LbRole.Name = "LbRole";
            LbRole.Size = new Size(39, 20);
            LbRole.TabIndex = 8;
            LbRole.Text = "Role";
            LbRole.MouseClick += Account_MouseClick;
            LbRole.MouseDown += Account_MouseDown;
            LbRole.MouseEnter += Account_MouseEnter;
            LbRole.MouseLeave += Account_MouseLeave;
            LbRole.MouseUp += Account_MouseUp;
            // 
            // PcbImageUser
            // 
            PcbImageUser.Image = Properties.Resources.AccImage;
            PcbImageUser.Location = new Point(12, 12);
            PcbImageUser.Name = "PcbImageUser";
            PcbImageUser.Size = new Size(48, 48);
            PcbImageUser.SizeMode = PictureBoxSizeMode.Zoom;
            PcbImageUser.TabIndex = 10;
            PcbImageUser.TabStop = false;
            PcbImageUser.MouseClick += Account_MouseClick;
            PcbImageUser.MouseDown += Account_MouseDown;
            PcbImageUser.MouseEnter += Account_MouseEnter;
            PcbImageUser.MouseLeave += Account_MouseLeave;
            PcbImageUser.MouseUp += Account_MouseUp;
            // 
            // BtnProgress
            // 
            BtnProgress.BackColor = Color.Transparent;
            BtnProgress.Cursor = Cursors.Hand;
            BtnProgress.Dock = DockStyle.Top;
            BtnProgress.FlatAppearance.BorderSize = 0;
            BtnProgress.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 130, 253);
            BtnProgress.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 130, 253);
            BtnProgress.FlatStyle = FlatStyle.Flat;
            BtnProgress.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnProgress.ForeColor = Color.White;
            BtnProgress.Image = Properties.Resources.DoughnutChart;
            BtnProgress.ImageAlign = ContentAlignment.MiddleLeft;
            BtnProgress.Location = new Point(0, 280);
            BtnProgress.Name = "BtnProgress";
            BtnProgress.Padding = new Padding(24, 5, 0, 5);
            BtnProgress.Size = new Size(231, 60);
            BtnProgress.TabIndex = 20;
            BtnProgress.Text = "   Tiến độ";
            BtnProgress.TextAlign = ContentAlignment.MiddleLeft;
            BtnProgress.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnProgress.UseVisualStyleBackColor = false;
            BtnProgress.MouseClick += BtnProgress_MouseClick;
            BtnProgress.MouseDown += BtnProgress_MouseDown;
            BtnProgress.MouseUp += BtnProgress_MouseUp;
            // 
            // BtnDocument
            // 
            BtnDocument.BackColor = Color.Transparent;
            BtnDocument.Cursor = Cursors.Hand;
            BtnDocument.Dock = DockStyle.Top;
            BtnDocument.FlatAppearance.BorderSize = 0;
            BtnDocument.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 130, 253);
            BtnDocument.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 130, 253);
            BtnDocument.FlatStyle = FlatStyle.Flat;
            BtnDocument.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnDocument.ForeColor = Color.White;
            BtnDocument.Image = Properties.Resources.MultiplePages;
            BtnDocument.ImageAlign = ContentAlignment.MiddleLeft;
            BtnDocument.Location = new Point(0, 220);
            BtnDocument.Name = "BtnDocument";
            BtnDocument.Padding = new Padding(24, 5, 0, 5);
            BtnDocument.Size = new Size(231, 60);
            BtnDocument.TabIndex = 19;
            BtnDocument.Text = "   Tài liệu";
            BtnDocument.TextAlign = ContentAlignment.MiddleLeft;
            BtnDocument.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnDocument.UseVisualStyleBackColor = false;
            BtnDocument.MouseClick += BtnDocument_MouseClick;
            BtnDocument.MouseDown += BtnDocument_MouseDown;
            BtnDocument.MouseUp += BtnDocument_MouseUp;
            // 
            // BtnProject
            // 
            BtnProject.BackColor = Color.Transparent;
            BtnProject.Cursor = Cursors.Hand;
            BtnProject.Dock = DockStyle.Top;
            BtnProject.FlatAppearance.BorderSize = 0;
            BtnProject.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 130, 253);
            BtnProject.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 130, 253);
            BtnProject.FlatStyle = FlatStyle.Flat;
            BtnProject.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnProject.ForeColor = Color.White;
            BtnProject.Image = Properties.Resources.Folder;
            BtnProject.ImageAlign = ContentAlignment.MiddleLeft;
            BtnProject.Location = new Point(0, 160);
            BtnProject.Name = "BtnProject";
            BtnProject.Padding = new Padding(24, 5, 0, 5);
            BtnProject.Size = new Size(231, 60);
            BtnProject.TabIndex = 21;
            BtnProject.Text = "   Dự án";
            BtnProject.TextAlign = ContentAlignment.MiddleLeft;
            BtnProject.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnProject.UseVisualStyleBackColor = false;
            BtnProject.MouseClick += BtnProject_MouseClick;
            BtnProject.MouseDown += BtnProject_MouseDown;
            BtnProject.MouseUp += BtnProject_MouseUp;
            // 
            // BtnJob
            // 
            BtnJob.BackColor = Color.Transparent;
            BtnJob.Cursor = Cursors.Hand;
            BtnJob.Dock = DockStyle.Top;
            BtnJob.FlatAppearance.BorderSize = 0;
            BtnJob.FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 130, 253);
            BtnJob.FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 130, 253);
            BtnJob.FlatStyle = FlatStyle.Flat;
            BtnJob.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnJob.ForeColor = Color.White;
            BtnJob.Image = Properties.Resources.PasteClipboard;
            BtnJob.ImageAlign = ContentAlignment.MiddleLeft;
            BtnJob.Location = new Point(0, 100);
            BtnJob.Name = "BtnJob";
            BtnJob.Padding = new Padding(24, 5, 0, 5);
            BtnJob.Size = new Size(231, 60);
            BtnJob.TabIndex = 18;
            BtnJob.Text = "   Công việc";
            BtnJob.TextAlign = ContentAlignment.MiddleLeft;
            BtnJob.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnJob.UseVisualStyleBackColor = false;
            BtnJob.MouseClick += BtnJob_MouseClick;
            BtnJob.MouseDown += BtnJob_MouseDown;
            BtnJob.MouseUp += BtnJob_MouseUp;
            // 
            // lbAppName
            // 
            lbAppName.Cursor = Cursors.Hand;
            lbAppName.Dock = DockStyle.Top;
            lbAppName.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAppName.ForeColor = Color.White;
            lbAppName.Location = new Point(0, 0);
            lbAppName.Name = "lbAppName";
            lbAppName.Size = new Size(231, 100);
            lbAppName.TabIndex = 23;
            lbAppName.Text = "iPPS Ver.0";
            lbAppName.TextAlign = ContentAlignment.MiddleCenter;
            lbAppName.Click += LbAppName_Click;
            // 
            // PnlWorkplace
            // 
            PnlWorkplace.AccessibleRole = AccessibleRole.None;
            PnlWorkplace.BackColor = Color.FromArgb(15, 15, 15);
            PnlWorkplace.Dock = DockStyle.Fill;
            PnlWorkplace.Location = new Point(231, 0);
            PnlWorkplace.Name = "PnlWorkplace";
            PnlWorkplace.Size = new Size(1049, 720);
            PnlWorkplace.TabIndex = 2;
            // 
            // FormMenuGUI
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(PnlWorkplace);
            Controls.Add(PnlLeft);
            Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2);
            Name = "FormMenuGUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bảng điều khiển";
            FormClosed += FormMenu_FormClosed;
            Load += FormMenu_Load;
            PnlLeft.ResumeLayout(false);
            PnlAccount.ResumeLayout(false);
            PnlAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PcbImageUser).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlLeft;
        private System.Windows.Forms.Panel PnlWorkplace;
        private System.Windows.Forms.PictureBox PcbImageUser;
        private System.Windows.Forms.Label LbUsername;
        private System.Windows.Forms.Label LbRole;
        private System.Windows.Forms.Panel PnlAccount;
        private System.Windows.Forms.Button BtnJob;
        private System.Windows.Forms.Button BtnProgress;
        private System.Windows.Forms.Button BtnDocument;
        private System.Windows.Forms.Button BtnProject;
        private System.Windows.Forms.Label lbAppName;
        private Button employeeButton;
        private Button dormitoryButton;
        private Button salaryButton;
        private Button attendanceButton;
        private Panel optionPanel;
    }
}

