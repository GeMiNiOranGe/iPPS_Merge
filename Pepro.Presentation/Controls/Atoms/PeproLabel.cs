using Pepro.Presentation.Extensions;

namespace Pepro.Presentation.Controls.Atoms;

public class PeproLabel : Label
{
    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.Clear(BackColor);

        float internalLeading = Font.FontFamily.GetInternalLeadingInPixels(Font);
        int topOffset = (int)Math.Round(internalLeading);

        TextFormatFlags flags = TextFormatFlags.NoPadding;
        if (!AutoSize)
        {
            flags |= TextFormatFlags.WordBreak;
        }
        else
        {
            flags |= TextFormatFlags.SingleLine | TextFormatFlags.EndEllipsis;
        }

        TextRenderer.DrawText(
            e.Graphics,
            Text,
            Font,
            new Rectangle(0, topOffset, ClientSize.Width, ClientSize.Height - topOffset),
            ForeColor,
            flags
        );
    }

    public override Size GetPreferredSize(Size proposedSize)
    {
        TextFormatFlags flags = TextFormatFlags.NoPadding;
        if (!AutoSize)
        {
            flags |= TextFormatFlags.WordBreak;
        }

        Size size = TextRenderer.MeasureText(
            Text,
            Font,
            proposedSize,
            flags
        );

        float internalLeading = Font.FontFamily.GetInternalLeadingInPixels(Font);
        int newHeight = size.Height + (int)Math.Round(internalLeading);
        return new Size(size.Width, newHeight);
    }
}
