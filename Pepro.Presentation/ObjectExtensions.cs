using System.ComponentModel;

namespace Pepro.Presentation;

public static class ObjectExtensions
{
    public static T? ToNullable<T>(this object? input) where T : struct
    {
        if (input == null || string.IsNullOrWhiteSpace(input.ToString()))
        {
            return null;
        }

        TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
        if (!converter.IsValid(input))
        {
            return null;
        }

        return (T?)converter.ConvertFrom(input);
    }
}
