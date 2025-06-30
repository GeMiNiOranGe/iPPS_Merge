namespace Pepro.Presentation;

public static class ThemeColors
{
    public static Color Primary => Color.Black;
    public static class Secondary
    {
        public static Color Light => Color.FromArgb(138, 63, 226);
        public static Color Base => Color.BlueViolet;
        public static Color Dark => Color.FromArgb(138, 3, 226);
    }
    public static class Accent
    {
        public static Color Light => Color.FromArgb(35, 125, 255);
        public static Color Base => Color.FromArgb(35, 105, 255);
        public static Color Dark => Color.FromArgb(35, 85, 255);
    }
    public static Color Background => Color.Empty;
    public static Color Text => Color.White;
    public static Color Subtext => Color.FromArgb(128, 128, 128);
    public static Color Neutral => Color.FromArgb(208, 208, 208);
}
