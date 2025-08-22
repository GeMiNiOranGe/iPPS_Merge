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
            projectDataGridView = new PeproDataGridView();
            addButton = new Button();
            actionPanel = new Panel();
            IDProject = new DataGridViewTextBoxColumn();
            ProjectName = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewTextBoxColumn();
            KhachHang = new DataGridViewTextBoxColumn();
            IDTask = new DataGridViewTextBoxColumn();
            start = new DataGridViewTextBoxColumn();
            end = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)projectDataGridView).BeginInit();
            actionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // projectDataGridView
            // 
            projectDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            projectDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projectDataGridView.Columns.AddRange(new DataGridViewColumn[] { IDProject, ProjectName, TrangThai, KhachHang, IDTask, start, end });
            projectDataGridView.Dock = DockStyle.Fill;
            projectDataGridView.Location = new Point(0, 48);
            projectDataGridView.Margin = new Padding(3, 4, 3, 4);
            projectDataGridView.Name = "projectDataGridView";
            projectDataGridView.Size = new Size(1064, 554);
            projectDataGridView.TabIndex = 0;
            projectDataGridView.CellContentClick += ProjectDataGridView_CellContentClick;
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
            // IDProject
            // 
            IDProject.DataPropertyName = "ProjectId";
            IDProject.HeaderText = "ID dự án";
            IDProject.Name = "IDProject";
            IDProject.ReadOnly = true;
            IDProject.Width = 87;
            // 
            // ProjectName
            // 
            ProjectName.DataPropertyName = "Name";
            ProjectName.HeaderText = "Tên dự án";
            ProjectName.Name = "ProjectName";
            ProjectName.ReadOnly = true;
            ProjectName.Width = 94;
            // 
            // TrangThai
            // 
            TrangThai.DataPropertyName = "StatusId";
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.Name = "TrangThai";
            TrangThai.ReadOnly = true;
            TrangThai.Width = 95;
            // 
            // KhachHang
            // 
            KhachHang.DataPropertyName = "CustomerName";
            KhachHang.HeaderText = "Tên khách hàng";
            KhachHang.Name = "KhachHang";
            KhachHang.ReadOnly = true;
            KhachHang.Width = 130;
            // 
            // IDTask
            // 
            IDTask.DataPropertyName = "ManagerId";
            IDTask.HeaderText = "ID quản lý";
            IDTask.Name = "IDTask";
            IDTask.ReadOnly = true;
            IDTask.Width = 97;
            // 
            // start
            // 
            start.DataPropertyName = "StartDate";
            start.HeaderText = "Ngày bắt đầu";
            start.Name = "start";
            start.ReadOnly = true;
            start.Width = 117;
            // 
            // end
            // 
            end.DataPropertyName = "EndDate";
            end.HeaderText = "Ngày kết thúc";
            end.Name = "end";
            end.ReadOnly = true;
            end.Width = 120;
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

        private PeproDataGridView projectDataGridView;
        private Button addButton;
        private Panel actionPanel;
        private DataGridViewTextBoxColumn IDProject;
        private DataGridViewTextBoxColumn ProjectName;
        private DataGridViewTextBoxColumn TrangThai;
        private DataGridViewTextBoxColumn KhachHang;
        private DataGridViewTextBoxColumn IDTask;
        private DataGridViewTextBoxColumn start;
        private DataGridViewTextBoxColumn end;
    }
}