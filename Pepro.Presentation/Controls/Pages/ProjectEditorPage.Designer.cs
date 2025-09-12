using Pepro.Presentation.Controls.Atoms;
using Pepro.Presentation.Controls.Molecules;

namespace Pepro.Presentation.Controls.Pages
{
    partial class ProjectEditorPage
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
            projectNameTextBoxField = new TextBoxField();
            statusComboBoxField = new ComboBoxField();
            customerNameTextBoxField = new TextBoxField();
            managerComboBoxField = new ComboBoxField();
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
            startDateTimePicker.TabIndex = 5;
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
            endDateTimePicker.TabIndex = 6;
            // 
            // projectNameTextBoxField
            // 
            projectNameTextBoxField.Anchor = AnchorStyles.None;
            projectNameTextBoxField.LabelText = "Project name";
            projectNameTextBoxField.Location = new Point(16, 67);
            projectNameTextBoxField.Margin = new Padding(16, 16, 16, 24);
            projectNameTextBoxField.Name = "projectNameTextBoxField";
            projectNameTextBoxField.PlaceholderText = "e.g. project name";
            projectNameTextBoxField.Size = new Size(1032, 48);
            projectNameTextBoxField.TabIndex = 1;
            // 
            // statusComboBoxField
            // 
            statusComboBoxField.Anchor = AnchorStyles.None;
            statusComboBoxField.LabelText = "Status";
            statusComboBoxField.Location = new Point(280, 211);
            statusComboBoxField.Margin = new Padding(24, 0, 0, 24);
            statusComboBoxField.Name = "statusComboBoxField";
            statusComboBoxField.Size = new Size(240, 48);
            statusComboBoxField.TabIndex = 4;
            // 
            // customerNameTextBoxField
            // 
            customerNameTextBoxField.Anchor = AnchorStyles.None;
            customerNameTextBoxField.LabelText = "Customer name";
            customerNameTextBoxField.Location = new Point(16, 139);
            customerNameTextBoxField.Margin = new Padding(16, 0, 16, 24);
            customerNameTextBoxField.Name = "customerNameTextBoxField";
            customerNameTextBoxField.PlaceholderText = "e.g. customer name";
            customerNameTextBoxField.Size = new Size(1032, 48);
            customerNameTextBoxField.TabIndex = 2;
            // 
            // managerComboBoxField
            // 
            managerComboBoxField.Anchor = AnchorStyles.None;
            managerComboBoxField.LabelText = "Manager id";
            managerComboBoxField.Location = new Point(16, 211);
            managerComboBoxField.Margin = new Padding(16, 0, 0, 24);
            managerComboBoxField.Name = "managerComboBoxField";
            managerComboBoxField.Size = new Size(240, 48);
            managerComboBoxField.TabIndex = 3;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.None;
            saveButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            saveButton.Location = new Point(472, 504);
            saveButton.Margin = new Padding(16);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(120, 56);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save";
            saveButton.Click += SaveButton_Click;
            // 
            // ProjectEditorPage
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(projectNameTextBoxField);
            Controls.Add(customerNameTextBoxField);
            Controls.Add(managerComboBoxField);
            Controls.Add(statusComboBoxField);
            Controls.Add(startDateLabel);
            Controls.Add(startDateTimePicker);
            Controls.Add(endDateLabel);
            Controls.Add(endDateTimePicker);
            Controls.Add(saveButton);
            HeaderText = "Project Editor";
            Name = "ProjectEditorPage";
            Load += ProjectEditorPage_Load;
            Controls.SetChildIndex(saveButton, 0);
            Controls.SetChildIndex(endDateTimePicker, 0);
            Controls.SetChildIndex(endDateLabel, 0);
            Controls.SetChildIndex(startDateTimePicker, 0);
            Controls.SetChildIndex(startDateLabel, 0);
            Controls.SetChildIndex(statusComboBoxField, 0);
            Controls.SetChildIndex(managerComboBoxField, 0);
            Controls.SetChildIndex(customerNameTextBoxField, 0);
            Controls.SetChildIndex(projectNameTextBoxField, 0);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private DateTimePicker startDateTimePicker;
        private PeproLabel startDateLabel;
        private PeproLabel endDateLabel;
        private DateTimePicker endDateTimePicker;
        private TextBoxField projectNameTextBoxField;
        private ComboBoxField statusComboBoxField;
        private TextBoxField customerNameTextBoxField;
        private ComboBoxField managerComboBoxField;
        private Button saveButton;
    }
}