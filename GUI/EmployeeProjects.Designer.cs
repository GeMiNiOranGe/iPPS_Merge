﻿namespace GUI
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
        private void InitializeComponent()
        {
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.IDProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProjects
            // 
            this.dgvProjects.AllowUserToAddRows = false;
            this.dgvProjects.AllowUserToDeleteRows = false;
            this.dgvProjects.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(128)))), ((int)(((byte)(134)))));
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProject,
            this.ProjectName,
            this.AccessRight,
            this.TrangThai,
            this.KhachHang,
            this.IDTask,
            this.IDPhongBan,
            this.start,
            this.end});
            this.dgvProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProjects.Location = new System.Drawing.Point(0, 0);
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.ReadOnly = true;
            this.dgvProjects.RowHeadersWidth = 51;
            this.dgvProjects.RowTemplate.Height = 24;
            this.dgvProjects.Size = new System.Drawing.Size(1082, 553);
            this.dgvProjects.TabIndex = 1;
            // 
            // IDProject
            // 
            this.IDProject.HeaderText = "ID dự án";
            this.IDProject.MinimumWidth = 6;
            this.IDProject.Name = "IDProject";
            this.IDProject.ReadOnly = true;
            this.IDProject.Width = 70;
            // 
            // ProjectName
            // 
            this.ProjectName.HeaderText = "Tên dự án";
            this.ProjectName.MinimumWidth = 6;
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            this.ProjectName.Width = 125;
            // 
            // AccessRight
            // 
            this.AccessRight.HeaderText = "Quyền truy cập";
            this.AccessRight.MinimumWidth = 6;
            this.AccessRight.Name = "AccessRight";
            this.AccessRight.ReadOnly = true;
            this.AccessRight.Width = 60;
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Width = 60;
            // 
            // KhachHang
            // 
            this.KhachHang.HeaderText = "Tên khách hàng";
            this.KhachHang.MinimumWidth = 6;
            this.KhachHang.Name = "KhachHang";
            this.KhachHang.ReadOnly = true;
            this.KhachHang.Width = 125;
            // 
            // IDTask
            // 
            this.IDTask.HeaderText = "ID quản lý";
            this.IDTask.MinimumWidth = 6;
            this.IDTask.Name = "IDTask";
            this.IDTask.ReadOnly = true;
            this.IDTask.Width = 70;
            // 
            // IDPhongBan
            // 
            this.IDPhongBan.HeaderText = "ID phòng ban";
            this.IDPhongBan.MinimumWidth = 6;
            this.IDPhongBan.Name = "IDPhongBan";
            this.IDPhongBan.ReadOnly = true;
            this.IDPhongBan.Width = 70;
            // 
            // start
            // 
            this.start.HeaderText = "Ngày bắt đầu";
            this.start.MinimumWidth = 6;
            this.start.Name = "start";
            this.start.ReadOnly = true;
            this.start.Width = 80;
            // 
            // end
            // 
            this.end.HeaderText = "Ngày kết thúc";
            this.end.MinimumWidth = 6;
            this.end.Name = "end";
            this.end.ReadOnly = true;
            this.end.Width = 80;
            // 
            // EmployeeProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.dgvProjects);
            this.Name = "EmployeeProjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeProjects";
            this.Load += new System.EventHandler(this.EmployeeProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn start;
        private System.Windows.Forms.DataGridViewTextBoxColumn end;
    }
}