using Pepro.Presentation.Controls.Atoms;

namespace Pepro.Presentation.Controls.Pages;

partial class ProjectPage
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
        projectDataGridView = new PeproDataGridView();
        insertButton = new Button();
        updateButton = new Button();
        deleteButton = new Button();
        reloadButton = new Button();
        searchButton = new Button();
        searchTextBox = new TextBox();
        projectNameColumn = new DataGridViewTextBoxColumn();
        customerNameColumn = new DataGridViewTextBoxColumn();
        managerColumn = new DataGridViewTextBoxColumn();
        startDateColumn = new DataGridViewTextBoxColumn();
        endDateColumn = new DataGridViewTextBoxColumn();
        statusNameColumn = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)projectDataGridView).BeginInit();
        SuspendLayout();
        // 
        // projectDataGridView
        // 
        projectDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        projectDataGridView.Columns.AddRange(new DataGridViewColumn[] { projectNameColumn, customerNameColumn, managerColumn, startDateColumn, endDateColumn, statusNameColumn });
        projectDataGridView.Location = new Point(16, 123);
        projectDataGridView.Margin = new Padding(16);
        projectDataGridView.Name = "projectDataGridView";
        projectDataGridView.Size = new Size(1032, 542);
        projectDataGridView.TabIndex = 7;
        projectDataGridView.CellClick += ProjectDataGridView_CellClick;
        // 
        // insertButton
        // 
        insertButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        insertButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        insertButton.Location = new Point(948, 67);
        insertButton.Margin = new Padding(16, 16, 0, 0);
        insertButton.Name = "insertButton";
        insertButton.Padding = new Padding(12, 0, 12, 0);
        insertButton.Size = new Size(100, 40);
        insertButton.TabIndex = 6;
        insertButton.Text = " Add";
        insertButton.Click += InsertButton_Click;
        // 
        // updateButton
        // 
        updateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        updateButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        updateButton.Location = new Point(834, 67);
        updateButton.Margin = new Padding(16, 16, 0, 0);
        updateButton.Name = "updateButton";
        updateButton.Padding = new Padding(12, 0, 12, 0);
        updateButton.Size = new Size(98, 40);
        updateButton.TabIndex = 5;
        updateButton.Text = " Edit";
        updateButton.Click += UpdateButton_Click;
        // 
        // deleteButton
        // 
        deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        deleteButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        deleteButton.Location = new Point(706, 67);
        deleteButton.Margin = new Padding(16, 16, 0, 0);
        deleteButton.Name = "deleteButton";
        deleteButton.Padding = new Padding(12, 0, 12, 0);
        deleteButton.Size = new Size(112, 40);
        deleteButton.TabIndex = 4;
        deleteButton.Text = " Delete";
        deleteButton.Click += DeleteButton_Click;
        // 
        // reloadButton
        // 
        reloadButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        reloadButton.Location = new Point(522, 67);
        reloadButton.Margin = new Padding(16, 16, 0, 0);
        reloadButton.Name = "reloadButton";
        reloadButton.Size = new Size(40, 40);
        reloadButton.TabIndex = 3;
        reloadButton.Click += ReloadButton_Click;
        // 
        // searchButton
        // 
        searchButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        searchButton.Location = new Point(466, 67);
        searchButton.Margin = new Padding(16, 16, 0, 0);
        searchButton.Name = "searchButton";
        searchButton.Size = new Size(40, 40);
        searchButton.TabIndex = 2;
        searchButton.Click += SearchButton_Click;
        // 
        // searchTextBox
        // 
        searchTextBox.Location = new Point(16, 75);
        searchTextBox.Margin = new Padding(3, 2, 3, 2);
        searchTextBox.Name = "searchTextBox";
        searchTextBox.PlaceholderText = "Search for customer name, project id or name";
        searchTextBox.Size = new Size(431, 26);
        searchTextBox.TabIndex = 1;
        // 
        // projectNameColumn
        // 
        projectNameColumn.DataPropertyName = "Name";
        projectNameColumn.HeaderText = "Project name";
        projectNameColumn.Name = "projectNameColumn";
        projectNameColumn.ReadOnly = true;
        projectNameColumn.Width = 114;
        // 
        // customerNameColumn
        // 
        customerNameColumn.DataPropertyName = "CustomerName";
        customerNameColumn.HeaderText = "Customer name";
        customerNameColumn.Name = "customerNameColumn";
        customerNameColumn.ReadOnly = true;
        customerNameColumn.Width = 132;
        // 
        // managerColumn
        // 
        managerColumn.DataPropertyName = "ManagerFullName";
        managerColumn.HeaderText = "Manager";
        managerColumn.Name = "managerColumn";
        managerColumn.ReadOnly = true;
        managerColumn.Width = 89;
        // 
        // startDateColumn
        // 
        startDateColumn.DataPropertyName = "StartDate";
        startDateColumn.HeaderText = "Start date";
        startDateColumn.Name = "startDateColumn";
        startDateColumn.ReadOnly = true;
        startDateColumn.Width = 94;
        // 
        // endDateColumn
        // 
        endDateColumn.DataPropertyName = "EndDate";
        endDateColumn.HeaderText = "End date";
        endDateColumn.Name = "endDateColumn";
        endDateColumn.ReadOnly = true;
        endDateColumn.Width = 88;
        // 
        // statusNameColumn
        // 
        statusNameColumn.DataPropertyName = "StatusName";
        statusNameColumn.HeaderText = "Status";
        statusNameColumn.Name = "statusNameColumn";
        statusNameColumn.ReadOnly = true;
        statusNameColumn.Width = 72;
        // 
        // ProjectPage
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(searchTextBox);
        Controls.Add(searchButton);
        Controls.Add(reloadButton);
        Controls.Add(deleteButton);
        Controls.Add(updateButton);
        Controls.Add(insertButton);
        Controls.Add(projectDataGridView);
        HeaderText = "Project";
        Name = "ProjectPage";
        ReturnButtonVisible = false;
        Load += ProjectPage_Load;
        Controls.SetChildIndex(projectDataGridView, 0);
        Controls.SetChildIndex(insertButton, 0);
        Controls.SetChildIndex(updateButton, 0);
        Controls.SetChildIndex(deleteButton, 0);
        Controls.SetChildIndex(reloadButton, 0);
        Controls.SetChildIndex(searchButton, 0);
        Controls.SetChildIndex(searchTextBox, 0);
        ((System.ComponentModel.ISupportInitialize)projectDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private PeproDataGridView projectDataGridView;
    private Button insertButton;
    private Button updateButton;
    private Button deleteButton;
    private Button reloadButton;
    private Button searchButton;
    private TextBox searchTextBox;
    private DataGridViewTextBoxColumn projectNameColumn;
    private DataGridViewTextBoxColumn customerNameColumn;
    private DataGridViewTextBoxColumn managerColumn;
    private DataGridViewTextBoxColumn startDateColumn;
    private DataGridViewTextBoxColumn endDateColumn;
    private DataGridViewTextBoxColumn statusNameColumn;
}
