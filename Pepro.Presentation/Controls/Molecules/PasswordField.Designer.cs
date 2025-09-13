namespace Pepro.Presentation.Controls.Molecules;

partial class PasswordField
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
        textBoxField = new TextBox();
        togglePasswordButton = new Button();
        underlinePanel = new Panel();
        SuspendLayout();
        // 
        // textBoxField
        // 
        textBoxField.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        textBoxField.BorderStyle = BorderStyle.None;
        textBoxField.Cursor = Cursors.IBeam;
        textBoxField.Location = new Point(0, 22);
        textBoxField.Margin = new Padding(0, 0, 4, 0);
        textBoxField.Name = "textBoxField";
        textBoxField.Size = new Size(212, 19);
        textBoxField.TabIndex = 1;
        textBoxField.UseSystemPasswordChar = true;
        // 
        // togglePasswordButton
        // 
        togglePasswordButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        togglePasswordButton.BackColor = Color.White;
        togglePasswordButton.Cursor = Cursors.Hand;
        togglePasswordButton.FlatAppearance.BorderSize = 0;
        togglePasswordButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
        togglePasswordButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
        togglePasswordButton.FlatStyle = FlatStyle.Flat;
        togglePasswordButton.Location = new Point(216, 19);
        togglePasswordButton.Margin = new Padding(0);
        togglePasswordButton.Name = "togglePasswordButton";
        togglePasswordButton.Size = new Size(24, 24);
        togglePasswordButton.TabIndex = 2;
        togglePasswordButton.UseVisualStyleBackColor = false;
        togglePasswordButton.Click += TogglePasswordButton_Click;
        // 
        // underlinePanel
        // 
        underlinePanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        underlinePanel.BackColor = SystemColors.ControlText;
        underlinePanel.Location = new Point(0, 46);
        underlinePanel.Margin = new Padding(0);
        underlinePanel.Name = "underlinePanel";
        underlinePanel.Size = new Size(240, 2);
        underlinePanel.TabIndex = 0;
        // 
        // PeproPasswordField
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(togglePasswordButton);
        Controls.Add(underlinePanel);
        Controls.Add(textBoxField);
        Name = "PeproPasswordField";
        Size = new Size(240, 48);
        Controls.SetChildIndex(textBoxField, 0);
        Controls.SetChildIndex(underlinePanel, 0);
        Controls.SetChildIndex(togglePasswordButton, 0);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button togglePasswordButton;
    private TextBox textBoxField;
    private Panel underlinePanel;
}
