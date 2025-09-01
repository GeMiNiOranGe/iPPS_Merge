namespace Pepro.Presentation.Controls
{
    partial class DepartmentControl
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
            departmentDataGridView = new PeproDataGridView();
            departmentNameColumn = new DataGridViewTextBoxColumn();
            managerIdColumn = new DataGridViewTextBoxColumn();
            departmentInputField = new PeproInputField();
            managerInputField = new PeproInputField();
            searchTextBox = new TextBox();
            searchButton = new Button();
            reloadButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            insertButton = new Button();
            ((System.ComponentModel.ISupportInitialize)departmentDataGridView).BeginInit();
            SuspendLayout();
            // 
            // departmentDataGridView
            // 
            departmentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            departmentDataGridView.Columns.AddRange(new DataGridViewColumn[] { departmentNameColumn, managerIdColumn });
            departmentDataGridView.Location = new Point(16, 195);
            departmentDataGridView.Margin = new Padding(16);
            departmentDataGridView.Name = "departmentDataGridView";
            departmentDataGridView.Size = new Size(1032, 470);
            departmentDataGridView.TabIndex = 7;
            // 
            // departmentNameColumn
            // 
            departmentNameColumn.DataPropertyName = "Name";
            departmentNameColumn.HeaderText = "Name";
            departmentNameColumn.Name = "departmentNameColumn";
            departmentNameColumn.ReadOnly = true;
            departmentNameColumn.Width = 70;
            // 
            // managerIdColumn
            // 
            managerIdColumn.DataPropertyName = "ManagerId";
            managerIdColumn.HeaderText = "Manager";
            managerIdColumn.Name = "managerIdColumn";
            managerIdColumn.ReadOnly = true;
            managerIdColumn.Width = 89;
            // 
            // departmentInputField
            // 
            departmentInputField.Enabled = false;
            departmentInputField.LabelText = "Department name";
            departmentInputField.Location = new Point(16, 67);
            departmentInputField.Margin = new Padding(16, 16, 0, 24);
            departmentInputField.Name = "departmentInputField";
            departmentInputField.PlaceholderText = "e.g. department name";
            departmentInputField.Size = new Size(504, 48);
            departmentInputField.TabIndex = 0;
            departmentInputField.TabStop = false;
            // 
            // managerInputField
            // 
            managerInputField.Enabled = false;
            managerInputField.LabelText = "Manager";
            managerInputField.Location = new Point(544, 67);
            managerInputField.Margin = new Padding(24, 16, 16, 24);
            managerInputField.Name = "managerInputField";
            managerInputField.PlaceholderText = "e.g. manager";
            managerInputField.Size = new Size(504, 48);
            managerInputField.TabIndex = 0;
            managerInputField.TabStop = false;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(16, 147);
            searchTextBox.Margin = new Padding(16, 0, 16, 0);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Search for department name";
            searchTextBox.Size = new Size(431, 26);
            searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            searchButton.Location = new Point(466, 139);
            searchButton.Margin = new Padding(16, 0, 0, 0);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(40, 40);
            searchButton.TabIndex = 2;
            // 
            // reloadButton
            // 
            reloadButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            reloadButton.Location = new Point(522, 139);
            reloadButton.Margin = new Padding(16, 0, 0, 0);
            reloadButton.Name = "reloadButton";
            reloadButton.Size = new Size(40, 40);
            reloadButton.TabIndex = 3;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            deleteButton.Location = new Point(706, 139);
            deleteButton.Margin = new Padding(16, 0, 0, 0);
            deleteButton.Name = "deleteButton";
            deleteButton.Padding = new Padding(12, 0, 12, 0);
            deleteButton.Size = new Size(112, 40);
            deleteButton.TabIndex = 4;
            deleteButton.Text = " Delete";
            // 
            // updateButton
            // 
            updateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            updateButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            updateButton.Location = new Point(834, 139);
            updateButton.Margin = new Padding(16, 0, 0, 0);
            updateButton.Name = "updateButton";
            updateButton.Padding = new Padding(12, 0, 12, 0);
            updateButton.Size = new Size(98, 40);
            updateButton.TabIndex = 5;
            updateButton.Text = " Edit";
            // 
            // insertButton
            // 
            insertButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insertButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            insertButton.Location = new Point(948, 139);
            insertButton.Margin = new Padding(16, 0, 0, 0);
            insertButton.Name = "insertButton";
            insertButton.Padding = new Padding(12, 0, 12, 0);
            insertButton.Size = new Size(100, 40);
            insertButton.TabIndex = 6;
            insertButton.Text = " Add";
            // 
            // DepartmentControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(departmentInputField);
            Controls.Add(managerInputField);
            Controls.Add(searchTextBox);
            Controls.Add(searchButton);
            Controls.Add(reloadButton);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(insertButton);
            Controls.Add(departmentDataGridView);
            HeaderText = "Department";
            Name = "DepartmentControl";
            ReturnButtonVisible = false;
            Load += DepartmentControl_Load;
            Controls.SetChildIndex(departmentDataGridView, 0);
            Controls.SetChildIndex(insertButton, 0);
            Controls.SetChildIndex(updateButton, 0);
            Controls.SetChildIndex(deleteButton, 0);
            Controls.SetChildIndex(reloadButton, 0);
            Controls.SetChildIndex(searchButton, 0);
            Controls.SetChildIndex(searchTextBox, 0);
            Controls.SetChildIndex(managerInputField, 0);
            Controls.SetChildIndex(departmentInputField, 0);
            ((System.ComponentModel.ISupportInitialize)departmentDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private PeproDataGridView departmentDataGridView;
        private PeproInputField departmentInputField;
        private PeproInputField managerInputField;
        private TextBox searchTextBox;
        private Button searchButton;
        private Button reloadButton;
        private Button deleteButton;
        private Button updateButton;
        private Button insertButton;
        private DataGridViewTextBoxColumn departmentNameColumn;
        private DataGridViewTextBoxColumn managerIdColumn;
    }
}