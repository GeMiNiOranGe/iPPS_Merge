using System.Text;
using System.Text.RegularExpressions;

namespace Pepro.Business.Extensions;

public static partial class AccentStrippingExtensions
{
    public static string ToNonAccentVietnamese(this string vietnameseText)
    {
        return VietnameseDiacriticsRegex()
            .Replace(
                vietnameseText.Normalize(NormalizationForm.FormD),
                string.Empty
            )
            .Replace('\u0111', 'd')
            .Replace('\u0110', 'D');
    }

    [GeneratedRegex(@"\p{IsCombiningDiacriticalMarks}+")]
    private static partial Regex VietnameseDiacriticsRegex();
}
