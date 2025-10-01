namespace Pepro.Presentation.Controls.Pages;

partial class RoleEditorPage
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
        roleNameTextBoxField = new Pepro.Presentation.Controls.Molecules.TextBoxField();
        saveButton = new Button();
        SuspendLayout();
        // 
        // roleNameTextBoxField
        // 
        roleNameTextBoxField.LabelText = "Role name";
        roleNameTextBoxField.Location = new Point(16, 75);
        roleNameTextBoxField.Margin = new Padding(16, 16, 16, 0);
        roleNameTextBoxField.Name = "roleNameTextBoxField";
        roleNameTextBoxField.PlaceholderText = "e.g. role name";
        roleNameTextBoxField.Size = new Size(1032, 48);
        roleNameTextBoxField.TabIndex = 1;
        // 
        // saveButton
        // 
        saveButton.Anchor = AnchorStyles.None;
        saveButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
        saveButton.Location = new Point(472, 504);
        saveButton.Margin = new Padding(16);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(120, 56);
        saveButton.TabIndex = 2;
        saveButton.Text = "Save";
        saveButton.Click += SaveButton_Click;
        // 
        // RoleEditorPage
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(roleNameTextBoxField);
        Controls.Add(saveButton);
        HeaderText = "Role Editor";
        Name = "RoleEditorPage";
        Load += RoleEditorPage_Load;
        Controls.SetChildIndex(saveButton, 0);
        Controls.SetChildIndex(roleNameTextBoxField, 0);
        ResumeLayout(false);
    }

    #endregion

    private Molecules.TextBoxField roleNameTextBoxField;
    private Button saveButton;
}
