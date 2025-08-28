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
            genderLabel = new PeproLabel();
            dateOfBirthLabel = new PeproLabel();
            maleRadioButton = new RadioButton();
            femaleRadioButton = new RadioButton();
            dateOfBirthDateTimePicker = new DateTimePicker();
            employeeIdInputField = new PeproInputField();
            firstNameInputField = new PeproInputField();
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
            middleNameInputField = new PeproInputField();
            lastNameInputField = new PeproInputField();
            taxCodeInputField = new PeproInputField();
            citizenIdInputField = new PeproInputField();
            SuspendLayout();
            // 
            // genderLabel
            // 
            genderLabel.Anchor = AnchorStyles.None;
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(280, 136);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(45, 14);
            genderLabel.TabIndex = 0;
            genderLabel.Text = "Gender";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.Anchor = AnchorStyles.None;
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new Point(16, 136);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new Size(78, 14);
            dateOfBirthLabel.TabIndex = 0;
            dateOfBirthLabel.Text = "Date of Birth";
            // 
            // maleRadioButton
            // 
            maleRadioButton.Anchor = AnchorStyles.None;
            maleRadioButton.AutoSize = true;
            maleRadioButton.Location = new Point(280, 161);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(57, 23);
            maleRadioButton.TabIndex = 6;
            maleRadioButton.TabStop = true;
            maleRadioButton.Text = "Male";
            maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.Anchor = AnchorStyles.None;
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Location = new Point(360, 161);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(70, 23);
            femaleRadioButton.TabIndex = 7;
            femaleRadioButton.TabStop = true;
            femaleRadioButton.Text = "Female";
            femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // dateOfBirthDateTimePicker
            // 
            dateOfBirthDateTimePicker.Anchor = AnchorStyles.None;
            dateOfBirthDateTimePicker.Location = new Point(16, 158);
            dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            dateOfBirthDateTimePicker.Size = new Size(240, 26);
            dateOfBirthDateTimePicker.TabIndex = 5;
            // 
            // employeeIdInputField
            // 
            employeeIdInputField.Anchor = AnchorStyles.None;
            employeeIdInputField.Enabled = false;
            employeeIdInputField.LabelText = "Employee id";
            employeeIdInputField.Location = new Point(16, 64);
            employeeIdInputField.Margin = new Padding(16, 16, 0, 24);
            employeeIdInputField.Name = "employeeIdInputField";
            employeeIdInputField.PlaceholderText = "e.g. employee id";
            employeeIdInputField.Size = new Size(240, 48);
            employeeIdInputField.TabIndex = 1;
            // 
            // firstNameInputField
            // 
            firstNameInputField.Anchor = AnchorStyles.None;
            firstNameInputField.LabelText = "First name";
            firstNameInputField.Location = new Point(280, 64);
            firstNameInputField.Margin = new Padding(24, 16, 0, 24);
            firstNameInputField.Name = "firstNameInputField";
            firstNameInputField.PlaceholderText = "e.g. first name";
            firstNameInputField.Size = new Size(240, 48);
            firstNameInputField.TabIndex = 2;
            // 
            // departmentComboBoxField
            // 
            departmentComboBoxField.Anchor = AnchorStyles.None;
            departmentComboBoxField.LabelText = "Department";
            departmentComboBoxField.Location = new Point(544, 208);
            departmentComboBoxField.Margin = new Padding(24, 0, 0, 24);
            departmentComboBoxField.Name = "departmentComboBoxField";
            departmentComboBoxField.Size = new Size(240, 48);
            departmentComboBoxField.TabIndex = 13;
            // 
            // departmentIdInputField
            // 
            departmentIdInputField.Anchor = AnchorStyles.None;
            departmentIdInputField.Enabled = false;
            departmentIdInputField.LabelText = "Department id";
            departmentIdInputField.Location = new Point(808, 208);
            departmentIdInputField.Margin = new Padding(24, 0, 16, 24);
            departmentIdInputField.Name = "departmentIdInputField";
            departmentIdInputField.PlaceholderText = "e.g. department id";
            departmentIdInputField.Size = new Size(240, 48);
            departmentIdInputField.TabIndex = 14;
            // 
            // positionIdInputField
            // 
            positionIdInputField.Anchor = AnchorStyles.None;
            positionIdInputField.Enabled = false;
            positionIdInputField.LabelText = "Position id";
            positionIdInputField.Location = new Point(808, 280);
            positionIdInputField.Margin = new Padding(24, 0, 16, 24);
            positionIdInputField.Name = "positionIdInputField";
            positionIdInputField.PlaceholderText = "e.g. position id";
            positionIdInputField.Size = new Size(240, 48);
            positionIdInputField.TabIndex = 18;
            // 
            // positionComboBoxField
            // 
            positionComboBoxField.Anchor = AnchorStyles.None;
            positionComboBoxField.LabelText = "Position";
            positionComboBoxField.Location = new Point(544, 280);
            positionComboBoxField.Margin = new Padding(24, 0, 0, 24);
            positionComboBoxField.Name = "positionComboBoxField";
            positionComboBoxField.Size = new Size(240, 48);
            positionComboBoxField.TabIndex = 17;
            // 
            // salaryScaleIdInputField
            // 
            salaryScaleIdInputField.Anchor = AnchorStyles.None;
            salaryScaleIdInputField.Enabled = false;
            salaryScaleIdInputField.LabelText = "Salary scale id";
            salaryScaleIdInputField.Location = new Point(280, 208);
            salaryScaleIdInputField.Margin = new Padding(24, 0, 0, 24);
            salaryScaleIdInputField.Name = "salaryScaleIdInputField";
            salaryScaleIdInputField.PlaceholderText = "e.g. salary scale id";
            salaryScaleIdInputField.Size = new Size(240, 48);
            salaryScaleIdInputField.TabIndex = 12;
            // 
            // salaryScaleComboBoxField
            // 
            salaryScaleComboBoxField.Anchor = AnchorStyles.None;
            salaryScaleComboBoxField.LabelText = "Salary scale";
            salaryScaleComboBoxField.Location = new Point(16, 208);
            salaryScaleComboBoxField.Margin = new Padding(16, 0, 0, 24);
            salaryScaleComboBoxField.Name = "salaryScaleComboBoxField";
            salaryScaleComboBoxField.Size = new Size(240, 48);
            salaryScaleComboBoxField.TabIndex = 11;
            salaryScaleComboBoxField.SelectedIndexChanged += SalaryScaleComboBoxField_SelectedIndexChanged;
            // 
            // salaryLevelIdInputField
            // 
            salaryLevelIdInputField.Anchor = AnchorStyles.None;
            salaryLevelIdInputField.Enabled = false;
            salaryLevelIdInputField.LabelText = "Salary level id";
            salaryLevelIdInputField.Location = new Point(280, 280);
            salaryLevelIdInputField.Margin = new Padding(24, 0, 0, 24);
            salaryLevelIdInputField.Name = "salaryLevelIdInputField";
            salaryLevelIdInputField.PlaceholderText = "e.g. salary level id";
            salaryLevelIdInputField.Size = new Size(240, 48);
            salaryLevelIdInputField.TabIndex = 16;
            // 
            // salaryLevelComboBoxField
            // 
            salaryLevelComboBoxField.Anchor = AnchorStyles.None;
            salaryLevelComboBoxField.LabelText = "Salary level";
            salaryLevelComboBoxField.Location = new Point(16, 280);
            salaryLevelComboBoxField.Margin = new Padding(16, 0, 0, 24);
            salaryLevelComboBoxField.Name = "salaryLevelComboBoxField";
            salaryLevelComboBoxField.Size = new Size(240, 48);
            salaryLevelComboBoxField.TabIndex = 15;
            // 
            // otherRadioButton
            // 
            otherRadioButton.Anchor = AnchorStyles.None;
            otherRadioButton.AutoSize = true;
            otherRadioButton.Location = new Point(457, 161);
            otherRadioButton.Name = "otherRadioButton";
            otherRadioButton.Size = new Size(63, 23);
            otherRadioButton.TabIndex = 8;
            otherRadioButton.TabStop = true;
            otherRadioButton.Text = "Other";
            otherRadioButton.UseVisualStyleBackColor = true;
            // 
            // lbCheck3
            // 
            lbCheck3.Anchor = AnchorStyles.None;
            lbCheck3.AutoSize = true;
            lbCheck3.Location = new Point(91, 208);
            lbCheck3.Name = "lbCheck3";
            lbCheck3.Size = new Size(15, 19);
            lbCheck3.TabIndex = 0;
            lbCheck3.Text = "*";
            // 
            // lbCheck1
            // 
            lbCheck1.Anchor = AnchorStyles.None;
            lbCheck1.AutoSize = true;
            lbCheck1.Location = new Point(624, 208);
            lbCheck1.Name = "lbCheck1";
            lbCheck1.Size = new Size(15, 19);
            lbCheck1.TabIndex = 0;
            lbCheck1.Text = "*";
            // 
            // lbCheck2
            // 
            lbCheck2.Anchor = AnchorStyles.None;
            lbCheck2.AutoSize = true;
            lbCheck2.Location = new Point(599, 280);
            lbCheck2.Name = "lbCheck2";
            lbCheck2.Size = new Size(15, 19);
            lbCheck2.TabIndex = 0;
            lbCheck2.Text = "*";
            // 
            // lbCheck4
            // 
            lbCheck4.Anchor = AnchorStyles.None;
            lbCheck4.AutoSize = true;
            lbCheck4.Location = new Point(91, 280);
            lbCheck4.Name = "lbCheck4";
            lbCheck4.Size = new Size(15, 19);
            lbCheck4.TabIndex = 0;
            lbCheck4.Text = "*";
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.None;
            saveButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            saveButton.Location = new Point(472, 504);
            saveButton.Margin = new Padding(16);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(120, 56);
            saveButton.TabIndex = 20;
            saveButton.Text = "Save";
            saveButton.Click += SaveButton_Click;
            // 
            // middleNameInputField
            // 
            middleNameInputField.Anchor = AnchorStyles.None;
            middleNameInputField.LabelText = "Middle name";
            middleNameInputField.Location = new Point(544, 64);
            middleNameInputField.Margin = new Padding(24, 16, 0, 24);
            middleNameInputField.Name = "middleNameInputField";
            middleNameInputField.PlaceholderText = "e.g. middle name";
            middleNameInputField.Size = new Size(240, 48);
            middleNameInputField.TabIndex = 3;
            // 
            // lastNameInputField
            // 
            lastNameInputField.Anchor = AnchorStyles.None;
            lastNameInputField.LabelText = "Last name";
            lastNameInputField.Location = new Point(808, 64);
            lastNameInputField.Margin = new Padding(24, 16, 16, 24);
            lastNameInputField.Name = "lastNameInputField";
            lastNameInputField.PlaceholderText = "e.g. last name";
            lastNameInputField.Size = new Size(240, 48);
            lastNameInputField.TabIndex = 4;
            // 
            // taxCodeInputField
            // 
            taxCodeInputField.Anchor = AnchorStyles.None;
            taxCodeInputField.LabelText = "Tax code";
            taxCodeInputField.Location = new Point(544, 136);
            taxCodeInputField.Margin = new Padding(24, 0, 0, 24);
            taxCodeInputField.Name = "taxCodeInputField";
            taxCodeInputField.PlaceholderText = "e.g. tax code";
            taxCodeInputField.Size = new Size(240, 48);
            taxCodeInputField.TabIndex = 9;
            // 
            // citizenIdInputField
            // 
            citizenIdInputField.Anchor = AnchorStyles.None;
            citizenIdInputField.LabelText = "Citizen id";
            citizenIdInputField.Location = new Point(808, 136);
            citizenIdInputField.Margin = new Padding(24, 0, 16, 24);
            citizenIdInputField.Name = "citizenIdInputField";
            citizenIdInputField.PlaceholderText = "e.g. citizen id";
            citizenIdInputField.Size = new Size(240, 48);
            citizenIdInputField.TabIndex = 10;
            // 
            // EmployeeEditorControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(employeeIdInputField);
            Controls.Add(firstNameInputField);
            Controls.Add(middleNameInputField);
            Controls.Add(lastNameInputField);
            Controls.Add(dateOfBirthLabel);
            Controls.Add(dateOfBirthDateTimePicker);
            Controls.Add(genderLabel);
            Controls.Add(maleRadioButton);
            Controls.Add(femaleRadioButton);
            Controls.Add(otherRadioButton);
            Controls.Add(taxCodeInputField);
            Controls.Add(citizenIdInputField);
            Controls.Add(lbCheck3);
            Controls.Add(salaryScaleComboBoxField);
            Controls.Add(salaryScaleIdInputField);
            Controls.Add(lbCheck1);
            Controls.Add(departmentComboBoxField);
            Controls.Add(departmentIdInputField);
            Controls.Add(lbCheck4);
            Controls.Add(salaryLevelComboBoxField);
            Controls.Add(salaryLevelIdInputField);
            Controls.Add(lbCheck2);
            Controls.Add(positionComboBoxField);
            Controls.Add(positionIdInputField);
            Controls.Add(saveButton);
            Name = "EmployeeEditorControl";
            Size = new Size(1064, 664);
            Load += EmployeeEditorControl_Load;
            Controls.SetChildIndex(saveButton, 0);
            Controls.SetChildIndex(positionIdInputField, 0);
            Controls.SetChildIndex(positionComboBoxField, 0);
            Controls.SetChildIndex(lbCheck2, 0);
            Controls.SetChildIndex(salaryLevelIdInputField, 0);
            Controls.SetChildIndex(salaryLevelComboBoxField, 0);
            Controls.SetChildIndex(lbCheck4, 0);
            Controls.SetChildIndex(departmentIdInputField, 0);
            Controls.SetChildIndex(departmentComboBoxField, 0);
            Controls.SetChildIndex(lbCheck1, 0);
            Controls.SetChildIndex(salaryScaleIdInputField, 0);
            Controls.SetChildIndex(salaryScaleComboBoxField, 0);
            Controls.SetChildIndex(lbCheck3, 0);
            Controls.SetChildIndex(citizenIdInputField, 0);
            Controls.SetChildIndex(taxCodeInputField, 0);
            Controls.SetChildIndex(otherRadioButton, 0);
            Controls.SetChildIndex(femaleRadioButton, 0);
            Controls.SetChildIndex(maleRadioButton, 0);
            Controls.SetChildIndex(genderLabel, 0);
            Controls.SetChildIndex(dateOfBirthDateTimePicker, 0);
            Controls.SetChildIndex(dateOfBirthLabel, 0);
            Controls.SetChildIndex(lastNameInputField, 0);
            Controls.SetChildIndex(middleNameInputField, 0);
            Controls.SetChildIndex(firstNameInputField, 0);
            Controls.SetChildIndex(employeeIdInputField, 0);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private PeproLabel genderLabel;
        private PeproLabel dateOfBirthLabel;
        private RadioButton maleRadioButton;
        private RadioButton femaleRadioButton;
        private DateTimePicker dateOfBirthDateTimePicker;
        private PeproInputField employeeIdInputField;
        private PeproInputField firstNameInputField;
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
        private PeproInputField middleNameInputField;
        private PeproInputField lastNameInputField;
        private PeproInputField taxCodeInputField;
        private PeproInputField citizenIdInputField;
    }
}