namespace Pepro.Presentation.Controls
{
    partial class DocumentControl
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
            documentIdInputField = new PeproInputField();
            taskIdInputField = new PeproInputField();
            taskNameInputField = new PeproInputField();
            fileTypeInputField = new PeproInputField();
            projectIdInputField = new PeproInputField();
            projectNameInputField = new PeproInputField();
            searchTextBox = new TextBox();
            searchButton = new Button();
            reloadButton = new Button();
            downloadButton = new Button();
            deleteButton = new Button();
            updateButton = new Button();
            insertButton = new Button();
            documentDataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)documentDataGridView).BeginInit();
            SuspendLayout();
            // 
            // documentIdInputField
            // 
            documentIdInputField.Enabled = false;
            documentIdInputField.ForeColor = Color.White;
            documentIdInputField.LabelText = "Document id";
            documentIdInputField.Location = new Point(16, 64);
            documentIdInputField.Margin = new Padding(16, 16, 0, 24);
            documentIdInputField.Name = "documentIdInputField";
            documentIdInputField.PlaceholderText = "e.g. document id";
            documentIdInputField.Size = new Size(240, 54);
            documentIdInputField.TabIndex = 0;
            documentIdInputField.TabStop = false;
            documentIdInputField.TextChanged += DocumentIdInputField_TextChanged;
            // 
            // taskIdInputField
            // 
            taskIdInputField.Enabled = false;
            taskIdInputField.ForeColor = Color.White;
            taskIdInputField.LabelText = "Task id";
            taskIdInputField.Location = new Point(280, 64);
            taskIdInputField.Margin = new Padding(24, 16, 0, 24);
            taskIdInputField.Name = "taskIdInputField";
            taskIdInputField.PlaceholderText = "e.g. task id";
            taskIdInputField.Size = new Size(240, 54);
            taskIdInputField.TabIndex = 0;
            taskIdInputField.TabStop = false;
            taskIdInputField.TextChanged += TaskIdInputField_TextChanged;
            // 
            // taskNameInputField
            // 
            taskNameInputField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            taskNameInputField.Enabled = false;
            taskNameInputField.ForeColor = Color.White;
            taskNameInputField.LabelText = "Task name";
            taskNameInputField.Location = new Point(544, 64);
            taskNameInputField.Margin = new Padding(24, 16, 16, 24);
            taskNameInputField.Name = "taskNameInputField";
            taskNameInputField.PlaceholderText = "e.g. task name";
            taskNameInputField.Size = new Size(504, 54);
            taskNameInputField.TabIndex = 0;
            taskNameInputField.TabStop = false;
            // 
            // fileTypeInputField
            // 
            fileTypeInputField.Enabled = false;
            fileTypeInputField.ForeColor = Color.White;
            fileTypeInputField.LabelText = "File type";
            fileTypeInputField.Location = new Point(16, 142);
            fileTypeInputField.Margin = new Padding(16, 0, 0, 16);
            fileTypeInputField.Name = "fileTypeInputField";
            fileTypeInputField.PlaceholderText = "e.g. docx, xlsx, pptx, ...";
            fileTypeInputField.Size = new Size(240, 54);
            fileTypeInputField.TabIndex = 0;
            fileTypeInputField.TabStop = false;
            // 
            // projectIdInputField
            // 
            projectIdInputField.Enabled = false;
            projectIdInputField.ForeColor = Color.White;
            projectIdInputField.LabelText = "Project id";
            projectIdInputField.Location = new Point(280, 142);
            projectIdInputField.Margin = new Padding(24, 0, 0, 16);
            projectIdInputField.Name = "projectIdInputField";
            projectIdInputField.PlaceholderText = "e.g. project id";
            projectIdInputField.Size = new Size(240, 54);
            projectIdInputField.TabIndex = 0;
            projectIdInputField.TabStop = false;
            // 
            // projectNameInputField
            // 
            projectNameInputField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            projectNameInputField.Enabled = false;
            projectNameInputField.ForeColor = Color.White;
            projectNameInputField.LabelText = "Project name";
            projectNameInputField.Location = new Point(544, 142);
            projectNameInputField.Margin = new Padding(24, 0, 16, 16);
            projectNameInputField.Name = "projectNameInputField";
            projectNameInputField.PlaceholderText = "e.g. project name";
            projectNameInputField.Size = new Size(504, 54);
            projectNameInputField.TabIndex = 0;
            projectNameInputField.TabStop = false;
            // 
            // searchTextBox
            // 
            searchTextBox.BorderStyle = BorderStyle.None;
            searchTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTextBox.Location = new Point(16, 224);
            searchTextBox.Margin = new Padding(2);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Search for document title, id, and task id";
            searchTextBox.Size = new Size(432, 19);
            searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            searchButton.Location = new Point(466, 212);
            searchButton.Margin = new Padding(16, 0, 0, 0);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(40, 40);
            searchButton.TabIndex = 2;
            searchButton.Click += SearchButton_Click;
            // 
            // reloadButton
            // 
            reloadButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            reloadButton.Location = new Point(522, 212);
            reloadButton.Margin = new Padding(16, 0, 0, 0);
            reloadButton.Name = "reloadButton";
            reloadButton.Size = new Size(40, 40);
            reloadButton.TabIndex = 3;
            reloadButton.Click += ReloadButton_Click;
            // 
            // downloadButton
            // 
            downloadButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            downloadButton.Location = new Point(578, 212);
            downloadButton.Margin = new Padding(16, 0, 0, 0);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size(112, 40);
            downloadButton.TabIndex = 7;
            downloadButton.Text = "Download";
            downloadButton.Click += DownloadButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            deleteButton.Location = new Point(706, 212);
            deleteButton.Margin = new Padding(16, 0, 0, 0);
            deleteButton.Name = "deleteButton";
            deleteButton.Padding = new Padding(12, 0, 12, 0);
            deleteButton.Size = new Size(112, 40);
            deleteButton.TabIndex = 6;
            deleteButton.Text = " Delete";
            deleteButton.Click += DeleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            updateButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            updateButton.Location = new Point(834, 212);
            updateButton.Margin = new Padding(16, 0, 0, 0);
            updateButton.Name = "updateButton";
            updateButton.Padding = new Padding(12, 0, 12, 0);
            updateButton.Size = new Size(98, 40);
            updateButton.TabIndex = 5;
            updateButton.Text = " Edit";
            updateButton.Click += EditButton_Click;
            // 
            // insertButton
            // 
            insertButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            insertButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            insertButton.Location = new Point(948, 212);
            insertButton.Margin = new Padding(16, 0, 0, 0);
            insertButton.Name = "insertButton";
            insertButton.Padding = new Padding(12, 0, 12, 0);
            insertButton.Size = new Size(100, 40);
            insertButton.TabIndex = 4;
            insertButton.Text = " Add";
            insertButton.Click += InsertButton_Click;
            // 
            // documentDataGridView
            // 
            documentDataGridView.AllowUserToAddRows = false;
            documentDataGridView.AllowUserToDeleteRows = false;
            documentDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            documentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            documentDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            documentDataGridView.BackgroundColor = Color.FromArgb(15, 15, 15);
            documentDataGridView.BorderStyle = BorderStyle.Fixed3D;
            documentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            documentDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11 });
            documentDataGridView.EnableHeadersVisualStyles = false;
            documentDataGridView.Location = new Point(16, 268);
            documentDataGridView.Margin = new Padding(16);
            documentDataGridView.Name = "documentDataGridView";
            documentDataGridView.ReadOnly = true;
            documentDataGridView.RowHeadersVisible = false;
            documentDataGridView.RowHeadersWidth = 51;
            documentDataGridView.RowTemplate.Height = 24;
            documentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            documentDataGridView.Size = new Size(1032, 397);
            documentDataGridView.TabIndex = 8;
            documentDataGridView.CellClick += DocumentDataGridView_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "DocumentId";
            Column1.HeaderText = "Mã";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 54;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Title";
            Column2.HeaderText = "Tiêu đề";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 59;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "CreateAt";
            Column3.HeaderText = "Ngày tạo";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 83;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "RevisionNumber";
            Column4.HeaderText = "Số sửa đổi";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 89;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "RevisionStatus";
            Column5.HeaderText = "Loại sửa đổi";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 81;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "DocumentUrl";
            Column6.HeaderText = "Đường dẫn tài liệu";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 115;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "NativeFileFormat";
            Column7.HeaderText = "loại tệp gốc";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 97;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "PreparedBy";
            Column8.HeaderText = "Chuẩn bị bởi";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 86;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "CheckedBy";
            Column9.HeaderText = "Kiểm tra bởi";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 82;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "ApprovedBy";
            Column10.HeaderText = "Chấp thuận bởi";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 101;
            // 
            // Column11
            // 
            Column11.DataPropertyName = "TaskId";
            Column11.HeaderText = "Mã nhiệm vụ";
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            Column11.Width = 92;
            // 
            // DocumentControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(documentIdInputField);
            Controls.Add(taskIdInputField);
            Controls.Add(taskNameInputField);
            Controls.Add(fileTypeInputField);
            Controls.Add(projectIdInputField);
            Controls.Add(projectNameInputField);
            Controls.Add(searchTextBox);
            Controls.Add(searchButton);
            Controls.Add(reloadButton);
            Controls.Add(downloadButton);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(insertButton);
            Controls.Add(documentDataGridView);
            HeaderText = "Document";
            Margin = new Padding(2);
            Name = "DocumentControl";
            ReturnButtonVisible = false;
            Load += DocumentControl_Load;
            Controls.SetChildIndex(documentDataGridView, 0);
            Controls.SetChildIndex(insertButton, 0);
            Controls.SetChildIndex(updateButton, 0);
            Controls.SetChildIndex(deleteButton, 0);
            Controls.SetChildIndex(downloadButton, 0);
            Controls.SetChildIndex(reloadButton, 0);
            Controls.SetChildIndex(searchButton, 0);
            Controls.SetChildIndex(searchTextBox, 0);
            Controls.SetChildIndex(projectNameInputField, 0);
            Controls.SetChildIndex(projectIdInputField, 0);
            Controls.SetChildIndex(fileTypeInputField, 0);
            Controls.SetChildIndex(taskNameInputField, 0);
            Controls.SetChildIndex(taskIdInputField, 0);
            Controls.SetChildIndex(documentIdInputField, 0);
            ((System.ComponentModel.ISupportInitialize)documentDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private DataGridView documentDataGridView;
        private Button insertButton;
        private Button deleteButton;
        private Button updateButton;
        private Button searchButton;
        private Button reloadButton;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private Button downloadButton;
        private TextBox searchTextBox;
        private PeproInputField documentIdInputField;
        private PeproInputField projectIdInputField;
        private PeproInputField taskIdInputField;
        private PeproInputField fileTypeInputField;
        private PeproInputField projectNameInputField;
        private PeproInputField taskNameInputField;
    }
}