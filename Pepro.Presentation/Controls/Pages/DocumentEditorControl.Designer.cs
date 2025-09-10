using Pepro.Presentation.Controls.Atoms;
using Pepro.Presentation.Controls.Molecules;

namespace Pepro.Presentation.Controls.Pages
{
    partial class DocumentEditorControl
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
            projectIdInputField = new PeproInputField();
            projectNameComboBoxField = new PeproComboBoxField();
            assignmentIdInputField = new PeproInputField();
            assignmentNameComboBoxField = new PeproComboBoxField();
            documentIdInputField = new PeproInputField();
            titleInputField = new PeproInputField();
            preparedByInputField = new PeproInputField();
            checkedByInputField = new PeproInputField();
            approvedByInputField = new PeproInputField();
            fileTypeInputField = new PeproInputField();
            createdAtLabel = new PeproLabel();
            createdAtDateTimePicker = new DateTimePicker();
            revisionNumberInputField = new PeproInputField();
            revisionStatusInputField = new PeproInputField();
            filePathInputField = new PeproInputField();
            browseButton = new Button();
            saveButton = new Button();
            SuspendLayout();
            // 
            // projectIdInputField
            // 
            projectIdInputField.Anchor = AnchorStyles.None;
            projectIdInputField.Enabled = false;
            projectIdInputField.ForeColor = Color.White;
            projectIdInputField.LabelText = "Project id";
            projectIdInputField.Location = new Point(16, 67);
            projectIdInputField.Margin = new Padding(16, 16, 0, 24);
            projectIdInputField.Name = "projectIdInputField";
            projectIdInputField.PlaceholderText = "e.g. project id";
            projectIdInputField.Size = new Size(240, 48);
            projectIdInputField.TabIndex = 1;
            projectIdInputField.TabStop = false;
            // 
            // projectNameComboBoxField
            // 
            projectNameComboBoxField.Anchor = AnchorStyles.None;
            projectNameComboBoxField.ForeColor = Color.White;
            projectNameComboBoxField.LabelText = "Project name";
            projectNameComboBoxField.Location = new Point(280, 64);
            projectNameComboBoxField.Margin = new Padding(24, 16, 16, 24);
            projectNameComboBoxField.Name = "projectNameComboBoxField";
            projectNameComboBoxField.Size = new Size(768, 48);
            projectNameComboBoxField.TabIndex = 2;
            projectNameComboBoxField.SelectedIndexChanged += ProjectNameComboBoxField_SelectedIndexChanged;
            // 
            // assignmentIdInputField
            // 
            assignmentIdInputField.Anchor = AnchorStyles.None;
            assignmentIdInputField.Enabled = false;
            assignmentIdInputField.ForeColor = Color.White;
            assignmentIdInputField.LabelText = "Assignment id";
            assignmentIdInputField.Location = new Point(16, 139);
            assignmentIdInputField.Margin = new Padding(16, 0, 0, 24);
            assignmentIdInputField.Name = "assignmentIdInputField";
            assignmentIdInputField.PlaceholderText = "e.g. assignment id";
            assignmentIdInputField.Size = new Size(240, 48);
            assignmentIdInputField.TabIndex = 3;
            assignmentIdInputField.TabStop = false;
            // 
            // assignmentNameComboBoxField
            // 
            assignmentNameComboBoxField.Anchor = AnchorStyles.None;
            assignmentNameComboBoxField.ForeColor = Color.White;
            assignmentNameComboBoxField.LabelText = "Assignment name";
            assignmentNameComboBoxField.Location = new Point(280, 139);
            assignmentNameComboBoxField.Margin = new Padding(24, 0, 16, 24);
            assignmentNameComboBoxField.Name = "assignmentNameComboBoxField";
            assignmentNameComboBoxField.Size = new Size(768, 48);
            assignmentNameComboBoxField.TabIndex = 4;
            // 
            // documentIdInputField
            // 
            documentIdInputField.Anchor = AnchorStyles.None;
            documentIdInputField.Enabled = false;
            documentIdInputField.ForeColor = Color.White;
            documentIdInputField.LabelText = "Document id";
            documentIdInputField.Location = new Point(16, 211);
            documentIdInputField.Margin = new Padding(16, 0, 0, 24);
            documentIdInputField.Name = "documentIdInputField";
            documentIdInputField.PlaceholderText = "e.g. document id";
            documentIdInputField.Size = new Size(240, 48);
            documentIdInputField.TabIndex = 5;
            documentIdInputField.TabStop = false;
            // 
            // titleInputField
            // 
            titleInputField.Anchor = AnchorStyles.None;
            titleInputField.ForeColor = Color.White;
            titleInputField.LabelText = "Title";
            titleInputField.Location = new Point(280, 211);
            titleInputField.Margin = new Padding(24, 0, 16, 24);
            titleInputField.Name = "titleInputField";
            titleInputField.PlaceholderText = "e.g. title";
            titleInputField.Size = new Size(768, 48);
            titleInputField.TabIndex = 6;
            // 
            // preparedByInputField
            // 
            preparedByInputField.Anchor = AnchorStyles.None;
            preparedByInputField.ForeColor = Color.White;
            preparedByInputField.LabelText = "Prepared by";
            preparedByInputField.Location = new Point(16, 283);
            preparedByInputField.Margin = new Padding(16, 0, 0, 24);
            preparedByInputField.Name = "preparedByInputField";
            preparedByInputField.PlaceholderText = "e.g. Jessica";
            preparedByInputField.Size = new Size(504, 48);
            preparedByInputField.TabIndex = 7;
            // 
            // checkedByInputField
            // 
            checkedByInputField.Anchor = AnchorStyles.None;
            checkedByInputField.ForeColor = Color.White;
            checkedByInputField.LabelText = "Checked by";
            checkedByInputField.Location = new Point(544, 283);
            checkedByInputField.Margin = new Padding(24, 0, 16, 24);
            checkedByInputField.Name = "checkedByInputField";
            checkedByInputField.PlaceholderText = "e.g. Mike";
            checkedByInputField.Size = new Size(504, 48);
            checkedByInputField.TabIndex = 8;
            // 
            // approvedByInputField
            // 
            approvedByInputField.Anchor = AnchorStyles.None;
            approvedByInputField.ForeColor = Color.White;
            approvedByInputField.LabelText = "Approved by";
            approvedByInputField.Location = new Point(16, 355);
            approvedByInputField.Margin = new Padding(16, 0, 0, 24);
            approvedByInputField.Name = "approvedByInputField";
            approvedByInputField.PlaceholderText = "e.g. John";
            approvedByInputField.Size = new Size(504, 48);
            approvedByInputField.TabIndex = 9;
            // 
            // fileTypeInputField
            // 
            fileTypeInputField.Anchor = AnchorStyles.None;
            fileTypeInputField.Enabled = false;
            fileTypeInputField.ForeColor = Color.White;
            fileTypeInputField.LabelText = "File type";
            fileTypeInputField.Location = new Point(544, 355);
            fileTypeInputField.Margin = new Padding(24, 0, 0, 24);
            fileTypeInputField.Name = "fileTypeInputField";
            fileTypeInputField.PlaceholderText = "e.g. docx, xlsx, pptx";
            fileTypeInputField.Size = new Size(240, 48);
            fileTypeInputField.TabIndex = 10;
            fileTypeInputField.TabStop = false;
            // 
            // createdAtLabel
            // 
            createdAtLabel.Anchor = AnchorStyles.None;
            createdAtLabel.AutoSize = true;
            createdAtLabel.ForeColor = Color.White;
            createdAtLabel.Location = new Point(808, 355);
            createdAtLabel.Margin = new Padding(16, 24, 8, 0);
            createdAtLabel.Name = "createdAtLabel";
            createdAtLabel.Size = new Size(29, 14);
            createdAtLabel.TabIndex = 0;
            createdAtLabel.Text = "Date";
            // 
            // createdAtDateTimePicker
            // 
            createdAtDateTimePicker.Anchor = AnchorStyles.None;
            createdAtDateTimePicker.Checked = false;
            createdAtDateTimePicker.Location = new Point(808, 377);
            createdAtDateTimePicker.Margin = new Padding(24, 8, 16, 16);
            createdAtDateTimePicker.Name = "createdAtDateTimePicker";
            createdAtDateTimePicker.Size = new Size(240, 26);
            createdAtDateTimePicker.TabIndex = 11;
            // 
            // revisionNumberInputField
            // 
            revisionNumberInputField.Anchor = AnchorStyles.None;
            revisionNumberInputField.Enabled = false;
            revisionNumberInputField.ForeColor = Color.White;
            revisionNumberInputField.LabelText = "Revision number";
            revisionNumberInputField.Location = new Point(16, 427);
            revisionNumberInputField.Margin = new Padding(16, 0, 0, 24);
            revisionNumberInputField.Name = "revisionNumberInputField";
            revisionNumberInputField.PlaceholderText = "e.g. 642837";
            revisionNumberInputField.Size = new Size(240, 48);
            revisionNumberInputField.TabIndex = 12;
            revisionNumberInputField.TabStop = false;
            // 
            // revisionStatusInputField
            // 
            revisionStatusInputField.Anchor = AnchorStyles.None;
            revisionStatusInputField.Enabled = false;
            revisionStatusInputField.ForeColor = Color.White;
            revisionStatusInputField.LabelText = "Revision status";
            revisionStatusInputField.Location = new Point(280, 427);
            revisionStatusInputField.Margin = new Padding(24, 0, 0, 24);
            revisionStatusInputField.Name = "revisionStatusInputField";
            revisionStatusInputField.PlaceholderText = "e.g. latest";
            revisionStatusInputField.Size = new Size(240, 48);
            revisionStatusInputField.TabIndex = 13;
            revisionStatusInputField.TabStop = false;
            // 
            // filePathInputField
            // 
            filePathInputField.Anchor = AnchorStyles.None;
            filePathInputField.Enabled = false;
            filePathInputField.ForeColor = Color.White;
            filePathInputField.LabelText = "File path";
            filePathInputField.Location = new Point(544, 427);
            filePathInputField.Margin = new Padding(24, 0, 0, 24);
            filePathInputField.Name = "filePathInputField";
            filePathInputField.PlaceholderText = "e.g. path/to/file.ext";
            filePathInputField.Size = new Size(240, 48);
            filePathInputField.TabIndex = 14;
            filePathInputField.TabStop = false;
            // 
            // browseButton
            // 
            browseButton.Anchor = AnchorStyles.None;
            browseButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            browseButton.Location = new Point(808, 431);
            browseButton.Margin = new Padding(16);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(104, 40);
            browseButton.TabIndex = 15;
            browseButton.Text = "Browse";
            browseButton.Click += BrowseButton_Click;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.None;
            saveButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            saveButton.Location = new Point(472, 584);
            saveButton.Margin = new Padding(16);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(120, 56);
            saveButton.TabIndex = 16;
            saveButton.Text = "Save";
            saveButton.Click += SaveButton_Click;
            // 
            // DocumentEditorControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(projectIdInputField);
            Controls.Add(projectNameComboBoxField);
            Controls.Add(assignmentIdInputField);
            Controls.Add(assignmentNameComboBoxField);
            Controls.Add(documentIdInputField);
            Controls.Add(titleInputField);
            Controls.Add(preparedByInputField);
            Controls.Add(checkedByInputField);
            Controls.Add(approvedByInputField);
            Controls.Add(fileTypeInputField);
            Controls.Add(createdAtLabel);
            Controls.Add(createdAtDateTimePicker);
            Controls.Add(revisionNumberInputField);
            Controls.Add(revisionStatusInputField);
            Controls.Add(filePathInputField);
            Controls.Add(browseButton);
            Controls.Add(saveButton);
            HeaderText = "Document Editor";
            Name = "DocumentEditorControl";
            Load += DocumentEditorControl_Load;
            Controls.SetChildIndex(saveButton, 0);
            Controls.SetChildIndex(browseButton, 0);
            Controls.SetChildIndex(filePathInputField, 0);
            Controls.SetChildIndex(revisionStatusInputField, 0);
            Controls.SetChildIndex(revisionNumberInputField, 0);
            Controls.SetChildIndex(createdAtDateTimePicker, 0);
            Controls.SetChildIndex(createdAtLabel, 0);
            Controls.SetChildIndex(fileTypeInputField, 0);
            Controls.SetChildIndex(approvedByInputField, 0);
            Controls.SetChildIndex(checkedByInputField, 0);
            Controls.SetChildIndex(preparedByInputField, 0);
            Controls.SetChildIndex(titleInputField, 0);
            Controls.SetChildIndex(documentIdInputField, 0);
            Controls.SetChildIndex(assignmentNameComboBoxField, 0);
            Controls.SetChildIndex(assignmentIdInputField, 0);
            Controls.SetChildIndex(projectNameComboBoxField, 0);
            Controls.SetChildIndex(projectIdInputField, 0);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private PeproLabel createdAtLabel;
        private Button saveButton;
        private Button browseButton;
        private DateTimePicker createdAtDateTimePicker;
        private PeproInputField fileTypeInputField;
        private PeproInputField filePathInputField;
        private PeproInputField projectIdInputField;
        private PeproInputField checkedByInputField;
        private PeproInputField titleInputField;
        private PeproInputField approvedByInputField;
        private PeproInputField preparedByInputField;
        private PeproInputField documentIdInputField;
        private PeproInputField assignmentIdInputField;
        private PeproInputField revisionNumberInputField;
        private PeproInputField revisionStatusInputField;
        private PeproComboBoxField projectNameComboBoxField;
        private PeproComboBoxField assignmentNameComboBoxField;
    }
}