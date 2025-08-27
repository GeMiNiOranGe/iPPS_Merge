namespace Pepro.Presentation.Controls
{
    partial class AssignmentControl
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
            assignmentDataGridView = new PeproDataGridView();
            assignmentNameColumn = new DataGridViewTextBoxColumn();
            isPublicToProjectColumn = new DataGridViewTextBoxColumn();
            isPublicToDepartmentColumn = new DataGridViewTextBoxColumn();
            managerIdColumn = new DataGridViewTextBoxColumn();
            startDateColumn = new DataGridViewTextBoxColumn();
            endDateColumn = new DataGridViewTextBoxColumn();
            projectIdColumn = new DataGridViewTextBoxColumn();
            statusColumn = new DataGridViewTextBoxColumn();
            searchTextBox = new TextBox();
            searchButton = new Button();
            reloadButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            insertButton = new Button();
            ((System.ComponentModel.ISupportInitialize)assignmentDataGridView).BeginInit();
            SuspendLayout();
            // 
            // assignmentDataGridView
            // 
            assignmentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            assignmentDataGridView.Columns.AddRange(new DataGridViewColumn[] { assignmentNameColumn, isPublicToProjectColumn, isPublicToDepartmentColumn, managerIdColumn, startDateColumn, endDateColumn, projectIdColumn, statusColumn });
            assignmentDataGridView.Location = new Point(16, 123);
            assignmentDataGridView.Margin = new Padding(16);
            assignmentDataGridView.Name = "assignmentDataGridView";
            assignmentDataGridView.Size = new Size(1032, 542);
            assignmentDataGridView.TabIndex = 0;
            assignmentDataGridView.CellClick += AssignmentDataGridView_CellClick;
            // 
            // assignmentNameColumn
            // 
            assignmentNameColumn.DataPropertyName = "Name";
            assignmentNameColumn.HeaderText = "Tên công việc";
            assignmentNameColumn.Name = "assignmentNameColumn";
            assignmentNameColumn.ReadOnly = true;
            assignmentNameColumn.Width = 106;
            // 
            // isPublicToProjectColumn
            // 
            isPublicToProjectColumn.DataPropertyName = "IsPublicToProject";
            isPublicToProjectColumn.HeaderText = "Công khai dự án";
            isPublicToProjectColumn.Name = "isPublicToProjectColumn";
            isPublicToProjectColumn.ReadOnly = true;
            isPublicToProjectColumn.Width = 110;
            // 
            // isPublicToDepartmentColumn
            // 
            isPublicToDepartmentColumn.DataPropertyName = "IsPublicToDepartment";
            isPublicToDepartmentColumn.HeaderText = "Công khai phòng ban";
            isPublicToDepartmentColumn.Name = "isPublicToDepartmentColumn";
            isPublicToDepartmentColumn.ReadOnly = true;
            isPublicToDepartmentColumn.Width = 132;
            // 
            // managerIdColumn
            // 
            managerIdColumn.DataPropertyName = "ManagerId";
            managerIdColumn.HeaderText = "Mã quản lý";
            managerIdColumn.Name = "managerIdColumn";
            managerIdColumn.ReadOnly = true;
            managerIdColumn.Width = 86;
            // 
            // startDateColumn
            // 
            startDateColumn.DataPropertyName = "StartDate";
            startDateColumn.HeaderText = "Ngày bắt đầu";
            startDateColumn.Name = "startDateColumn";
            startDateColumn.ReadOnly = true;
            startDateColumn.Width = 87;
            // 
            // endDateColumn
            // 
            endDateColumn.DataPropertyName = "EndDate";
            endDateColumn.HeaderText = "Ngày kết thúc";
            endDateColumn.Name = "endDateColumn";
            endDateColumn.ReadOnly = true;
            endDateColumn.Width = 86;
            // 
            // projectIdColumn
            // 
            projectIdColumn.DataPropertyName = "ProjectId";
            projectIdColumn.HeaderText = "Mã dự án";
            projectIdColumn.Name = "projectIdColumn";
            projectIdColumn.ReadOnly = true;
            projectIdColumn.Width = 72;
            // 
            // statusColumn
            // 
            statusColumn.DataPropertyName = "StatusName";
            statusColumn.HeaderText = "Tình trạng";
            statusColumn.Name = "statusColumn";
            statusColumn.ReadOnly = true;
            statusColumn.Width = 89;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(16, 75);
            searchTextBox.Margin = new Padding(3, 2, 3, 2);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Search for assignment id or name";
            searchTextBox.Size = new Size(431, 26);
            searchTextBox.TabIndex = 7;
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            searchButton.Location = new Point(466, 67);
            searchButton.Margin = new Padding(16, 16, 0, 0);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(40, 40);
            searchButton.TabIndex = 8;
            searchButton.Click += SearchButton_Click;
            // 
            // reloadButton
            // 
            reloadButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            reloadButton.Location = new Point(522, 67);
            reloadButton.Margin = new Padding(16, 16, 0, 0);
            reloadButton.Name = "reloadButton";
            reloadButton.Size = new Size(40, 40);
            reloadButton.TabIndex = 9;
            reloadButton.Click += ReloadButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            deleteButton.Location = new Point(706, 67);
            deleteButton.Margin = new Padding(16, 16, 0, 0);
            deleteButton.Name = "deleteButton";
            deleteButton.Padding = new Padding(12, 0, 12, 0);
            deleteButton.Size = new Size(112, 40);
            deleteButton.TabIndex = 10;
            deleteButton.Text = " Delete";
            // 
            // updateButton
            // 
            updateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            updateButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            updateButton.Location = new Point(834, 67);
            updateButton.Margin = new Padding(16, 16, 0, 0);
            updateButton.Name = "updateButton";
            updateButton.Padding = new Padding(12, 0, 12, 0);
            updateButton.Size = new Size(98, 40);
            updateButton.TabIndex = 11;
            updateButton.Text = " Edit";
            updateButton.Click += UpdateButton_Click;
            // 
            // insertButton
            // 
            insertButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insertButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            insertButton.Location = new Point(948, 67);
            insertButton.Margin = new Padding(16, 16, 0, 0);
            insertButton.Name = "insertButton";
            insertButton.Padding = new Padding(12, 0, 12, 0);
            insertButton.Size = new Size(100, 40);
            insertButton.TabIndex = 12;
            insertButton.Text = " Add";
            insertButton.Click += InsertButton_Click;
            // 
            // AssignmentControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(searchTextBox);
            Controls.Add(searchButton);
            Controls.Add(reloadButton);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(insertButton);
            Controls.Add(assignmentDataGridView);
            HeaderText = "Assignment";
            Name = "AssignmentControl";
            ReturnButtonVisible = false;
            Load += AssignmentControl_Load;
            Controls.SetChildIndex(assignmentDataGridView, 0);
            Controls.SetChildIndex(insertButton, 0);
            Controls.SetChildIndex(updateButton, 0);
            Controls.SetChildIndex(deleteButton, 0);
            Controls.SetChildIndex(reloadButton, 0);
            Controls.SetChildIndex(searchButton, 0);
            Controls.SetChildIndex(searchTextBox, 0);
            ((System.ComponentModel.ISupportInitialize)assignmentDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private PeproDataGridView assignmentDataGridView;
        private TextBox searchTextBox;
        private Button searchButton;
        private Button reloadButton;
        private Button deleteButton;
        private Button updateButton;
        private Button insertButton;
        private DataGridViewTextBoxColumn assignmentNameColumn;
        private DataGridViewTextBoxColumn isPublicToProjectColumn;
        private DataGridViewTextBoxColumn isPublicToDepartmentColumn;
        private DataGridViewTextBoxColumn managerIdColumn;
        private DataGridViewTextBoxColumn startDateColumn;
        private DataGridViewTextBoxColumn endDateColumn;
        private DataGridViewTextBoxColumn projectIdColumn;
        private DataGridViewTextBoxColumn statusColumn;
    }
}