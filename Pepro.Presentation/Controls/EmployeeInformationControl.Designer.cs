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
            headerLabel = new Label();
            otherRadioButton = new RadioButton();
            phoneNumberComboBox = new ComboBox();
            phoneNumberLabel = new Label();
            femaleRadioButton = new RadioButton();
            maleRadioButton = new RadioButton();
            citizenIdTextBox = new TextBox();
            dateOfBirthDateTimePicker = new DateTimePicker();
            employeeIdLabel = new Label();
            fullNameLabel = new Label();
            genderLabel = new Label();
            roleLabel = new Label();
            citizenIdLabel = new Label();
            projectComboBox = new ComboBox();
            departmentLabel = new Label();
            projectLabel = new Label();
            employeeIdTextBox = new TextBox();
            departmentTextBox = new TextBox();
            employeeNameTextBox = new TextBox();
            dateOfBirthLabel = new Label();
            roleTextBox = new TextBox();
            SuspendLayout();
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
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Thông tin cơ bản";
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // otherRadioButton
            // 
            otherRadioButton.Anchor = AnchorStyles.None;
            otherRadioButton.AutoSize = true;
            otherRadioButton.BackColor = Color.White;
            otherRadioButton.Enabled = false;
            otherRadioButton.ForeColor = Color.Black;
            otherRadioButton.Location = new Point(662, 259);
            otherRadioButton.Name = "otherRadioButton";
            otherRadioButton.Size = new Size(56, 23);
            otherRadioButton.TabIndex = 5;
            otherRadioButton.Text = "Khác";
            otherRadioButton.UseVisualStyleBackColor = false;
            // 
            // phoneNumberComboBox
            // 
            phoneNumberComboBox.Anchor = AnchorStyles.None;
            phoneNumberComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            phoneNumberComboBox.FormattingEnabled = true;
            phoneNumberComboBox.Location = new Point(455, 527);
            phoneNumberComboBox.Name = "phoneNumberComboBox";
            phoneNumberComboBox.Size = new Size(264, 27);
            phoneNumberComboBox.TabIndex = 11;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.Anchor = AnchorStyles.None;
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.ForeColor = Color.White;
            phoneNumberLabel.Location = new Point(344, 531);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(89, 19);
            phoneNumberLabel.TabIndex = 0;
            phoneNumberLabel.Text = "Số điện thoại";
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.Anchor = AnchorStyles.None;
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.BackColor = Color.White;
            femaleRadioButton.Enabled = false;
            femaleRadioButton.ForeColor = Color.Black;
            femaleRadioButton.Location = new Point(564, 259);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(45, 23);
            femaleRadioButton.TabIndex = 4;
            femaleRadioButton.Text = "Nữ";
            femaleRadioButton.UseVisualStyleBackColor = false;
            // 
            // maleRadioButton
            // 
            maleRadioButton.Anchor = AnchorStyles.None;
            maleRadioButton.AutoSize = true;
            maleRadioButton.BackColor = Color.White;
            maleRadioButton.Enabled = false;
            maleRadioButton.ForeColor = Color.Black;
            maleRadioButton.Location = new Point(455, 259);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(56, 23);
            maleRadioButton.TabIndex = 3;
            maleRadioButton.Text = "Nam";
            maleRadioButton.UseVisualStyleBackColor = false;
            // 
            // citizenIdTextBox
            // 
            citizenIdTextBox.Anchor = AnchorStyles.None;
            citizenIdTextBox.Enabled = false;
            citizenIdTextBox.Location = new Point(455, 347);
            citizenIdTextBox.Name = "citizenIdTextBox";
            citizenIdTextBox.Size = new Size(264, 26);
            citizenIdTextBox.TabIndex = 7;
            // 
            // dateOfBirthDateTimePicker
            // 
            dateOfBirthDateTimePicker.Anchor = AnchorStyles.None;
            dateOfBirthDateTimePicker.Checked = false;
            dateOfBirthDateTimePicker.Enabled = false;
            dateOfBirthDateTimePicker.Location = new Point(455, 302);
            dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            dateOfBirthDateTimePicker.Size = new Size(264, 26);
            dateOfBirthDateTimePicker.TabIndex = 6;
            // 
            // employeeIdLabel
            // 
            employeeIdLabel.Anchor = AnchorStyles.None;
            employeeIdLabel.AutoSize = true;
            employeeIdLabel.ForeColor = Color.White;
            employeeIdLabel.Location = new Point(340, 171);
            employeeIdLabel.Name = "employeeIdLabel";
            employeeIdLabel.Size = new Size(93, 19);
            employeeIdLabel.TabIndex = 0;
            employeeIdLabel.Text = "Mã nhân viên";
            // 
            // fullNameLabel
            // 
            fullNameLabel.Anchor = AnchorStyles.None;
            fullNameLabel.AutoSize = true;
            fullNameLabel.ForeColor = Color.White;
            fullNameLabel.Location = new Point(364, 216);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(69, 19);
            fullNameLabel.TabIndex = 0;
            fullNameLabel.Text = "Họ và tên";
            // 
            // genderLabel
            // 
            genderLabel.Anchor = AnchorStyles.None;
            genderLabel.AutoSize = true;
            genderLabel.ForeColor = Color.White;
            genderLabel.Location = new Point(372, 261);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(61, 19);
            genderLabel.TabIndex = 0;
            genderLabel.Text = "Giới tính";
            // 
            // roleLabel
            // 
            roleLabel.Anchor = AnchorStyles.None;
            roleLabel.AutoSize = true;
            roleLabel.ForeColor = Color.White;
            roleLabel.Location = new Point(374, 396);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(59, 19);
            roleLabel.TabIndex = 0;
            roleLabel.Text = "Chức vụ";
            // 
            // citizenIdLabel
            // 
            citizenIdLabel.Anchor = AnchorStyles.None;
            citizenIdLabel.AutoSize = true;
            citizenIdLabel.ForeColor = Color.White;
            citizenIdLabel.Location = new Point(352, 351);
            citizenIdLabel.Name = "citizenIdLabel";
            citizenIdLabel.Size = new Size(81, 19);
            citizenIdLabel.TabIndex = 0;
            citizenIdLabel.Text = "Số căn cước";
            // 
            // projectComboBox
            // 
            projectComboBox.Anchor = AnchorStyles.None;
            projectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            projectComboBox.FormattingEnabled = true;
            projectComboBox.Location = new Point(455, 482);
            projectComboBox.Name = "projectComboBox";
            projectComboBox.Size = new Size(264, 27);
            projectComboBox.TabIndex = 10;
            // 
            // departmentLabel
            // 
            departmentLabel.Anchor = AnchorStyles.None;
            departmentLabel.AutoSize = true;
            departmentLabel.ForeColor = Color.White;
            departmentLabel.Location = new Point(357, 441);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new Size(76, 19);
            departmentLabel.TabIndex = 0;
            departmentLabel.Text = "Phòng ban";
            // 
            // projectLabel
            // 
            projectLabel.Anchor = AnchorStyles.None;
            projectLabel.AutoSize = true;
            projectLabel.ForeColor = Color.White;
            projectLabel.Location = new Point(329, 486);
            projectLabel.Name = "projectLabel";
            projectLabel.Size = new Size(104, 19);
            projectLabel.TabIndex = 0;
            projectLabel.Text = "Dự án tham gia";
            // 
            // employeeIdTextBox
            // 
            employeeIdTextBox.Anchor = AnchorStyles.None;
            employeeIdTextBox.Enabled = false;
            employeeIdTextBox.Location = new Point(455, 167);
            employeeIdTextBox.Name = "employeeIdTextBox";
            employeeIdTextBox.Size = new Size(264, 26);
            employeeIdTextBox.TabIndex = 1;
            // 
            // departmentTextBox
            // 
            departmentTextBox.Anchor = AnchorStyles.None;
            departmentTextBox.Enabled = false;
            departmentTextBox.Location = new Point(455, 437);
            departmentTextBox.Name = "departmentTextBox";
            departmentTextBox.Size = new Size(264, 26);
            departmentTextBox.TabIndex = 9;
            // 
            // employeeNameTextBox
            // 
            employeeNameTextBox.Anchor = AnchorStyles.None;
            employeeNameTextBox.Enabled = false;
            employeeNameTextBox.Location = new Point(455, 212);
            employeeNameTextBox.Name = "employeeNameTextBox";
            employeeNameTextBox.Size = new Size(264, 26);
            employeeNameTextBox.TabIndex = 2;
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.Anchor = AnchorStyles.None;
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.ForeColor = Color.White;
            dateOfBirthLabel.Location = new Point(363, 306);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new Size(70, 19);
            dateOfBirthLabel.TabIndex = 0;
            dateOfBirthLabel.Text = "Ngày sinh";
            // 
            // roleTextBox
            // 
            roleTextBox.Anchor = AnchorStyles.None;
            roleTextBox.Enabled = false;
            roleTextBox.Location = new Point(455, 392);
            roleTextBox.Name = "roleTextBox";
            roleTextBox.Size = new Size(264, 26);
            roleTextBox.TabIndex = 8;
            // 
            // EmployeeInformationControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            Controls.Add(otherRadioButton);
            Controls.Add(phoneNumberComboBox);
            Controls.Add(headerLabel);
            Controls.Add(phoneNumberLabel);
            Controls.Add(maleRadioButton);
            Controls.Add(femaleRadioButton);
            Controls.Add(roleTextBox);
            Controls.Add(dateOfBirthLabel);
            Controls.Add(citizenIdTextBox);
            Controls.Add(employeeNameTextBox);
            Controls.Add(dateOfBirthDateTimePicker);
            Controls.Add(departmentTextBox);
            Controls.Add(employeeIdLabel);
            Controls.Add(employeeIdTextBox);
            Controls.Add(fullNameLabel);
            Controls.Add(projectLabel);
            Controls.Add(genderLabel);
            Controls.Add(departmentLabel);
            Controls.Add(roleLabel);
            Controls.Add(projectComboBox);
            Controls.Add(citizenIdLabel);
            Name = "EmployeeInformationControl";
            Size = new Size(1064, 681);
            Load += EmployeeInformationControl_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private Label employeeIdLabel;
        private Label fullNameLabel;
        private Label genderLabel;
        private Label roleLabel;
        private Label citizenIdLabel;
        private ComboBox projectComboBox;
        private Label departmentLabel;
        private Label projectLabel;
        private TextBox employeeIdTextBox;
        private TextBox departmentTextBox;
        private TextBox employeeNameTextBox;
        private Label dateOfBirthLabel;
        private TextBox roleTextBox;
        private TextBox citizenIdTextBox;
        private DateTimePicker dateOfBirthDateTimePicker;
        private RadioButton maleRadioButton;
        private RadioButton femaleRadioButton;
        private Label phoneNumberLabel;
        private ComboBox phoneNumberComboBox;
        private RadioButton otherRadioButton;
    }
}