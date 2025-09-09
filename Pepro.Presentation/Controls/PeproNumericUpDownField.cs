using System.ComponentModel;

namespace Pepro.Presentation.Controls;

public partial class PeproNumericUpDownField : PeproInputFieldBase
{
    public PeproNumericUpDownField()
    {
        InitializeComponent();
    }

    protected override Size DefaultSize => new(240, 48);

    [DefaultValue(typeof(Size), "240, 48")]
    public new Size Size
    {
        get => base.Size;
        set => base.Size = value;
    }

    /// <summary>
    ///     Gets or sets the value
    ///     assigned to the up-down control.
    /// </summary>
    [Bindable(true)]
    [Category("Appearance")]
    [DefaultValue(typeof(decimal), "0")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public decimal Value
    {
        get => inputFieldNumericUpDown.Value;
        set => inputFieldNumericUpDown.Value = value;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public new bool Enabled
    {
        get => inputFieldNumericUpDown.Enabled;
        set
        {
            inputFieldNumericUpDown.Enabled = value;
            TabStop = value;
        }
    }

    protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
    {
        base.SetBoundsCore(x, y, width, DefaultSize.Height, specified);
    }

    protected override void OnBackColorChanged(EventArgs e)
    {
        base.OnBackColorChanged(e);
        if (inputFieldNumericUpDown != null)
        {
            inputFieldNumericUpDown.BackColor = BackColor;
        }
    }

    protected override void OnForeColorChanged(EventArgs e)
    {
        base.OnForeColorChanged(e);
        if (inputFieldNumericUpDown != null)
        {
            inputFieldNumericUpDown.ForeColor = ForeColor;
        }
    }
}
