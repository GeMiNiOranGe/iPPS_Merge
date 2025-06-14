namespace Pepro.Presentation
{
    partial class AdminProjects
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
            dgvProjects = new DataGridView();
            IDProject = new DataGridViewTextBoxColumn();
            ProjectName = new DataGridViewTextBoxColumn();
            AccessRight = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            KhachHang = new DataGridViewTextBoxColumn();
            IDTask = new DataGridViewTextBoxColumn();
            IDPhongBan = new DataGridViewTextBoxColumn();
            start = new DataGridViewTextBoxColumn();
            end = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            btnAdd = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvProjects).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProjects
            // 
            dgvProjects.AllowUserToAddRows = false;
            dgvProjects.BackgroundColor = Color.FromArgb(15, 15, 15);
            dgvProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProjects.Columns.AddRange(new DataGridViewColumn[] { IDProject, ProjectName, AccessRight, TrangThai, KhachHang, IDTask, IDPhongBan, start, end, Edit, Delete });
            dgvProjects.Dock = DockStyle.Fill;
            dgvProjects.Location = new Point(0, 0);
            dgvProjects.Margin = new Padding(3, 4, 3, 4);
            dgvProjects.Name = "dgvProjects";
            dgvProjects.RowHeadersWidth = 51;
            dgvProjects.RowTemplate.Height = 24;
            dgvProjects.Size = new Size(984, 482);
            dgvProjects.TabIndex = 0;
            dgvProjects.CellContentClick += dgvProjects_CellContentClick;
            // 
            // IDProject
            // 
            IDProject.HeaderText = "ID dự án";
            IDProject.MinimumWidth = 6;
            IDProject.Name = "IDProject";
            IDProject.Width = 110;
            // 
            // ProjectName
            // 
            ProjectName.HeaderText = "Tên dự án";
            ProjectName.MinimumWidth = 6;
            ProjectName.Name = "ProjectName";
            ProjectName.Width = 125;
            // 
            // AccessRight
            // 
            AccessRight.HeaderText = "Quyền truy cập";
            AccessRight.MinimumWidth = 6;
            AccessRight.Name = "AccessRight";
            AccessRight.Width = 160;
            // 
            // TrangThai
            // 
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            TrangThai.Width = 120;
            // 
            // KhachHang
            // 
            KhachHang.HeaderText = "Tên khách hàng";
            KhachHang.MinimumWidth = 6;
            KhachHang.Name = "KhachHang";
            KhachHang.Width = 160;
            // 
            // IDTask
            // 
            IDTask.HeaderText = "ID quản lý";
            IDTask.MinimumWidth = 6;
            IDTask.Name = "IDTask";
            IDTask.Width = 130;
            // 
            // IDPhongBan
            // 
            IDPhongBan.HeaderText = "ID phòng ban";
            IDPhongBan.MinimumWidth = 6;
            IDPhongBan.Name = "IDPhongBan";
            IDPhongBan.Width = 150;
            // 
            // start
            // 
            start.HeaderText = "Ngày bắt đầu";
            start.MinimumWidth = 6;
            start.Name = "start";
            start.Width = 160;
            // 
            // end
            // 
            end.HeaderText = "Ngày kết thúc";
            end.MinimumWidth = 6;
            end.Name = "end";
            end.Width = 160;
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
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Width = 6;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(922, 16);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(50, 50);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 22, 22);
            panel2.Controls.Add(btnAdd);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 482);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 79);
            panel2.TabIndex = 2;
            // 
            // AdminProjects
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(dgvProjects);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 13F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminProjects";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Projects";
            Load += AdminProjects_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProjects).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvProjects;
        private Button btnAdd;
        private Panel panel2;
        private DataGridViewTextBoxColumn IDProject;
        private DataGridViewTextBoxColumn ProjectName;
        private DataGridViewTextBoxColumn AccessRight;
        private DataGridViewTextBoxColumn TrangThai;
        private DataGridViewTextBoxColumn KhachHang;
        private DataGridViewTextBoxColumn IDTask;
        private DataGridViewTextBoxColumn IDPhongBan;
        private DataGridViewTextBoxColumn start;
        private DataGridViewTextBoxColumn end;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}