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
        private void InitializeComponent() {
            searchTextBox = new TextBox();
            employeeDataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            employeeIdInputField = new PeproInputField();
            numberOfEmployeesInputField = new PeproInputField();
            employeeNameInputField = new PeproInputField();
            searchButton = new Button();
            reloadButton = new Button();
            exportButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            insertButton = new Button();
            ((System.ComponentModel.ISupportInitialize)employeeDataGridView).BeginInit();
            SuspendLayout();
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTextBox.Location = new Point(16, 142);
            searchTextBox.Margin = new Padding(3, 2, 3, 2);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Search for employee id or name";
            searchTextBox.Size = new Size(431, 26);
            searchTextBox.TabIndex = 1;
            // 
            // employeeDataGridView
            // 
            employeeDataGridView.AllowUserToAddRows = false;
            employeeDataGridView.AllowUserToDeleteRows = false;
            employeeDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            employeeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            employeeDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            employeeDataGridView.BackgroundColor = Color.FromArgb(15, 15, 15);
            employeeDataGridView.BorderStyle = BorderStyle.Fixed3D;
            employeeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11 });
            employeeDataGridView.EnableHeadersVisualStyles = false;
            employeeDataGridView.Location = new Point(16, 190);
            employeeDataGridView.Margin = new Padding(16);
            employeeDataGridView.Name = "employeeDataGridView";
            employeeDataGridView.ReadOnly = true;
            employeeDataGridView.RowHeadersVisible = false;
            employeeDataGridView.RowHeadersWidth = 51;
            employeeDataGridView.RowTemplate.Height = 24;
            employeeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeeDataGridView.Size = new Size(1032, 475);
            employeeDataGridView.TabIndex = 8;
            employeeDataGridView.CellClick += EmployeeDataGridView_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "EmployeeId";
            Column1.HeaderText = "Mã nhân viên";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 118;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "FirstName";
            Column2.HeaderText = "Tên";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 55;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "MiddleName";
            Column3.HeaderText = "Tên đệm";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 86;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "LastName";
            Column4.HeaderText = "Họ";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 52;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "DateOfBirth";
            Column5.HeaderText = "Ngày sinh";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 95;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "Gender";
            Column6.HeaderText = "Giới tính";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 86;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "TaxCode";
            Column7.HeaderText = "Mã số thuế";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 104;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "CitizenId";
            Column8.HeaderText = "Căn cước";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 90;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "DepartmentId";
            Column9.HeaderText = "Mã phòng ban";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "JobPositionId";
            Column10.HeaderText = "Mã chức vụ";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 105;
            // 
            // Column11
            // 
            Column11.DataPropertyName = "SalaryLevelId";
            Column11.HeaderText = "Mã bậc lương ";
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            Column11.Width = 122;
            // 
            // employeeIdInputField
            // 
            employeeIdInputField.Enabled = false;
            employeeIdInputField.ForeColor = Color.White;
            employeeIdInputField.LabelText = "Employee id";
            employeeIdInputField.Location = new Point(280, 64);
            employeeIdInputField.Margin = new Padding(24, 16, 0, 16);
            employeeIdInputField.Name = "employeeIdInputField";
            employeeIdInputField.PlaceholderText = "e.g. employee id";
            employeeIdInputField.Size = new Size(240, 54);
            employeeIdInputField.TabIndex = 0;
            // 
            // numberOfEmployeesInputField
            // 
            numberOfEmployeesInputField.Enabled = false;
            numberOfEmployeesInputField.ForeColor = Color.White;
            numberOfEmployeesInputField.LabelText = "Number of employees";
            numberOfEmployeesInputField.Location = new Point(16, 64);
            numberOfEmployeesInputField.Margin = new Padding(16, 16, 0, 16);
            numberOfEmployeesInputField.Name = "numberOfEmployeesInputField";
            numberOfEmployeesInputField.PlaceholderText = "e.g. number of employees";
            numberOfEmployeesInputField.Size = new Size(240, 54);
            numberOfEmployeesInputField.TabIndex = 0;
            // 
            // employeeNameInputField
            // 
            employeeNameInputField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            employeeNameInputField.Enabled = false;
            employeeNameInputField.ForeColor = Color.White;
            employeeNameInputField.LabelText = "Employee name";
            employeeNameInputField.Location = new Point(544, 64);
            employeeNameInputField.Margin = new Padding(24, 16, 0, 16);
            employeeNameInputField.Name = "employeeNameInputField";
            employeeNameInputField.PlaceholderText = "e.g. employee name";
            employeeNameInputField.Size = new Size(504, 54);
            employeeNameInputField.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            searchButton.Location = new Point(466, 134);
            searchButton.Margin = new Padding(16, 0, 0, 0);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(40, 40);
            searchButton.TabIndex = 2;
            searchButton.Click += SearchButton_Click;
            // 
            // reloadButton
            // 
            reloadButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            reloadButton.Location = new Point(522, 134);
            reloadButton.Margin = new Padding(16, 0, 0, 0);
            reloadButton.Name = "reloadButton";
            reloadButton.Size = new Size(40, 40);
            reloadButton.TabIndex = 3;
            reloadButton.Click += ReloadButton_Click;
            // 
            // exportButton
            // 
            exportButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            exportButton.Location = new Point(578, 134);
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
            deleteButton.Location = new Point(706, 134);
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
            updateButton.Location = new Point(834, 134);
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
            insertButton.Location = new Point(948, 134);
            insertButton.Margin = new Padding(16, 0, 0, 0);
            insertButton.Name = "insertButton";
            insertButton.Padding = new Padding(12, 0, 12, 0);
            insertButton.Size = new Size(100, 40);
            insertButton.TabIndex = 7;
            insertButton.Text = " Add";
            insertButton.Click += InsertButton_Click;
            // 
            // EmployeeControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
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
        private DataGridView employeeDataGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private PeproInputField employeeIdInputField;
        private PeproInputField numberOfEmployeesInputField;
        private PeproInputField employeeNameInputField;
        private Button searchButton;
        private Button reloadButton;
        private Button exportButton;
        private Button deleteButton;
        private Button updateButton;
        private Button insertButton;
    }
}