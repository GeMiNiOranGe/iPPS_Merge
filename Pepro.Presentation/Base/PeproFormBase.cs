using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Pepro.Presentation.Base;

public class PeproFormBase : Form {
    public PeproFormBase() : base() {
        Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
        Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
    }

    [DefaultValue(typeof(Font), "Segoe UI, 14px")]
    [AllowNull]
    public override Font Font {
        get => base.Font;
        set => base.Font = value;
    }
}
