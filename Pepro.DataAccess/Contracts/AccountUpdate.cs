namespace Pepro.DataAccess.Contracts;

public class AccountUpdate
{
    private TrackedValue<string> _username = new();
    private TrackedValue<byte[]> _salt = new();
    private TrackedValue<byte[]> _password = new();
    private TrackedValue<bool> _isActive = new();
    private TrackedValue<int> _employeeId = new();

    public TrackedValue<string> Username
    {
        get => _username;
        set => _username = value;
    }

    public TrackedValue<byte[]> Salt
    {
        get => _salt;
        set => _salt = value;
    }

    public TrackedValue<byte[]> Password
    {
        get => _password;
        set => _password = value;
    }

    public TrackedValue<bool> IsActive
    {
        get => _isActive;
        set => _isActive = value;
    }

    public TrackedValue<int> EmployeeId
    {
        get => _employeeId;
        set => _employeeId = value;
    }
}
