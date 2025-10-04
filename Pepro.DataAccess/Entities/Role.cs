namespace Pepro.DataAccess.Entities;

public class Role
{
    private int _roleId;
    private string _name = null!;
    private bool _isDeleted;
    private DateTime _createdAt;
    private DateTime _updatedAt;
    private DateTime? _deletedAt;

    public required int RoleId
    {
        get => _roleId;
        set => _roleId = value;
    }

    public required string Name
    {
        get => _name;
        set => _name = value;
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
