namespace Pepro.Domain.Contracts;

public class TrackedValue<T>
{
    private readonly T? _value;
    private readonly bool _isModified;

    public TrackedValue() { }

    public TrackedValue(T value, bool isModified)
    {
        _value = value;
        _isModified = isModified;
    }

    public T? Value
    {
        get => _value;
    }

    public bool IsModified
    {
        get => _isModified;
    }
}
