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
            insertButton = new Button();
            deleteButton = new Button();
            editButton = new Button();
            downloadButton = new Button();
            reloadButton = new Button();
            searchButton = new Button();
            searchTextBox = new TextBox();
            documentIdInputField = new PeproInputField();
            projectIdInputField = new PeproInputField();
            taskIdInputField = new PeproInputField();
            fileTypeInputField = new PeproInputField();
            projectNameInputField = new PeproInputField();
            taskNameInputField = new PeproInputField();
            ((System.ComponentModel.ISupportInitialize)documentDataGridView).BeginInit();
            SuspendLayout();
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
            documentDataGridView.Location = new Point(16, 280);
            documentDataGridView.Margin = new Padding(16);
            documentDataGridView.Name = "documentDataGridView";
            documentDataGridView.ReadOnly = true;
            documentDataGridView.RowHeadersVisible = false;
            documentDataGridView.RowHeadersWidth = 51;
            documentDataGridView.RowTemplate.Height = 24;
            documentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            documentDataGridView.Size = new Size(1032, 385);
            documentDataGridView.TabIndex = 0;
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
            // insertButton
            // 
            insertButton.BackColor = Color.FromArgb(34, 130, 253);
            insertButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            insertButton.Location = new Point(445, 215);
            insertButton.Margin = new Padding(2);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(65, 47);
            insertButton.TabIndex = 4;
            insertButton.Text = "Thêm";
            insertButton.UseVisualStyleBackColor = false;
            insertButton.Click += InsertButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FromArgb(34, 130, 253);
            deleteButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            deleteButton.Location = new Point(627, 215);
            deleteButton.Margin = new Padding(2);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(65, 47);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Xoá";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += DeleteButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = Color.FromArgb(34, 130, 253);
            editButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            editButton.Location = new Point(538, 215);
            editButton.Margin = new Padding(2);
            editButton.Name = "editButton";
            editButton.Size = new Size(65, 47);
            editButton.TabIndex = 5;
            editButton.Text = "Sửa";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += EditButton_Click;
            // 
            // downloadButton
            // 
            downloadButton.BackColor = Color.FromArgb(34, 130, 253);
            downloadButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            downloadButton.Location = new Point(715, 215);
            downloadButton.Margin = new Padding(2);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size(122, 47);
            downloadButton.TabIndex = 7;
            downloadButton.Text = "Download";
            downloadButton.UseVisualStyleBackColor = false;
            downloadButton.Click += DownloadButton_Click;
            // 
            // reloadButton
            // 
            reloadButton.BackColor = Color.FromArgb(34, 130, 253);
            reloadButton.FlatStyle = FlatStyle.Flat;
            reloadButton.Image = Properties.Resources.reload;
            reloadButton.Location = new Point(392, 223);
            reloadButton.Margin = new Padding(2);
            reloadButton.Name = "reloadButton";
            reloadButton.Size = new Size(32, 32);
            reloadButton.TabIndex = 3;
            reloadButton.UseVisualStyleBackColor = false;
            reloadButton.Click += ReloadButton_Click;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(34, 130, 253);
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Image = Properties.Resources.search;
            searchButton.Location = new Point(347, 223);
            searchButton.Margin = new Padding(2);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(32, 32);
            searchButton.TabIndex = 2;
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += SearchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.BorderStyle = BorderStyle.None;
            searchTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTextBox.Location = new Point(16, 232);
            searchTextBox.Margin = new Padding(2);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Search for document title, id, and task id";
            searchTextBox.Size = new Size(316, 19);
            searchTextBox.TabIndex = 1;
            // 
            // documentIdInputField
            // 
            documentIdInputField.ForeColor = Color.White;
            documentIdInputField.InputEnabled = false;
            documentIdInputField.LabelText = "Document id";
            documentIdInputField.Location = new Point(16, 64);
            documentIdInputField.Margin = new Padding(16, 16, 0, 24);
            documentIdInputField.Name = "documentIdInputField";
            documentIdInputField.PlaceholderText = "e.g. document id";
            documentIdInputField.Size = new Size(192, 54);
            documentIdInputField.TabIndex = 0;
            documentIdInputField.TextChanged += DocumentIdInputField_TextChanged;
            // 
            // projectIdInputField
            // 
            projectIdInputField.ForeColor = Color.White;
            projectIdInputField.InputEnabled = false;
            projectIdInputField.LabelText = "Project id";
            projectIdInputField.Location = new Point(232, 142);
            projectIdInputField.Margin = new Padding(24, 0, 0, 0);
            projectIdInputField.Name = "projectIdInputField";
            projectIdInputField.PlaceholderText = "e.g. project id";
            projectIdInputField.Size = new Size(192, 54);
            projectIdInputField.TabIndex = 0;
            // 
            // taskIdInputField
            // 
            taskIdInputField.ForeColor = Color.White;
            taskIdInputField.InputEnabled = false;
            taskIdInputField.LabelText = "Task id";
            taskIdInputField.Location = new Point(232, 64);
            taskIdInputField.Margin = new Padding(24, 16, 0, 24);
            taskIdInputField.Name = "taskIdInputField";
            taskIdInputField.PlaceholderText = "e.g. task id";
            taskIdInputField.Size = new Size(192, 54);
            taskIdInputField.TabIndex = 0;
            taskIdInputField.TextChanged += TaskIdInputField_TextChanged;
            // 
            // fileTypeInputField
            // 
            fileTypeInputField.ForeColor = Color.White;
            fileTypeInputField.InputEnabled = false;
            fileTypeInputField.LabelText = "File type";
            fileTypeInputField.Location = new Point(16, 142);
            fileTypeInputField.Margin = new Padding(16, 0, 0, 0);
            fileTypeInputField.Name = "fileTypeInputField";
            fileTypeInputField.PlaceholderText = "e.g. docx, xlsx, pptx, ...";
            fileTypeInputField.Size = new Size(192, 54);
            fileTypeInputField.TabIndex = 0;
            // 
            // projectNameInputField
            // 
            projectNameInputField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            projectNameInputField.ForeColor = Color.White;
            projectNameInputField.InputEnabled = false;
            projectNameInputField.LabelText = "Project name";
            projectNameInputField.Location = new Point(448, 142);
            projectNameInputField.Margin = new Padding(24, 0, 16, 0);
            projectNameInputField.Name = "projectNameInputField";
            projectNameInputField.PlaceholderText = "e.g. project name";
            projectNameInputField.Size = new Size(600, 54);
            projectNameInputField.TabIndex = 0;
            // 
            // taskNameInputField
            // 
            taskNameInputField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            taskNameInputField.ForeColor = Color.White;
            taskNameInputField.InputEnabled = false;
            taskNameInputField.LabelText = "Task name";
            taskNameInputField.Location = new Point(448, 64);
            taskNameInputField.Margin = new Padding(24, 16, 16, 24);
            taskNameInputField.Name = "taskNameInputField";
            taskNameInputField.PlaceholderText = "e.g. task name";
            taskNameInputField.Size = new Size(600, 54);
            taskNameInputField.TabIndex = 0;
            // 
            // DocumentControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(documentDataGridView);
            Controls.Add(downloadButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(insertButton);
            Controls.Add(reloadButton);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(projectNameInputField);
            Controls.Add(projectIdInputField);
            Controls.Add(fileTypeInputField);
            Controls.Add(taskNameInputField);
            Controls.Add(taskIdInputField);
            Controls.Add(documentIdInputField);
            HeaderText = "Document";
            Margin = new Padding(2);
            Name = "DocumentControl";
            ReturnButtonVisible = false;
            Load += DocumentControl_Load;
            Controls.SetChildIndex(documentIdInputField, 0);
            Controls.SetChildIndex(taskIdInputField, 0);
            Controls.SetChildIndex(taskNameInputField, 0);
            Controls.SetChildIndex(fileTypeInputField, 0);
            Controls.SetChildIndex(projectIdInputField, 0);
            Controls.SetChildIndex(projectNameInputField, 0);
            Controls.SetChildIndex(searchTextBox, 0);
            Controls.SetChildIndex(searchButton, 0);
            Controls.SetChildIndex(reloadButton, 0);
            Controls.SetChildIndex(insertButton, 0);
            Controls.SetChildIndex(editButton, 0);
            Controls.SetChildIndex(deleteButton, 0);
            Controls.SetChildIndex(downloadButton, 0);
            Controls.SetChildIndex(documentDataGridView, 0);
            ((System.ComponentModel.ISupportInitialize)documentDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private DataGridView documentDataGridView;
        private Button insertButton;
        private Button deleteButton;
        private Button editButton;
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