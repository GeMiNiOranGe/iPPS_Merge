using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Pepro.Presentation;

public class DesignTimeOnlyException : InvalidOperationException
{
    public DesignTimeOnlyException()
        : base(
            "This constructor is for design-time use only. Use the appropriate constructor for runtime."
        ) { }

    public static void ThrowIfRuntime()
    {
        if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
        {
            Throw();
        }
    }

    [DoesNotReturn]
    internal static void Throw() =>
        throw new DesignTimeOnlyException();
}
