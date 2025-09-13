using Pepro.Presentation.Controls.Atoms;
using Pepro.Presentation.Controls.Molecules;

namespace Pepro.Presentation.Controls.Pages;

partial class DocumentPage
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
        documentIdTextBoxField = new TextBoxField();
        assignmentIdTextBoxField = new TextBoxField();
        assignmentNameTextBoxField = new TextBoxField();
        fileTypeTextBoxField = new TextBoxField();
        projectIdTextBoxField = new TextBoxField();
        projectNameTextBoxField = new TextBoxField();
        searchTextBox = new TextBox();
        searchButton = new Button();
        reloadButton = new Button();
        downloadButton = new Button();
        deleteButton = new Button();
        updateButton = new Button();
        insertButton = new Button();
        documentDataGridView = new PeproDataGridView();
        titleColumn = new DataGridViewTextBoxColumn();
        createAtColumn = new DataGridViewTextBoxColumn();
        revisionNumberColumn = new DataGridViewTextBoxColumn();
        revisionStatusColumn = new DataGridViewTextBoxColumn();
        documentUrlColumn = new DataGridViewTextBoxColumn();
        nativeFileFormatColumn = new DataGridViewTextBoxColumn();
        preparedByColumn = new DataGridViewTextBoxColumn();
        checkedByColumn = new DataGridViewTextBoxColumn();
        approvedByColumn = new DataGridViewTextBoxColumn();
        assignmentIdColumn = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)documentDataGridView).BeginInit();
        SuspendLayout();
        // 
        // documentIdTextBoxField
        // 
        documentIdTextBoxField.Enabled = false;
        documentIdTextBoxField.ForeColor = Color.White;
        documentIdTextBoxField.LabelText = "Document id";
        documentIdTextBoxField.Location = new Point(16, 64);
        documentIdTextBoxField.Margin = new Padding(16, 16, 0, 24);
        documentIdTextBoxField.Name = "documentIdTextBoxField";
        documentIdTextBoxField.PlaceholderText = "e.g. document id";
        documentIdTextBoxField.Size = new Size(240, 48);
        documentIdTextBoxField.TabIndex = 0;
        documentIdTextBoxField.TabStop = false;
        documentIdTextBoxField.TextChanged += DocumentIdTextBoxField_TextChanged;
        // 
        // assignmentIdTextBoxField
        // 
        assignmentIdTextBoxField.Enabled = false;
        assignmentIdTextBoxField.ForeColor = Color.White;
        assignmentIdTextBoxField.LabelText = "Assignment id";
        assignmentIdTextBoxField.Location = new Point(280, 64);
        assignmentIdTextBoxField.Margin = new Padding(24, 16, 0, 24);
        assignmentIdTextBoxField.Name = "assignmentIdTextBoxField";
        assignmentIdTextBoxField.PlaceholderText = "e.g. assignment id";
        assignmentIdTextBoxField.Size = new Size(240, 48);
        assignmentIdTextBoxField.TabIndex = 0;
        assignmentIdTextBoxField.TabStop = false;
        assignmentIdTextBoxField.TextChanged += AssignmentIdTextBoxField_TextChanged;
        // 
        // assignmentNameTextBoxField
        // 
        assignmentNameTextBoxField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        assignmentNameTextBoxField.Enabled = false;
        assignmentNameTextBoxField.ForeColor = Color.White;
        assignmentNameTextBoxField.LabelText = "Assignment name";
        assignmentNameTextBoxField.Location = new Point(544, 64);
        assignmentNameTextBoxField.Margin = new Padding(24, 16, 16, 24);
        assignmentNameTextBoxField.Name = "assignmentNameTextBoxField";
        assignmentNameTextBoxField.PlaceholderText = "e.g. assignment name";
        assignmentNameTextBoxField.Size = new Size(504, 48);
        assignmentNameTextBoxField.TabIndex = 0;
        assignmentNameTextBoxField.TabStop = false;
        // 
        // fileTypeTextBoxField
        // 
        fileTypeTextBoxField.Enabled = false;
        fileTypeTextBoxField.ForeColor = Color.White;
        fileTypeTextBoxField.LabelText = "File type";
        fileTypeTextBoxField.Location = new Point(16, 136);
        fileTypeTextBoxField.Margin = new Padding(16, 0, 0, 24);
        fileTypeTextBoxField.Name = "fileTypeTextBoxField";
        fileTypeTextBoxField.PlaceholderText = "e.g. docx, xlsx, pptx, ...";
        fileTypeTextBoxField.Size = new Size(240, 48);
        fileTypeTextBoxField.TabIndex = 0;
        fileTypeTextBoxField.TabStop = false;
        // 
        // projectIdTextBoxField
        // 
        projectIdTextBoxField.Enabled = false;
        projectIdTextBoxField.ForeColor = Color.White;
        projectIdTextBoxField.LabelText = "Project id";
        projectIdTextBoxField.Location = new Point(280, 136);
        projectIdTextBoxField.Margin = new Padding(24, 0, 0, 24);
        projectIdTextBoxField.Name = "projectIdTextBoxField";
        projectIdTextBoxField.PlaceholderText = "e.g. project id";
        projectIdTextBoxField.Size = new Size(240, 48);
        projectIdTextBoxField.TabIndex = 0;
        projectIdTextBoxField.TabStop = false;
        // 
        // projectNameTextBoxField
        // 
        projectNameTextBoxField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        projectNameTextBoxField.Enabled = false;
        projectNameTextBoxField.ForeColor = Color.White;
        projectNameTextBoxField.LabelText = "Project name";
        projectNameTextBoxField.Location = new Point(544, 136);
        projectNameTextBoxField.Margin = new Padding(24, 0, 16, 24);
        projectNameTextBoxField.Name = "projectNameTextBoxField";
        projectNameTextBoxField.PlaceholderText = "e.g. project name";
        projectNameTextBoxField.Size = new Size(504, 48);
        projectNameTextBoxField.TabIndex = 0;
        projectNameTextBoxField.TabStop = false;
        // 
        // searchTextBox
        // 
        searchTextBox.Location = new Point(16, 215);
        searchTextBox.Margin = new Padding(2);
        searchTextBox.Name = "searchTextBox";
        searchTextBox.PlaceholderText = "Search for document title, id, and assignment id";
        searchTextBox.Size = new Size(432, 26);
        searchTextBox.TabIndex = 1;
        // 
        // searchButton
        // 
        searchButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        searchButton.Location = new Point(466, 208);
        searchButton.Margin = new Padding(16, 0, 0, 0);
        searchButton.Name = "searchButton";
        searchButton.Size = new Size(40, 40);
        searchButton.TabIndex = 2;
        searchButton.Click += SearchButton_Click;
        // 
        // reloadButton
        // 
        reloadButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        reloadButton.Location = new Point(522, 208);
        reloadButton.Margin = new Padding(16, 0, 0, 0);
        reloadButton.Name = "reloadButton";
        reloadButton.Size = new Size(40, 40);
        reloadButton.TabIndex = 3;
        reloadButton.Click += ReloadButton_Click;
        // 
        // downloadButton
        // 
        downloadButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        downloadButton.Location = new Point(578, 208);
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
        deleteButton.Location = new Point(706, 208);
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
        updateButton.Location = new Point(834, 208);
        updateButton.Margin = new Padding(16, 0, 0, 0);
        updateButton.Name = "updateButton";
        updateButton.Padding = new Padding(12, 0, 12, 0);
        updateButton.Size = new Size(98, 40);
        updateButton.TabIndex = 5;
        updateButton.Text = " Edit";
        updateButton.Click += UpdateButton_Click;
        // 
        // insertButton
        // 
        insertButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        insertButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        insertButton.Location = new Point(948, 208);
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
        documentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        documentDataGridView.Columns.AddRange(new DataGridViewColumn[] { titleColumn, createAtColumn, revisionNumberColumn, revisionStatusColumn, documentUrlColumn, nativeFileFormatColumn, preparedByColumn, checkedByColumn, approvedByColumn, assignmentIdColumn });
        documentDataGridView.Location = new Point(16, 264);
        documentDataGridView.Margin = new Padding(16);
        documentDataGridView.Name = "documentDataGridView";
        documentDataGridView.Size = new Size(1032, 401);
        documentDataGridView.TabIndex = 8;
        documentDataGridView.CellClick += DocumentDataGridView_CellClick;
        // 
        // titleColumn
        // 
        titleColumn.DataPropertyName = "Title";
        titleColumn.HeaderText = "Tiêu đề";
        titleColumn.Name = "titleColumn";
        titleColumn.ReadOnly = true;
        titleColumn.Width = 59;
        // 
        // createAtColumn
        // 
        createAtColumn.DataPropertyName = "CreateAt";
        createAtColumn.HeaderText = "Ngày tạo";
        createAtColumn.Name = "createAtColumn";
        createAtColumn.ReadOnly = true;
        createAtColumn.Width = 83;
        // 
        // revisionNumberColumn
        // 
        revisionNumberColumn.DataPropertyName = "RevisionNumber";
        revisionNumberColumn.HeaderText = "Số sửa đổi";
        revisionNumberColumn.Name = "revisionNumberColumn";
        revisionNumberColumn.ReadOnly = true;
        revisionNumberColumn.Width = 89;
        // 
        // revisionStatusColumn
        // 
        revisionStatusColumn.DataPropertyName = "RevisionStatus";
        revisionStatusColumn.HeaderText = "Loại sửa đổi";
        revisionStatusColumn.Name = "revisionStatusColumn";
        revisionStatusColumn.ReadOnly = true;
        revisionStatusColumn.Width = 81;
        // 
        // documentUrlColumn
        // 
        documentUrlColumn.DataPropertyName = "DocumentUrl";
        documentUrlColumn.HeaderText = "Đường dẫn tài liệu";
        documentUrlColumn.Name = "documentUrlColumn";
        documentUrlColumn.ReadOnly = true;
        documentUrlColumn.Width = 115;
        // 
        // nativeFileFormatColumn
        // 
        nativeFileFormatColumn.DataPropertyName = "NativeFileFormat";
        nativeFileFormatColumn.HeaderText = "loại tệp gốc";
        nativeFileFormatColumn.Name = "nativeFileFormatColumn";
        nativeFileFormatColumn.ReadOnly = true;
        nativeFileFormatColumn.Width = 97;
        // 
        // preparedByColumn
        // 
        preparedByColumn.DataPropertyName = "PreparedBy";
        preparedByColumn.HeaderText = "Chuẩn bị bởi";
        preparedByColumn.Name = "preparedByColumn";
        preparedByColumn.ReadOnly = true;
        preparedByColumn.Width = 86;
        // 
        // checkedByColumn
        // 
        checkedByColumn.DataPropertyName = "CheckedBy";
        checkedByColumn.HeaderText = "Kiểm tra bởi";
        checkedByColumn.Name = "checkedByColumn";
        checkedByColumn.ReadOnly = true;
        checkedByColumn.Width = 82;
        // 
        // approvedByColumn
        // 
        approvedByColumn.DataPropertyName = "ApprovedBy";
        approvedByColumn.HeaderText = "Chấp thuận bởi";
        approvedByColumn.Name = "approvedByColumn";
        approvedByColumn.ReadOnly = true;
        approvedByColumn.Width = 101;
        // 
        // assignmentIdColumn
        // 
        assignmentIdColumn.DataPropertyName = "AssignmentId";
        assignmentIdColumn.HeaderText = "Mã nhiệm vụ";
        assignmentIdColumn.Name = "assignmentIdColumn";
        assignmentIdColumn.ReadOnly = true;
        assignmentIdColumn.Width = 92;
        // 
        // DocumentPage
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(documentIdTextBoxField);
        Controls.Add(assignmentIdTextBoxField);
        Controls.Add(assignmentNameTextBoxField);
        Controls.Add(fileTypeTextBoxField);
        Controls.Add(projectIdTextBoxField);
        Controls.Add(projectNameTextBoxField);
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
        Name = "DocumentPage";
        ReturnButtonVisible = false;
        Load += DocumentPage_Load;
        Controls.SetChildIndex(documentDataGridView, 0);
        Controls.SetChildIndex(insertButton, 0);
        Controls.SetChildIndex(updateButton, 0);
        Controls.SetChildIndex(deleteButton, 0);
        Controls.SetChildIndex(downloadButton, 0);
        Controls.SetChildIndex(reloadButton, 0);
        Controls.SetChildIndex(searchButton, 0);
        Controls.SetChildIndex(searchTextBox, 0);
        Controls.SetChildIndex(projectNameTextBoxField, 0);
        Controls.SetChildIndex(projectIdTextBoxField, 0);
        Controls.SetChildIndex(fileTypeTextBoxField, 0);
        Controls.SetChildIndex(assignmentNameTextBoxField, 0);
        Controls.SetChildIndex(assignmentIdTextBoxField, 0);
        Controls.SetChildIndex(documentIdTextBoxField, 0);
        ((System.ComponentModel.ISupportInitialize)documentDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private PeproDataGridView documentDataGridView;
    private Button insertButton;
    private Button deleteButton;
    private Button updateButton;
    private Button searchButton;
    private Button reloadButton;
    private Button downloadButton;
    private TextBox searchTextBox;
    private TextBoxField documentIdTextBoxField;
    private TextBoxField projectIdTextBoxField;
    private TextBoxField assignmentIdTextBoxField;
    private TextBoxField fileTypeTextBoxField;
    private TextBoxField projectNameTextBoxField;
    private TextBoxField assignmentNameTextBoxField;
    private DataGridViewTextBoxColumn titleColumn;
    private DataGridViewTextBoxColumn createAtColumn;
    private DataGridViewTextBoxColumn revisionNumberColumn;
    private DataGridViewTextBoxColumn revisionStatusColumn;
    private DataGridViewTextBoxColumn documentUrlColumn;
    private DataGridViewTextBoxColumn nativeFileFormatColumn;
    private DataGridViewTextBoxColumn preparedByColumn;
    private DataGridViewTextBoxColumn checkedByColumn;
    private DataGridViewTextBoxColumn approvedByColumn;
    private DataGridViewTextBoxColumn assignmentIdColumn;
}
