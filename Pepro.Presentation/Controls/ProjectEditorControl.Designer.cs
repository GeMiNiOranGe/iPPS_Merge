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
        private void InitializeComponent() {
            startDateTimePicker = new DateTimePicker();
            startDateLabel = new Label();
            endDateLabel = new Label();
            endDateTimePicker = new DateTimePicker();
            projectNameInputField = new PeproInputField();
            statusComboBoxField = new PeproComboBoxField();
            customerNameInputField = new PeproInputField();
            managerIdInputField = new PeproInputField();
            saveButton = new Button();
            SuspendLayout();
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.Anchor = AnchorStyles.None;
            startDateTimePicker.Location = new Point(544, 232);
            startDateTimePicker.Margin = new Padding(24, 0, 0, 16);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(240, 26);
            startDateTimePicker.TabIndex = 8;
            // 
            // startDateLabel
            // 
            startDateLabel.Anchor = AnchorStyles.None;
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new Point(544, 204);
            startDateLabel.Margin = new Padding(24, 16, 0, 0);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(69, 19);
            startDateLabel.TabIndex = 0;
            startDateLabel.Text = "Start date";
            // 
            // endDateLabel
            // 
            endDateLabel.Anchor = AnchorStyles.None;
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new Point(808, 204);
            endDateLabel.Margin = new Padding(24, 16, 0, 0);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(63, 19);
            endDateLabel.TabIndex = 0;
            endDateLabel.Text = "End date";
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Anchor = AnchorStyles.None;
            endDateTimePicker.Location = new Point(808, 232);
            endDateTimePicker.Margin = new Padding(24, 0, 16, 16);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(240, 26);
            endDateTimePicker.TabIndex = 9;
            // 
            // projectNameInputField
            // 
            projectNameInputField.Anchor = AnchorStyles.None;
            projectNameInputField.LabelText = "Project name";
            projectNameInputField.Location = new Point(16, 64);
            projectNameInputField.Margin = new Padding(16, 16, 16, 0);
            projectNameInputField.Name = "projectNameInputField";
            projectNameInputField.PlaceholderText = "e.g. project name";
            projectNameInputField.Size = new Size(1032, 54);
            projectNameInputField.TabIndex = 19;
            // 
            // statusComboBoxField
            // 
            statusComboBoxField.Anchor = AnchorStyles.None;
            statusComboBoxField.LabelText = "Status";
            statusComboBoxField.Location = new Point(280, 204);
            statusComboBoxField.Margin = new Padding(24, 16, 0, 16);
            statusComboBoxField.Name = "statusComboBoxField";
            statusComboBoxField.Size = new Size(240, 56);
            statusComboBoxField.TabIndex = 20;
            // 
            // customerNameInputField
            // 
            customerNameInputField.Anchor = AnchorStyles.None;
            customerNameInputField.LabelText = "Customer name";
            customerNameInputField.Location = new Point(16, 134);
            customerNameInputField.Margin = new Padding(16, 16, 16, 0);
            customerNameInputField.Name = "customerNameInputField";
            customerNameInputField.PlaceholderText = "e.g. customer name";
            customerNameInputField.Size = new Size(1032, 54);
            customerNameInputField.TabIndex = 19;
            // 
            // managerIdInputField
            // 
            managerIdInputField.Anchor = AnchorStyles.None;
            managerIdInputField.LabelText = "Manager id";
            managerIdInputField.Location = new Point(16, 204);
            managerIdInputField.Margin = new Padding(16, 16, 0, 0);
            managerIdInputField.Name = "managerIdInputField";
            managerIdInputField.PlaceholderText = "e.g. manager id";
            managerIdInputField.Size = new Size(240, 54);
            managerIdInputField.TabIndex = 19;
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
            Controls.Add(managerIdInputField);
            Controls.Add(statusComboBoxField);
            Controls.Add(startDateLabel);
            Controls.Add(startDateTimePicker);
            Controls.Add(endDateLabel);
            Controls.Add(endDateTimePicker);
            Controls.Add(saveButton);
            HeaderText = "Project Editor";
            Name = "ProjectEditorControl";
            Controls.SetChildIndex(saveButton, 0);
            Controls.SetChildIndex(endDateTimePicker, 0);
            Controls.SetChildIndex(endDateLabel, 0);
            Controls.SetChildIndex(startDateTimePicker, 0);
            Controls.SetChildIndex(startDateLabel, 0);
            Controls.SetChildIndex(statusComboBoxField, 0);
            Controls.SetChildIndex(managerIdInputField, 0);
            Controls.SetChildIndex(customerNameInputField, 0);
            Controls.SetChildIndex(projectNameInputField, 0);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        public DateTimePicker startDateTimePicker;
        private Label startDateLabel;
        private Label endDateLabel;
        public DateTimePicker endDateTimePicker;
        private PeproInputField projectNameInputField;
        private PeproComboBoxField statusComboBoxField;
        private PeproInputField customerNameInputField;
        private PeproInputField managerIdInputField;
        private Button saveButton;
    }
}