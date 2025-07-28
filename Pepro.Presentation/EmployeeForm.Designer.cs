namespace Pepro.Presentation
{
    partial class EmployeeForm
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
            groupBox1 = new GroupBox();
            btnReload = new Button();
            cbbDepartment = new ComboBox();
            label9 = new Label();
            txtTax = new TextBox();
            label8 = new Label();
            txtAllowance = new TextBox();
            label7 = new Label();
            txtSalary = new TextBox();
            label6 = new Label();
            txtPhone = new TextBox();
            label5 = new Label();
            label4 = new Label();
            dtpkDOB = new DateTimePicker();
            label3 = new Label();
            cbFemale = new CheckBox();
            cbMale = new CheckBox();
            txtName = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dtgvEmployee = new DataGridView();
            EmployeeID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            DateOfBirth = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Salary = new DataGridViewTextBoxColumn();
            Allowance = new DataGridViewTextBoxColumn();
            TaxCode = new DataGridViewTextBoxColumn();
            DepartmentID = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(btnReload);
            groupBox1.Controls.Add(cbbDepartment);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtTax);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtAllowance);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtSalary);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpkDOB);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbFemale);
            groupBox1.Controls.Add(cbMale);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Location = new Point(131, 36);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(853, 225);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Manage";
            // 
            // btnReload
            // 
            btnReload.BackColor = SystemColors.ControlLightLight;
            btnReload.BackgroundImageLayout = ImageLayout.Stretch;
            btnReload.Location = new Point(626, 167);
            btnReload.Margin = new Padding(4, 3, 4, 3);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(63, 44);
            btnReload.TabIndex = 22;
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += btnReload_Click;
            // 
            // cbbDepartment
            // 
            cbbDepartment.FormattingEnabled = true;
            cbbDepartment.Location = new Point(668, 117);
            cbbDepartment.Margin = new Padding(4, 3, 4, 3);
            cbbDepartment.Name = "cbbDepartment";
            cbbDepartment.Size = new Size(165, 23);
            cbbDepartment.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(584, 121);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(73, 15);
            label9.TabIndex = 20;
            label9.Text = "Department:";
            // 
            // txtTax
            // 
            txtTax.Location = new Point(667, 75);
            txtTax.Margin = new Padding(4, 3, 4, 3);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(166, 23);
            txtTax.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(598, 78);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 18;
            label8.Text = "TaxCode:";
            // 
            // txtAllowance
            // 
            txtAllowance.Location = new Point(667, 35);
            txtAllowance.Margin = new Padding(4, 3, 4, 3);
            txtAllowance.Name = "txtAllowance";
            txtAllowance.Size = new Size(166, 23);
            txtAllowance.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(594, 38);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 16;
            label7.Text = "Allowance:";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(324, 112);
            txtSalary.Margin = new Padding(4, 3, 4, 3);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(171, 23);
            txtSalary.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(268, 115);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 14;
            label6.Text = "Salary:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(324, 73);
            txtPhone.Margin = new Padding(4, 3, 4, 3);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(171, 23);
            txtPhone.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(268, 76);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 12;
            label5.Text = "Phone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(238, 36);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 11;
            label4.Text = "Date of birth:";
            // 
            // dtpkDOB
            // 
            dtpkDOB.Location = new Point(324, 32);
            dtpkDOB.Margin = new Padding(4, 3, 4, 3);
            dtpkDOB.Name = "dtpkDOB";
            dtpkDOB.Size = new Size(213, 23);
            dtpkDOB.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 120);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 9;
            label3.Text = "Gender:";
            // 
            // cbFemale
            // 
            cbFemale.AutoSize = true;
            cbFemale.Location = new Point(127, 119);
            cbFemale.Margin = new Padding(4, 3, 4, 3);
            cbFemale.Name = "cbFemale";
            cbFemale.Size = new Size(64, 19);
            cbFemale.TabIndex = 8;
            cbFemale.Text = "Female";
            cbFemale.UseVisualStyleBackColor = true;
            cbFemale.CheckedChanged += cbFemale_CheckedChanged;
            // 
            // cbMale
            // 
            cbMale.AutoSize = true;
            cbMale.Location = new Point(57, 119);
            cbMale.Margin = new Padding(4, 3, 4, 3);
            cbMale.Name = "cbMale";
            cbMale.Size = new Size(52, 19);
            cbMale.TabIndex = 7;
            cbMale.Text = "Male";
            cbMale.UseVisualStyleBackColor = true;
            cbMale.CheckedChanged += cbMale_CheckedChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(51, 75);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(148, 23);
            txtName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 81);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 5;
            label2.Text = "Name:";
            // 
            // txtID
            // 
            txtID.Location = new Point(51, 32);
            txtID.Margin = new Padding(4, 3, 4, 3);
            txtID.Name = "txtID";
            txtID.Size = new Size(148, 23);
            txtID.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 3;
            label1.Text = "ID:";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ControlLightLight;
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.Location = new Point(475, 167);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(63, 44);
            btnDelete.TabIndex = 2;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ControlLightLight;
            btnUpdate.BackgroundImageLayout = ImageLayout.Stretch;
            btnUpdate.Location = new Point(324, 167);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(63, 44);
            btnUpdate.TabIndex = 1;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ControlLightLight;
            btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdd.Location = new Point(164, 167);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(63, 44);
            btnAdd.TabIndex = 0;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dtgvEmployee
            // 
            dtgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvEmployee.Columns.AddRange(new DataGridViewColumn[] { EmployeeID, FullName, Gender, DateOfBirth, PhoneNumber, Salary, Allowance, TaxCode, DepartmentID });
            dtgvEmployee.Location = new Point(14, 290);
            dtgvEmployee.Margin = new Padding(4, 3, 4, 3);
            dtgvEmployee.Name = "dtgvEmployee";
            dtgvEmployee.ReadOnly = true;
            dtgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvEmployee.Size = new Size(1073, 212);
            dtgvEmployee.TabIndex = 2;
            dtgvEmployee.CellClick += dtgvEmployee_CellClick;
            // 
            // EmployeeID
            // 
            EmployeeID.DataPropertyName = "EmployeeID";
            EmployeeID.HeaderText = "EmployeeID";
            EmployeeID.Name = "EmployeeID";
            EmployeeID.ReadOnly = true;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "FullName";
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // Gender
            // 
            Gender.DataPropertyName = "Gender";
            Gender.HeaderText = "Gender";
            Gender.Name = "Gender";
            Gender.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            DateOfBirth.DataPropertyName = "DateOfBirth";
            DateOfBirth.HeaderText = "DateOfBirth";
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            PhoneNumber.DataPropertyName = "PhoneNumber";
            PhoneNumber.HeaderText = "PhoneNumber";
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            // 
            // Salary
            // 
            Salary.DataPropertyName = "Salary";
            Salary.HeaderText = "Salary";
            Salary.Name = "Salary";
            Salary.ReadOnly = true;
            // 
            // Allowance
            // 
            Allowance.DataPropertyName = "Allowance";
            Allowance.HeaderText = "Allowance";
            Allowance.Name = "Allowance";
            Allowance.ReadOnly = true;
            // 
            // TaxCode
            // 
            TaxCode.DataPropertyName = "TaxCode";
            TaxCode.HeaderText = "TaxCode";
            TaxCode.Name = "TaxCode";
            TaxCode.ReadOnly = true;
            // 
            // DepartmentID
            // 
            DepartmentID.DataPropertyName = "DepartmentID";
            DepartmentID.HeaderText = "DepartmentID";
            DepartmentID.Name = "DepartmentID";
            DepartmentID.ReadOnly = true;
            // 
            // FormEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1101, 537);
            Controls.Add(dtgvEmployee);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvEmployee).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtID;
        private Label label1;
        private Label label3;
        private CheckBox cbFemale;
        private CheckBox cbMale;
        private TextBox txtName;
        private Label label2;
        private TextBox txtPhone;
        private Label label5;
        private Label label4;
        private DateTimePicker dtpkDOB;
        private TextBox txtTax;
        private Label label8;
        private TextBox txtAllowance;
        private Label label7;
        private TextBox txtSalary;
        private Label label6;
        private ComboBox cbbDepartment;
        private Label label9;
        private DataGridView dtgvEmployee;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn DateOfBirth;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Salary;
        private DataGridViewTextBoxColumn Allowance;
        private DataGridViewTextBoxColumn TaxCode;
        private DataGridViewTextBoxColumn DepartmentID;
        private Button btnReload;
    }
}