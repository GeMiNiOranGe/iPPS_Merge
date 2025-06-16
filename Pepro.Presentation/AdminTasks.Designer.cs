namespace Pepro.Presentation
{
    partial class AdminTasks
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
            txtSearchTask = new TextBox();
            label1 = new Label();
            btnAdd = new Button();
            txtSearchProject = new TextBox();
            lblSearch = new Label();
            Delete = new DataGridViewImageColumn();
            Edit = new DataGridViewImageColumn();
            ProjectID = new DataGridViewTextBoxColumn();
            DepPublic = new DataGridViewTextBoxColumn();
            PrjPublic = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            AccessRight = new DataGridViewTextBoxColumn();
            WorkName = new DataGridViewTextBoxColumn();
            idMng = new DataGridViewTextBoxColumn();
            idJob = new DataGridViewTextBoxColumn();
            dgvTasks = new DataGridView();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearchTask
            // 
            txtSearchTask.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtSearchTask.Location = new Point(792, 54);
            txtSearchTask.Margin = new Padding(2, 5, 2, 5);
            txtSearchTask.Name = "txtSearchTask";
            txtSearchTask.Size = new Size(112, 31);
            txtSearchTask.TabIndex = 4;
            txtSearchTask.KeyPress += txtSearchTask_KeyPress;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(645, 58);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 21);
            label1.TabIndex = 3;
            label1.Text = "Nhập mã công việc";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(916, 22);
            btnAdd.Margin = new Padding(2, 5, 2, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(56, 57);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearchProject
            // 
            txtSearchProject.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtSearchProject.Location = new Point(792, 15);
            txtSearchProject.Margin = new Padding(2, 5, 2, 5);
            txtSearchProject.Name = "txtSearchProject";
            txtSearchProject.Size = new Size(112, 31);
            txtSearchProject.TabIndex = 1;
            txtSearchProject.KeyPress += txtSearchProject_KeyPress;
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 12F);
            lblSearch.ForeColor = Color.White;
            lblSearch.Location = new Point(671, 19);
            lblSearch.Margin = new Padding(2, 0, 2, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(117, 21);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Nhập mã dự án";
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Width = 6;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "";
            Edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Width = 6;
            // 
            // ProjectID
            // 
            ProjectID.HeaderText = "ID dự án";
            ProjectID.MinimumWidth = 6;
            ProjectID.Name = "ProjectID";
            ProjectID.Width = 125;
            // 
            // DepPublic
            // 
            DepPublic.HeaderText = "Công khai phòng ban";
            DepPublic.MinimumWidth = 6;
            DepPublic.Name = "DepPublic";
            DepPublic.Width = 220;
            // 
            // PrjPublic
            // 
            PrjPublic.HeaderText = "Công khai dự án";
            PrjPublic.MinimumWidth = 6;
            PrjPublic.Name = "PrjPublic";
            PrjPublic.Width = 175;
            // 
            // Status
            // 
            Status.HeaderText = "Tình trạng";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // AccessRight
            // 
            AccessRight.HeaderText = "Quyền truy cập";
            AccessRight.MinimumWidth = 6;
            AccessRight.Name = "AccessRight";
            AccessRight.Width = 160;
            // 
            // WorkName
            // 
            WorkName.HeaderText = "Tên công việc";
            WorkName.MinimumWidth = 6;
            WorkName.Name = "WorkName";
            WorkName.Width = 145;
            // 
            // idMng
            // 
            idMng.HeaderText = "ID quản lý";
            idMng.MinimumWidth = 6;
            idMng.Name = "idMng";
            idMng.Width = 125;
            // 
            // idJob
            // 
            idJob.HeaderText = "ID công việc";
            idJob.MinimumWidth = 6;
            idJob.Name = "idJob";
            idJob.Width = 135;
            // 
            // dgvTasks
            // 
            dgvTasks.AllowUserToAddRows = false;
            dgvTasks.BackgroundColor = Color.FromArgb(15, 15, 15);
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Columns.AddRange(new DataGridViewColumn[] { idJob, idMng, WorkName, AccessRight, Status, PrjPublic, DepPublic, ProjectID, Edit, Delete });
            dgvTasks.Dock = DockStyle.Fill;
            dgvTasks.Location = new Point(0, 0);
            dgvTasks.Margin = new Padding(2, 5, 2, 5);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersWidth = 51;
            dgvTasks.RowTemplate.Height = 24;
            dgvTasks.Size = new Size(984, 462);
            dgvTasks.TabIndex = 0;
            dgvTasks.CellContentClick += dgvTasks_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 22, 22);
            panel2.Controls.Add(txtSearchProject);
            panel2.Controls.Add(txtSearchTask);
            panel2.Controls.Add(lblSearch);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnAdd);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 462);
            panel2.Margin = new Padding(2, 5, 2, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 99);
            panel2.TabIndex = 2;
            // 
            // AdminTasks
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(dgvTasks);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2, 5, 2, 5);
            Name = "AdminTasks";
            Text = "Admin Tasks";
            Load += AdminTasks_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private Button btnAdd;
        private TextBox txtSearchProject;
        private Label lblSearch;
        private TextBox txtSearchTask;
        private Label label1;
        private DataGridViewImageColumn Delete;
        private DataGridViewImageColumn Edit;
        private DataGridViewTextBoxColumn ProjectID;
        private DataGridViewTextBoxColumn DepPublic;
        private DataGridViewTextBoxColumn PrjPublic;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn AccessRight;
        private DataGridViewTextBoxColumn WorkName;
        private DataGridViewTextBoxColumn idMng;
        private DataGridViewTextBoxColumn idJob;
        private DataGridView dgvTasks;
        private Panel panel2;
    }
}