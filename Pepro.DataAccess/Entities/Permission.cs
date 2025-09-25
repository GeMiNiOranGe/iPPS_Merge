namespace Pepro.DataAccess.Entities;

public class Permission
{
    private int _permissionId;
    private string _key = null!;

    public int PermissionId
    {
        get => _permissionId;
        set => _permissionId = value;
    }

    public string Key
    {
        get => _key;
        set => _key = value;
    }
}