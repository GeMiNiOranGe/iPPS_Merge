using Pepro.Presentation.Controls.Molecules;

namespace Pepro.Presentation.Controls.Pages
{
    partial class PersonalPage
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
            fullNameTextBoxField = new PeproTextBoxField();
            employeeIdTextBoxField = new PeproTextBoxField();
            phoneNumberComboBoxField = new PeproComboBoxField();
            genderLabel = new Label();
            maleRadioButton = new RadioButton();
            femaleRadioButton = new RadioButton();
            otherRadioButton = new RadioButton();
            dateOfBirthLabel = new Label();
            dateOfBirthDateTimePicker = new DateTimePicker();
            citizenIdTextBoxField = new PeproTextBoxField();
            departmentTextBoxField = new PeproTextBoxField();
            positionTextBoxField = new PeproTextBoxField();
            assignedProjectsComboBoxField = new PeproComboBoxField();
            SuspendLayout();
            // 
            // fullNameTextBoxField
            // 
            fullNameTextBoxField.Anchor = AnchorStyles.None;
            fullNameTextBoxField.Enabled = false;
            fullNameTextBoxField.ForeColor = Color.White;
            fullNameTextBoxField.LabelText = "Full name";
            fullNameTextBoxField.Location = new Point(263, 162);
            fullNameTextBoxField.Margin = new Padding(0, 0, 24, 32);
            fullNameTextBoxField.Name = "fullNameTextBoxField";
            fullNameTextBoxField.PlaceholderText = "e.g. full name";
            fullNameTextBoxField.Size = new Size(256, 48);
            fullNameTextBoxField.TabIndex = 1;
            // 
            // employeeIdTextBoxField
            // 
            employeeIdTextBoxField.Anchor = AnchorStyles.None;
            employeeIdTextBoxField.Enabled = false;
            employeeIdTextBoxField.ForeColor = Color.White;
            employeeIdTextBoxField.LabelText = "Employee id";
            employeeIdTextBoxField.Location = new Point(543, 162);
            employeeIdTextBoxField.Margin = new Padding(0);
            employeeIdTextBoxField.Name = "employeeIdTextBoxField";
            employeeIdTextBoxField.PlaceholderText = "e.g. employee id";
            employeeIdTextBoxField.Size = new Size(256, 48);
            employeeIdTextBoxField.TabIndex = 2;
            // 
            // phoneNumberComboBoxField
            // 
            phoneNumberComboBoxField.Anchor = AnchorStyles.None;
            phoneNumberComboBoxField.ForeColor = Color.White;
            phoneNumberComboBoxField.LabelText = "Phone number";
            phoneNumberComboBoxField.Location = new Point(263, 248);
            phoneNumberComboBoxField.Margin = new Padding(0, 0, 24, 32);
            phoneNumberComboBoxField.Name = "phoneNumberComboBoxField";
            phoneNumberComboBoxField.Size = new Size(256, 48);
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
            // citizenIdTextBoxField
            // 
            citizenIdTextBoxField.Anchor = AnchorStyles.None;
            citizenIdTextBoxField.Enabled = false;
            citizenIdTextBoxField.ForeColor = Color.White;
            citizenIdTextBoxField.LabelText = "Citizen id";
            citizenIdTextBoxField.Location = new Point(543, 336);
            citizenIdTextBoxField.Margin = new Padding(0, 0, 0, 32);
            citizenIdTextBoxField.Name = "citizenIdTextBoxField";
            citizenIdTextBoxField.PlaceholderText = "e.g. citizen id";
            citizenIdTextBoxField.Size = new Size(256, 48);
            citizenIdTextBoxField.TabIndex = 8;
            // 
            // departmentTextBoxField
            // 
            departmentTextBoxField.Anchor = AnchorStyles.None;
            departmentTextBoxField.Enabled = false;
            departmentTextBoxField.ForeColor = Color.White;
            departmentTextBoxField.LabelText = "Department";
            departmentTextBoxField.Location = new Point(263, 422);
            departmentTextBoxField.Margin = new Padding(0, 0, 24, 32);
            departmentTextBoxField.Name = "departmentTextBoxField";
            departmentTextBoxField.PlaceholderText = "e.g. department";
            departmentTextBoxField.Size = new Size(256, 48);
            departmentTextBoxField.TabIndex = 9;
            // 
            // positionTextBoxField
            // 
            positionTextBoxField.Anchor = AnchorStyles.None;
            positionTextBoxField.Enabled = false;
            positionTextBoxField.ForeColor = Color.White;
            positionTextBoxField.LabelText = "Position";
            positionTextBoxField.Location = new Point(543, 422);
            positionTextBoxField.Margin = new Padding(0, 0, 0, 32);
            positionTextBoxField.Name = "positionTextBoxField";
            positionTextBoxField.PlaceholderText = "e.g. position";
            positionTextBoxField.Size = new Size(256, 48);
            positionTextBoxField.TabIndex = 10;
            // 
            // assignedProjectsComboBoxField
            // 
            assignedProjectsComboBoxField.Anchor = AnchorStyles.None;
            assignedProjectsComboBoxField.ForeColor = Color.White;
            assignedProjectsComboBoxField.LabelText = "Assigned Projects";
            assignedProjectsComboBoxField.Location = new Point(263, 508);
            assignedProjectsComboBoxField.Margin = new Padding(0);
            assignedProjectsComboBoxField.Name = "assignedProjectsComboBoxField";
            assignedProjectsComboBoxField.Size = new Size(536, 48);
            assignedProjectsComboBoxField.TabIndex = 11;
            // 
            // PersonalPage
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            Controls.Add(assignedProjectsComboBoxField);
            Controls.Add(phoneNumberComboBoxField);
            Controls.Add(fullNameTextBoxField);
            Controls.Add(employeeIdTextBoxField);
            Controls.Add(genderLabel);
            Controls.Add(maleRadioButton);
            Controls.Add(femaleRadioButton);
            Controls.Add(otherRadioButton);
            Controls.Add(dateOfBirthLabel);
            Controls.Add(dateOfBirthDateTimePicker);
            Controls.Add(citizenIdTextBoxField);
            Controls.Add(departmentTextBoxField);
            Controls.Add(positionTextBoxField);
            HeaderText = "Personal Information";
            Name = "PersonalPage";
            ReturnButtonVisible = false;
            Load += PersonalPage_Load;
            Controls.SetChildIndex(positionTextBoxField, 0);
            Controls.SetChildIndex(departmentTextBoxField, 0);
            Controls.SetChildIndex(citizenIdTextBoxField, 0);
            Controls.SetChildIndex(dateOfBirthDateTimePicker, 0);
            Controls.SetChildIndex(dateOfBirthLabel, 0);
            Controls.SetChildIndex(otherRadioButton, 0);
            Controls.SetChildIndex(femaleRadioButton, 0);
            Controls.SetChildIndex(maleRadioButton, 0);
            Controls.SetChildIndex(genderLabel, 0);
            Controls.SetChildIndex(employeeIdTextBoxField, 0);
            Controls.SetChildIndex(fullNameTextBoxField, 0);
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
        private PeproTextBoxField fullNameTextBoxField;
        private PeproTextBoxField employeeIdTextBoxField;
        private PeproTextBoxField departmentTextBoxField;
        private PeproTextBoxField positionTextBoxField;
        private PeproTextBoxField citizenIdTextBoxField;
        private PeproComboBoxField phoneNumberComboBoxField;
        private PeproComboBoxField assignedProjectsComboBoxField;
    }
}