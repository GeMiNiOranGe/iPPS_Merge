using Microsoft.Data.SqlClient;
using Pepro.DataAccess.Contracts;
using Pepro.DataAccess.Entities;
using Pepro.DataAccess.Mappings;
using System.Data;

namespace Pepro.DataAccess;

public class DepartmentDataAccess
{
    private static DepartmentDataAccess? instance;

    public static DepartmentDataAccess Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private DepartmentDataAccess() { }

    public Department? GetDepartmentByDepartmentId(int departmentId) {
        string query = @"
            SELECT Department.DepartmentId
                , Department.Name
                , Department.ManagerId
                , Department.IsDeleted
                , Department.CreatedAt
                , Department.UpdatedAt
                , Department.DeletedAt
            FROM Department
            WHERE Department.DepartmentId = @DepartmentId
                AND Department.IsDeleted = 0
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("DepartmentId", SqlDbType.Int, departmentId);

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, [.. parameters]);
        if (dataTable.Rows.Count == 0) {
            return null;
        }

        DataRow row = dataTable.Rows[0];
        return DepartmentMapper.FromDataRow(row);
    }

    public List<Department> GetDepartments() {
        string query = @"
            SELECT Department.DepartmentId
                , Department.Name
                , Department.ManagerId
                , Department.IsDeleted
                , Department.CreatedAt
                , Department.UpdatedAt
                , Department.DeletedAt
            FROM Department
            WHERE Department.IsDeleted = 0
        ";

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

        List<Department> departments = [];
        foreach (DataRow row in dataTable.Rows) {
            Department department = DepartmentMapper.FromDataRow(row);
            departments.Add(department);
        }
        return departments;
    }

    public List<Department> SearchDepartments(string searchValue) {
        string query = @"
            SELECT Department.DepartmentId
                , Department.Name
                , Department.ManagerId
                , Department.IsDeleted
                , Department.CreatedAt
                , Department.UpdatedAt
                , Department.DeletedAt
            FROM Department
            WHERE Department.Name LIKE '%' + @SearchValue + '%'
                AND Department.IsDeleted = 0
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("SearchValue", SqlDbType.NVarChar, DatabaseConstants.SEARCH_SIZE, searchValue);

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, [.. parameters]);

        List<Department> departments = [];
        foreach (DataRow row in dataTable.Rows) {
            Department department = DepartmentMapper.FromDataRow(row);
            departments.Add(department);
        }
        return departments;
    }

    public int DeleteDepartment(int departmentId)
    {
        string query = @"
            UPDATE Department
            SET IsDeleted = 1,
                DeletedAt = GetDate()
            WHERE DepartmentId = @DepartmentId
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("DepartmentId", SqlDbType.Int, departmentId);

        return DataProvider.Instance.ExecuteNonQuery(query, [.. parameters]);
    }

    public int UpdateDepartment(int departmentId, DepartmentUpdate info)
    {
        SqlUpdateQueryBuilder builder = new SqlUpdateQueryBuilder("Department")
            .Set("Name", SqlDbType.NVarChar, 50, info.Name)
            .Set("ManagerId", SqlDbType.Int, info.ManagerId)
            .SetDirect("UpdatedAt", SqlDbType.DateTime, DateTime.Now)
            .Where("DepartmentId", SqlDbType.Int, departmentId);

        (string query, List<SqlParameter> parameters) = builder.Build();

        if (string.IsNullOrEmpty(query) || parameters.Count == 0)
        {
            return 0;
        }
        return DataProvider.Instance.ExecuteNonQuery(query, [.. parameters]);
    }

    public int InsertDepartment(Department entity)
    {
        string query = @"
            INSERT INTO Department
            (
                Name
                , ManagerId
            )
            VALUES
            (
                @Name
                , @ManagerId
            )
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("Name", SqlDbType.NVarChar, 50, entity.Name);
        parameters.Add("ManagerId", SqlDbType.Int, entity.ManagerId);

        return DataProvider.Instance.ExecuteNonQuery(query, [.. parameters]);
    }

    public DataTable GetDepartmentList()
    {
        DataTable dataTable = new DataTable();

        using (SqlConnection connection = new SqlConnection(""))
        {
            string query = "SELECT DepartmentID FROM Departments";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }
        }

        return dataTable;
    }
}
