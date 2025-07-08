using Microsoft.Data.SqlClient;
using Pepro.DTOs;
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
        string query = "SELECT DepartmentId, Name, ManagerId FROM Department WHERE DepartmentId = @DepartmentId";
        SqlParameter[] parameters =
        [
            new()
            {
                ParameterName = "DepartmentId",
                SqlDbType = SqlDbType.VarChar,
                Size = 10,
                Value = departmentId
            }
        ];

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, parameters);
        if (dataTable.Rows.Count == 0) {
            return null;
        }

        DataRow row = dataTable.Rows[0];
        Department department = new() {
            DepartmentId = row.Field<string>("DepartmentId") ?? "",
            Name = row.Field<string>("Name") ?? "",
            ManagerId = row.Field<string>("ManagerId") ?? ""
        };
        return department;
    }

    public DataTable GetDepartments()
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
