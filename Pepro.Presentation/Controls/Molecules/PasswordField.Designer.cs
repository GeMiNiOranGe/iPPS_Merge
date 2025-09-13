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
        inputFieldTextBox = new TextBox();
        togglePasswordButton = new Button();
        inputFieldPanel = new Panel();
        SuspendLayout();
        // 
        // inputFieldTextBox
        // 
        inputFieldTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        inputFieldTextBox.BorderStyle = BorderStyle.None;
        inputFieldTextBox.Cursor = Cursors.IBeam;
        inputFieldTextBox.Location = new Point(0, 22);
        inputFieldTextBox.Margin = new Padding(0, 0, 4, 0);
        inputFieldTextBox.Name = "inputFieldTextBox";
        inputFieldTextBox.Size = new Size(212, 19);
        inputFieldTextBox.TabIndex = 1;
        inputFieldTextBox.UseSystemPasswordChar = true;
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
        // inputFieldPanel
        // 
        inputFieldPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        inputFieldPanel.BackColor = SystemColors.ControlText;
        inputFieldPanel.Location = new Point(0, 46);
        inputFieldPanel.Margin = new Padding(0);
        inputFieldPanel.Name = "inputFieldPanel";
        inputFieldPanel.Size = new Size(240, 2);
        inputFieldPanel.TabIndex = 0;
        // 
        // PeproPasswordField
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(togglePasswordButton);
        Controls.Add(inputFieldPanel);
        Controls.Add(inputFieldTextBox);
        Name = "PeproPasswordField";
        Size = new Size(240, 48);
        Controls.SetChildIndex(inputFieldTextBox, 0);
        Controls.SetChildIndex(inputFieldPanel, 0);
        Controls.SetChildIndex(togglePasswordButton, 0);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button togglePasswordButton;
    private TextBox inputFieldTextBox;
    private Panel inputFieldPanel;
}
