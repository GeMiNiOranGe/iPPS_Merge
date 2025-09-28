using Pepro.Presentation.Controls.Atoms;

namespace Pepro.Presentation.Controls.Pages;

partial class AccountPage
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        searchTextBox = new TextBox();
        searchButton = new Button();
        reloadButton = new Button();
        deleteButton = new Button();
        toggleActiveButton = new Button();
        resetPasswordButton = new Button();
        accountDataGridView = new PeproDataGridView();
        employeeColumn = new DataGridViewTextBoxColumn();
        usernameColumn = new DataGridViewTextBoxColumn();
        activeStatusColumn = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)accountDataGridView).BeginInit();
        SuspendLayout();
        // 
        // searchTextBox
        // 
        searchTextBox.Location = new Point(16, 80);
        searchTextBox.Margin = new Padding(3, 2, 3, 2);
        searchTextBox.Name = "searchTextBox";
        searchTextBox.PlaceholderText = "Search for username";
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
        deleteButton.Location = new Point(936, 72);
        deleteButton.Margin = new Padding(16, 16, 16, 0);
        deleteButton.Name = "deleteButton";
        deleteButton.Padding = new Padding(12, 0, 12, 0);
        deleteButton.Size = new Size(112, 40);
        deleteButton.TabIndex = 6;
        deleteButton.Text = " Delete";
        deleteButton.Click += DeleteButton_Click;
        // 
        // toggleActiveButton
        // 
        toggleActiveButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        toggleActiveButton.Location = new Point(578, 72);
        toggleActiveButton.Margin = new Padding(16, 16, 0, 0);
        toggleActiveButton.Name = "toggleActiveButton";
        toggleActiveButton.Padding = new Padding(12, 0, 12, 0);
        toggleActiveButton.Size = new Size(112, 40);
        toggleActiveButton.TabIndex = 4;
        toggleActiveButton.Text = "Lock";
        toggleActiveButton.Click += ToggleActiveButton_Click;
        // 
        // resetPasswordButton
        // 
        resetPasswordButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
        resetPasswordButton.Location = new Point(706, 72);
        resetPasswordButton.Margin = new Padding(16, 16, 0, 0);
        resetPasswordButton.Name = "resetPasswordButton";
        resetPasswordButton.Padding = new Padding(12, 0, 12, 0);
        resetPasswordButton.Size = new Size(152, 40);
        resetPasswordButton.TabIndex = 5;
        resetPasswordButton.Text = "Reset password";
        resetPasswordButton.Click += ResetPasswordButton_Click;
        // 
        // accountDataGridView
        // 
        accountDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        accountDataGridView.Columns.AddRange(new DataGridViewColumn[] { employeeColumn, usernameColumn, activeStatusColumn });
        accountDataGridView.Location = new Point(16, 128);
        accountDataGridView.Margin = new Padding(16);
        accountDataGridView.Name = "accountDataGridView";
        accountDataGridView.Size = new Size(1032, 537);
        accountDataGridView.TabIndex = 7;
        accountDataGridView.CellClick += AccountDataGridView_CellClick;
        // 
        // employeeColumn
        // 
        employeeColumn.DataPropertyName = "EmployeeFullName";
        employeeColumn.HeaderText = "Employee full name";
        employeeColumn.Name = "employeeColumn";
        employeeColumn.ReadOnly = true;
        employeeColumn.Width = 109;
        // 
        // usernameColumn
        // 
        usernameColumn.DataPropertyName = "Username";
        usernameColumn.HeaderText = "Username";
        usernameColumn.Name = "usernameColumn";
        usernameColumn.ReadOnly = true;
        usernameColumn.Width = 96;
        // 
        // activeStatusColumn
        // 
        activeStatusColumn.DataPropertyName = "ActiveStatusText";
        activeStatusColumn.HeaderText = "Active status";
        activeStatusColumn.Name = "activeStatusColumn";
        activeStatusColumn.ReadOnly = true;
        activeStatusColumn.Width = 103;
        // 
        // AccountPage
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(searchTextBox);
        Controls.Add(searchButton);
        Controls.Add(reloadButton);
        Controls.Add(toggleActiveButton);
        Controls.Add(resetPasswordButton);
        Controls.Add(deleteButton);
        Controls.Add(accountDataGridView);
        HeaderText = "Account";
        Name = "AccountPage";
        ReturnButtonVisible = false;
        Load += AccountPage_Load;
        Controls.SetChildIndex(accountDataGridView, 0);
        Controls.SetChildIndex(deleteButton, 0);
        Controls.SetChildIndex(resetPasswordButton, 0);
        Controls.SetChildIndex(toggleActiveButton, 0);
        Controls.SetChildIndex(reloadButton, 0);
        Controls.SetChildIndex(searchButton, 0);
        Controls.SetChildIndex(searchTextBox, 0);
        ((System.ComponentModel.ISupportInitialize)accountDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox searchTextBox;
    private Button searchButton;
    private Button reloadButton;
    private Button deleteButton;
    private Button toggleActiveButton;
    private Button resetPasswordButton;
    private PeproDataGridView accountDataGridView;
    private DataGridViewTextBoxColumn employeeColumn;
    private DataGridViewTextBoxColumn usernameColumn;
    private DataGridViewTextBoxColumn activeStatusColumn;
}
