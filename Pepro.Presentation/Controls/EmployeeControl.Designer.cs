namespace Pepro.Presentation.Controls
{
    partial class EmployeeControl
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
            searchTextBox = new TextBox();
            employeeDataGridView = new PeproDataGridView();
            employeeIdInputField = new PeproInputField();
            numberOfEmployeesInputField = new PeproInputField();
            employeeNameInputField = new PeproInputField();
            searchButton = new Button();
            reloadButton = new Button();
            exportButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            insertButton = new Button();
            fullNameColumn = new DataGridViewTextBoxColumn();
            dateOfBirthColumn = new DataGridViewTextBoxColumn();
            genderColumn = new DataGridViewTextBoxColumn();
            taxCodeColumn = new DataGridViewTextBoxColumn();
            citizenIdColumn = new DataGridViewTextBoxColumn();
            departmentColumn = new DataGridViewTextBoxColumn();
            positionColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)employeeDataGridView).BeginInit();
            SuspendLayout();
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(16, 147);
            searchTextBox.Margin = new Padding(3, 2, 3, 2);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Search for employee id or name";
            searchTextBox.Size = new Size(431, 26);
            searchTextBox.TabIndex = 1;
            // 
            // employeeDataGridView
            // 
            employeeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeDataGridView.Columns.AddRange(new DataGridViewColumn[] { fullNameColumn, dateOfBirthColumn, genderColumn, taxCodeColumn, citizenIdColumn, departmentColumn, positionColumn });
            employeeDataGridView.Location = new Point(16, 195);
            employeeDataGridView.Margin = new Padding(16);
            employeeDataGridView.Name = "employeeDataGridView";
            employeeDataGridView.Size = new Size(1032, 470);
            employeeDataGridView.TabIndex = 8;
            employeeDataGridView.CellClick += EmployeeDataGridView_CellClick;
            // 
            // employeeIdInputField
            // 
            employeeIdInputField.Enabled = false;
            employeeIdInputField.ForeColor = Color.White;
            employeeIdInputField.LabelText = "Employee id";
            employeeIdInputField.Location = new Point(280, 67);
            employeeIdInputField.Margin = new Padding(24, 16, 0, 24);
            employeeIdInputField.Name = "employeeIdInputField";
            employeeIdInputField.PlaceholderText = "e.g. employee id";
            employeeIdInputField.Size = new Size(240, 48);
            employeeIdInputField.TabIndex = 0;
            // 
            // numberOfEmployeesInputField
            // 
            numberOfEmployeesInputField.Enabled = false;
            numberOfEmployeesInputField.ForeColor = Color.White;
            numberOfEmployeesInputField.LabelText = "Number of employees";
            numberOfEmployeesInputField.Location = new Point(16, 67);
            numberOfEmployeesInputField.Margin = new Padding(16, 16, 0, 24);
            numberOfEmployeesInputField.Name = "numberOfEmployeesInputField";
            numberOfEmployeesInputField.PlaceholderText = "e.g. number of employees";
            numberOfEmployeesInputField.Size = new Size(240, 48);
            numberOfEmployeesInputField.TabIndex = 0;
            // 
            // employeeNameInputField
            // 
            employeeNameInputField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            employeeNameInputField.Enabled = false;
            employeeNameInputField.ForeColor = Color.White;
            employeeNameInputField.LabelText = "Employee name";
            employeeNameInputField.Location = new Point(544, 67);
            employeeNameInputField.Margin = new Padding(24, 16, 16, 24);
            employeeNameInputField.Name = "employeeNameInputField";
            employeeNameInputField.PlaceholderText = "e.g. employee name";
            employeeNameInputField.Size = new Size(504, 48);
            employeeNameInputField.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            searchButton.Location = new Point(466, 139);
            searchButton.Margin = new Padding(16, 0, 0, 0);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(40, 40);
            searchButton.TabIndex = 2;
            searchButton.Click += SearchButton_Click;
            // 
            // reloadButton
            // 
            reloadButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            reloadButton.Location = new Point(522, 139);
            reloadButton.Margin = new Padding(16, 0, 0, 0);
            reloadButton.Name = "reloadButton";
            reloadButton.Size = new Size(40, 40);
            reloadButton.TabIndex = 3;
            reloadButton.Click += ReloadButton_Click;
            // 
            // exportButton
            // 
            exportButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            exportButton.Location = new Point(578, 139);
            exportButton.Margin = new Padding(16, 0, 0, 0);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(112, 40);
            exportButton.TabIndex = 4;
            exportButton.Text = "Export";
            exportButton.Click += ExportButton_Click;
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
            deleteButton.TabIndex = 5;
            deleteButton.Text = " Delete";
            deleteButton.Click += DeleteButton_Click;
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
            updateButton.TabIndex = 6;
            updateButton.Text = " Edit";
            updateButton.Click += UpdateButton_Click;
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
            insertButton.TabIndex = 7;
            insertButton.Text = " Add";
            insertButton.Click += InsertButton_Click;
            // 
            // fullNameColumn
            // 
            fullNameColumn.DataPropertyName = "FullName";
            fullNameColumn.HeaderText = "Full name";
            fullNameColumn.Name = "fullNameColumn";
            fullNameColumn.ReadOnly = true;
            fullNameColumn.Width = 93;
            // 
            // dateOfBirthColumn
            // 
            dateOfBirthColumn.DataPropertyName = "DateOfBirth";
            dateOfBirthColumn.HeaderText = "Date of Birth";
            dateOfBirthColumn.Name = "dateOfBirthColumn";
            dateOfBirthColumn.ReadOnly = true;
            dateOfBirthColumn.Width = 112;
            // 
            // genderColumn
            // 
            genderColumn.DataPropertyName = "Gender";
            genderColumn.HeaderText = "Gender";
            genderColumn.Name = "genderColumn";
            genderColumn.ReadOnly = true;
            genderColumn.Width = 79;
            // 
            // taxCodeColumn
            // 
            taxCodeColumn.DataPropertyName = "TaxCode";
            taxCodeColumn.HeaderText = "Tax code";
            taxCodeColumn.Name = "taxCodeColumn";
            taxCodeColumn.ReadOnly = true;
            taxCodeColumn.Width = 85;
            // 
            // citizenIdColumn
            // 
            citizenIdColumn.DataPropertyName = "CitizenId";
            citizenIdColumn.HeaderText = "Citizen id";
            citizenIdColumn.Name = "citizenIdColumn";
            citizenIdColumn.ReadOnly = true;
            citizenIdColumn.Width = 90;
            // 
            // departmentColumn
            // 
            departmentColumn.DataPropertyName = "DepartmentName";
            departmentColumn.HeaderText = "Department";
            departmentColumn.Name = "departmentColumn";
            departmentColumn.ReadOnly = true;
            departmentColumn.Width = 108;
            // 
            // positionColumn
            // 
            positionColumn.DataPropertyName = "PositionTitle";
            positionColumn.HeaderText = "Position";
            positionColumn.Name = "positionColumn";
            positionColumn.ReadOnly = true;
            positionColumn.Width = 82;
            // 
            // EmployeeControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(employeeDataGridView);
            Controls.Add(insertButton);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(exportButton);
            Controls.Add(reloadButton);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(employeeNameInputField);
            Controls.Add(employeeIdInputField);
            Controls.Add(numberOfEmployeesInputField);
            HeaderText = "Employee";
            Margin = new Padding(3, 2, 3, 2);
            Name = "EmployeeControl";
            ReturnButtonVisible = false;
            Load += EmployeeControl_Load;
            Controls.SetChildIndex(numberOfEmployeesInputField, 0);
            Controls.SetChildIndex(employeeIdInputField, 0);
            Controls.SetChildIndex(employeeNameInputField, 0);
            Controls.SetChildIndex(searchTextBox, 0);
            Controls.SetChildIndex(searchButton, 0);
            Controls.SetChildIndex(reloadButton, 0);
            Controls.SetChildIndex(exportButton, 0);
            Controls.SetChildIndex(deleteButton, 0);
            Controls.SetChildIndex(updateButton, 0);
            Controls.SetChildIndex(insertButton, 0);
            Controls.SetChildIndex(employeeDataGridView, 0);
            ((System.ComponentModel.ISupportInitialize)employeeDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private TextBox searchTextBox;
        private PeproDataGridView employeeDataGridView;
        private PeproInputField employeeIdInputField;
        private PeproInputField numberOfEmployeesInputField;
        private PeproInputField employeeNameInputField;
        private Button searchButton;
        private Button reloadButton;
        private Button exportButton;
        private Button deleteButton;
        private Button updateButton;
        private Button insertButton;
        private DataGridViewTextBoxColumn fullNameColumn;
        private DataGridViewTextBoxColumn dateOfBirthColumn;
        private DataGridViewTextBoxColumn genderColumn;
        private DataGridViewTextBoxColumn taxCodeColumn;
        private DataGridViewTextBoxColumn citizenIdColumn;
        private DataGridViewTextBoxColumn departmentColumn;
        private DataGridViewTextBoxColumn positionColumn;
    }
}