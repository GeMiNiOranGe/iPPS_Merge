using Microsoft.Data.SqlClient;
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

    public Department? GetDepartmentByDepartmentId(string departmentId) {
        string query = @"
            SELECT Department.DepartmentId
                , Department.Name
                , Department.ManagerId
            FROM Department
            WHERE Department.DepartmentId = @DepartmentId
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("DepartmentId", SqlDbType.VarChar, 10, departmentId);

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
            FROM Department
        ";

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

        List<Department> departments = [];
        foreach (DataRow row in dataTable.Rows) {
            Department department = DepartmentMapper.FromDataRow(row);
            departments.Add(department);
        }
        return departments;
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

    public DataTable GetAllDepartments()
    {
        DataTable dataTable = new DataTable();

        using (SqlConnection connection = new SqlConnection(""))
        {
            string query = "SELECT DepartmentID, DepartmentName, ISNULL(ManagerID, 'NULL') AS ManagerID FROM Departments";

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
