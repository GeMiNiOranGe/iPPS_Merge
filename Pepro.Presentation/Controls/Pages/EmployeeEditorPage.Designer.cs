using Pepro.Presentation.Controls.Atoms;
using Pepro.Presentation.Controls.Molecules;

namespace Pepro.Presentation.Controls.Pages
{
    partial class EmployeeEditorPage
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
            genderLabel = new PeproLabel();
            dateOfBirthLabel = new PeproLabel();
            maleRadioButton = new RadioButton();
            femaleRadioButton = new RadioButton();
            dateOfBirthDateTimePicker = new DateTimePicker();
            firstNameInputField = new PeproInputField();
            departmentComboBoxField = new PeproComboBoxField();
            positionInputField = new PeproInputField();
            positionComboBoxField = new PeproComboBoxField();
            salaryScaleInputField = new PeproInputField();
            salaryScaleComboBoxField = new PeproComboBoxField();
            salaryLevelInputField = new PeproInputField();
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
            genderLabel.Location = new Point(16, 136);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(45, 14);
            genderLabel.TabIndex = 0;
            genderLabel.Text = "Gender";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.Anchor = AnchorStyles.None;
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new Point(808, 64);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new Size(78, 14);
            dateOfBirthLabel.TabIndex = 0;
            dateOfBirthLabel.Text = "Date of Birth";
            // 
            // maleRadioButton
            // 
            maleRadioButton.Anchor = AnchorStyles.None;
            maleRadioButton.AutoSize = true;
            maleRadioButton.Location = new Point(16, 161);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(57, 23);
            maleRadioButton.TabIndex = 5;
            maleRadioButton.TabStop = true;
            maleRadioButton.Text = "Male";
            maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.Anchor = AnchorStyles.None;
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Location = new Point(96, 161);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(70, 23);
            femaleRadioButton.TabIndex = 6;
            femaleRadioButton.TabStop = true;
            femaleRadioButton.Text = "Female";
            femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // dateOfBirthDateTimePicker
            // 
            dateOfBirthDateTimePicker.Anchor = AnchorStyles.None;
            dateOfBirthDateTimePicker.Location = new Point(808, 86);
            dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            dateOfBirthDateTimePicker.Size = new Size(240, 26);
            dateOfBirthDateTimePicker.TabIndex = 4;
            // 
            // firstNameInputField
            // 
            firstNameInputField.Anchor = AnchorStyles.None;
            firstNameInputField.LabelText = "First name";
            firstNameInputField.Location = new Point(16, 64);
            firstNameInputField.Margin = new Padding(16, 16, 0, 24);
            firstNameInputField.Name = "firstNameInputField";
            firstNameInputField.PlaceholderText = "e.g. first name";
            firstNameInputField.Size = new Size(240, 48);
            firstNameInputField.TabIndex = 1;
            // 
            // departmentComboBoxField
            // 
            departmentComboBoxField.Anchor = AnchorStyles.None;
            departmentComboBoxField.LabelText = "Department";
            departmentComboBoxField.Location = new Point(808, 136);
            departmentComboBoxField.Margin = new Padding(24, 0, 16, 24);
            departmentComboBoxField.Name = "departmentComboBoxField";
            departmentComboBoxField.Size = new Size(240, 48);
            departmentComboBoxField.TabIndex = 10;
            // 
            // positionInputField
            // 
            positionInputField.Anchor = AnchorStyles.None;
            positionInputField.Enabled = false;
            positionInputField.LabelText = "Position allowance percent";
            positionInputField.Location = new Point(808, 208);
            positionInputField.Margin = new Padding(24, 0, 16, 24);
            positionInputField.Name = "positionInputField";
            positionInputField.PlaceholderText = "e.g. position allowance percent";
            positionInputField.Size = new Size(240, 48);
            positionInputField.TabIndex = 14;
            // 
            // positionComboBoxField
            // 
            positionComboBoxField.Anchor = AnchorStyles.None;
            positionComboBoxField.LabelText = "Position";
            positionComboBoxField.Location = new Point(544, 208);
            positionComboBoxField.Margin = new Padding(24, 0, 0, 24);
            positionComboBoxField.Name = "positionComboBoxField";
            positionComboBoxField.Size = new Size(240, 48);
            positionComboBoxField.TabIndex = 13;
            positionComboBoxField.SelectedIndexChanged += PositionComboBoxField_SelectedIndexChanged;
            // 
            // salaryScaleInputField
            // 
            salaryScaleInputField.Anchor = AnchorStyles.None;
            salaryScaleInputField.Enabled = false;
            salaryScaleInputField.LabelText = "Salary scale group";
            salaryScaleInputField.Location = new Point(280, 208);
            salaryScaleInputField.Margin = new Padding(24, 0, 0, 24);
            salaryScaleInputField.Name = "salaryScaleInputField";
            salaryScaleInputField.PlaceholderText = "e.g. salary scale group";
            salaryScaleInputField.Size = new Size(240, 48);
            salaryScaleInputField.TabIndex = 12;
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
            // salaryLevelInputField
            // 
            salaryLevelInputField.Anchor = AnchorStyles.None;
            salaryLevelInputField.Enabled = false;
            salaryLevelInputField.LabelText = "Salary level coefficient";
            salaryLevelInputField.Location = new Point(280, 280);
            salaryLevelInputField.Margin = new Padding(24, 0, 0, 24);
            salaryLevelInputField.Name = "salaryLevelInputField";
            salaryLevelInputField.PlaceholderText = "e.g. salary level coefficient";
            salaryLevelInputField.Size = new Size(240, 48);
            salaryLevelInputField.TabIndex = 16;
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
            salaryLevelComboBoxField.SelectedIndexChanged += SalaryLevelComboBoxField_SelectedIndexChanged;
            // 
            // otherRadioButton
            // 
            otherRadioButton.Anchor = AnchorStyles.None;
            otherRadioButton.AutoSize = true;
            otherRadioButton.Location = new Point(193, 161);
            otherRadioButton.Name = "otherRadioButton";
            otherRadioButton.Size = new Size(63, 23);
            otherRadioButton.TabIndex = 7;
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
            lbCheck1.Location = new Point(888, 136);
            lbCheck1.Name = "lbCheck1";
            lbCheck1.Size = new Size(15, 19);
            lbCheck1.TabIndex = 0;
            lbCheck1.Text = "*";
            // 
            // lbCheck2
            // 
            lbCheck2.Anchor = AnchorStyles.None;
            lbCheck2.AutoSize = true;
            lbCheck2.Location = new Point(599, 208);
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
            middleNameInputField.Location = new Point(280, 64);
            middleNameInputField.Margin = new Padding(24, 16, 0, 24);
            middleNameInputField.Name = "middleNameInputField";
            middleNameInputField.PlaceholderText = "e.g. middle name";
            middleNameInputField.Size = new Size(240, 48);
            middleNameInputField.TabIndex = 2;
            // 
            // lastNameInputField
            // 
            lastNameInputField.Anchor = AnchorStyles.None;
            lastNameInputField.LabelText = "Last name";
            lastNameInputField.Location = new Point(544, 64);
            lastNameInputField.Margin = new Padding(24, 16, 16, 24);
            lastNameInputField.Name = "lastNameInputField";
            lastNameInputField.PlaceholderText = "e.g. last name";
            lastNameInputField.Size = new Size(240, 48);
            lastNameInputField.TabIndex = 3;
            // 
            // taxCodeInputField
            // 
            taxCodeInputField.Anchor = AnchorStyles.None;
            taxCodeInputField.LabelText = "Tax code";
            taxCodeInputField.Location = new Point(280, 136);
            taxCodeInputField.Margin = new Padding(24, 0, 0, 24);
            taxCodeInputField.Name = "taxCodeInputField";
            taxCodeInputField.PlaceholderText = "e.g. tax code";
            taxCodeInputField.Size = new Size(240, 48);
            taxCodeInputField.TabIndex = 8;
            // 
            // citizenIdInputField
            // 
            citizenIdInputField.Anchor = AnchorStyles.None;
            citizenIdInputField.LabelText = "Citizen id";
            citizenIdInputField.Location = new Point(544, 136);
            citizenIdInputField.Margin = new Padding(24, 0, 16, 24);
            citizenIdInputField.Name = "citizenIdInputField";
            citizenIdInputField.PlaceholderText = "e.g. citizen id";
            citizenIdInputField.Size = new Size(240, 48);
            citizenIdInputField.TabIndex = 9;
            // 
            // EmployeeEditorPage
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(lbCheck4);
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
            Controls.Add(salaryScaleInputField);
            Controls.Add(lbCheck1);
            Controls.Add(salaryLevelComboBoxField);
            Controls.Add(salaryLevelInputField);
            Controls.Add(lbCheck2);
            Controls.Add(departmentComboBoxField);
            Controls.Add(positionComboBoxField);
            Controls.Add(positionInputField);
            Controls.Add(saveButton);
            Name = "EmployeeEditorPage";
            Size = new Size(1064, 664);
            Load += EmployeeEditorPage_Load;
            Controls.SetChildIndex(saveButton, 0);
            Controls.SetChildIndex(positionInputField, 0);
            Controls.SetChildIndex(positionComboBoxField, 0);
            Controls.SetChildIndex(departmentComboBoxField, 0);
            Controls.SetChildIndex(lbCheck2, 0);
            Controls.SetChildIndex(salaryLevelInputField, 0);
            Controls.SetChildIndex(salaryLevelComboBoxField, 0);
            Controls.SetChildIndex(lbCheck1, 0);
            Controls.SetChildIndex(salaryScaleInputField, 0);
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
            Controls.SetChildIndex(lbCheck4, 0);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private PeproLabel genderLabel;
        private PeproLabel dateOfBirthLabel;
        private RadioButton maleRadioButton;
        private RadioButton femaleRadioButton;
        private DateTimePicker dateOfBirthDateTimePicker;
        private PeproInputField firstNameInputField;
        private PeproComboBoxField departmentComboBoxField;
        private PeproInputField positionInputField;
        private PeproComboBoxField positionComboBoxField;
        private PeproInputField salaryScaleInputField;
        private PeproComboBoxField salaryScaleComboBoxField;
        private PeproInputField salaryLevelInputField;
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