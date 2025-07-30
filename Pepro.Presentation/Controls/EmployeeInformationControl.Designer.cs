namespace Pepro.Presentation.Controls
{
    partial class EmployeeInformationControl
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
            fullNameInputField = new PeproInputField();
            employeeIdInputField = new PeproInputField();
            phoneNumberComboBoxField = new PeproComboBoxField();
            genderLabel = new Label();
            maleRadioButton = new RadioButton();
            femaleRadioButton = new RadioButton();
            otherRadioButton = new RadioButton();
            dateOfBirthLabel = new Label();
            dateOfBirthDateTimePicker = new DateTimePicker();
            citizenIdInputField = new PeproInputField();
            departmentInputField = new PeproInputField();
            roleInputField = new PeproInputField();
            assignedProjectsComboBoxField = new PeproComboBoxField();
            SuspendLayout();
            // 
            // fullNameInputField
            // 
            fullNameInputField.Anchor = AnchorStyles.None;
            fullNameInputField.Enabled = false;
            fullNameInputField.ForeColor = Color.White;
            fullNameInputField.LabelText = "Full name";
            fullNameInputField.Location = new Point(263, 162);
            fullNameInputField.Margin = new Padding(0, 0, 24, 32);
            fullNameInputField.Name = "fullNameInputField";
            fullNameInputField.PlaceholderText = "e.g. full name";
            fullNameInputField.Size = new Size(256, 54);
            fullNameInputField.TabIndex = 1;
            // 
            // employeeIdInputField
            // 
            employeeIdInputField.Anchor = AnchorStyles.None;
            employeeIdInputField.Enabled = false;
            employeeIdInputField.ForeColor = Color.White;
            employeeIdInputField.LabelText = "Employee id";
            employeeIdInputField.Location = new Point(543, 162);
            employeeIdInputField.Margin = new Padding(0);
            employeeIdInputField.Name = "employeeIdInputField";
            employeeIdInputField.PlaceholderText = "e.g. employee id";
            employeeIdInputField.Size = new Size(256, 54);
            employeeIdInputField.TabIndex = 2;
            // 
            // phoneNumberComboBoxField
            // 
            phoneNumberComboBoxField.Anchor = AnchorStyles.None;
            phoneNumberComboBoxField.ForeColor = Color.White;
            phoneNumberComboBoxField.LabelText = "Phone number";
            phoneNumberComboBoxField.Location = new Point(263, 248);
            phoneNumberComboBoxField.Margin = new Padding(0, 0, 24, 32);
            phoneNumberComboBoxField.Name = "phoneNumberComboBoxField";
            phoneNumberComboBoxField.Size = new Size(256, 56);
            phoneNumberComboBoxField.TabIndex = 3;
            // 
            // genderLabel
            // 
            genderLabel.Anchor = AnchorStyles.None;
            genderLabel.AutoSize = true;
            genderLabel.ForeColor = Color.White;
            genderLabel.Location = new Point(543, 248);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(54, 19);
            genderLabel.TabIndex = 0;
            genderLabel.Text = "Gender";
            // 
            // maleRadioButton
            // 
            maleRadioButton.Anchor = AnchorStyles.None;
            maleRadioButton.AutoSize = true;
            maleRadioButton.BackColor = Color.White;
            maleRadioButton.Enabled = false;
            maleRadioButton.ForeColor = Color.Black;
            maleRadioButton.Location = new Point(547, 278);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(57, 23);
            maleRadioButton.TabIndex = 4;
            maleRadioButton.Text = "Male";
            maleRadioButton.UseVisualStyleBackColor = false;
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.Anchor = AnchorStyles.None;
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.BackColor = Color.White;
            femaleRadioButton.Enabled = false;
            femaleRadioButton.ForeColor = Color.Black;
            femaleRadioButton.Location = new Point(633, 278);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(70, 23);
            femaleRadioButton.TabIndex = 5;
            femaleRadioButton.Text = "Female";
            femaleRadioButton.UseVisualStyleBackColor = false;
            // 
            // otherRadioButton
            // 
            otherRadioButton.Anchor = AnchorStyles.None;
            otherRadioButton.AutoSize = true;
            otherRadioButton.BackColor = Color.White;
            otherRadioButton.Enabled = false;
            otherRadioButton.ForeColor = Color.Black;
            otherRadioButton.Location = new Point(732, 278);
            otherRadioButton.Name = "otherRadioButton";
            otherRadioButton.Size = new Size(63, 23);
            otherRadioButton.TabIndex = 6;
            otherRadioButton.Text = "Other";
            otherRadioButton.UseVisualStyleBackColor = false;
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.Anchor = AnchorStyles.None;
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.ForeColor = Color.White;
            dateOfBirthLabel.Location = new Point(263, 336);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new Size(87, 19);
            dateOfBirthLabel.TabIndex = 0;
            dateOfBirthLabel.Text = "Date of Birth";
            // 
            // dateOfBirthDateTimePicker
            // 
            dateOfBirthDateTimePicker.Anchor = AnchorStyles.None;
            dateOfBirthDateTimePicker.Checked = false;
            dateOfBirthDateTimePicker.Enabled = false;
            dateOfBirthDateTimePicker.Location = new Point(267, 364);
            dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            dateOfBirthDateTimePicker.Size = new Size(248, 26);
            dateOfBirthDateTimePicker.TabIndex = 7;
            // 
            // citizenIdInputField
            // 
            citizenIdInputField.Anchor = AnchorStyles.None;
            citizenIdInputField.Enabled = false;
            citizenIdInputField.ForeColor = Color.White;
            citizenIdInputField.LabelText = "Citizen id";
            citizenIdInputField.Location = new Point(543, 336);
            citizenIdInputField.Margin = new Padding(0, 0, 0, 32);
            citizenIdInputField.Name = "citizenIdInputField";
            citizenIdInputField.PlaceholderText = "e.g. citizen id";
            citizenIdInputField.Size = new Size(256, 54);
            citizenIdInputField.TabIndex = 8;
            // 
            // departmentInputField
            // 
            departmentInputField.Anchor = AnchorStyles.None;
            departmentInputField.Enabled = false;
            departmentInputField.ForeColor = Color.White;
            departmentInputField.LabelText = "Department";
            departmentInputField.Location = new Point(263, 422);
            departmentInputField.Margin = new Padding(0, 0, 24, 32);
            departmentInputField.Name = "departmentInputField";
            departmentInputField.PlaceholderText = "e.g. department";
            departmentInputField.Size = new Size(256, 54);
            departmentInputField.TabIndex = 9;
            // 
            // roleInputField
            // 
            roleInputField.Anchor = AnchorStyles.None;
            roleInputField.Enabled = false;
            roleInputField.ForeColor = Color.White;
            roleInputField.LabelText = "Role";
            roleInputField.Location = new Point(543, 422);
            roleInputField.Margin = new Padding(0, 0, 0, 32);
            roleInputField.Name = "roleInputField";
            roleInputField.PlaceholderText = "e.g. role";
            roleInputField.Size = new Size(256, 54);
            roleInputField.TabIndex = 10;
            // 
            // assignedProjectsComboBoxField
            // 
            assignedProjectsComboBoxField.Anchor = AnchorStyles.None;
            assignedProjectsComboBoxField.ForeColor = Color.White;
            assignedProjectsComboBoxField.LabelText = "Assigned Projects";
            assignedProjectsComboBoxField.Location = new Point(263, 508);
            assignedProjectsComboBoxField.Margin = new Padding(0);
            assignedProjectsComboBoxField.Name = "assignedProjectsComboBoxField";
            assignedProjectsComboBoxField.Size = new Size(536, 56);
            assignedProjectsComboBoxField.TabIndex = 11;
            // 
            // EmployeeInformationControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            Controls.Add(assignedProjectsComboBoxField);
            Controls.Add(phoneNumberComboBoxField);
            Controls.Add(fullNameInputField);
            Controls.Add(employeeIdInputField);
            Controls.Add(genderLabel);
            Controls.Add(maleRadioButton);
            Controls.Add(femaleRadioButton);
            Controls.Add(otherRadioButton);
            Controls.Add(dateOfBirthLabel);
            Controls.Add(dateOfBirthDateTimePicker);
            Controls.Add(citizenIdInputField);
            Controls.Add(departmentInputField);
            Controls.Add(roleInputField);
            HeaderText = "Personal Information";
            Name = "EmployeeInformationControl";
            ReturnButtonVisible = false;
            Load += EmployeeInformationControl_Load;
            Controls.SetChildIndex(roleInputField, 0);
            Controls.SetChildIndex(departmentInputField, 0);
            Controls.SetChildIndex(citizenIdInputField, 0);
            Controls.SetChildIndex(dateOfBirthDateTimePicker, 0);
            Controls.SetChildIndex(dateOfBirthLabel, 0);
            Controls.SetChildIndex(otherRadioButton, 0);
            Controls.SetChildIndex(femaleRadioButton, 0);
            Controls.SetChildIndex(maleRadioButton, 0);
            Controls.SetChildIndex(genderLabel, 0);
            Controls.SetChildIndex(employeeIdInputField, 0);
            Controls.SetChildIndex(fullNameInputField, 0);
            Controls.SetChildIndex(phoneNumberComboBoxField, 0);
            Controls.SetChildIndex(assignedProjectsComboBoxField, 0);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Label genderLabel;
        private Label dateOfBirthLabel;
        private DateTimePicker dateOfBirthDateTimePicker;
        private RadioButton maleRadioButton;
        private RadioButton femaleRadioButton;
        private RadioButton otherRadioButton;
        private PeproInputField fullNameInputField;
        private PeproInputField employeeIdInputField;
        private PeproInputField departmentInputField;
        private PeproInputField roleInputField;
        private PeproInputField citizenIdInputField;
        private PeproComboBoxField phoneNumberComboBoxField;
        private PeproComboBoxField assignedProjectsComboBoxField;
    }
}