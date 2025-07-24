using Pepro.Presentation.Controls;

namespace Pepro.Presentation
{
    partial class DocumentEditorForm
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
            createdAtDateTimePicker = new DateTimePicker();
            browseButton = new Button();
            headerLabel = new Label();
            saveButton = new Button();
            createdAtLabel = new Label();
            fileTypeInputField = new PeproInputField();
            filePathInputField = new PeproInputField();
            projectIdInputField = new PeproInputField();
            checkedByInputField = new PeproInputField();
            titleInputField = new PeproInputField();
            approvedByInputField = new PeproInputField();
            preparedByInputField = new PeproInputField();
            documentIdInputField = new PeproInputField();
            taskIdInputField = new PeproInputField();
            projectNameComboBoxField = new PeproComboBoxField();
            taskNameComboBoxField = new PeproComboBoxField();
            revisionNumberInputField = new PeproInputField();
            revisionStatusInputField = new PeproInputField();
            SuspendLayout();
            // 
            // createdAtDateTimePicker
            // 
            createdAtDateTimePicker.Anchor = AnchorStyles.None;
            createdAtDateTimePicker.Checked = false;
            createdAtDateTimePicker.Location = new Point(777, 436);
            createdAtDateTimePicker.Margin = new Padding(24, 8, 16, 16);
            createdAtDateTimePicker.Name = "createdAtDateTimePicker";
            createdAtDateTimePicker.Size = new Size(224, 26);
            createdAtDateTimePicker.TabIndex = 191;
            // 
            // browseButton
            // 
            browseButton.Anchor = AnchorStyles.None;
            browseButton.BackColor = Color.FromArgb(34, 130, 253);
            browseButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            browseButton.ForeColor = Color.Black;
            browseButton.Location = new Point(777, 498);
            browseButton.Margin = new Padding(8);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(96, 47);
            browseButton.TabIndex = 185;
            browseButton.Text = "Browse";
            browseButton.UseVisualStyleBackColor = false;
            browseButton.Click += BrowseButton_Click;
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
            headerLabel.TabIndex = 182;
            headerLabel.Text = "Header Text";
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.None;
            saveButton.BackColor = Color.FromArgb(34, 130, 253);
            saveButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveButton.ForeColor = Color.Black;
            saveButton.Location = new Point(905, 498);
            saveButton.Margin = new Padding(8);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(96, 47);
            saveButton.TabIndex = 172;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += SaveButton_Click;
            // 
            // createdAtLabel
            // 
            createdAtLabel.Anchor = AnchorStyles.None;
            createdAtLabel.AutoSize = true;
            createdAtLabel.ForeColor = Color.White;
            createdAtLabel.Location = new Point(777, 408);
            createdAtLabel.Margin = new Padding(16, 24, 8, 0);
            createdAtLabel.Name = "createdAtLabel";
            createdAtLabel.Size = new Size(38, 19);
            createdAtLabel.TabIndex = 144;
            createdAtLabel.Text = "Date";
            // 
            // fileTypeInputField
            // 
            fileTypeInputField.Anchor = AnchorStyles.None;
            fileTypeInputField.ForeColor = Color.White;
            fileTypeInputField.InputEnabled = false;
            fileTypeInputField.LabelText = "File type";
            fileTypeInputField.Location = new Point(529, 408);
            fileTypeInputField.Margin = new Padding(0);
            fileTypeInputField.Name = "fileTypeInputField";
            fileTypeInputField.PlaceholderText = "e.g. docx, xlsx, pptx";
            fileTypeInputField.Size = new Size(224, 54);
            fileTypeInputField.TabIndex = 193;
            // 
            // filePathInputField
            // 
            filePathInputField.Anchor = AnchorStyles.None;
            filePathInputField.ForeColor = Color.White;
            filePathInputField.InputEnabled = false;
            filePathInputField.LabelText = "File path";
            filePathInputField.Location = new Point(529, 494);
            filePathInputField.Margin = new Padding(0);
            filePathInputField.Name = "filePathInputField";
            filePathInputField.PlaceholderText = "e.g. path/to/file.ext";
            filePathInputField.Size = new Size(224, 54);
            filePathInputField.TabIndex = 194;
            // 
            // projectIdInputField
            // 
            projectIdInputField.Anchor = AnchorStyles.None;
            projectIdInputField.ForeColor = Color.White;
            projectIdInputField.InputEnabled = false;
            projectIdInputField.LabelText = "Project id";
            projectIdInputField.Location = new Point(25, 64);
            projectIdInputField.Margin = new Padding(16, 16, 0, 16);
            projectIdInputField.Name = "projectIdInputField";
            projectIdInputField.PlaceholderText = "e.g. project id";
            projectIdInputField.Size = new Size(224, 54);
            projectIdInputField.TabIndex = 195;
            // 
            // checkedByInputField
            // 
            checkedByInputField.Anchor = AnchorStyles.None;
            checkedByInputField.ForeColor = Color.White;
            checkedByInputField.LabelText = "Checked by";
            checkedByInputField.Location = new Point(529, 322);
            checkedByInputField.Margin = new Padding(24, 16, 0, 16);
            checkedByInputField.Name = "checkedByInputField";
            checkedByInputField.PlaceholderText = "e.g. Mike";
            checkedByInputField.Size = new Size(472, 54);
            checkedByInputField.TabIndex = 196;
            // 
            // titleInputField
            // 
            titleInputField.Anchor = AnchorStyles.None;
            titleInputField.ForeColor = Color.White;
            titleInputField.LabelText = "Title";
            titleInputField.Location = new Point(273, 236);
            titleInputField.Margin = new Padding(24, 16, 16, 16);
            titleInputField.Name = "titleInputField";
            titleInputField.PlaceholderText = "e.g. title";
            titleInputField.Size = new Size(728, 54);
            titleInputField.TabIndex = 197;
            // 
            // approvedByInputField
            // 
            approvedByInputField.Anchor = AnchorStyles.None;
            approvedByInputField.ForeColor = Color.White;
            approvedByInputField.LabelText = "Approved by";
            approvedByInputField.Location = new Point(25, 408);
            approvedByInputField.Margin = new Padding(16, 16, 0, 16);
            approvedByInputField.Name = "approvedByInputField";
            approvedByInputField.PlaceholderText = "e.g. John";
            approvedByInputField.Size = new Size(472, 54);
            approvedByInputField.TabIndex = 198;
            // 
            // preparedByInputField
            // 
            preparedByInputField.Anchor = AnchorStyles.None;
            preparedByInputField.ForeColor = Color.White;
            preparedByInputField.LabelText = "Prepared by";
            preparedByInputField.Location = new Point(25, 322);
            preparedByInputField.Margin = new Padding(16, 16, 0, 16);
            preparedByInputField.Name = "preparedByInputField";
            preparedByInputField.PlaceholderText = "e.g. Jessica";
            preparedByInputField.Size = new Size(472, 54);
            preparedByInputField.TabIndex = 199;
            // 
            // documentIdInputField
            // 
            documentIdInputField.Anchor = AnchorStyles.None;
            documentIdInputField.ForeColor = Color.White;
            documentIdInputField.InputEnabled = false;
            documentIdInputField.LabelText = "Document id";
            documentIdInputField.Location = new Point(25, 236);
            documentIdInputField.Margin = new Padding(16, 16, 0, 16);
            documentIdInputField.Name = "documentIdInputField";
            documentIdInputField.PlaceholderText = "e.g. document id";
            documentIdInputField.Size = new Size(224, 54);
            documentIdInputField.TabIndex = 200;
            // 
            // taskIdInputField
            // 
            taskIdInputField.Anchor = AnchorStyles.None;
            taskIdInputField.ForeColor = Color.White;
            taskIdInputField.InputEnabled = false;
            taskIdInputField.LabelText = "Task id";
            taskIdInputField.Location = new Point(25, 150);
            taskIdInputField.Margin = new Padding(16, 16, 0, 16);
            taskIdInputField.Name = "taskIdInputField";
            taskIdInputField.PlaceholderText = "e.g. task id";
            taskIdInputField.Size = new Size(224, 54);
            taskIdInputField.TabIndex = 201;
            // 
            // projectNameComboBoxField
            // 
            projectNameComboBoxField.Anchor = AnchorStyles.None;
            projectNameComboBoxField.ForeColor = Color.White;
            projectNameComboBoxField.LabelText = "Project name";
            projectNameComboBoxField.Location = new Point(273, 64);
            projectNameComboBoxField.Margin = new Padding(24, 16, 16, 16);
            projectNameComboBoxField.Name = "projectNameComboBoxField";
            projectNameComboBoxField.Size = new Size(728, 56);
            projectNameComboBoxField.TabIndex = 202;
            projectNameComboBoxField.SelectedIndexChanged += ProjectNameComboBoxField_SelectedIndexChanged;
            // 
            // taskNameComboBoxField
            // 
            taskNameComboBoxField.Anchor = AnchorStyles.None;
            taskNameComboBoxField.ForeColor = Color.White;
            taskNameComboBoxField.LabelText = "Task name";
            taskNameComboBoxField.Location = new Point(273, 152);
            taskNameComboBoxField.Margin = new Padding(24, 16, 16, 16);
            taskNameComboBoxField.Name = "taskNameComboBoxField";
            taskNameComboBoxField.Size = new Size(728, 56);
            taskNameComboBoxField.TabIndex = 202;
            // 
            // revisionNumberInputField
            // 
            revisionNumberInputField.Anchor = AnchorStyles.None;
            revisionNumberInputField.ForeColor = Color.White;
            revisionNumberInputField.InputEnabled = false;
            revisionNumberInputField.LabelText = "Revision number";
            revisionNumberInputField.Location = new Point(25, 494);
            revisionNumberInputField.Margin = new Padding(24, 16, 0, 16);
            revisionNumberInputField.Name = "revisionNumberInputField";
            revisionNumberInputField.PlaceholderText = "e.g. 642837";
            revisionNumberInputField.Size = new Size(224, 54);
            revisionNumberInputField.TabIndex = 202;
            // 
            // revisionStatusInputField
            // 
            revisionStatusInputField.Anchor = AnchorStyles.None;
            revisionStatusInputField.ForeColor = Color.White;
            revisionStatusInputField.InputEnabled = false;
            revisionStatusInputField.LabelText = "Revision status";
            revisionStatusInputField.Location = new Point(273, 494);
            revisionStatusInputField.Margin = new Padding(24, 16, 16, 16);
            revisionStatusInputField.Name = "revisionStatusInputField";
            revisionStatusInputField.PlaceholderText = "e.g. latest";
            revisionStatusInputField.Size = new Size(224, 54);
            revisionStatusInputField.TabIndex = 202;
            // 
            // DocumentEditorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1064, 681);
            Controls.Add(headerLabel);
            Controls.Add(taskIdInputField);
            Controls.Add(taskNameComboBoxField);
            Controls.Add(projectIdInputField);
            Controls.Add(projectNameComboBoxField);
            Controls.Add(documentIdInputField);
            Controls.Add(titleInputField);
            Controls.Add(revisionNumberInputField);
            Controls.Add(revisionStatusInputField);
            Controls.Add(preparedByInputField);
            Controls.Add(checkedByInputField);
            Controls.Add(filePathInputField);
            Controls.Add(fileTypeInputField);
            Controls.Add(approvedByInputField);
            Controls.Add(createdAtLabel);
            Controls.Add(createdAtDateTimePicker);
            Controls.Add(saveButton);
            Controls.Add(browseButton);
            Margin = new Padding(2);
            Name = "DocumentEditorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInsert";
            Load += FormInsert_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Label createdAtLabel;
        private Button saveButton;
        private Label headerLabel;
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
        private PeproInputField taskIdInputField;
        private PeproInputField revisionNumberInputField;
        private PeproInputField revisionStatusInputField;
        private PeproComboBoxField projectNameComboBoxField;
        private PeproComboBoxField taskNameComboBoxField;
    }
}