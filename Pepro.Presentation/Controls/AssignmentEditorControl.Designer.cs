namespace Pepro.Presentation.Controls
{
    partial class AssignmentEditorControl
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
            publicProjectLabel = new Label();
            publicDepartmentLabel = new Label();
            saveButton = new Button();
            managerIdInputField = new PeproInputField();
            assignmentNameInputField = new PeproInputField();
            statusComboBoxField = new PeproComboBoxField();
            isPublicToProjectCheckBox = new CheckBox();
            isPublicToDepartmentCheckBox = new CheckBox();
            startDateLabel = new Label();
            startDateTimePicker = new DateTimePicker();
            endDateLabel = new Label();
            endDateTimePicker = new DateTimePicker();
            projectComboBoxField = new PeproComboBoxField();
            SuspendLayout();
            // 
            // publicProjectLabel
            // 
            publicProjectLabel.AutoSize = true;
            publicProjectLabel.BackColor = Color.Transparent;
            publicProjectLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            publicProjectLabel.ForeColor = Color.White;
            publicProjectLabel.Location = new Point(544, 137);
            publicProjectLabel.Margin = new Padding(2, 0, 2, 0);
            publicProjectLabel.Name = "publicProjectLabel";
            publicProjectLabel.Size = new Size(124, 20);
            publicProjectLabel.TabIndex = 8;
            publicProjectLabel.Text = "Công khai dự án";
            // 
            // publicDepartmentLabel
            // 
            publicDepartmentLabel.AutoSize = true;
            publicDepartmentLabel.BackColor = Color.Transparent;
            publicDepartmentLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            publicDepartmentLabel.ForeColor = Color.White;
            publicDepartmentLabel.Location = new Point(811, 137);
            publicDepartmentLabel.Margin = new Padding(2, 0, 2, 0);
            publicDepartmentLabel.Name = "publicDepartmentLabel";
            publicDepartmentLabel.Size = new Size(160, 20);
            publicDepartmentLabel.TabIndex = 9;
            publicDepartmentLabel.Text = "Công khai phòng ban";
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.None;
            saveButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            saveButton.Location = new Point(472, 512);
            saveButton.Margin = new Padding(16);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(120, 56);
            saveButton.TabIndex = 21;
            saveButton.Text = "Save";
            // 
            // managerIdInputField
            // 
            managerIdInputField.LabelText = "Manager id";
            managerIdInputField.Location = new Point(16, 209);
            managerIdInputField.Margin = new Padding(16, 16, 0, 16);
            managerIdInputField.Name = "managerIdInputField";
            managerIdInputField.PlaceholderText = "e.g. manager id";
            managerIdInputField.Size = new Size(240, 54);
            managerIdInputField.TabIndex = 22;
            // 
            // assignmentNameInputField
            // 
            assignmentNameInputField.LabelText = "Assignment name";
            assignmentNameInputField.Location = new Point(16, 67);
            assignmentNameInputField.Margin = new Padding(16, 16, 16, 0);
            assignmentNameInputField.Name = "assignmentNameInputField";
            assignmentNameInputField.PlaceholderText = "e.g. assignment name";
            assignmentNameInputField.Size = new Size(1032, 54);
            assignmentNameInputField.TabIndex = 22;
            // 
            // statusComboBoxField
            // 
            statusComboBoxField.Anchor = AnchorStyles.None;
            statusComboBoxField.LabelText = "Status";
            statusComboBoxField.Location = new Point(808, 209);
            statusComboBoxField.Margin = new Padding(24, 16, 0, 16);
            statusComboBoxField.Name = "statusComboBoxField";
            statusComboBoxField.Size = new Size(240, 56);
            statusComboBoxField.TabIndex = 23;
            // 
            // isPublicToProjectCheckBox
            // 
            isPublicToProjectCheckBox.AutoSize = true;
            isPublicToProjectCheckBox.Location = new Point(544, 168);
            isPublicToProjectCheckBox.Name = "isPublicToProjectCheckBox";
            isPublicToProjectCheckBox.Size = new Size(48, 23);
            isPublicToProjectCheckBox.TabIndex = 24;
            isPublicToProjectCheckBox.Text = "Yes";
            isPublicToProjectCheckBox.UseVisualStyleBackColor = true;
            // 
            // isPublicToDepartmentCheckBox
            // 
            isPublicToDepartmentCheckBox.AutoSize = true;
            isPublicToDepartmentCheckBox.Location = new Point(811, 168);
            isPublicToDepartmentCheckBox.Name = "isPublicToDepartmentCheckBox";
            isPublicToDepartmentCheckBox.Size = new Size(48, 23);
            isPublicToDepartmentCheckBox.TabIndex = 24;
            isPublicToDepartmentCheckBox.Text = "Yes";
            isPublicToDepartmentCheckBox.UseVisualStyleBackColor = true;
            // 
            // startDateLabel
            // 
            startDateLabel.Anchor = AnchorStyles.None;
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new Point(280, 209);
            startDateLabel.Margin = new Padding(24, 0, 0, 0);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(69, 19);
            startDateLabel.TabIndex = 25;
            startDateLabel.Text = "Start date";
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.Anchor = AnchorStyles.None;
            startDateTimePicker.Location = new Point(280, 237);
            startDateTimePicker.Margin = new Padding(16, 0, 0, 16);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(240, 26);
            startDateTimePicker.TabIndex = 27;
            // 
            // endDateLabel
            // 
            endDateLabel.Anchor = AnchorStyles.None;
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new Point(544, 209);
            endDateLabel.Margin = new Padding(24, 0, 0, 0);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(63, 19);
            endDateLabel.TabIndex = 26;
            endDateLabel.Text = "End date";
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Anchor = AnchorStyles.None;
            endDateTimePicker.Location = new Point(544, 237);
            endDateTimePicker.Margin = new Padding(24, 0, 16, 16);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(240, 26);
            endDateTimePicker.TabIndex = 28;
            // 
            // projectComboBoxField
            // 
            projectComboBoxField.Anchor = AnchorStyles.None;
            projectComboBoxField.LabelText = "Project name";
            projectComboBoxField.Location = new Point(16, 137);
            projectComboBoxField.Margin = new Padding(16, 16, 0, 16);
            projectComboBoxField.Name = "projectComboBoxField";
            projectComboBoxField.Size = new Size(504, 56);
            projectComboBoxField.TabIndex = 23;
            // 
            // AssignmentEditorControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(managerIdInputField);
            Controls.Add(startDateLabel);
            Controls.Add(startDateTimePicker);
            Controls.Add(endDateLabel);
            Controls.Add(endDateTimePicker);
            Controls.Add(statusComboBoxField);
            Controls.Add(saveButton);
            Controls.Add(isPublicToDepartmentCheckBox);
            Controls.Add(isPublicToProjectCheckBox);
            Controls.Add(projectComboBoxField);
            Controls.Add(assignmentNameInputField);
            Controls.Add(publicDepartmentLabel);
            Controls.Add(publicProjectLabel);
            HeaderText = "Assignment Editor";
            Name = "AssignmentEditorControl";
            Controls.SetChildIndex(publicProjectLabel, 0);
            Controls.SetChildIndex(publicDepartmentLabel, 0);
            Controls.SetChildIndex(assignmentNameInputField, 0);
            Controls.SetChildIndex(projectComboBoxField, 0);
            Controls.SetChildIndex(isPublicToProjectCheckBox, 0);
            Controls.SetChildIndex(isPublicToDepartmentCheckBox, 0);
            Controls.SetChildIndex(saveButton, 0);
            Controls.SetChildIndex(statusComboBoxField, 0);
            Controls.SetChildIndex(endDateTimePicker, 0);
            Controls.SetChildIndex(endDateLabel, 0);
            Controls.SetChildIndex(startDateTimePicker, 0);
            Controls.SetChildIndex(startDateLabel, 0);
            Controls.SetChildIndex(managerIdInputField, 0);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Label publicProjectLabel;
        private Label publicDepartmentLabel;
        private Button saveButton;
        private PeproInputField managerIdInputField;
        private PeproInputField assignmentNameInputField;
        private PeproComboBoxField statusComboBoxField;
        private CheckBox isPublicToProjectCheckBox;
        private CheckBox isPublicToDepartmentCheckBox;
        private Label startDateLabel;
        public DateTimePicker startDateTimePicker;
        private Label endDateLabel;
        public DateTimePicker endDateTimePicker;
        private PeproComboBoxField projectComboBoxField;
    }
}