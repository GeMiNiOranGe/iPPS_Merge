using Pepro.Presentation.Controls;

namespace Pepro.Presentation;

public static class ButtonExtensions {
    public static void ApplyFlatStyle(this Button button) {
        button.BackColor = ThemeColors.Accent.Base;
        button.Cursor = Cursors.Hand;
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;
        button.FlatAppearance.MouseOverBackColor = ThemeColors.Accent.Light;
        button.FlatAppearance.MouseDownBackColor = ThemeColors.Accent.Dark;
    }

    public static void ApplyFlatStyleNoBackColor(this Button button) {
        button.Cursor = Cursors.Hand;
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;
        button.FlatAppearance.MouseOverBackColor = ThemeColors.Accent.Base;
        button.FlatAppearance.MouseDownBackColor = ThemeColors.Accent.Dark;
    }

    public static void ApplyIcon(
        this Button button,
        string name,
        string style = "Linear",
        int size = 24,
        Color? color = null
    ) {
        if (!string.IsNullOrEmpty(button.Text)) {
            button.TextAlign = ContentAlignment.MiddleLeft;
            button.ImageAlign = ContentAlignment.MiddleLeft;
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
        }
        button.Image = IconProvider.GetIcon(name, style, size, color);
    }
    
    public static void ApplyFlatStyleWithIcon(
        this Button button,
        string name,
        Color color
    ) {
        button.ApplyFlatStyle();
        button.ApplyIcon(name, color: color);
    }
}
