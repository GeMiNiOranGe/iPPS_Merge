namespace Pepro.Presentation.Controls
{
    partial class ProjectEditorControl
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
            startDateTimePicker = new DateTimePicker();
            startDateLabel = new PeproLabel();
            endDateLabel = new PeproLabel();
            endDateTimePicker = new DateTimePicker();
            projectNameInputField = new PeproInputField();
            statusComboBoxField = new PeproComboBoxField();
            customerNameInputField = new PeproInputField();
            managerComboBoxField = new PeproComboBoxField();
            saveButton = new Button();
            SuspendLayout();
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.Anchor = AnchorStyles.None;
            startDateTimePicker.Location = new Point(544, 233);
            startDateTimePicker.Margin = new Padding(24, 0, 0, 16);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(240, 26);
            startDateTimePicker.TabIndex = 8;
            // 
            // startDateLabel
            // 
            startDateLabel.Anchor = AnchorStyles.None;
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new Point(544, 211);
            startDateLabel.Margin = new Padding(24, 16, 0, 0);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(60, 14);
            startDateLabel.TabIndex = 0;
            startDateLabel.Text = "Start date";
            // 
            // endDateLabel
            // 
            endDateLabel.Anchor = AnchorStyles.None;
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new Point(808, 211);
            endDateLabel.Margin = new Padding(24, 16, 0, 0);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(54, 14);
            endDateLabel.TabIndex = 0;
            endDateLabel.Text = "End date";
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Anchor = AnchorStyles.None;
            endDateTimePicker.Location = new Point(808, 233);
            endDateTimePicker.Margin = new Padding(24, 0, 16, 16);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(240, 26);
            endDateTimePicker.TabIndex = 9;
            // 
            // projectNameInputField
            // 
            projectNameInputField.Anchor = AnchorStyles.None;
            projectNameInputField.LabelText = "Project name";
            projectNameInputField.Location = new Point(16, 67);
            projectNameInputField.Margin = new Padding(16, 16, 16, 24);
            projectNameInputField.Name = "projectNameInputField";
            projectNameInputField.PlaceholderText = "e.g. project name";
            projectNameInputField.Size = new Size(1032, 48);
            projectNameInputField.TabIndex = 19;
            // 
            // statusComboBoxField
            // 
            statusComboBoxField.Anchor = AnchorStyles.None;
            statusComboBoxField.LabelText = "Status";
            statusComboBoxField.Location = new Point(280, 211);
            statusComboBoxField.Margin = new Padding(24, 0, 0, 24);
            statusComboBoxField.Name = "statusComboBoxField";
            statusComboBoxField.Size = new Size(240, 48);
            statusComboBoxField.TabIndex = 20;
            // 
            // customerNameInputField
            // 
            customerNameInputField.Anchor = AnchorStyles.None;
            customerNameInputField.LabelText = "Customer name";
            customerNameInputField.Location = new Point(16, 139);
            customerNameInputField.Margin = new Padding(16, 0, 16, 24);
            customerNameInputField.Name = "customerNameInputField";
            customerNameInputField.PlaceholderText = "e.g. customer name";
            customerNameInputField.Size = new Size(1032, 48);
            customerNameInputField.TabIndex = 19;
            // 
            // managerComboBoxField
            // 
            managerComboBoxField.Anchor = AnchorStyles.None;
            managerComboBoxField.LabelText = "Manager id";
            managerComboBoxField.Location = new Point(16, 211);
            managerComboBoxField.Margin = new Padding(16, 0, 0, 24);
            managerComboBoxField.Name = "managerComboBoxField";
            managerComboBoxField.Size = new Size(240, 48);
            managerComboBoxField.TabIndex = 19;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.None;
            saveButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            saveButton.Location = new Point(472, 504);
            saveButton.Margin = new Padding(16);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(120, 56);
            saveButton.TabIndex = 21;
            saveButton.Text = "Save";
            saveButton.Click += SaveButton_Click;
            // 
            // ProjectEditorControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(projectNameInputField);
            Controls.Add(customerNameInputField);
            Controls.Add(managerComboBoxField);
            Controls.Add(statusComboBoxField);
            Controls.Add(startDateLabel);
            Controls.Add(startDateTimePicker);
            Controls.Add(endDateLabel);
            Controls.Add(endDateTimePicker);
            Controls.Add(saveButton);
            HeaderText = "Project Editor";
            Name = "ProjectEditorControl";
            Load += ProjectEditorControl_Load;
            Controls.SetChildIndex(saveButton, 0);
            Controls.SetChildIndex(endDateTimePicker, 0);
            Controls.SetChildIndex(endDateLabel, 0);
            Controls.SetChildIndex(startDateTimePicker, 0);
            Controls.SetChildIndex(startDateLabel, 0);
            Controls.SetChildIndex(statusComboBoxField, 0);
            Controls.SetChildIndex(managerComboBoxField, 0);
            Controls.SetChildIndex(customerNameInputField, 0);
            Controls.SetChildIndex(projectNameInputField, 0);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private DateTimePicker startDateTimePicker;
        private PeproLabel startDateLabel;
        private PeproLabel endDateLabel;
        private DateTimePicker endDateTimePicker;
        private PeproInputField projectNameInputField;
        private PeproComboBoxField statusComboBoxField;
        private PeproInputField customerNameInputField;
        private PeproComboBoxField managerComboBoxField;
        private Button saveButton;
    }
}