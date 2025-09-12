using Pepro.Presentation.Controls.Molecules;

namespace Pepro.Presentation.Controls.Pages;

partial class DepartmentEditorPage
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
        departmentNameTextBoxField = new TextBoxField();
        managerComboBoxField = new ComboBoxField();
        saveButton = new Button();
        SuspendLayout();
        // 
        // departmentNameTextBoxField
        // 
        departmentNameTextBoxField.Anchor = AnchorStyles.None;
        departmentNameTextBoxField.LabelText = "Department name";
        departmentNameTextBoxField.Location = new Point(16, 67);
        departmentNameTextBoxField.Margin = new Padding(16, 16, 16, 24);
        departmentNameTextBoxField.Name = "departmentNameTextBoxField";
        departmentNameTextBoxField.PlaceholderText = "e.g. department name";
        departmentNameTextBoxField.Size = new Size(1032, 48);
        departmentNameTextBoxField.TabIndex = 1;
        // 
        // managerComboBoxField
        // 
        managerComboBoxField.Anchor = AnchorStyles.None;
        managerComboBoxField.LabelText = "Manager";
        managerComboBoxField.Location = new Point(16, 139);
        managerComboBoxField.Margin = new Padding(16, 0, 16, 24);
        managerComboBoxField.Name = "managerComboBoxField";
        managerComboBoxField.Size = new Size(1032, 48);
        managerComboBoxField.TabIndex = 2;
        // 
        // saveButton
        // 
        saveButton.Anchor = AnchorStyles.None;
        saveButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
        saveButton.Location = new Point(472, 512);
        saveButton.Margin = new Padding(16);
        saveButton.Name = "saveButton";
        saveButton.Size = new Size(120, 56);
        saveButton.TabIndex = 3;
        saveButton.Text = "Save";
        saveButton.Click += SaveButton_Click;
        // 
        // DepartmentEditorPage
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(departmentNameTextBoxField);
        Controls.Add(managerComboBoxField);
        Controls.Add(saveButton);
        HeaderText = "Department Editor";
        Name = "DepartmentEditorPage";
        Load += DepartmentEditorPage_Load;
        Controls.SetChildIndex(saveButton, 0);
        Controls.SetChildIndex(managerComboBoxField, 0);
        Controls.SetChildIndex(departmentNameTextBoxField, 0);
        ResumeLayout(false);
    }

    #endregion

    private TextBoxField departmentNameTextBoxField;
    private ComboBoxField managerComboBoxField;
    private Button saveButton;
}
