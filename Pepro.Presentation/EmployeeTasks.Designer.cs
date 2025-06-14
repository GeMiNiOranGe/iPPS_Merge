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
            txtSearchTask = new TextBox();
            label1 = new Label();
            txtSearchProject = new TextBox();
            lblSearch = new Label();
            dgvTasks = new DataGridView();
            idJob = new DataGridViewTextBoxColumn();
            idMng = new DataGridViewTextBoxColumn();
            WorkName = new DataGridViewTextBoxColumn();
            AccessRight = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            PrjPublic = new DataGridViewTextBoxColumn();
            DepPublic = new DataGridViewTextBoxColumn();
            ProjectID = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 22, 22);
            panel1.Controls.Add(txtSearchTask);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtSearchProject);
            panel1.Controls.Add(lblSearch);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 467);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 94);
            panel1.TabIndex = 3;
            // 
            // txtSearchTask
            // 
            txtSearchTask.Location = new Point(146, 52);
            txtSearchTask.Margin = new Padding(3, 4, 3, 4);
            txtSearchTask.Name = "txtSearchTask";
            txtSearchTask.Size = new Size(169, 31);
            txtSearchTask.TabIndex = 4;
            txtSearchTask.KeyPress += txtSearchTask_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(128, 18);
            label1.TabIndex = 3;
            label1.Text = "Nhập ID công việc";
            // 
            // txtSearchProject
            // 
            txtSearchProject.Location = new Point(146, 13);
            txtSearchProject.Margin = new Padding(3, 4, 3, 4);
            txtSearchProject.Name = "txtSearchProject";
            txtSearchProject.Size = new Size(169, 31);
            txtSearchProject.TabIndex = 1;
            txtSearchProject.KeyPress += txtSearchProject_KeyPress;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.White;
            lblSearch.Location = new Point(39, 20);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(101, 18);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Nhập ID dự án";
            // 
            // dgvTasks
            // 
            dgvTasks.AllowUserToAddRows = false;
            dgvTasks.AllowUserToDeleteRows = false;
            dgvTasks.BackgroundColor = Color.FromArgb(15, 15, 15);
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Columns.AddRange(new DataGridViewColumn[] { idJob, idMng, WorkName, AccessRight, Status, PrjPublic, DepPublic, ProjectID });
            dgvTasks.Dock = DockStyle.Fill;
            dgvTasks.Location = new Point(0, 0);
            dgvTasks.Margin = new Padding(3, 4, 3, 4);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.ReadOnly = true;
            dgvTasks.RowHeadersWidth = 51;
            dgvTasks.RowTemplate.Height = 24;
            dgvTasks.Size = new Size(984, 467);
            dgvTasks.TabIndex = 2;
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
            ClientSize = new Size(984, 561);
            Controls.Add(dgvTasks);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 13F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmployeeTasks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeTasks";
            Load += EmployeeTasks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox txtSearchTask;
        private Label label1;
        private TextBox txtSearchProject;
        private Label lblSearch;
        private DataGridView dgvTasks;
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