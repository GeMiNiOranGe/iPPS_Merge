namespace Pepro.Presentation
{
    partial class EmployeeTasks
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
        private void InitializeComponent() {
            panel1 = new Panel();
            taskIdTextBox = new TextBox();
            taskIdLabel = new Label();
            projectIdTextBox = new TextBox();
            projectIdLabel = new Label();
            taskDataGridView = new DataGridView();
            idJob = new DataGridViewTextBoxColumn();
            idMng = new DataGridViewTextBoxColumn();
            WorkName = new DataGridViewTextBoxColumn();
            AccessRight = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            PrjPublic = new DataGridViewTextBoxColumn();
            DepPublic = new DataGridViewTextBoxColumn();
            ProjectID = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)taskDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 22, 22);
            panel1.Controls.Add(taskIdTextBox);
            panel1.Controls.Add(taskIdLabel);
            panel1.Controls.Add(projectIdTextBox);
            panel1.Controls.Add(projectIdLabel);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 467);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 94);
            panel1.TabIndex = 3;
            // 
            // taskIdTextBox
            // 
            taskIdTextBox.Location = new Point(146, 52);
            taskIdTextBox.Margin = new Padding(3, 4, 3, 4);
            taskIdTextBox.Name = "taskIdTextBox";
            taskIdTextBox.Size = new Size(169, 31);
            taskIdTextBox.TabIndex = 4;
            taskIdTextBox.KeyPress += TaskIdTextBox_KeyPress;
            // 
            // taskIdLabel
            // 
            taskIdLabel.AutoSize = true;
            taskIdLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskIdLabel.ForeColor = Color.White;
            taskIdLabel.Location = new Point(12, 59);
            taskIdLabel.Name = "taskIdLabel";
            taskIdLabel.Size = new Size(128, 18);
            taskIdLabel.TabIndex = 3;
            taskIdLabel.Text = "Nhập ID công việc";
            // 
            // projectIdTextBox
            // 
            projectIdTextBox.Location = new Point(146, 13);
            projectIdTextBox.Margin = new Padding(3, 4, 3, 4);
            projectIdTextBox.Name = "projectIdTextBox";
            projectIdTextBox.Size = new Size(169, 31);
            projectIdTextBox.TabIndex = 1;
            projectIdTextBox.KeyPress += ProjectIdTextBox_KeyPress;
            // 
            // projectIdLabel
            // 
            projectIdLabel.AutoSize = true;
            projectIdLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectIdLabel.ForeColor = Color.White;
            projectIdLabel.Location = new Point(39, 20);
            projectIdLabel.Name = "projectIdLabel";
            projectIdLabel.Size = new Size(101, 18);
            projectIdLabel.TabIndex = 0;
            projectIdLabel.Text = "Nhập ID dự án";
            // 
            // taskDataGridView
            // 
            taskDataGridView.AllowUserToAddRows = false;
            taskDataGridView.AllowUserToDeleteRows = false;
            taskDataGridView.BackgroundColor = Color.FromArgb(15, 15, 15);
            taskDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            taskDataGridView.Columns.AddRange(new DataGridViewColumn[] { idJob, idMng, WorkName, AccessRight, Status, PrjPublic, DepPublic, ProjectID });
            taskDataGridView.Dock = DockStyle.Fill;
            taskDataGridView.Location = new Point(0, 0);
            taskDataGridView.Margin = new Padding(3, 4, 3, 4);
            taskDataGridView.Name = "taskDataGridView";
            taskDataGridView.ReadOnly = true;
            taskDataGridView.RowHeadersWidth = 51;
            taskDataGridView.RowTemplate.Height = 24;
            taskDataGridView.Size = new Size(984, 467);
            taskDataGridView.TabIndex = 2;
            // 
            // idJob
            // 
            idJob.HeaderText = "ID công việc";
            idJob.MinimumWidth = 6;
            idJob.Name = "idJob";
            idJob.ReadOnly = true;
            idJob.Width = 150;
            // 
            // idMng
            // 
            idMng.HeaderText = "ID quản lý";
            idMng.MinimumWidth = 6;
            idMng.Name = "idMng";
            idMng.ReadOnly = true;
            idMng.Width = 125;
            // 
            // WorkName
            // 
            WorkName.HeaderText = "Tên công việc";
            WorkName.MinimumWidth = 6;
            WorkName.Name = "WorkName";
            WorkName.ReadOnly = true;
            WorkName.Width = 160;
            // 
            // AccessRight
            // 
            AccessRight.HeaderText = "Quyền truy cập";
            AccessRight.MinimumWidth = 6;
            AccessRight.Name = "AccessRight";
            AccessRight.ReadOnly = true;
            AccessRight.Width = 160;
            // 
            // Status
            // 
            Status.HeaderText = "Tình trạng";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 160;
            // 
            // PrjPublic
            // 
            PrjPublic.HeaderText = "Công khai dự án";
            PrjPublic.MinimumWidth = 6;
            PrjPublic.Name = "PrjPublic";
            PrjPublic.ReadOnly = true;
            PrjPublic.Width = 220;
            // 
            // DepPublic
            // 
            DepPublic.HeaderText = "Công khai phòng ban";
            DepPublic.MinimumWidth = 6;
            DepPublic.Name = "DepPublic";
            DepPublic.ReadOnly = true;
            DepPublic.Width = 220;
            // 
            // ProjectID
            // 
            ProjectID.HeaderText = "ID dự án";
            ProjectID.MinimumWidth = 6;
            ProjectID.Name = "ProjectID";
            ProjectID.ReadOnly = true;
            ProjectID.Width = 125;
            // 
            // EmployeeTasks
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(taskDataGridView);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 13F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmployeeTasks";
            Size = new Size(984, 561);
            Load += EmployeeTasks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)taskDataGridView).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox taskIdTextBox;
        private Label taskIdLabel;
        private TextBox projectIdTextBox;
        private Label projectIdLabel;
        private DataGridView taskDataGridView;
        private DataGridViewTextBoxColumn idJob;
        private DataGridViewTextBoxColumn idMng;
        private DataGridViewTextBoxColumn WorkName;
        private DataGridViewTextBoxColumn AccessRight;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn PrjPublic;
        private DataGridViewTextBoxColumn DepPublic;
        private DataGridViewTextBoxColumn ProjectID;
    }
}