using Pepro.Business.Mappings;
using Pepro.DataAccess;
using Pepro.DataAccess.Contracts;
using Pepro.DataAccess.Entities;
using Pepro.DTOs;
using System.Data;

namespace Pepro.Business;

public class RoleBusiness
{
    private static RoleBusiness? _instance;

    public static RoleBusiness Instance
    {
        get => _instance ??= new();
        private set => _instance = value;
    }

    private RoleBusiness() { }
    
    public IEnumerable<RoleDto> GetRoles()
    {
        IEnumerable<Role> roles = RoleDataAccess.Instance.GetMany();
        return roles.ToDtos();
    }

    public IEnumerable<RoleDto> SearchRoles(string searchValue)
    {
        IEnumerable<Role> roles = RoleDataAccess.Instance.Search(searchValue);
        return roles.ToDtos();
    }

    public int InsertRole(RoleDto dto)
    {
        RoleInsertModel entity = dto.ToInsertModel();
        return RoleDataAccess.Instance.Insert(entity);
    }

    public DataTable GetRolePermissions()
    {
        return RoleDataAccess.Instance.GetRolePermissions();
    }

    /*
    public DataTable GetRoles()
    {
        return RoleDataAccess.Instance.getRoleID();
    }
    */

    public DataTable GetPermission()
    {
        return RoleDataAccess.Instance.getPermissionsID();
    }

    public void GrantRole(int roleID, int roleIDAdd, int permissionID, string name, string columnName)
    {
        RoleDataAccess.Instance.GrantRole(roleID, roleIDAdd, permissionID, name, columnName);
    }

    public void UpdateRolePermission(int roleID, int roleIDAdd, int permissionID, string columnName)
    {
        RoleDataAccess.Instance.UpdateRolePermission(roleID, roleIDAdd, permissionID, columnName);
    }
}
