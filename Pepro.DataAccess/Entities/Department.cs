namespace Pepro.DataAccess.Entities;

public class Department
{
    private int _departmentId;
    private string _name = null!;
    private int? _managerId;
    private bool _isDeleted;
    private DateTime _createdAt;
    private DateTime _updatedAt;
    private DateTime? _deletedAt;

    public required int DepartmentId
    {
        get => _departmentId;
        set => _departmentId = value;
    }

    public required string Name
    {
        get => _name;
        set => _name = value;
    }

    public required int? ManagerId
    {
        get => _managerId;
        set => _managerId = value;
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
