namespace Pepro.Presentation.Controls.Molecules;

partial class NumericUpDownField
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
        numericUpDownField = new NumericUpDown();
        ((System.ComponentModel.ISupportInitialize)numericUpDownField).BeginInit();
        SuspendLayout();
        // 
        // numericUpDownField
        // 
        numericUpDownField.Location = new Point(0, 22);
        numericUpDownField.Margin = new Padding(0);
        numericUpDownField.Name = "numericUpDownField";
        numericUpDownField.Size = new Size(240, 26);
        numericUpDownField.TabIndex = 1;
        // 
        // PeproNumericUpDownField
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(numericUpDownField);
        Name = "PeproNumericUpDownField";
        Size = new Size(240, 48);
        Controls.SetChildIndex(numericUpDownField, 0);
        ((System.ComponentModel.ISupportInitialize)numericUpDownField).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private NumericUpDown numericUpDownField;
}
