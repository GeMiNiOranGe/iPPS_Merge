using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Pepro.Presentation.Base;

public class PeproUserControlBase : UserControl {
    public PeproUserControlBase() : base() {
        Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
    }

    [DefaultValue(typeof(Font), "Segoe UI, 14px")]
    [AllowNull]
    public override Font Font {
        get => base.Font;
        set => base.Font = value;
    }
}
