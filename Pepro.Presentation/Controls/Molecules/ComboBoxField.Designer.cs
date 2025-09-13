namespace Pepro.Presentation.Controls.Molecules;

partial class ComboBoxField
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
        comboBoxField = new ComboBox();
        SuspendLayout();
        // 
        // comboBoxField
        // 
        comboBoxField.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        comboBoxField.Cursor = Cursors.Hand;
        comboBoxField.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxField.FlatStyle = FlatStyle.Flat;
        comboBoxField.FormattingEnabled = true;
        comboBoxField.Location = new Point(0, 21);
        comboBoxField.Margin = new Padding(0);
        comboBoxField.Name = "comboBoxField";
        comboBoxField.Size = new Size(240, 27);
        comboBoxField.TabIndex = 1;
        comboBoxField.SelectedIndexChanged += InputFieldComboBox_SelectedIndexChanged;
        // 
        // PeproComboBoxField
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(comboBoxField);
        Name = "PeproComboBoxField";
        Size = new Size(240, 48);
        Controls.SetChildIndex(comboBoxField, 0);
        ResumeLayout(false);
    }

    #endregion

    private ComboBox comboBoxField;
}
