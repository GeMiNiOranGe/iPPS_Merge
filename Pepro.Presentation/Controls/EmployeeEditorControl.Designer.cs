namespace Pepro.Presentation.Controls
{
    partial class EmployeeEditorControl
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
            genderLabel = new Label();
            dateOfBirthLabel = new Label();
            maleRadioButton = new RadioButton();
            femaleRadioButton = new RadioButton();
            dateOfBirthDateTimePicker = new DateTimePicker();
            employeeIdInputField = new PeproInputField();
            fullNameInputField = new PeproInputField();
            departmentComboBoxField = new PeproComboBoxField();
            departmentIdInputField = new PeproInputField();
            positionIdInputField = new PeproInputField();
            positionComboBoxField = new PeproComboBoxField();
            salaryScaleIdInputField = new PeproInputField();
            salaryScaleComboBoxField = new PeproComboBoxField();
            salaryLevelIdInputField = new PeproInputField();
            salaryLevelComboBoxField = new PeproComboBoxField();
            otherRadioButton = new RadioButton();
            lbCheck3 = new Label();
            lbCheck1 = new Label();
            lbCheck2 = new Label();
            lbCheck4 = new Label();
            saveButton = new Button();
            SuspendLayout();
            // 
            // genderLabel
            // 
            genderLabel.Anchor = AnchorStyles.None;
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(280, 153);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(54, 19);
            genderLabel.TabIndex = 3;
            genderLabel.Text = "Gender";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.Anchor = AnchorStyles.None;
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new Point(16, 153);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new Size(87, 19);
            dateOfBirthLabel.TabIndex = 4;
            dateOfBirthLabel.Text = "Date of Birth";
            // 
            // maleRadioButton
            // 
            maleRadioButton.Anchor = AnchorStyles.None;
            maleRadioButton.AutoSize = true;
            maleRadioButton.Location = new Point(284, 184);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(57, 23);
            maleRadioButton.TabIndex = 17;
            maleRadioButton.TabStop = true;
            maleRadioButton.Text = "Male";
            maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.Anchor = AnchorStyles.None;
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Location = new Point(364, 186);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(70, 23);
            femaleRadioButton.TabIndex = 18;
            femaleRadioButton.TabStop = true;
            femaleRadioButton.Text = "Female";
            femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // dateOfBirthDateTimePicker
            // 
            dateOfBirthDateTimePicker.Anchor = AnchorStyles.None;
            dateOfBirthDateTimePicker.Format = DateTimePickerFormat.Short;
            dateOfBirthDateTimePicker.Location = new Point(16, 182);
            dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            dateOfBirthDateTimePicker.Size = new Size(240, 26);
            dateOfBirthDateTimePicker.TabIndex = 19;
            // 
            // employeeIdInputField
            // 
            employeeIdInputField.Anchor = AnchorStyles.None;
            employeeIdInputField.LabelText = "Employee id";
            employeeIdInputField.Location = new Point(16, 67);
            employeeIdInputField.Margin = new Padding(16, 16, 0, 16);
            employeeIdInputField.Name = "employeeIdInputField";
            employeeIdInputField.PlaceholderText = "e.g. employee id";
            employeeIdInputField.Size = new Size(240, 54);
            employeeIdInputField.TabIndex = 106;
            // 
            // fullNameInputField
            // 
            fullNameInputField.Anchor = AnchorStyles.None;
            fullNameInputField.LabelText = "Full name";
            fullNameInputField.Location = new Point(280, 67);
            fullNameInputField.Margin = new Padding(24, 16, 0, 16);
            fullNameInputField.Name = "fullNameInputField";
            fullNameInputField.PlaceholderText = "e.g. full name";
            fullNameInputField.Size = new Size(240, 54);
            fullNameInputField.TabIndex = 106;
            // 
            // departmentComboBoxField
            // 
            departmentComboBoxField.Anchor = AnchorStyles.None;
            departmentComboBoxField.LabelText = "Department";
            departmentComboBoxField.Location = new Point(544, 67);
            departmentComboBoxField.Margin = new Padding(24, 16, 0, 16);
            departmentComboBoxField.Name = "departmentComboBoxField";
            departmentComboBoxField.Size = new Size(240, 56);
            departmentComboBoxField.TabIndex = 107;
            departmentComboBoxField.SelectedIndexChanged += DepartmentComboBoxField_SelectedIndexChanged;
            // 
            // departmentIdInputField
            // 
            departmentIdInputField.Anchor = AnchorStyles.None;
            departmentIdInputField.LabelText = "Department id";
            departmentIdInputField.Location = new Point(808, 67);
            departmentIdInputField.Margin = new Padding(24, 16, 16, 16);
            departmentIdInputField.Name = "departmentIdInputField";
            departmentIdInputField.PlaceholderText = "e.g. department id";
            departmentIdInputField.Size = new Size(240, 54);
            departmentIdInputField.TabIndex = 106;
            // 
            // positionIdInputField
            // 
            positionIdInputField.Anchor = AnchorStyles.None;
            positionIdInputField.LabelText = "Job position id";
            positionIdInputField.Location = new Point(808, 153);
            positionIdInputField.Margin = new Padding(24, 16, 16, 16);
            positionIdInputField.Name = "positionIdInputField";
            positionIdInputField.PlaceholderText = "e.g. job position id";
            positionIdInputField.Size = new Size(240, 54);
            positionIdInputField.TabIndex = 106;
            // 
            // positionComboBoxField
            // 
            positionComboBoxField.Anchor = AnchorStyles.None;
            positionComboBoxField.LabelText = "Job position";
            positionComboBoxField.Location = new Point(544, 153);
            positionComboBoxField.Margin = new Padding(24, 16, 0, 16);
            positionComboBoxField.Name = "positionComboBoxField";
            positionComboBoxField.Size = new Size(240, 56);
            positionComboBoxField.TabIndex = 107;
            positionComboBoxField.SelectedIndexChanged += PositionComboBoxField_SelectedIndexChanged;
            // 
            // salaryScaleIdInputField
            // 
            salaryScaleIdInputField.Anchor = AnchorStyles.None;
            salaryScaleIdInputField.LabelText = "Salary scale id";
            salaryScaleIdInputField.Location = new Point(280, 239);
            salaryScaleIdInputField.Margin = new Padding(0);
            salaryScaleIdInputField.Name = "salaryScaleIdInputField";
            salaryScaleIdInputField.PlaceholderText = "e.g. salary scale id";
            salaryScaleIdInputField.Size = new Size(240, 54);
            salaryScaleIdInputField.TabIndex = 106;
            // 
            // salaryScaleComboBoxField
            // 
            salaryScaleComboBoxField.Anchor = AnchorStyles.None;
            salaryScaleComboBoxField.LabelText = "Salary scale";
            salaryScaleComboBoxField.Location = new Point(16, 239);
            salaryScaleComboBoxField.Margin = new Padding(0);
            salaryScaleComboBoxField.Name = "salaryScaleComboBoxField";
            salaryScaleComboBoxField.Size = new Size(240, 56);
            salaryScaleComboBoxField.TabIndex = 107;
            salaryScaleComboBoxField.SelectedIndexChanged += SalaryScaleComboBoxField_SelectedIndexChanged;
            // 
            // salaryLevelIdInputField
            // 
            salaryLevelIdInputField.Anchor = AnchorStyles.None;
            salaryLevelIdInputField.LabelText = "Salary level id";
            salaryLevelIdInputField.Location = new Point(808, 239);
            salaryLevelIdInputField.Margin = new Padding(24, 16, 16, 16);
            salaryLevelIdInputField.Name = "salaryLevelIdInputField";
            salaryLevelIdInputField.PlaceholderText = "e.g. salary level id";
            salaryLevelIdInputField.Size = new Size(240, 54);
            salaryLevelIdInputField.TabIndex = 106;
            // 
            // salaryLevelComboBoxField
            // 
            salaryLevelComboBoxField.Anchor = AnchorStyles.None;
            salaryLevelComboBoxField.LabelText = "Salary level";
            salaryLevelComboBoxField.Location = new Point(544, 239);
            salaryLevelComboBoxField.Margin = new Padding(0);
            salaryLevelComboBoxField.Name = "salaryLevelComboBoxField";
            salaryLevelComboBoxField.Size = new Size(240, 56);
            salaryLevelComboBoxField.TabIndex = 107;
            // 
            // otherRadioButton
            // 
            otherRadioButton.Anchor = AnchorStyles.None;
            otherRadioButton.AutoSize = true;
            otherRadioButton.Location = new Point(457, 186);
            otherRadioButton.Name = "otherRadioButton";
            otherRadioButton.Size = new Size(63, 23);
            otherRadioButton.TabIndex = 18;
            otherRadioButton.TabStop = true;
            otherRadioButton.Text = "Other";
            otherRadioButton.UseVisualStyleBackColor = true;
            // 
            // lbCheck3
            // 
            lbCheck3.Anchor = AnchorStyles.None;
            lbCheck3.AutoSize = true;
            lbCheck3.Location = new Point(94, 239);
            lbCheck3.Name = "lbCheck3";
            lbCheck3.Size = new Size(15, 19);
            lbCheck3.TabIndex = 99;
            lbCheck3.Text = "*";
            // 
            // lbCheck1
            // 
            lbCheck1.Anchor = AnchorStyles.None;
            lbCheck1.AutoSize = true;
            lbCheck1.Location = new Point(630, 67);
            lbCheck1.Name = "lbCheck1";
            lbCheck1.Size = new Size(15, 19);
            lbCheck1.TabIndex = 95;
            lbCheck1.Text = "*";
            // 
            // lbCheck2
            // 
            lbCheck2.Anchor = AnchorStyles.None;
            lbCheck2.AutoSize = true;
            lbCheck2.Location = new Point(630, 153);
            lbCheck2.Name = "lbCheck2";
            lbCheck2.Size = new Size(15, 19);
            lbCheck2.TabIndex = 97;
            lbCheck2.Text = "*";
            // 
            // lbCheck4
            // 
            lbCheck4.Anchor = AnchorStyles.None;
            lbCheck4.AutoSize = true;
            lbCheck4.Location = new Point(619, 239);
            lbCheck4.Name = "lbCheck4";
            lbCheck4.Size = new Size(15, 19);
            lbCheck4.TabIndex = 101;
            lbCheck4.Text = "*";
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.None;
            saveButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            saveButton.Location = new Point(472, 404);
            saveButton.Margin = new Padding(16);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(120, 56);
            saveButton.TabIndex = 108;
            saveButton.Text = "Save";
            saveButton.Click += SaveButton_Click;
            // 
            // EmployeeEditorControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(lbCheck3);
            Controls.Add(saveButton);
            Controls.Add(lbCheck4);
            Controls.Add(lbCheck2);
            Controls.Add(lbCheck1);
            Controls.Add(salaryLevelComboBoxField);
            Controls.Add(salaryScaleComboBoxField);
            Controls.Add(salaryLevelIdInputField);
            Controls.Add(positionComboBoxField);
            Controls.Add(salaryScaleIdInputField);
            Controls.Add(departmentComboBoxField);
            Controls.Add(positionIdInputField);
            Controls.Add(fullNameInputField);
            Controls.Add(departmentIdInputField);
            Controls.Add(employeeIdInputField);
            Controls.Add(dateOfBirthLabel);
            Controls.Add(dateOfBirthDateTimePicker);
            Controls.Add(otherRadioButton);
            Controls.Add(femaleRadioButton);
            Controls.Add(maleRadioButton);
            Controls.Add(genderLabel);
            Name = "EmployeeEditorControl";
            Size = new Size(1064, 664);
            Load += EmployeeEditorControl_Load;
            Controls.SetChildIndex(genderLabel, 0);
            Controls.SetChildIndex(maleRadioButton, 0);
            Controls.SetChildIndex(femaleRadioButton, 0);
            Controls.SetChildIndex(otherRadioButton, 0);
            Controls.SetChildIndex(dateOfBirthDateTimePicker, 0);
            Controls.SetChildIndex(dateOfBirthLabel, 0);
            Controls.SetChildIndex(employeeIdInputField, 0);
            Controls.SetChildIndex(departmentIdInputField, 0);
            Controls.SetChildIndex(fullNameInputField, 0);
            Controls.SetChildIndex(positionIdInputField, 0);
            Controls.SetChildIndex(departmentComboBoxField, 0);
            Controls.SetChildIndex(salaryScaleIdInputField, 0);
            Controls.SetChildIndex(positionComboBoxField, 0);
            Controls.SetChildIndex(salaryLevelIdInputField, 0);
            Controls.SetChildIndex(salaryScaleComboBoxField, 0);
            Controls.SetChildIndex(salaryLevelComboBoxField, 0);
            Controls.SetChildIndex(lbCheck1, 0);
            Controls.SetChildIndex(lbCheck2, 0);
            Controls.SetChildIndex(lbCheck4, 0);
            Controls.SetChildIndex(saveButton, 0);
            Controls.SetChildIndex(lbCheck3, 0);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Label genderLabel;
        private Label dateOfBirthLabel;
        private RadioButton maleRadioButton;
        private RadioButton femaleRadioButton;
        private DateTimePicker dateOfBirthDateTimePicker;
        private PeproInputField employeeIdInputField;
        private PeproInputField fullNameInputField;
        private PeproComboBoxField departmentComboBoxField;
        private PeproInputField departmentIdInputField;
        private PeproInputField positionIdInputField;
        private PeproComboBoxField positionComboBoxField;
        private PeproInputField salaryScaleIdInputField;
        private PeproComboBoxField salaryScaleComboBoxField;
        private PeproInputField salaryLevelIdInputField;
        private PeproComboBoxField salaryLevelComboBoxField;
        private RadioButton otherRadioButton;
        private Label lbCheck3;
        private Label lbCheck1;
        private Label lbCheck2;
        private Label lbCheck4;
        private Button saveButton;
    }
}