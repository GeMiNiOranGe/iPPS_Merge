using Pepro.DataAccess;
using System.Data;

namespace Pepro.Business
{
    public class RoleBussiness
    {
        private RoleDataAccess rolePermissionData;

        public RoleBussiness()
        {
            rolePermissionData = new RoleDataAccess();
        }

        public DataTable GetRolePermissions()
        {
            return rolePermissionData.GetRolePermissions();
        }

        public DataTable GetRoles()
        {
            return rolePermissionData.getRoleID();
        }

        public DataTable GetPermission()
        {
            return rolePermissionData.getPermissionsID();
        }

        public void GrantRole(int roleID, int roleIDAdd, int permissionID, string name, string columnName)
        {
            rolePermissionData.GrantRole(roleID, roleIDAdd, permissionID, name, columnName);
        }

        public void UpdateRolePermission(int roleID, int roleIDAdd, int permissionID, string columnName)
        {
            rolePermissionData.UpdateRolePermission(roleID, roleIDAdd, permissionID, columnName);
        }
    }
}
