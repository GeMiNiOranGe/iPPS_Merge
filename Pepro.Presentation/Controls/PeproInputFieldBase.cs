using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Pepro.Presentation.Controls;

public partial class PeproInputFieldBase : PeproUserControl {
    public PeproInputFieldBase() {
        InitializeComponent();
    }

    [AllowNull]
    [Browsable(true)]
    [Category("Appearance")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [DefaultValue("")]
    public virtual string LabelText {
        get => inputFieldLabel.Text;
        set => inputFieldLabel.Text = value;
    }

    protected override Size DefaultSize => new(256, 128);

    [DefaultValue(typeof(Size), "256, 128")]
    public new Size Size {
        get => base.Size;
        set => base.Size = value;
    }
}
