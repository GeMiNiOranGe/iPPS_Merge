namespace Pepro.Presentation.Controls
{
    partial class EmployeeProjects
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
            projectDataGridView = new DataGridView();
            IDProject = new DataGridViewTextBoxColumn();
            ProjectName = new DataGridViewTextBoxColumn();
            AccessRight = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            KhachHang = new DataGridViewTextBoxColumn();
            IDTask = new DataGridViewTextBoxColumn();
            IDPhongBan = new DataGridViewTextBoxColumn();
            start = new DataGridViewTextBoxColumn();
            end = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)projectDataGridView).BeginInit();
            SuspendLayout();
            // 
            // projectDataGridView
            // 
            projectDataGridView.AllowUserToAddRows = false;
            projectDataGridView.AllowUserToDeleteRows = false;
            projectDataGridView.BackgroundColor = Color.FromArgb(15, 15, 15);
            projectDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projectDataGridView.Columns.AddRange(new DataGridViewColumn[] { IDProject, ProjectName, AccessRight, TrangThai, KhachHang, IDTask, IDPhongBan, start, end });
            projectDataGridView.Dock = DockStyle.Fill;
            projectDataGridView.Location = new Point(0, 0);
            projectDataGridView.Margin = new Padding(3, 4, 3, 4);
            projectDataGridView.Name = "projectDataGridView";
            projectDataGridView.ReadOnly = true;
            projectDataGridView.RowHeadersWidth = 51;
            projectDataGridView.RowTemplate.Height = 24;
            projectDataGridView.Size = new Size(984, 561);
            projectDataGridView.TabIndex = 1;
            // 
            // IDProject
            // 
            IDProject.HeaderText = "ID dự án";
            IDProject.MinimumWidth = 6;
            IDProject.Name = "IDProject";
            IDProject.ReadOnly = true;
            IDProject.Width = 150;
            // 
            // ProjectName
            // 
            ProjectName.HeaderText = "Tên dự án";
            ProjectName.MinimumWidth = 6;
            ProjectName.Name = "ProjectName";
            ProjectName.ReadOnly = true;
            ProjectName.Width = 125;
            // 
            // AccessRight
            // 
            AccessRight.HeaderText = "Quyền truy cập";
            AccessRight.MinimumWidth = 6;
            AccessRight.Name = "AccessRight";
            AccessRight.ReadOnly = true;
            AccessRight.Width = 180;
            // 
            // TrangThai
            // 
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            TrangThai.ReadOnly = true;
            TrangThai.Width = 120;
            // 
            // KhachHang
            // 
            KhachHang.HeaderText = "Tên khách hàng";
            KhachHang.MinimumWidth = 6;
            KhachHang.Name = "KhachHang";
            KhachHang.ReadOnly = true;
            KhachHang.Width = 160;
            // 
            // IDTask
            // 
            IDTask.HeaderText = "ID quản lý";
            IDTask.MinimumWidth = 6;
            IDTask.Name = "IDTask";
            IDTask.ReadOnly = true;
            IDTask.Width = 140;
            // 
            // IDPhongBan
            // 
            IDPhongBan.HeaderText = "ID phòng ban";
            IDPhongBan.MinimumWidth = 6;
            IDPhongBan.Name = "IDPhongBan";
            IDPhongBan.ReadOnly = true;
            IDPhongBan.Width = 160;
            // 
            // start
            // 
            start.HeaderText = "Ngày bắt đầu";
            start.MinimumWidth = 6;
            start.Name = "start";
            start.ReadOnly = true;
            start.Width = 160;
            // 
            // end
            // 
            end.HeaderText = "Ngày kết thúc";
            end.MinimumWidth = 6;
            end.Name = "end";
            end.ReadOnly = true;
            end.Width = 160;
            // 
            // EmployeeProjects
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(projectDataGridView);
            Font = new Font("Segoe UI", 13F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmployeeProjects";
            Size = new Size(984, 561);
            Load += EmployeeProjects_Load;
            ((System.ComponentModel.ISupportInitialize)projectDataGridView).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private DataGridView projectDataGridView;
        private DataGridViewTextBoxColumn IDProject;
        private DataGridViewTextBoxColumn ProjectName;
        private DataGridViewTextBoxColumn AccessRight;
        private DataGridViewTextBoxColumn TrangThai;
        private DataGridViewTextBoxColumn KhachHang;
        private DataGridViewTextBoxColumn IDTask;
        private DataGridViewTextBoxColumn IDPhongBan;
        private DataGridViewTextBoxColumn start;
        private DataGridViewTextBoxColumn end;
    }
}