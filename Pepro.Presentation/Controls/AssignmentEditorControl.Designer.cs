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
            publicProjectLabel = new PeproLabel();
            publicDepartmentLabel = new PeproLabel();
            saveButton = new Button();
            managerIdInputField = new PeproInputField();
            assignmentNameInputField = new PeproInputField();
            statusComboBoxField = new PeproComboBoxField();
            isPublicToProjectCheckBox = new CheckBox();
            isPublicToDepartmentCheckBox = new CheckBox();
            startDateLabel = new PeproLabel();
            startDateTimePicker = new DateTimePicker();
            endDateLabel = new PeproLabel();
            endDateTimePicker = new DateTimePicker();
            projectComboBoxField = new PeproComboBoxField();
            requiredDocumentCountInputField = new PeproInputField();
            SuspendLayout();
            // 
            // publicProjectLabel
            // 
            publicProjectLabel.Anchor = AnchorStyles.None;
            publicProjectLabel.AutoSize = true;
            publicProjectLabel.BackColor = Color.Transparent;
            publicProjectLabel.ForeColor = Color.White;
            publicProjectLabel.Location = new Point(544, 136);
            publicProjectLabel.Margin = new Padding(2, 0, 2, 0);
            publicProjectLabel.Name = "publicProjectLabel";
            publicProjectLabel.Size = new Size(99, 14);
            publicProjectLabel.TabIndex = 0;
            publicProjectLabel.Text = "Public to project";
            // 
            // publicDepartmentLabel
            // 
            publicDepartmentLabel.Anchor = AnchorStyles.None;
            publicDepartmentLabel.AutoSize = true;
            publicDepartmentLabel.BackColor = Color.Transparent;
            publicDepartmentLabel.ForeColor = Color.White;
            publicDepartmentLabel.Location = new Point(808, 136);
            publicDepartmentLabel.Margin = new Padding(2, 0, 2, 0);
            publicDepartmentLabel.Name = "publicDepartmentLabel";
            publicDepartmentLabel.Size = new Size(129, 14);
            publicDepartmentLabel.TabIndex = 0;
            publicDepartmentLabel.Text = "Public to department";
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.None;
            saveButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            saveButton.Location = new Point(472, 512);
            saveButton.Margin = new Padding(16);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(120, 56);
            saveButton.TabIndex = 10;
            saveButton.Text = "Save";
            saveButton.Click += SaveButton_Click;
            // 
            // managerIdInputField
            // 
            managerIdInputField.Anchor = AnchorStyles.None;
            managerIdInputField.LabelText = "Manager id";
            managerIdInputField.Location = new Point(280, 208);
            managerIdInputField.Margin = new Padding(24, 0, 0, 24);
            managerIdInputField.Name = "managerIdInputField";
            managerIdInputField.PlaceholderText = "e.g. manager id";
            managerIdInputField.Size = new Size(240, 48);
            managerIdInputField.TabIndex = 6;
            // 
            // assignmentNameInputField
            // 
            assignmentNameInputField.Anchor = AnchorStyles.None;
            assignmentNameInputField.LabelText = "Assignment name";
            assignmentNameInputField.Location = new Point(16, 64);
            assignmentNameInputField.Margin = new Padding(16, 16, 16, 24);
            assignmentNameInputField.Name = "assignmentNameInputField";
            assignmentNameInputField.PlaceholderText = "e.g. assignment name";
            assignmentNameInputField.Size = new Size(1032, 48);
            assignmentNameInputField.TabIndex = 1;
            // 
            // statusComboBoxField
            // 
            statusComboBoxField.Anchor = AnchorStyles.None;
            statusComboBoxField.LabelText = "Status";
            statusComboBoxField.Location = new Point(16, 280);
            statusComboBoxField.Margin = new Padding(16, 0, 0, 24);
            statusComboBoxField.Name = "statusComboBoxField";
            statusComboBoxField.Size = new Size(240, 48);
            statusComboBoxField.TabIndex = 9;
            // 
            // isPublicToProjectCheckBox
            // 
            isPublicToProjectCheckBox.Anchor = AnchorStyles.None;
            isPublicToProjectCheckBox.AutoSize = true;
            isPublicToProjectCheckBox.Location = new Point(544, 159);
            isPublicToProjectCheckBox.Margin = new Padding(24, 8, 0, 24);
            isPublicToProjectCheckBox.Name = "isPublicToProjectCheckBox";
            isPublicToProjectCheckBox.Size = new Size(48, 23);
            isPublicToProjectCheckBox.TabIndex = 3;
            isPublicToProjectCheckBox.Text = "Yes";
            isPublicToProjectCheckBox.UseVisualStyleBackColor = true;
            // 
            // isPublicToDepartmentCheckBox
            // 
            isPublicToDepartmentCheckBox.Anchor = AnchorStyles.None;
            isPublicToDepartmentCheckBox.AutoSize = true;
            isPublicToDepartmentCheckBox.Location = new Point(808, 159);
            isPublicToDepartmentCheckBox.Margin = new Padding(24, 8, 0, 24);
            isPublicToDepartmentCheckBox.Name = "isPublicToDepartmentCheckBox";
            isPublicToDepartmentCheckBox.Size = new Size(48, 23);
            isPublicToDepartmentCheckBox.TabIndex = 4;
            isPublicToDepartmentCheckBox.Text = "Yes";
            isPublicToDepartmentCheckBox.UseVisualStyleBackColor = true;
            // 
            // startDateLabel
            // 
            startDateLabel.Anchor = AnchorStyles.None;
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new Point(544, 208);
            startDateLabel.Margin = new Padding(24, 0, 0, 0);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(60, 14);
            startDateLabel.TabIndex = 0;
            startDateLabel.Text = "Start date";
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.Anchor = AnchorStyles.None;
            startDateTimePicker.Location = new Point(544, 230);
            startDateTimePicker.Margin = new Padding(24, 0, 0, 24);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(240, 26);
            startDateTimePicker.TabIndex = 7;
            // 
            // endDateLabel
            // 
            endDateLabel.Anchor = AnchorStyles.None;
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new Point(808, 208);
            endDateLabel.Margin = new Padding(24, 0, 0, 0);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(54, 14);
            endDateLabel.TabIndex = 0;
            endDateLabel.Text = "End date";
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Anchor = AnchorStyles.None;
            endDateTimePicker.Location = new Point(808, 230);
            endDateTimePicker.Margin = new Padding(24, 0, 16, 24);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(240, 26);
            endDateTimePicker.TabIndex = 8;
            // 
            // projectComboBoxField
            // 
            projectComboBoxField.Anchor = AnchorStyles.None;
            projectComboBoxField.LabelText = "Project name";
            projectComboBoxField.Location = new Point(16, 136);
            projectComboBoxField.Margin = new Padding(16, 0, 0, 24);
            projectComboBoxField.Name = "projectComboBoxField";
            projectComboBoxField.Size = new Size(504, 48);
            projectComboBoxField.TabIndex = 2;
            // 
            // requiredDocumentCountInputField
            // 
            requiredDocumentCountInputField.Anchor = AnchorStyles.None;
            requiredDocumentCountInputField.LabelText = "Required document count";
            requiredDocumentCountInputField.Location = new Point(16, 208);
            requiredDocumentCountInputField.Margin = new Padding(16, 0, 0, 24);
            requiredDocumentCountInputField.Name = "requiredDocumentCountInputField";
            requiredDocumentCountInputField.PlaceholderText = "e.g. required document count";
            requiredDocumentCountInputField.Size = new Size(240, 48);
            requiredDocumentCountInputField.TabIndex = 5;
            // 
            // AssignmentEditorControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(assignmentNameInputField);
            Controls.Add(projectComboBoxField);
            Controls.Add(publicProjectLabel);
            Controls.Add(isPublicToProjectCheckBox);
            Controls.Add(publicDepartmentLabel);
            Controls.Add(isPublicToDepartmentCheckBox);
            Controls.Add(requiredDocumentCountInputField);
            Controls.Add(managerIdInputField);
            Controls.Add(startDateLabel);
            Controls.Add(startDateTimePicker);
            Controls.Add(endDateLabel);
            Controls.Add(endDateTimePicker);
            Controls.Add(statusComboBoxField);
            Controls.Add(saveButton);
            HeaderText = "Assignment Editor";
            Name = "AssignmentEditorControl";
            Load += AssignmentEditorControl_Load;
            Controls.SetChildIndex(saveButton, 0);
            Controls.SetChildIndex(statusComboBoxField, 0);
            Controls.SetChildIndex(endDateTimePicker, 0);
            Controls.SetChildIndex(endDateLabel, 0);
            Controls.SetChildIndex(startDateTimePicker, 0);
            Controls.SetChildIndex(startDateLabel, 0);
            Controls.SetChildIndex(managerIdInputField, 0);
            Controls.SetChildIndex(requiredDocumentCountInputField, 0);
            Controls.SetChildIndex(isPublicToDepartmentCheckBox, 0);
            Controls.SetChildIndex(publicDepartmentLabel, 0);
            Controls.SetChildIndex(isPublicToProjectCheckBox, 0);
            Controls.SetChildIndex(publicProjectLabel, 0);
            Controls.SetChildIndex(projectComboBoxField, 0);
            Controls.SetChildIndex(assignmentNameInputField, 0);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private PeproLabel publicProjectLabel;
        private PeproLabel publicDepartmentLabel;
        private Button saveButton;
        private PeproInputField managerIdInputField;
        private PeproInputField assignmentNameInputField;
        private PeproComboBoxField statusComboBoxField;
        private CheckBox isPublicToProjectCheckBox;
        private CheckBox isPublicToDepartmentCheckBox;
        private PeproLabel startDateLabel;
        private DateTimePicker startDateTimePicker;
        private PeproLabel endDateLabel;
        private DateTimePicker endDateTimePicker;
        private PeproComboBoxField projectComboBoxField;
        private PeproInputField requiredDocumentCountInputField;
    }
}