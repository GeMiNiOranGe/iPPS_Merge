using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Pepro.Presentation.Controls;

public class PeproSidebarButton : Button {
    private Image? _defaultImage;

    public PeproSidebarButton() {
        BackColor = Color.Transparent;
        Dock = DockStyle.Top;
        Font = new("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
        ForeColor = Color.White;
        TextAlign = ContentAlignment.MiddleLeft;

        FlatStyle = FlatStyle.Flat;
        ImageAlign = ContentAlignment.MiddleLeft;
        TextImageRelation = TextImageRelation.ImageBeforeText;

        FlatAppearance.BorderSize = 0;
        FlatAppearance.MouseDownBackColor = Color.FromArgb(34, 130, 253);
        FlatAppearance.MouseOverBackColor = Color.FromArgb(34, 130, 253);
    }

    protected override void OnMouseDown(MouseEventArgs mevent) {
        base.OnMouseDown(mevent);

        _defaultImage ??= Image;

        if (PressedImage != null) {
            Image = PressedImage;
        }

        ForeColor = Color.FromArgb(29, 29, 29);
    }

    protected override void OnMouseUp(MouseEventArgs mevent) {
        base.OnMouseUp(mevent);

        if (_defaultImage != null) {
            Image = _defaultImage;
        }

        ForeColor = Color.White;
    }

    [Category("Appearance")]
    [Description("The image displayed when the button is pressed.")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [DefaultValue(null)]
    public Image? PressedImage {
        get;
        set;
    }

    [DefaultValue(typeof(Color), nameof(Color.Transparent))]
    public override Color BackColor {
        get => base.BackColor;
        set => base.BackColor = value;
    }

    [DefaultValue(DockStyle.Top)]
    public override DockStyle Dock {
        get => base.Dock;
        set => base.Dock = value;
    }

    [DefaultValue(typeof(Font), "Segoe UI, 16px, style=Bold")]
    [AllowNull]
    public override Font Font {
        get => base.Font;
        set => base.Font = value;
    }

    [DefaultValue(typeof(Color), nameof(Color.White))]
    public override Color ForeColor {
        get => base.ForeColor;
        set => base.ForeColor = value;
    }

    [DefaultValue(ContentAlignment.MiddleLeft)]
    public override ContentAlignment TextAlign {
        get => base.TextAlign;
        set => base.TextAlign = value;
    }

    [DefaultValue(ContentAlignment.MiddleLeft)]
    public new ContentAlignment ImageAlign {
        get => base.ImageAlign;
        set => base.ImageAlign = value;
    }

    private bool ShouldSerializeImageAlign() {
        return ImageAlign != ContentAlignment.MiddleLeft;
    }

    private void ResetImageAlign() {
        ImageAlign = ContentAlignment.MiddleLeft;
    }

    [DefaultValue(TextImageRelation.ImageBeforeText)]
    public new TextImageRelation TextImageRelation {
        get => base.TextImageRelation;
        set => base.TextImageRelation = value;
    }

    private bool ShouldSerializeTextImageRelation() {
        return TextImageRelation != TextImageRelation.ImageBeforeText;
    }

    private void ResetTextImageRelation() {
        TextImageRelation = TextImageRelation.ImageBeforeText;
    }

    [DefaultValue(FlatStyle.Flat)]
    public new FlatStyle FlatStyle {
        get => base.FlatStyle;
        set => base.FlatStyle = value;
    }

    private bool ShouldSerializeFlatStyle() {
        return FlatStyle != FlatStyle.Flat;
    }

    private void ResetFlatStyle() {
        FlatStyle = FlatStyle.Flat;
    }
}
