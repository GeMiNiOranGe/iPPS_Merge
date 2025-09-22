namespace Pepro.DataAccess.Contracts;

public class AccountInsertModel
{
    private string _username = null!;
    private byte[] _salt = null!;
    private byte[] _password = null!;
    private bool _isActive;
    private int _employeeId;

    public string Username
    {
        get => _username;
        set => _username = value;
    }

    public byte[] Salt
    {
        get => _salt;
        set => _salt = value;
    }

    public byte[] Password
    {
        get => _password;
        set => _password = value;
    }

    public bool IsActive
    {
        get => _isActive;
        set => _isActive = value;
    }

    public int EmployeeId
    {
        get => _employeeId;
        set => _employeeId = value;
    }
}