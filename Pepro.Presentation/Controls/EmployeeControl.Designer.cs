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
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            reloadButton = new Button();
            exportButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            insertButton = new Button();
            searchButton = new Button();
            headerLabel = new Label();
            employeeIdInputField = new PeproInputField();
            numberOfEmployeesInputField = new PeproInputField();
            ((System.ComponentModel.ISupportInitialize)employeeDataGridView).BeginInit();
            SuspendLayout();
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTextBox.Location = new Point(16, 78);
            searchTextBox.Margin = new Padding(3, 2, 3, 2);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(211, 26);
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
            employeeDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13 });
            employeeDataGridView.EnableHeadersVisualStyles = false;
            employeeDataGridView.Location = new Point(16, 150);
            employeeDataGridView.Margin = new Padding(16);
            employeeDataGridView.Name = "employeeDataGridView";
            employeeDataGridView.ReadOnly = true;
            employeeDataGridView.RowHeadersVisible = false;
            employeeDataGridView.RowHeadersWidth = 51;
            employeeDataGridView.RowTemplate.Height = 24;
            employeeDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeeDataGridView.Size = new Size(1032, 515);
            employeeDataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "STT";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 55;
            // 
            // Column2
            // 
            Column2.HeaderText = "Mã nhân viên";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 118;
            // 
            // Column3
            // 
            Column3.HeaderText = "Họ và tên";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 94;
            // 
            // Column4
            // 
            Column4.HeaderText = "Giới tính";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 86;
            // 
            // Column5
            // 
            Column5.HeaderText = "Ngày sinh";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 95;
            // 
            // Column6
            // 
            Column6.HeaderText = "Nơi sinh";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 84;
            // 
            // Column7
            // 
            Column7.HeaderText = "Quê quán";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 95;
            // 
            // Column8
            // 
            Column8.HeaderText = "Trình độ văn hoá";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 137;
            // 
            // Column9
            // 
            Column9.HeaderText = "Dân tộc";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 82;
            // 
            // Column10
            // 
            Column10.HeaderText = "Tôn giáo";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 86;
            // 
            // Column11
            // 
            Column11.HeaderText = "Đoàn viên ";
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // Column12
            // 
            Column12.HeaderText = "Đảng viên";
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            Column12.Width = 96;
            // 
            // Column13
            // 
            Column13.HeaderText = "Công đoàn viên";
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            Column13.Width = 131;
            // 
            // reloadButton
            // 
            reloadButton.BackColor = Color.FromArgb(34, 130, 253);
            reloadButton.BackgroundImage = Properties.Resources.reload;
            reloadButton.BackgroundImageLayout = ImageLayout.Center;
            reloadButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reloadButton.Location = new Point(282, 75);
            reloadButton.Margin = new Padding(3, 2, 3, 2);
            reloadButton.Name = "reloadButton";
            reloadButton.Size = new Size(32, 32);
            reloadButton.TabIndex = 13;
            reloadButton.UseVisualStyleBackColor = false;
            reloadButton.Click += ReloadButton_Click;
            // 
            // exportButton
            // 
            exportButton.BackColor = Color.FromArgb(34, 130, 253);
            exportButton.BackgroundImageLayout = ImageLayout.Center;
            exportButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exportButton.Location = new Point(462, 75);
            exportButton.Margin = new Padding(3, 2, 3, 2);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(32, 32);
            exportButton.TabIndex = 7;
            exportButton.UseVisualStyleBackColor = false;
            exportButton.Click += ExportButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FromArgb(34, 130, 253);
            deleteButton.BackgroundImageLayout = ImageLayout.Center;
            deleteButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteButton.Location = new Point(417, 75);
            deleteButton.Margin = new Padding(3, 2, 3, 2);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(32, 32);
            deleteButton.TabIndex = 5;
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += DeleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.FromArgb(34, 130, 253);
            updateButton.BackgroundImageLayout = ImageLayout.Center;
            updateButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateButton.ForeColor = Color.Black;
            updateButton.Location = new Point(372, 75);
            updateButton.Margin = new Padding(3, 2, 3, 2);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(32, 32);
            updateButton.TabIndex = 4;
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += UpdateButton_Click;
            // 
            // insertButton
            // 
            insertButton.BackColor = Color.FromArgb(34, 130, 253);
            insertButton.BackgroundImageLayout = ImageLayout.Center;
            insertButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            insertButton.ForeColor = Color.Black;
            insertButton.Location = new Point(327, 75);
            insertButton.Margin = new Padding(3, 2, 3, 2);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(32, 32);
            insertButton.TabIndex = 3;
            insertButton.UseVisualStyleBackColor = false;
            insertButton.Click += InsertButton_Click;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(34, 130, 253);
            searchButton.BackgroundImage = Properties.Resources.search;
            searchButton.BackgroundImageLayout = ImageLayout.Center;
            searchButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.Location = new Point(237, 75);
            searchButton.Margin = new Padding(3, 2, 3, 2);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(32, 32);
            searchButton.TabIndex = 2;
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += SearchButton_Click;
            // 
            // headerLabel
            // 
            headerLabel.BackColor = Color.FromArgb(22, 22, 22);
            headerLabel.Dock = DockStyle.Top;
            headerLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            headerLabel.ForeColor = Color.White;
            headerLabel.Location = new Point(0, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(1064, 48);
            headerLabel.TabIndex = 16;
            headerLabel.Text = "Employee";
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // employeeIdInputField
            // 
            employeeIdInputField.ForeColor = Color.White;
            employeeIdInputField.LabelText = "Employee id";
            employeeIdInputField.Location = new Point(792, 64);
            employeeIdInputField.Margin = new Padding(24, 16, 16, 16);
            employeeIdInputField.Name = "employeeIdInputField";
            employeeIdInputField.PlaceholderText = "e.g. employee id";
            employeeIdInputField.Size = new Size(256, 54);
            employeeIdInputField.TabIndex = 17;
            // 
            // numberOfEmployeesInputField
            // 
            numberOfEmployeesInputField.ForeColor = Color.White;
            numberOfEmployeesInputField.LabelText = "Number of employees";
            numberOfEmployeesInputField.Location = new Point(512, 64);
            numberOfEmployeesInputField.Margin = new Padding(16, 16, 0, 24);
            numberOfEmployeesInputField.Name = "numberOfEmployeesInputField";
            numberOfEmployeesInputField.PlaceholderText = "e.g. number of employees";
            numberOfEmployeesInputField.Size = new Size(256, 54);
            numberOfEmployeesInputField.TabIndex = 18;
            // 
            // EmployeeControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            Controls.Add(headerLabel);
            Controls.Add(searchTextBox);
            Controls.Add(searchButton);
            Controls.Add(reloadButton);
            Controls.Add(insertButton);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(exportButton);
            Controls.Add(numberOfEmployeesInputField);
            Controls.Add(employeeIdInputField);
            Controls.Add(employeeDataGridView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EmployeeControl";
            Size = new Size(1064, 681);
            Load += EmployeeControl_Load;
            ((System.ComponentModel.ISupportInitialize)employeeDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private TextBox searchTextBox;
        private Button searchButton;
        private Button insertButton;
        private Button updateButton;
        private Button deleteButton;
        private Button exportButton;
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
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private Button reloadButton;
        private Label headerLabel;
        private PeproInputField employeeIdInputField;
        private PeproInputField numberOfEmployeesInputField;
    }
}