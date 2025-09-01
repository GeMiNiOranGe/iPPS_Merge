namespace Pepro.DataAccess.Entities;

public class Department
{
    private string _departmentId = null!;
    private string _name = null!;
    private int _managerId;

    #region Optional fields
    private bool _isDeleted;
    private DateTime _createdAt;
    private DateTime _updatedAt;
    private DateTime? _deletedAt;
    #endregion

    public required string DepartmentId
    {
        get => _departmentId;
        set => _departmentId = value;
    }

    public required string Name
    {
        get => _name;
        set => _name = value;
    }

    public required int ManagerId
    {
        get => _managerId;
        set => _managerId = value;
    }

    public bool IsDeleted
    {
        get => _isDeleted;
        set => _isDeleted = value;
    }

    public DateTime CreatedAt
    {
        get => _createdAt;
        set => _createdAt = value;
    }

    public DateTime UpdatedAt
    {
        get => _updatedAt;
        set => _updatedAt = value;
    }

    public DateTime? DeletedAt
    {
        get => _deletedAt;
        set => _deletedAt = value;
    }
}
