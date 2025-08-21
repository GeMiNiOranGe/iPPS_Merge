namespace Pepro.Presentation.Controls
{
    partial class ProjectControl
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
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            addButton = new Button();
            actionPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)projectDataGridView).BeginInit();
            actionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // projectDataGridView
            // 
            projectDataGridView.AllowUserToAddRows = false;
            projectDataGridView.BackgroundColor = Color.FromArgb(15, 15, 15);
            projectDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projectDataGridView.Columns.AddRange(new DataGridViewColumn[] { IDProject, ProjectName, AccessRight, TrangThai, KhachHang, IDTask, IDPhongBan, start, end, Edit, Delete });
            projectDataGridView.Dock = DockStyle.Fill;
            projectDataGridView.Location = new Point(0, 48);
            projectDataGridView.Margin = new Padding(3, 4, 3, 4);
            projectDataGridView.Name = "projectDataGridView";
            projectDataGridView.RowHeadersWidth = 51;
            projectDataGridView.RowTemplate.Height = 24;
            projectDataGridView.Size = new Size(1064, 554);
            projectDataGridView.TabIndex = 0;
            projectDataGridView.CellContentClick += ProjectDataGridView_CellContentClick;
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
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addButton.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addButton.Location = new Point(1002, 16);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(50, 50);
            addButton.TabIndex = 0;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // actionPanel
            // 
            actionPanel.BackColor = Color.FromArgb(22, 22, 22);
            actionPanel.Controls.Add(addButton);
            actionPanel.Dock = DockStyle.Bottom;
            actionPanel.Location = new Point(0, 602);
            actionPanel.Margin = new Padding(3, 4, 3, 4);
            actionPanel.Name = "actionPanel";
            actionPanel.Size = new Size(1064, 79);
            actionPanel.TabIndex = 2;
            // 
            // ProjectControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(projectDataGridView);
            Controls.Add(actionPanel);
            HeaderText = "Project";
            Name = "ProjectControl";
            ReturnButtonVisible = false;
            Load += AdminProjects_Load;
            Controls.SetChildIndex(actionPanel, 0);
            Controls.SetChildIndex(projectDataGridView, 0);
            ((System.ComponentModel.ISupportInitialize)projectDataGridView).EndInit();
            actionPanel.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private DataGridView projectDataGridView;
        private Button addButton;
        private Panel actionPanel;
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