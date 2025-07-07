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
            empoyeeIdTextBox = new TextBox();
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
            headerLabel.Margin = new Padding(2, 0, 2, 0);
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
            otherRadioButton.Enabled = false;
            otherRadioButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            otherRadioButton.ForeColor = Color.White;
            otherRadioButton.Location = new Point(659, 259);
            otherRadioButton.Name = "otherRadioButton";
            otherRadioButton.Size = new Size(61, 25);
            otherRadioButton.TabIndex = 5;
            otherRadioButton.Text = "Khác";
            // 
            // phoneNumberComboBox
            // 
            phoneNumberComboBox.Anchor = AnchorStyles.None;
            phoneNumberComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            phoneNumberComboBox.Enabled = false;
            phoneNumberComboBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            phoneNumberComboBox.FormattingEnabled = true;
            phoneNumberComboBox.Location = new Point(455, 527);
            phoneNumberComboBox.Margin = new Padding(2);
            phoneNumberComboBox.Name = "phoneNumberComboBox";
            phoneNumberComboBox.Size = new Size(264, 29);
            phoneNumberComboBox.TabIndex = 11;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.Anchor = AnchorStyles.None;
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            phoneNumberLabel.ForeColor = Color.White;
            phoneNumberLabel.Location = new Point(400, 531);
            phoneNumberLabel.Margin = new Padding(2, 0, 2, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(38, 21);
            phoneNumberLabel.TabIndex = 0;
            phoneNumberLabel.Text = "SĐT";
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.Anchor = AnchorStyles.None;
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Enabled = false;
            femaleRadioButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            femaleRadioButton.ForeColor = Color.White;
            femaleRadioButton.Location = new Point(563, 259);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(49, 25);
            femaleRadioButton.TabIndex = 4;
            femaleRadioButton.Text = "Nữ";
            // 
            // maleRadioButton
            // 
            maleRadioButton.Anchor = AnchorStyles.None;
            maleRadioButton.AutoSize = true;
            maleRadioButton.Enabled = false;
            maleRadioButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            maleRadioButton.ForeColor = Color.White;
            maleRadioButton.Location = new Point(455, 259);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(62, 25);
            maleRadioButton.TabIndex = 3;
            maleRadioButton.Text = "Nam";
            // 
            // citizenIdTextBox
            // 
            citizenIdTextBox.Anchor = AnchorStyles.None;
            citizenIdTextBox.Enabled = false;
            citizenIdTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            citizenIdTextBox.Location = new Point(455, 347);
            citizenIdTextBox.Margin = new Padding(2);
            citizenIdTextBox.Name = "citizenIdTextBox";
            citizenIdTextBox.Size = new Size(264, 29);
            citizenIdTextBox.TabIndex = 7;
            // 
            // dateOfBirthDateTimePicker
            // 
            dateOfBirthDateTimePicker.Anchor = AnchorStyles.None;
            dateOfBirthDateTimePicker.Checked = false;
            dateOfBirthDateTimePicker.CustomFormat = "yyyy-mm-dd";
            dateOfBirthDateTimePicker.Enabled = false;
            dateOfBirthDateTimePicker.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dateOfBirthDateTimePicker.Format = DateTimePickerFormat.Short;
            dateOfBirthDateTimePicker.Location = new Point(455, 302);
            dateOfBirthDateTimePicker.Margin = new Padding(2);
            dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            dateOfBirthDateTimePicker.Size = new Size(264, 29);
            dateOfBirthDateTimePicker.TabIndex = 6;
            // 
            // employeeIdLabel
            // 
            employeeIdLabel.Anchor = AnchorStyles.None;
            employeeIdLabel.AutoSize = true;
            employeeIdLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            employeeIdLabel.ForeColor = Color.White;
            employeeIdLabel.Location = new Point(334, 171);
            employeeIdLabel.Margin = new Padding(2, 0, 2, 0);
            employeeIdLabel.Name = "employeeIdLabel";
            employeeIdLabel.Size = new Size(104, 21);
            employeeIdLabel.TabIndex = 0;
            employeeIdLabel.Text = "Mã nhân viên";
            // 
            // fullNameLabel
            // 
            fullNameLabel.Anchor = AnchorStyles.None;
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            fullNameLabel.ForeColor = Color.White;
            fullNameLabel.Location = new Point(362, 216);
            fullNameLabel.Margin = new Padding(2, 0, 2, 0);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(76, 21);
            fullNameLabel.TabIndex = 0;
            fullNameLabel.Text = "Họ và tên";
            // 
            // genderLabel
            // 
            genderLabel.Anchor = AnchorStyles.None;
            genderLabel.AutoSize = true;
            genderLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            genderLabel.ForeColor = Color.White;
            genderLabel.Location = new Point(368, 261);
            genderLabel.Margin = new Padding(2, 0, 2, 0);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(70, 21);
            genderLabel.TabIndex = 0;
            genderLabel.Text = "Giới tính";
            // 
            // roleLabel
            // 
            roleLabel.Anchor = AnchorStyles.None;
            roleLabel.AutoSize = true;
            roleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            roleLabel.ForeColor = Color.White;
            roleLabel.Location = new Point(372, 396);
            roleLabel.Margin = new Padding(2, 0, 2, 0);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(66, 21);
            roleLabel.TabIndex = 0;
            roleLabel.Text = "Chức vụ";
            // 
            // citizenIdLabel
            // 
            citizenIdLabel.Anchor = AnchorStyles.None;
            citizenIdLabel.AutoSize = true;
            citizenIdLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            citizenIdLabel.ForeColor = Color.White;
            citizenIdLabel.Location = new Point(387, 351);
            citizenIdLabel.Margin = new Padding(2, 0, 2, 0);
            citizenIdLabel.Name = "citizenIdLabel";
            citizenIdLabel.Size = new Size(51, 21);
            citizenIdLabel.TabIndex = 0;
            citizenIdLabel.Text = "CCCD";
            // 
            // projectComboBox
            // 
            projectComboBox.Anchor = AnchorStyles.None;
            projectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            projectComboBox.Enabled = false;
            projectComboBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            projectComboBox.FormattingEnabled = true;
            projectComboBox.Location = new Point(455, 482);
            projectComboBox.Margin = new Padding(2);
            projectComboBox.Name = "projectComboBox";
            projectComboBox.Size = new Size(264, 29);
            projectComboBox.TabIndex = 10;
            // 
            // departmentLabel
            // 
            departmentLabel.Anchor = AnchorStyles.None;
            departmentLabel.AutoSize = true;
            departmentLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            departmentLabel.ForeColor = Color.White;
            departmentLabel.Location = new Point(353, 441);
            departmentLabel.Margin = new Padding(2, 0, 2, 0);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new Size(85, 21);
            departmentLabel.TabIndex = 0;
            departmentLabel.Text = "Phòng ban";
            // 
            // projectLabel
            // 
            projectLabel.Anchor = AnchorStyles.None;
            projectLabel.AutoSize = true;
            projectLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            projectLabel.ForeColor = Color.White;
            projectLabel.Location = new Point(322, 486);
            projectLabel.Margin = new Padding(2, 0, 2, 0);
            projectLabel.Name = "projectLabel";
            projectLabel.Size = new Size(116, 21);
            projectLabel.TabIndex = 0;
            projectLabel.Text = "Dự án tham gia";
            // 
            // empoyeeIdTextBox
            // 
            empoyeeIdTextBox.Anchor = AnchorStyles.None;
            empoyeeIdTextBox.Enabled = false;
            empoyeeIdTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            empoyeeIdTextBox.Location = new Point(455, 167);
            empoyeeIdTextBox.Margin = new Padding(2);
            empoyeeIdTextBox.Name = "empoyeeIdTextBox";
            empoyeeIdTextBox.Size = new Size(264, 29);
            empoyeeIdTextBox.TabIndex = 1;
            // 
            // departmentTextBox
            // 
            departmentTextBox.Anchor = AnchorStyles.None;
            departmentTextBox.Enabled = false;
            departmentTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            departmentTextBox.Location = new Point(455, 437);
            departmentTextBox.Margin = new Padding(2);
            departmentTextBox.Name = "departmentTextBox";
            departmentTextBox.Size = new Size(264, 29);
            departmentTextBox.TabIndex = 9;
            // 
            // employeeNameTextBox
            // 
            employeeNameTextBox.Anchor = AnchorStyles.None;
            employeeNameTextBox.Enabled = false;
            employeeNameTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            employeeNameTextBox.Location = new Point(455, 212);
            employeeNameTextBox.Margin = new Padding(2);
            employeeNameTextBox.Name = "employeeNameTextBox";
            employeeNameTextBox.Size = new Size(264, 29);
            employeeNameTextBox.TabIndex = 2;
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.Anchor = AnchorStyles.None;
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dateOfBirthLabel.ForeColor = Color.White;
            dateOfBirthLabel.Location = new Point(358, 306);
            dateOfBirthLabel.Margin = new Padding(2, 0, 2, 0);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new Size(80, 21);
            dateOfBirthLabel.TabIndex = 0;
            dateOfBirthLabel.Text = "Ngày sinh";
            // 
            // roleTextBox
            // 
            roleTextBox.Anchor = AnchorStyles.None;
            roleTextBox.Enabled = false;
            roleTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            roleTextBox.Location = new Point(455, 392);
            roleTextBox.Margin = new Padding(2);
            roleTextBox.Name = "roleTextBox";
            roleTextBox.Size = new Size(264, 29);
            roleTextBox.TabIndex = 8;
            // 
            // EmployeeInformationControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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
            Controls.Add(empoyeeIdTextBox);
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
        private TextBox empoyeeIdTextBox;
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