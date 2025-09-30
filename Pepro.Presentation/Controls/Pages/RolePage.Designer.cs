using Pepro.Presentation.Controls.Atoms;

namespace Pepro.Presentation.Controls.Pages;

partial class RolePage
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
        roleDataGridView = new PeproDataGridView();
        searchTextBox = new TextBox();
        searchButton = new Button();
        reloadButton = new Button();
        deleteButton = new Button();
        updateButton = new Button();
        insertButton = new Button();
        roleNameColumn = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)roleDataGridView).BeginInit();
        SuspendLayout();
        // 
        // roleDataGridView
        // 
        roleDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        roleDataGridView.Columns.AddRange(new DataGridViewColumn[] { roleNameColumn });
        roleDataGridView.Location = new Point(16, 128);
        roleDataGridView.Margin = new Padding(16);
        roleDataGridView.Name = "roleDataGridView";
        roleDataGridView.Size = new Size(1032, 537);
        roleDataGridView.TabIndex = 7;
        roleDataGridView.CellClick += RoleDataGridView_CellClick;
        // 
        // searchTextBox
        // 
        searchTextBox.Location = new Point(16, 80);
        searchTextBox.Margin = new Padding(3, 2, 3, 2);
        searchTextBox.Name = "searchTextBox";
        searchTextBox.PlaceholderText = "Search for role name";
        searchTextBox.Size = new Size(431, 26);
        searchTextBox.TabIndex = 1;
        // 
        // searchButton
        // 
        searchButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        searchButton.Location = new Point(466, 72);
        searchButton.Margin = new Padding(16, 16, 0, 0);
        searchButton.Name = "searchButton";
        searchButton.Size = new Size(40, 40);
        searchButton.TabIndex = 2;
        searchButton.Click += SearchButton_Click;
        // 
        // reloadButton
        // 
        reloadButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        reloadButton.Location = new Point(522, 72);
        reloadButton.Margin = new Padding(16, 16, 0, 0);
        reloadButton.Name = "reloadButton";
        reloadButton.Size = new Size(40, 40);
        reloadButton.TabIndex = 3;
        reloadButton.Click += ReloadButton_Click;
        // 
        // deleteButton
        // 
        deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        deleteButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        deleteButton.Location = new Point(706, 72);
        deleteButton.Margin = new Padding(16, 16, 0, 0);
        deleteButton.Name = "deleteButton";
        deleteButton.Padding = new Padding(12, 0, 12, 0);
        deleteButton.Size = new Size(112, 40);
        deleteButton.TabIndex = 4;
        deleteButton.Text = " Delete";
        deleteButton.Click += DeleteButton_Click;
        // 
        // updateButton
        // 
        updateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        updateButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        updateButton.Location = new Point(834, 72);
        updateButton.Margin = new Padding(16, 16, 0, 0);
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
        insertButton.Location = new Point(948, 72);
        insertButton.Margin = new Padding(16, 16, 0, 0);
        insertButton.Name = "insertButton";
        insertButton.Padding = new Padding(12, 0, 12, 0);
        insertButton.Size = new Size(100, 40);
        insertButton.TabIndex = 6;
        insertButton.Text = " Add";
        insertButton.Click += InsertButton_Click;
        // 
        // roleNameColumn
        // 
        roleNameColumn.DataPropertyName = "Name";
        roleNameColumn.HeaderText = "Role name";
        roleNameColumn.Name = "roleNameColumn";
        roleNameColumn.ReadOnly = true;
        roleNameColumn.Width = 98;
        // 
        // RolePage
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(searchTextBox);
        Controls.Add(searchButton);
        Controls.Add(reloadButton);
        Controls.Add(deleteButton);
        Controls.Add(updateButton);
        Controls.Add(insertButton);
        Controls.Add(roleDataGridView);
        HeaderText = "Role";
        Name = "RolePage";
        ReturnButtonVisible = false;
        Load += RolePage_Load;
        Controls.SetChildIndex(roleDataGridView, 0);
        Controls.SetChildIndex(insertButton, 0);
        Controls.SetChildIndex(updateButton, 0);
        Controls.SetChildIndex(deleteButton, 0);
        Controls.SetChildIndex(reloadButton, 0);
        Controls.SetChildIndex(searchButton, 0);
        Controls.SetChildIndex(searchTextBox, 0);
        ((System.ComponentModel.ISupportInitialize)roleDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion
    private PeproDataGridView roleDataGridView;
    private TextBox searchTextBox;
    private Button searchButton;
    private Button reloadButton;
    private Button deleteButton;
    private Button updateButton;
    private Button insertButton;
    private DataGridViewTextBoxColumn roleNameColumn;
}