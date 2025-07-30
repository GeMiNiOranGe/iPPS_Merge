using Microsoft.Data.SqlClient;
using Pepro.DTOs;
using System.Data;

namespace Pepro.DataAccess;

public class EmployeeDataAccess {
    private static EmployeeDataAccess? instance;

    public static EmployeeDataAccess Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private EmployeeDataAccess() { }

    public List<Employee> GetEmployees()
    {
        string query = @"
            SELECT EmployeeId
                , FirstName
                , MiddleName
                , LastName
                , DateOfBirth
                , Gender
                , TaxCode
                , CitizenId
                , DepartmentId
                , JobPositionId
                , SalaryLevelId
            FROM Employee
        ";

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

        List<Employee> employees = [];
        foreach (DataRow row in dataTable.Rows)
        {
            Employee employee = new()
            {
                EmployeeId = row.Field<string>("EmployeeId") ?? "",
                FirstName = row.Field<string>("FirstName") ?? "",
                MiddleName = row.Field<string>("MiddleName"),
                LastName = row.Field<string>("LastName") ?? "",
                DateOfBirth = row.Field<DateTime>("DateOfBirth"),
                Gender = row.Field<bool?>("Gender"),
                TaxCode = row.Field<byte[]>("TaxCode"),
                CitizenId = row.Field<string>("CitizenId") ?? "",
                DepartmentId = row.Field<string>("DepartmentId") ?? "",
                JobPositionId = row.Field<int>("JobPositionId"),
                SalaryLevelId = row.Field<int>("SalaryLevelId")
            };
            employees.Add(employee);
        }
        return employees;
    }

    public EmployeeFullName? GetFullname(string accountName) {
        string query = "SELECT FirstName, MiddleName, LastName FROM Employee WHERE Employee.EmployeeId = @EmployeeId";
        SqlParameter[] parameters =
        [
            new()
            {
                ParameterName = "EmployeeId",
                SqlDbType = SqlDbType.VarChar,
                Size = 10,
                Value = accountName
            }
        ];

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, parameters);
        if (dataTable.Rows.Count == 0) {
            return null;
        }

