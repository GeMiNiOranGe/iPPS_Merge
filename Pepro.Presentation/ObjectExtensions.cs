namespace Pepro.Presentation;

public static class ObjectExtensions
{
    public static int? ToNullableInt(this object? input)
    {
        if (input == null || string.IsNullOrWhiteSpace(input.ToString()))
        {
            return null;
        }

        if (int.TryParse(input.ToString(), out int value))
        {
            return value;
        }

        return null;
    }
}
