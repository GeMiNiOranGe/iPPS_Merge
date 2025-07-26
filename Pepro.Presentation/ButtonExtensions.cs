using Microsoft.IdentityModel.Tokens;
using Svg;

namespace Pepro.Presentation;

public static class ButtonExtensions {
    public static void SetupRuntimeFlatStyle(this Button button) {
        button.BackColor = ThemeColors.Accent.Base;
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;
        button.FlatAppearance.MouseOverBackColor = ThemeColors.Accent.Light;
        button.FlatAppearance.MouseDownBackColor = ThemeColors.Accent.Dark;
    }

    public static void SetupRuntimeIcon(
        this Button button,
        string name,
        string style = "Linear",
        SvgPaintServer? colorServer = null,
        int size = 24
    ) {
        if (!button.Text.IsNullOrEmpty()) {
            button.TextAlign = ContentAlignment.MiddleLeft;
            button.ImageAlign = ContentAlignment.MiddleLeft;
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
        }
        button.Image = IconProvider.GetIcon(name, style, colorServer, size);
    }
}
