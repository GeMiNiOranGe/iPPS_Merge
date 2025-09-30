using Microsoft.Data.SqlClient;
using Pepro.DataAccess.Entities;
using Pepro.DataAccess.Extensions;
using Pepro.DataAccess.Mappings;
using Pepro.DataAccess.Utilities;
using System.Data;

namespace Pepro.DataAccess;

public class RoleDataAccess
{
    private static RoleDataAccess? _instance;

    public static RoleDataAccess Instance
    {
        get => _instance ??= new();
        private set => _instance = value;
    }

    private RoleDataAccess() { }

    public IEnumerable<Role> GetMany()
    {
        string query = @"
            SELECT Role.RoleId
                , Role.Name
                , Role.IsDeleted
                , Role.CreatedAt
                , Role.UpdatedAt
                , Role.DeletedAt
            FROM Role
            WHERE Role.IsDeleted = 0
        ";

        return DataProvider
            .Instance.ExecuteQuery(query)
            .MapMany(RoleMapper.FromDataRow);
    }

    /*
    public DataTable getRoleID()
    {
        DataTable dataTable = new();
        using (SqlConnection connection = new(""))
        {
            string query = "SELECT RoleID FROM Roles";
            using SqlCommand command = new(query, connection);
            connection.Open();
            using SqlDataAdapter adapter = new(command);
            adapter.Fill(dataTable);
        }
        return dataTable;
    }
    */

    public DataTable getPermissionsID()
    {
        DataTable dataTable = new();
        using (SqlConnection connection = new(""))
        {
            string query = "SELECT PermissionID FROM Permissions";
            using SqlCommand command = new(query, connection);
            connection.Open();
            using SqlDataAdapter adapter = new(command);
            adapter.Fill(dataTable);
        }
        return dataTable;
    }

    public DataTable GetRolePermissions()
    {
        DataTable dataTable = new();

        using (SqlConnection connection = new(""))
        {
            string query = "SELECT * FROM RolePermissions";

            using SqlCommand command = new(query, connection);
            connection.Open();

            using SqlDataAdapter adapter = new(command);
            adapter.Fill(dataTable);
        }

        return dataTable;
    }

    public void GrantRole(int roleID, int roleIDAdd, int permissionID, string name, string columnName)
    {
        DataTable rolePermissions = GetRolePermissions();
        DataRow[] existingPermissions = rolePermissions.Select($"RoleID = {roleIDAdd} AND PermissionID = {permissionID} AND Name = '{name}'");

        if (existingPermissions.Length > 0)
        {
            DataRow row = existingPermissions[0];
            string currentColumnName = (string)row["ColumnName"];

            if (!string.IsNullOrEmpty(columnName))
            {
                if (string.IsNullOrEmpty(currentColumnName))
                {
                    currentColumnName = columnName;
                }
                else
                {
                    currentColumnName = $"{currentColumnName},{columnName}";
                }

                // Update the existing row with the new ColumnName
                using SqlConnection connection = new("");
                connection.Open();
                using SqlCommand command = new("UPDATE RolePermissions SET ColumnName = @ColumnName WHERE RoleID = @RoleIDAdd AND PermissionID = @PermissionID AND Name = @Name", connection);
                command.Parameters.AddWithValue("@ColumnName", currentColumnName);
                command.Parameters.AddWithValue("@RoleIDAdd", roleIDAdd);
                command.Parameters.AddWithValue("@PermissionID", permissionID);
                command.Parameters.AddWithValue("@Name", name);
                command.ExecuteNonQuery();
            }
        }
        else
        {
            // Call the stored procedure to insert a new permission
            using SqlConnection connection = new("");
            connection.Open();
            using SqlCommand command = new("GrantRole", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@RoleID", roleID);
            command.Parameters.AddWithValue("@RoleIDAdd", roleIDAdd);
            command.Parameters.AddWithValue("@PermissionID", permissionID);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@ColumnName", string.IsNullOrWhiteSpace(columnName) ? (object)DBNull.Value : columnName);

            command.ExecuteNonQuery();
        }
    }

    public void UpdateRolePermission(int roleID, int roleIDAdd, int permissionID, string columnName)
    {
        using SqlConnection connection = new("");
        SqlCommand command = new("UpdateRolePermission", connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.AddWithValue("@RoleID", roleID);
        command.Parameters.AddWithValue("@RoleIDAdd", roleIDAdd);
        command.Parameters.AddWithValue("@PermissionID", permissionID);
        command.Parameters.AddWithValue("@ColumnName", columnName);

        try
        {
            connection.Open();
            command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
