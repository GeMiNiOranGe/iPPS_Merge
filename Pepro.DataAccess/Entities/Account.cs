namespace Pepro.DataAccess.Entities;

public class Account
{
    private int _accountId;
    private string _username = null!;
    private byte[] _salt = null!;
    private byte[] _password = null!;
    private bool _isActive;
    private int _employeeId;
    private bool _isDeleted;
    private DateTime _createdAt;
    private DateTime _updatedAt;
    private DateTime? _deletedAt;

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

    public required int EmployeeId
    {
        get => _employeeId;
        set => _employeeId = value;
    }

    public required bool IsDeleted
    {
        get => _isDeleted;
        set => _isDeleted = value;
    }

    public required DateTime CreatedAt
    {
        get => _createdAt;
        set => _createdAt = value;
    }

    public required DateTime UpdatedAt
    {
        get => _updatedAt;
        set => _updatedAt = value;
    }

    public required DateTime? DeletedAt
    {
        get => _deletedAt;
        set => _deletedAt = value;
    }
}
