namespace Pepro.Presentation.Extensions;

public static class FontFamilyExtensions
{
    public static int GetInternalLeading(
        this FontFamily family,
        FontStyle style
    )
    {
        int em = family.GetEmHeight(style);
        int asc = family.GetCellAscent(style);
        int desc = family.GetCellDescent(style);
        return em - (asc + desc);
    }

    public static int GetExternalLeading(
        this FontFamily family,
        FontStyle style
    )
    {
        int em = family.GetEmHeight(style);
        int line = family.GetLineSpacing(style);
        return line - em;
    }

    public static float GetEmHeightInPixels(this FontFamily family, Font font)
    {
        int em = family.GetEmHeight(font.Style);
        float scale = font.Size / family.GetEmHeight(font.Style);
        return em * scale;
    }

    public static float GetCellAscentInPixels(this FontFamily family, Font font)
    {
        int ascent = family.GetCellAscent(font.Style);
        float scale = font.Size / family.GetEmHeight(font.Style);
        return ascent * scale;
    }

    public static float GetCellDescentInPixels(
        this FontFamily family,
        Font font
    )
    {
        int descent = family.GetCellDescent(font.Style);
        float scale = font.Size / family.GetEmHeight(font.Style);
        return descent * scale;
    }

    public static float GetLineSpacingInPixels(
        this FontFamily family,
        Font font
    )
    {
        int lineSpacing = family.GetLineSpacing(font.Style);
        float scale = font.Size / family.GetEmHeight(font.Style);
        return lineSpacing * scale;
    }

    public static float GetInternalLeadingInPixels(
        this FontFamily family,
        Font font
    )
    {
        int internalLeadingDU = family.GetInternalLeading(font.Style);
        float scale = font.Size / family.GetEmHeight(font.Style);
        return internalLeadingDU * scale;
    }

    public static float GetExternalLeadingInPixels(
        this FontFamily family,
        Font font
    )
    {
        int externalLeadingDU = family.GetExternalLeading(font.Style);
        float scale = font.Size / family.GetEmHeight(font.Style);
        return externalLeadingDU * scale;
    }
}