        DataRow row = dataTable.Rows[0];
        EmployeeFullName employeeFullName = new()
        {
            FirstName = row.Field<string>("FirstName") ?? "",
            MiddleName = row.Field<string>("MiddleName"),
            LastName = row.Field<string>("LastName") ?? ""
        };
        return employeeFullName;
    }

    public DataTable GetEmployeeByRoleID(int roleID) {
        DataTable dataTable = new DataTable();
        using (SqlConnection conn = new SqlConnection("")) {
            using (SqlCommand cmd = new SqlCommand("spSelectEmployees", conn)) {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RoleID", roleID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dataTable);
            }
        }
        return dataTable;
    }

    public bool UpdateEmployee(int roleID, string valueList, string employeeID) {
        SqlParameter[] parameters =
        [
            new("@RoleID", SqlDbType.Int) { Value = roleID },
            new("@ValueList", SqlDbType.NVarChar) { Value = valueList },
            new("@EmployeeID", SqlDbType.VarChar) { Value = employeeID }
        ];

        int numberOfRowsAffected = DataProvider.Instance.ExecuteNonQuery(
            "usp_UpdateEmployee",
            parameters,
            CommandType.StoredProcedure
        );
        return numberOfRowsAffected > 0;
    }

    /*
    public bool UpdateEmployee(int roleID, string valueList, string employeeID) {
        try {
            using (SqlConnection connection = new SqlConnection("")) {
                connection.Open();

                SqlCommand command = new SqlCommand("dbo.usp_UpdateEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@RoleID", roleID);
                command.Parameters.AddWithValue("@ValueList", valueList);
                command.Parameters.AddWithValue("@EmployeeID", employeeID);

                command.ExecuteNonQuery();

                return true;
            }
        }
        catch (SqlException ex) {
            // Xử lý các ngoại lệ SQL
            throw new Exception("SQL Error: " + ex.Message);
        }
        catch (Exception ex) {
            // Xử lý các ngoại lệ khác
            throw new Exception("Error: " + ex.Message);
        }
    }
    */

    public bool DeleteEmployee(int roleID, string employeeID) {
        using (SqlConnection connection = new SqlConnection("")) {
            try {
                using (SqlCommand command = new SqlCommand("spDeleteEmployee", connection)) {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@RoleID", roleID);
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex) {

                throw new Exception("An error occurred while deleting the employee.", ex);
            }
        }
    }

    public void InsertEmployee(string employeeId, string fullname, bool? gender, DateTime? dateOfBirth, string phoneNumber, string salary, string allowance, string taxCode, string departmentId) {
        using (SqlConnection conn = new SqlConnection("")) {
            using (SqlCommand cmd = new SqlCommand("spInsertEmployeeFull", conn)) {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmployeeId", (object)employeeId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Fullname", fullname);
                cmd.Parameters.AddWithValue("@Gender", (object)gender ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DateOfBirth", (object)dateOfBirth ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PhoneNumber", (object)phoneNumber ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Salary", salary);
                cmd.Parameters.AddWithValue("@Allowance", allowance);
                cmd.Parameters.AddWithValue("@TaxCode", (object)taxCode ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@DepartmentId", departmentId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

    public Employee? GetEmployeeByEmployeeId(string employeeId) {
        string query = @"
            SELECT EmployeeId
                , FirstName
                , MiddleName
                , LastName
                , DateOfBirth
                , Gender
                , TaxCode
                , CitizenId
                , DepartmentId
                , JobPositionId
                , SalaryLevelId
            FROM Employee
            WHERE EmployeeId = @EmployeeId
        ";
        SqlParameter[] parameters =
        [
            new()
            {
                ParameterName = "EmployeeId",
                SqlDbType = SqlDbType.VarChar,
                Size = 10,
                Value = employeeId
            }
        ];

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, parameters);
        if (dataTable.Rows.Count == 0) {
            return null;
        }

        DataRow row = dataTable.Rows[0];
        Employee employee = new() {
            EmployeeId = row.Field<string>("EmployeeId") ?? "",
            FirstName = row.Field<string>("FirstName") ?? "",
            MiddleName = row.Field<string>("MiddleName"),
            LastName = row.Field<string>("LastName") ?? "",
            DateOfBirth = row.Field<DateTime>("DateOfBirth"),
            Gender = row.Field<bool?>("Gender"),
            TaxCode = row.Field<byte[]>("TaxCode"),
            CitizenId = row.Field<string>("CitizenId") ?? "",
            DepartmentId = row.Field<string>("DepartmentId") ?? "",
            JobPositionId = row.Field<int>("JobPositionId"),
            SalaryLevelId = row.Field<int>("SalaryLevelId")
        };
        return employee;
    }

    //Lấy dữ liệu từ table ROLE trong database dựa vào EMPLOYEE_ID
    public CRole GetRolebyEmployeeID(string employeeID) {
        DataTable data = DataProvider.Instance.ExecuteQuery("Select * from ROLE where EMPLOYEE_ID = '" + employeeID + "'");
        foreach (DataRow item in data.Rows) {
            return new CRole(item);
        }
        return null;
    }

    public List<EmployeePhoneNumber> GetPhoneNumberListByEmployeeId(string employeeId) {
        string query = "SELECT EmployeePhoneNumberId, PhoneNumber, EmployeeId FROM EmployeePhoneNumber WHERE EmployeeId = @EmployeeId";
        SqlParameter[] parameters =
        [
            new()
            {
                ParameterName = "EmployeeId",
                SqlDbType = SqlDbType.VarChar,
                Size = 10,
                Value = employeeId
            }
        ];

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, parameters);

        List<EmployeePhoneNumber> listPhoneNumber = [];
        foreach (DataRow row in dataTable.Rows)
        {
            EmployeePhoneNumber phoneNumber = new()
            {
                EmployeePhoneNumberId = row.Field<int>("EmployeePhoneNumberId"),
                PhoneNumber = row.Field<string>("PhoneNumber") ?? "",
                EmployeeId = row.Field<string>("EmployeeId") ?? ""
            };
            listPhoneNumber.Add(phoneNumber);
        }
        return listPhoneNumber;
    }
}
