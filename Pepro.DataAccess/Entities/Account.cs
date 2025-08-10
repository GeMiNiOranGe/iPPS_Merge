namespace Pepro.DataAccess.Entities;

public class Account
{
    private int _accountId;
    private string _username = "";
    private byte[] _salt = [];
    private byte[] _password = [];
    private bool _isActive;
    private string _employeeId = "";

    public required int AccountId
    {
        get => _accountId;
        set => _accountId = value;
    }

    public required string Username
    {
        get => _username;
        set => _username = value;
    }

    public required byte[] Salt
    {
        get => _salt;
        set => _salt = value;
    }

    public required byte[] Password
    {
        get => _password;
        set => _password = value;
    }

    public required bool IsActive
    {
        get => _isActive;
        set => _isActive = value;
    }

    public required string EmployeeId
    {
        get => _employeeId;
        set => _employeeId = value;
    }
}
