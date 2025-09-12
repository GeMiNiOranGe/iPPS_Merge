using Pepro.Presentation.Controls.Atoms;
using Pepro.Presentation.Controls.Molecules;

namespace Pepro.Presentation.Controls.Pages
{
    partial class DocumentEditorPage
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
            projectIdTextBoxField = new TextBoxField();
            projectNameComboBoxField = new ComboBoxField();
            assignmentIdTextBoxField = new TextBoxField();
            assignmentNameComboBoxField = new ComboBoxField();
            documentIdTextBoxField = new TextBoxField();
            titleTextBoxField = new TextBoxField();
            preparedByTextBoxField = new TextBoxField();
            checkedByTextBoxField = new TextBoxField();
            approvedByTextBoxField = new TextBoxField();
            fileTypeTextBoxField = new TextBoxField();
            createdAtLabel = new PeproLabel();
            createdAtDateTimePicker = new DateTimePicker();
            revisionNumberTextBoxField = new TextBoxField();
            revisionStatusTextBoxField = new TextBoxField();
            filePathTextBoxField = new TextBoxField();
            browseButton = new Button();
            saveButton = new Button();
            SuspendLayout();
            // 
            // projectIdTextBoxField
            // 
            projectIdTextBoxField.Anchor = AnchorStyles.None;
            projectIdTextBoxField.Enabled = false;
            projectIdTextBoxField.ForeColor = Color.White;
            projectIdTextBoxField.LabelText = "Project id";
            projectIdTextBoxField.Location = new Point(16, 67);
            projectIdTextBoxField.Margin = new Padding(16, 16, 0, 24);
            projectIdTextBoxField.Name = "projectIdTextBoxField";
            projectIdTextBoxField.PlaceholderText = "e.g. project id";
            projectIdTextBoxField.Size = new Size(240, 48);
            projectIdTextBoxField.TabIndex = 1;
            projectIdTextBoxField.TabStop = false;
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
            // assignmentIdTextBoxField
            // 
            assignmentIdTextBoxField.Anchor = AnchorStyles.None;
            assignmentIdTextBoxField.Enabled = false;
            assignmentIdTextBoxField.ForeColor = Color.White;
            assignmentIdTextBoxField.LabelText = "Assignment id";
            assignmentIdTextBoxField.Location = new Point(16, 139);
            assignmentIdTextBoxField.Margin = new Padding(16, 0, 0, 24);
            assignmentIdTextBoxField.Name = "assignmentIdTextBoxField";
            assignmentIdTextBoxField.PlaceholderText = "e.g. assignment id";
            assignmentIdTextBoxField.Size = new Size(240, 48);
            assignmentIdTextBoxField.TabIndex = 3;
            assignmentIdTextBoxField.TabStop = false;
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
            // documentIdTextBoxField
            // 
            documentIdTextBoxField.Anchor = AnchorStyles.None;
            documentIdTextBoxField.Enabled = false;
            documentIdTextBoxField.ForeColor = Color.White;
            documentIdTextBoxField.LabelText = "Document id";
            documentIdTextBoxField.Location = new Point(16, 211);
            documentIdTextBoxField.Margin = new Padding(16, 0, 0, 24);
            documentIdTextBoxField.Name = "documentIdTextBoxField";
            documentIdTextBoxField.PlaceholderText = "e.g. document id";
            documentIdTextBoxField.Size = new Size(240, 48);
            documentIdTextBoxField.TabIndex = 5;
            documentIdTextBoxField.TabStop = false;
            // 
            // titleTextBoxField
            // 
            titleTextBoxField.Anchor = AnchorStyles.None;
            titleTextBoxField.ForeColor = Color.White;
            titleTextBoxField.LabelText = "Title";
            titleTextBoxField.Location = new Point(280, 211);
            titleTextBoxField.Margin = new Padding(24, 0, 16, 24);
            titleTextBoxField.Name = "titleTextBoxField";
            titleTextBoxField.PlaceholderText = "e.g. title";
            titleTextBoxField.Size = new Size(768, 48);
            titleTextBoxField.TabIndex = 6;
            // 
            // preparedByTextBoxField
            // 
            preparedByTextBoxField.Anchor = AnchorStyles.None;
            preparedByTextBoxField.ForeColor = Color.White;
            preparedByTextBoxField.LabelText = "Prepared by";
            preparedByTextBoxField.Location = new Point(16, 283);
            preparedByTextBoxField.Margin = new Padding(16, 0, 0, 24);
            preparedByTextBoxField.Name = "preparedByTextBoxField";
            preparedByTextBoxField.PlaceholderText = "e.g. Jessica";
            preparedByTextBoxField.Size = new Size(504, 48);
            preparedByTextBoxField.TabIndex = 7;
            // 
            // checkedByTextBoxField
            // 
            checkedByTextBoxField.Anchor = AnchorStyles.None;
            checkedByTextBoxField.ForeColor = Color.White;
            checkedByTextBoxField.LabelText = "Checked by";
            checkedByTextBoxField.Location = new Point(544, 283);
            checkedByTextBoxField.Margin = new Padding(24, 0, 16, 24);
            checkedByTextBoxField.Name = "checkedByTextBoxField";
            checkedByTextBoxField.PlaceholderText = "e.g. Mike";
            checkedByTextBoxField.Size = new Size(504, 48);
            checkedByTextBoxField.TabIndex = 8;
            // 
            // approvedByTextBoxField
            // 
            approvedByTextBoxField.Anchor = AnchorStyles.None;
            approvedByTextBoxField.ForeColor = Color.White;
            approvedByTextBoxField.LabelText = "Approved by";
            approvedByTextBoxField.Location = new Point(16, 355);
            approvedByTextBoxField.Margin = new Padding(16, 0, 0, 24);
            approvedByTextBoxField.Name = "approvedByTextBoxField";
            approvedByTextBoxField.PlaceholderText = "e.g. John";
            approvedByTextBoxField.Size = new Size(504, 48);
            approvedByTextBoxField.TabIndex = 9;
            // 
            // fileTypeTextBoxField
            // 
            fileTypeTextBoxField.Anchor = AnchorStyles.None;
            fileTypeTextBoxField.Enabled = false;
            fileTypeTextBoxField.ForeColor = Color.White;
            fileTypeTextBoxField.LabelText = "File type";
            fileTypeTextBoxField.Location = new Point(544, 355);
            fileTypeTextBoxField.Margin = new Padding(24, 0, 0, 24);
            fileTypeTextBoxField.Name = "fileTypeTextBoxField";
            fileTypeTextBoxField.PlaceholderText = "e.g. docx, xlsx, pptx";
            fileTypeTextBoxField.Size = new Size(240, 48);
            fileTypeTextBoxField.TabIndex = 10;
            fileTypeTextBoxField.TabStop = false;
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
            // revisionNumberTextBoxField
            // 
            revisionNumberTextBoxField.Anchor = AnchorStyles.None;
            revisionNumberTextBoxField.Enabled = false;
            revisionNumberTextBoxField.ForeColor = Color.White;
            revisionNumberTextBoxField.LabelText = "Revision number";
            revisionNumberTextBoxField.Location = new Point(16, 427);
            revisionNumberTextBoxField.Margin = new Padding(16, 0, 0, 24);
            revisionNumberTextBoxField.Name = "revisionNumberTextBoxField";
            revisionNumberTextBoxField.PlaceholderText = "e.g. 642837";
            revisionNumberTextBoxField.Size = new Size(240, 48);
            revisionNumberTextBoxField.TabIndex = 12;
            revisionNumberTextBoxField.TabStop = false;
            // 
            // revisionStatusTextBoxField
            // 
            revisionStatusTextBoxField.Anchor = AnchorStyles.None;
            revisionStatusTextBoxField.Enabled = false;
            revisionStatusTextBoxField.ForeColor = Color.White;
            revisionStatusTextBoxField.LabelText = "Revision status";
            revisionStatusTextBoxField.Location = new Point(280, 427);
            revisionStatusTextBoxField.Margin = new Padding(24, 0, 0, 24);
            revisionStatusTextBoxField.Name = "revisionStatusTextBoxField";
            revisionStatusTextBoxField.PlaceholderText = "e.g. latest";
            revisionStatusTextBoxField.Size = new Size(240, 48);
            revisionStatusTextBoxField.TabIndex = 13;
            revisionStatusTextBoxField.TabStop = false;
            // 
            // filePathTextBoxField
            // 
            filePathTextBoxField.Anchor = AnchorStyles.None;
            filePathTextBoxField.Enabled = false;
            filePathTextBoxField.ForeColor = Color.White;
            filePathTextBoxField.LabelText = "File path";
            filePathTextBoxField.Location = new Point(544, 427);
            filePathTextBoxField.Margin = new Padding(24, 0, 0, 24);
            filePathTextBoxField.Name = "filePathTextBoxField";
            filePathTextBoxField.PlaceholderText = "e.g. path/to/file.ext";
            filePathTextBoxField.Size = new Size(240, 48);
            filePathTextBoxField.TabIndex = 14;
            filePathTextBoxField.TabStop = false;
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
            // DocumentEditorPage
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(projectIdTextBoxField);
            Controls.Add(projectNameComboBoxField);
            Controls.Add(assignmentIdTextBoxField);
            Controls.Add(assignmentNameComboBoxField);
            Controls.Add(documentIdTextBoxField);
            Controls.Add(titleTextBoxField);
            Controls.Add(preparedByTextBoxField);
            Controls.Add(checkedByTextBoxField);
            Controls.Add(approvedByTextBoxField);
            Controls.Add(fileTypeTextBoxField);
            Controls.Add(createdAtLabel);
            Controls.Add(createdAtDateTimePicker);
            Controls.Add(revisionNumberTextBoxField);
            Controls.Add(revisionStatusTextBoxField);
            Controls.Add(filePathTextBoxField);
            Controls.Add(browseButton);
            Controls.Add(saveButton);
            HeaderText = "Document Editor";
            Name = "DocumentEditorPage";
            Load += DocumentEditorPage_Load;
            Controls.SetChildIndex(saveButton, 0);
            Controls.SetChildIndex(browseButton, 0);
            Controls.SetChildIndex(filePathTextBoxField, 0);
            Controls.SetChildIndex(revisionStatusTextBoxField, 0);
            Controls.SetChildIndex(revisionNumberTextBoxField, 0);
            Controls.SetChildIndex(createdAtDateTimePicker, 0);
            Controls.SetChildIndex(createdAtLabel, 0);
            Controls.SetChildIndex(fileTypeTextBoxField, 0);
            Controls.SetChildIndex(approvedByTextBoxField, 0);
            Controls.SetChildIndex(checkedByTextBoxField, 0);
            Controls.SetChildIndex(preparedByTextBoxField, 0);
            Controls.SetChildIndex(titleTextBoxField, 0);
            Controls.SetChildIndex(documentIdTextBoxField, 0);
            Controls.SetChildIndex(assignmentNameComboBoxField, 0);
            Controls.SetChildIndex(assignmentIdTextBoxField, 0);
            Controls.SetChildIndex(projectNameComboBoxField, 0);
            Controls.SetChildIndex(projectIdTextBoxField, 0);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private PeproLabel createdAtLabel;
        private Button saveButton;
        private Button browseButton;
        private DateTimePicker createdAtDateTimePicker;
        private TextBoxField fileTypeTextBoxField;
        private TextBoxField filePathTextBoxField;
        private TextBoxField projectIdTextBoxField;
        private TextBoxField checkedByTextBoxField;
        private TextBoxField titleTextBoxField;
        private TextBoxField approvedByTextBoxField;
        private TextBoxField preparedByTextBoxField;
        private TextBoxField documentIdTextBoxField;
        private TextBoxField assignmentIdTextBoxField;
        private TextBoxField revisionNumberTextBoxField;
        private TextBoxField revisionStatusTextBoxField;
        private ComboBoxField projectNameComboBoxField;
        private ComboBoxField assignmentNameComboBoxField;
    }
}