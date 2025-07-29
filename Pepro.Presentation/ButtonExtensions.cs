using Pepro.Presentation.Controls;
using Svg;

namespace Pepro.Presentation;

public static class ButtonExtensions {
    public static void SetupRuntimeFlatStyle(this Button button) {
        button.BackColor = ThemeColors.Accent.Base;
        button.Cursor = Cursors.Hand;
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;
        button.FlatAppearance.MouseOverBackColor = ThemeColors.Accent.Light;
        button.FlatAppearance.MouseDownBackColor = ThemeColors.Accent.Dark;
    }

    public static void SetupRuntimeFlatStyleNoBackColor(this Button button) {
        button.Cursor = Cursors.Hand;
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;
        button.FlatAppearance.MouseOverBackColor = ThemeColors.Accent.Base;
        button.FlatAppearance.MouseDownBackColor = ThemeColors.Accent.Dark;
    }

    public static void SetupRuntimeIcon(
        this Button button,
        string name,
        string style = "Linear",
        SvgPaintServer? colorServer = null,
        int size = 24
    ) {
        if (!string.IsNullOrEmpty(button.Text)) {
            button.TextAlign = ContentAlignment.MiddleLeft;
            button.ImageAlign = ContentAlignment.MiddleLeft;
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
        }
        button.Image = IconProvider.GetIcon(name, style, colorServer, size);
    }
}

public static class PeproIconButtonExtensions {
    public static void SetSidebarButtonImages(this PeproIconButton button, string iconName) {
        SvgColourServer baseColor = new(ThemeColors.Text);
        button.SetupRuntimeFlatStyleNoBackColor();
        button.SetupRuntimeIcon(iconName, colorServer: baseColor);

        try {
            button.PressedImage = IconProvider.GetIcon(iconName, "Bold", baseColor);
        }
        catch (Exception) {
            button.PressedImage = null;
        }
    }
}
