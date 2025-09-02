namespace Pepro.Presentation.Controls;

partial class DepartmentEditorControl
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
        departmentNameInputField = new PeproInputField();
        managerInputField = new PeproInputField();
        saveButton = new Button();
        SuspendLayout();
        // 
        // departmentNameInputField
        // 
        departmentNameInputField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        departmentNameInputField.LabelText = "Department name";
        departmentNameInputField.Location = new Point(16, 67);
        departmentNameInputField.Margin = new Padding(16, 16, 16, 24);
        departmentNameInputField.Name = "departmentNameInputField";
        departmentNameInputField.PlaceholderText = "e.g. department name";
        departmentNameInputField.Size = new Size(1032, 48);
        departmentNameInputField.TabIndex = 1;
        // 
        // managerInputField
        // 
        managerInputField.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        managerInputField.LabelText = "Manager";
        managerInputField.Location = new Point(16, 139);
        managerInputField.Margin = new Padding(16, 0, 16, 24);
        managerInputField.Name = "managerInputField";
        managerInputField.PlaceholderText = "e.g. manager";
        managerInputField.Size = new Size(1032, 48);
        managerInputField.TabIndex = 2;
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
        // DepartmentEditorControl
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(departmentNameInputField);
        Controls.Add(managerInputField);
        Controls.Add(saveButton);
        HeaderText = "Department Editor";
        Name = "DepartmentEditorControl";
        Controls.SetChildIndex(saveButton, 0);
        Controls.SetChildIndex(managerInputField, 0);
        Controls.SetChildIndex(departmentNameInputField, 0);
        ResumeLayout(false);
    }

    #endregion

    private PeproInputField departmentNameInputField;
    private PeproInputField managerInputField;
    private Button saveButton;
}
