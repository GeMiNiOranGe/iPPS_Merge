namespace Pepro.DataAccess.Entities;

public class Role
{
    private int _roleId;
    private string _name = null!;

    #region Optional fields
    private bool _isDeleted;
    private DateTime _createdAt;
    private DateTime _updatedAt;
    private DateTime? _deletedAt;
    #endregion

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
