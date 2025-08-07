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
                , PositionId
                , SalaryLevelId
            FROM Employee
            WHERE IsDeleted = 0
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
                PositionId = row.Field<int>("PositionId"),
                SalaryLevelId = row.Field<int>("SalaryLevelId")
            };
            employees.Add(employee);
        }
        return employees;
    }

    public List<Employee> SearchEmployees(string searchValue) {
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
                , PositionId
                , SalaryLevelId
            FROM Employee
            WHERE
                (
                    EmployeeId LIKE '%' + @SearchValue + '%'
                    OR LastName + ' ' + IsNull(MiddleName + ' ', '') + FirstName LIKE '%' + @SearchValue + '%'
                )
                AND IsDeleted = 0
        ";
        SqlParameter[] parameters =
        [
            new()
            {
                ParameterName = "SearchValue",
                SqlDbType = SqlDbType.NVarChar,
                Size = DatabaseConstants.SEARCH_SIZE,
                Value = searchValue
            }
        ];

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, parameters);

        List<Employee> employees = [];
        foreach (DataRow row in dataTable.Rows) {
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
                PositionId = row.Field<int>("PositionId"),
                SalaryLevelId = row.Field<int>("SalaryLevelId")
            };
            employees.Add(employee);
        }
        return employees;
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

    public int DeleteEmployee(string employeeId) {
        string query = @"
            UPDATE Employee
            SET IsDeleted = 1
            WHERE EmployeeId = @EmployeeId;
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

        return DataProvider.Instance.ExecuteNonQuery(query, parameters);
    }

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

    public int InsertEmployee(Employee employee)
    {
        string query = @"
            INSERT INTO [dbo].[Employee]
                    ([EmployeeId], [FirstName], [MiddleName], [LastName], [DateOfBirth], [Gender], [TaxCode], [CitizenId], [DepartmentId], [PositionId], [SalaryLevelId])
            VALUES  (@EmployeeId,  @FirstName,  @MiddleName,  @LastName,  @DateOfBirth,  @Gender,  @TaxCode,  @CitizenId,  @DepartmentId,  @PositionId,  @SalaryLevelId)
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("EmployeeId", SqlDbType.VarChar, 10, employee.EmployeeId);
        parameters.Add("FirstName", SqlDbType.NVarChar, 10, employee.FirstName);
        parameters.Add("MiddleName", SqlDbType.NVarChar, 30, employee.MiddleName);
        parameters.Add("LastName", SqlDbType.NVarChar, 10, employee.LastName);
        parameters.Add("DateOfBirth", SqlDbType.Date, employee.DateOfBirth);
        parameters.Add("Gender", SqlDbType.Bit, employee.Gender);
        parameters.Add("TaxCode", SqlDbType.VarBinary, DatabaseConstants.MAX_SIZE, employee.TaxCode);
        parameters.Add("CitizenId", SqlDbType.VarChar, 12, employee.CitizenId);
        parameters.Add("DepartmentId", SqlDbType.VarChar, 10, employee.DepartmentId);
        parameters.Add("PositionId", SqlDbType.Int, employee.PositionId);
        parameters.Add("SalaryLevelId", SqlDbType.Int, employee.SalaryLevelId);

        return DataProvider.Instance.ExecuteNonQuery(query, [.. parameters]);
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
                , PositionId
                , SalaryLevelId
            FROM Employee
            WHERE EmployeeId = @EmployeeId
            AND IsDeleted = 0
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
            PositionId = row.Field<int>("PositionId"),
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

    public List<EmployeePhoneNumber> GetPhoneNumbersByEmployeeId(string employeeId) {
        string query = @"
            SELECT EmployeePhoneNumberId
                , PhoneNumber
                , Employee.EmployeeID
            FROM EmployeePhoneNumber
            INNER JOIN Employee
                    ON Employee.EmployeeID = EmployeePhoneNumber.EmployeeID
            WHERE Employee.EmployeeID = @EmployeeId
            AND IsDeleted = 0
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
