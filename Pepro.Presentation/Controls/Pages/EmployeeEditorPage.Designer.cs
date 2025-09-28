using Pepro.Presentation.Controls.Atoms;
using Pepro.Presentation.Controls.Molecules;

namespace Pepro.Presentation.Controls.Pages;

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
        firstNameTextBoxField = new TextBoxField();
        departmentComboBoxField = new ComboBoxField();
        positionTextBoxField = new TextBoxField();
        positionComboBoxField = new ComboBoxField();
        salaryScaleTextBoxField = new TextBoxField();
        salaryScaleComboBoxField = new ComboBoxField();
        salaryLevelTextBoxField = new TextBoxField();
        salaryLevelComboBoxField = new ComboBoxField();
        otherRadioButton = new RadioButton();
        lbCheck3 = new Label();
        lbCheck1 = new Label();
        lbCheck2 = new Label();
        lbCheck4 = new Label();
        saveButton = new Button();
        middleNameTextBoxField = new TextBoxField();
        lastNameTextBoxField = new TextBoxField();
        taxCodeTextBoxField = new TextBoxField();
        citizenIdTextBoxField = new TextBoxField();
        SuspendLayout();
        // 
        // genderLabel
        // 
        genderLabel.Anchor = AnchorStyles.None;
        genderLabel.AutoSize = true;
        genderLabel.Location = new Point(16, 147);
        genderLabel.Name = "genderLabel";
        genderLabel.Size = new Size(45, 14);
        genderLabel.TabIndex = 0;
        genderLabel.Text = "Gender";
        // 
        // dateOfBirthLabel
        // 
        dateOfBirthLabel.Anchor = AnchorStyles.None;
        dateOfBirthLabel.AutoSize = true;
        dateOfBirthLabel.Location = new Point(808, 75);
        dateOfBirthLabel.Name = "dateOfBirthLabel";
        dateOfBirthLabel.Size = new Size(78, 14);
        dateOfBirthLabel.TabIndex = 0;
        dateOfBirthLabel.Text = "Date of Birth";
        // 
        // maleRadioButton
        // 
        maleRadioButton.Anchor = AnchorStyles.None;
        maleRadioButton.AutoSize = true;
        maleRadioButton.Location = new Point(16, 172);
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
        femaleRadioButton.Location = new Point(96, 172);
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
        dateOfBirthDateTimePicker.Location = new Point(808, 97);
        dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
        dateOfBirthDateTimePicker.Size = new Size(240, 26);
        dateOfBirthDateTimePicker.TabIndex = 4;
        // 
        // firstNameTextBoxField
        // 
        firstNameTextBoxField.Anchor = AnchorStyles.None;
        firstNameTextBoxField.LabelText = "First name";
        firstNameTextBoxField.Location = new Point(16, 75);
        firstNameTextBoxField.Margin = new Padding(16, 16, 0, 24);
        firstNameTextBoxField.Name = "firstNameTextBoxField";
        firstNameTextBoxField.PlaceholderText = "e.g. first name";
        firstNameTextBoxField.Size = new Size(240, 48);
        firstNameTextBoxField.TabIndex = 1;
        // 
        // departmentComboBoxField
        // 
        departmentComboBoxField.Anchor = AnchorStyles.None;
        departmentComboBoxField.LabelText = "Department";
        departmentComboBoxField.Location = new Point(808, 147);
        departmentComboBoxField.Margin = new Padding(24, 0, 16, 24);
        departmentComboBoxField.Name = "departmentComboBoxField";
        departmentComboBoxField.Size = new Size(240, 48);
        departmentComboBoxField.TabIndex = 10;
        // 
        // positionTextBoxField
        // 
        positionTextBoxField.Anchor = AnchorStyles.None;
        positionTextBoxField.Enabled = false;
        positionTextBoxField.LabelText = "Position allowance percent";
        positionTextBoxField.Location = new Point(808, 219);
        positionTextBoxField.Margin = new Padding(24, 0, 16, 24);
        positionTextBoxField.Name = "positionTextBoxField";
        positionTextBoxField.PlaceholderText = "e.g. position allowance percent";
        positionTextBoxField.Size = new Size(240, 48);
        positionTextBoxField.TabIndex = 14;
        // 
        // positionComboBoxField
        // 
        positionComboBoxField.Anchor = AnchorStyles.None;
        positionComboBoxField.LabelText = "Position";
        positionComboBoxField.Location = new Point(544, 219);
        positionComboBoxField.Margin = new Padding(24, 0, 0, 24);
        positionComboBoxField.Name = "positionComboBoxField";
        positionComboBoxField.Size = new Size(240, 48);
        positionComboBoxField.TabIndex = 13;
        positionComboBoxField.SelectedIndexChanged += PositionComboBoxField_SelectedIndexChanged;
        // 
        // salaryScaleTextBoxField
        // 
        salaryScaleTextBoxField.Anchor = AnchorStyles.None;
        salaryScaleTextBoxField.Enabled = false;
        salaryScaleTextBoxField.LabelText = "Salary scale group";
        salaryScaleTextBoxField.Location = new Point(280, 219);
        salaryScaleTextBoxField.Margin = new Padding(24, 0, 0, 24);
        salaryScaleTextBoxField.Name = "salaryScaleTextBoxField";
        salaryScaleTextBoxField.PlaceholderText = "e.g. salary scale group";
        salaryScaleTextBoxField.Size = new Size(240, 48);
        salaryScaleTextBoxField.TabIndex = 12;
        // 
        // salaryScaleComboBoxField
        // 
        salaryScaleComboBoxField.Anchor = AnchorStyles.None;
        salaryScaleComboBoxField.LabelText = "Salary scale";
        salaryScaleComboBoxField.Location = new Point(16, 219);
        salaryScaleComboBoxField.Margin = new Padding(16, 0, 0, 24);
        salaryScaleComboBoxField.Name = "salaryScaleComboBoxField";
        salaryScaleComboBoxField.Size = new Size(240, 48);
        salaryScaleComboBoxField.TabIndex = 11;
        salaryScaleComboBoxField.SelectedIndexChanged += SalaryScaleComboBoxField_SelectedIndexChanged;
        // 
        // salaryLevelTextBoxField
        // 
        salaryLevelTextBoxField.Anchor = AnchorStyles.None;
        salaryLevelTextBoxField.Enabled = false;
        salaryLevelTextBoxField.LabelText = "Salary level coefficient";
        salaryLevelTextBoxField.Location = new Point(280, 291);
        salaryLevelTextBoxField.Margin = new Padding(24, 0, 0, 24);
        salaryLevelTextBoxField.Name = "salaryLevelTextBoxField";
        salaryLevelTextBoxField.PlaceholderText = "e.g. salary level coefficient";
        salaryLevelTextBoxField.Size = new Size(240, 48);
        salaryLevelTextBoxField.TabIndex = 16;
        // 
        // salaryLevelComboBoxField
        // 
        salaryLevelComboBoxField.Anchor = AnchorStyles.None;
        salaryLevelComboBoxField.LabelText = "Salary level";
        salaryLevelComboBoxField.Location = new Point(16, 291);
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
        otherRadioButton.Location = new Point(193, 172);
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
        lbCheck3.Location = new Point(91, 219);
        lbCheck3.Name = "lbCheck3";
        lbCheck3.Size = new Size(15, 19);
        lbCheck3.TabIndex = 0;
        lbCheck3.Text = "*";
        // 
        // lbCheck1
        // 
        lbCheck1.Anchor = AnchorStyles.None;
        lbCheck1.AutoSize = true;
        lbCheck1.Location = new Point(888, 147);
        lbCheck1.Name = "lbCheck1";
        lbCheck1.Size = new Size(15, 19);
        lbCheck1.TabIndex = 0;
        lbCheck1.Text = "*";
        // 
        // lbCheck2
        // 
        lbCheck2.Anchor = AnchorStyles.None;
        lbCheck2.AutoSize = true;
        lbCheck2.Location = new Point(599, 219);
        lbCheck2.Name = "lbCheck2";
        lbCheck2.Size = new Size(15, 19);
        lbCheck2.TabIndex = 0;
        lbCheck2.Text = "*";
        // 
        // lbCheck4
        // 
        lbCheck4.Anchor = AnchorStyles.None;
        lbCheck4.AutoSize = true;
        lbCheck4.Location = new Point(91, 291);
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
        // middleNameTextBoxField
        // 
        middleNameTextBoxField.Anchor = AnchorStyles.None;
        middleNameTextBoxField.LabelText = "Middle name";
        middleNameTextBoxField.Location = new Point(280, 75);
        middleNameTextBoxField.Margin = new Padding(24, 16, 0, 24);
        middleNameTextBoxField.Name = "middleNameTextBoxField";
        middleNameTextBoxField.PlaceholderText = "e.g. middle name";
        middleNameTextBoxField.Size = new Size(240, 48);
        middleNameTextBoxField.TabIndex = 2;
        // 
        // lastNameTextBoxField
        // 
        lastNameTextBoxField.Anchor = AnchorStyles.None;
        lastNameTextBoxField.LabelText = "Last name";
        lastNameTextBoxField.Location = new Point(544, 75);
        lastNameTextBoxField.Margin = new Padding(24, 16, 16, 24);
        lastNameTextBoxField.Name = "lastNameTextBoxField";
        lastNameTextBoxField.PlaceholderText = "e.g. last name";
        lastNameTextBoxField.Size = new Size(240, 48);
        lastNameTextBoxField.TabIndex = 3;
        // 
        // taxCodeTextBoxField
        // 
        taxCodeTextBoxField.Anchor = AnchorStyles.None;
        taxCodeTextBoxField.LabelText = "Tax code";
        taxCodeTextBoxField.Location = new Point(280, 147);
        taxCodeTextBoxField.Margin = new Padding(24, 0, 0, 24);
        taxCodeTextBoxField.Name = "taxCodeTextBoxField";
        taxCodeTextBoxField.PlaceholderText = "e.g. tax code";
        taxCodeTextBoxField.Size = new Size(240, 48);
        taxCodeTextBoxField.TabIndex = 8;
        // 
        // citizenIdTextBoxField
        // 
        citizenIdTextBoxField.Anchor = AnchorStyles.None;
        citizenIdTextBoxField.LabelText = "Citizen id";
        citizenIdTextBoxField.Location = new Point(544, 147);
        citizenIdTextBoxField.Margin = new Padding(24, 0, 16, 24);
        citizenIdTextBoxField.Name = "citizenIdTextBoxField";
        citizenIdTextBoxField.PlaceholderText = "e.g. citizen id";
        citizenIdTextBoxField.Size = new Size(240, 48);
        citizenIdTextBoxField.TabIndex = 9;
        // 
        // EmployeeEditorPage
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        Controls.Add(lbCheck4);
        Controls.Add(firstNameTextBoxField);
        Controls.Add(middleNameTextBoxField);
        Controls.Add(lastNameTextBoxField);
        Controls.Add(dateOfBirthLabel);
        Controls.Add(dateOfBirthDateTimePicker);
        Controls.Add(genderLabel);
        Controls.Add(maleRadioButton);
        Controls.Add(femaleRadioButton);
        Controls.Add(otherRadioButton);
        Controls.Add(taxCodeTextBoxField);
        Controls.Add(citizenIdTextBoxField);
        Controls.Add(lbCheck3);
        Controls.Add(salaryScaleComboBoxField);
        Controls.Add(salaryScaleTextBoxField);
        Controls.Add(lbCheck1);
        Controls.Add(salaryLevelComboBoxField);
        Controls.Add(salaryLevelTextBoxField);
        Controls.Add(lbCheck2);
        Controls.Add(departmentComboBoxField);
        Controls.Add(positionComboBoxField);
        Controls.Add(positionTextBoxField);
        Controls.Add(saveButton);
        Name = "EmployeeEditorPage";
        Size = new Size(1064, 664);
        Load += EmployeeEditorPage_Load;
        Controls.SetChildIndex(saveButton, 0);
        Controls.SetChildIndex(positionTextBoxField, 0);
        Controls.SetChildIndex(positionComboBoxField, 0);
        Controls.SetChildIndex(departmentComboBoxField, 0);
        Controls.SetChildIndex(lbCheck2, 0);
        Controls.SetChildIndex(salaryLevelTextBoxField, 0);
        Controls.SetChildIndex(salaryLevelComboBoxField, 0);
        Controls.SetChildIndex(lbCheck1, 0);
        Controls.SetChildIndex(salaryScaleTextBoxField, 0);
        Controls.SetChildIndex(salaryScaleComboBoxField, 0);
        Controls.SetChildIndex(lbCheck3, 0);
        Controls.SetChildIndex(citizenIdTextBoxField, 0);
        Controls.SetChildIndex(taxCodeTextBoxField, 0);
        Controls.SetChildIndex(otherRadioButton, 0);
        Controls.SetChildIndex(femaleRadioButton, 0);
        Controls.SetChildIndex(maleRadioButton, 0);
        Controls.SetChildIndex(genderLabel, 0);
        Controls.SetChildIndex(dateOfBirthDateTimePicker, 0);
        Controls.SetChildIndex(dateOfBirthLabel, 0);
        Controls.SetChildIndex(lastNameTextBoxField, 0);
        Controls.SetChildIndex(middleNameTextBoxField, 0);
        Controls.SetChildIndex(firstNameTextBoxField, 0);
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
    private TextBoxField firstNameTextBoxField;
    private ComboBoxField departmentComboBoxField;
    private TextBoxField positionTextBoxField;
    private ComboBoxField positionComboBoxField;
    private TextBoxField salaryScaleTextBoxField;
    private ComboBoxField salaryScaleComboBoxField;
    private TextBoxField salaryLevelTextBoxField;
    private ComboBoxField salaryLevelComboBoxField;
    private RadioButton otherRadioButton;
    private Label lbCheck3;
    private Label lbCheck1;
    private Label lbCheck2;
    private Label lbCheck4;
    private Button saveButton;
    private TextBoxField middleNameTextBoxField;
    private TextBoxField lastNameTextBoxField;
    private TextBoxField taxCodeTextBoxField;
    private TextBoxField citizenIdTextBoxField;
}
