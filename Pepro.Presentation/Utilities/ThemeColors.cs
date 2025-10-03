namespace Pepro.Presentation.Utilities;

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
        public static Color Light => Color.FromArgb(59, 104, 255);

        public static Color Base => Color.FromArgb(0, 58, 250);

        public static Color Dark => Color.FromArgb(0, 36, 156);
    }

    public static class Background
    {
        public static Color Lighter => Color.FromArgb(43, 43, 43);

        public static Color Light => Color.FromArgb(36, 36, 36);

        public static Color Base => Color.FromArgb(29, 29, 29);

        public static Color Dark => Color.FromArgb(22, 22, 22);

        public static Color Darker => Color.FromArgb(15, 15, 15);
    }

    public static Color Text => Color.White;

    public static Color Subtext => Color.FromArgb(128, 128, 128);

    public static Color Neutral => Color.FromArgb(208, 208, 208);

    public static class System
    {
        public static class CloseButton
        {
            public static Color Light => Color.FromArgb(244, 31, 49);

            public static Color Normal => Color.FromArgb(232, 17, 35);

            public static Color Dark => Color.FromArgb(203, 21, 36);
        }
    }
}
