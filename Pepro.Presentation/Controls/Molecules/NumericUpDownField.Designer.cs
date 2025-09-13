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
        inputFieldNumericUpDown = new NumericUpDown();
        ((System.ComponentModel.ISupportInitialize)inputFieldNumericUpDown).BeginInit();
        SuspendLayout();
        // 
        // inputFieldNumericUpDown
        // 
        inputFieldNumericUpDown.Location = new Point(0, 22);
        inputFieldNumericUpDown.Margin = new Padding(0);
        inputFieldNumericUpDown.Name = "inputFieldNumericUpDown";
        inputFieldNumericUpDown.Size = new Size(240, 26);
        inputFieldNumericUpDown.TabIndex = 1;
        // 
        // PeproNumericUpDownField
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(inputFieldNumericUpDown);
        Name = "PeproNumericUpDownField";
        Size = new Size(240, 48);
        Controls.SetChildIndex(inputFieldNumericUpDown, 0);
        ((System.ComponentModel.ISupportInitialize)inputFieldNumericUpDown).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private NumericUpDown inputFieldNumericUpDown;
}
