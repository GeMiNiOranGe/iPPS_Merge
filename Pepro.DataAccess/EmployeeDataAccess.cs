using Microsoft.Data.SqlClient;
using Pepro.DataAccess.Contracts;
using Pepro.DataAccess.Entities;
using Pepro.DataAccess.Mappings;
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
            SELECT Employee.EmployeeId
                , Employee.FirstName
                , Employee.MiddleName
                , Employee.LastName
                , Employee.DateOfBirth
                , Employee.Gender
                , Employee.TaxCode
                , Employee.CitizenId
                , Employee.DepartmentId
                , Employee.PositionId
                , Employee.SalaryLevelId
                , Employee.IsDeleted
                , Employee.CreatedAt
                , Employee.UpdatedAt
                , Employee.DeletedAt
            FROM Employee
            WHERE Employee.IsDeleted = 0
        ";

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

        List<Employee> employees = [];
        foreach (DataRow row in dataTable.Rows)
        {
            Employee employee = EmployeeMapper.FromDataRow(row);
            employees.Add(employee);
        }
        return employees;
    }

    public List<Employee> SearchEmployees(string searchValue) {
        string query = @"
            SELECT Employee.EmployeeId
                , Employee.FirstName
                , Employee.MiddleName
                , Employee.LastName
                , Employee.DateOfBirth
                , Employee.Gender
                , Employee.TaxCode
                , Employee.CitizenId
                , Employee.DepartmentId
                , Employee.PositionId
                , Employee.SalaryLevelId
                , Employee.IsDeleted
                , Employee.CreatedAt
                , Employee.UpdatedAt
                , Employee.DeletedAt
            FROM Employee
            WHERE
                (
                    Employee.EmployeeId LIKE '%' + @SearchValue + '%'
                    OR Employee.LastName + ' ' + IsNull(Employee.MiddleName + ' ', '') + Employee.FirstName LIKE '%' + @SearchValue + '%'
                )
                AND Employee.IsDeleted = 0
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("SearchValue", SqlDbType.NVarChar, DatabaseConstants.SEARCH_SIZE, searchValue);

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, [.. parameters]);

        List<Employee> employees = [];
        foreach (DataRow row in dataTable.Rows) {
            Employee employee = EmployeeMapper.FromDataRow(row);
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

    public int UpdateEmployee(int employeeId, EmployeeUpdate entity)
    {
        SqlUpdateQueryBuilder builder = new SqlUpdateQueryBuilder("Employee")
            .Set("FirstName", SqlDbType.NVarChar, 10, entity.FirstName)
            .Set("MiddleName", SqlDbType.NVarChar, 30, entity.MiddleName)
            .Set("LastName", SqlDbType.NVarChar, 10, entity.LastName)
            .Set("DateOfBirth", SqlDbType.Date, entity.DateOfBirth)
            .Set("Gender", SqlDbType.Bit, entity.Gender)
            .Set("TaxCode", SqlDbType.VarBinary, DatabaseConstants.MAX_SIZE, entity.TaxCode)
            .Set("CitizenId", SqlDbType.VarChar, 12, entity.CitizenId)
            .Set("DepartmentId", SqlDbType.VarChar, 10, entity.DepartmentId)
            .Set("PositionId", SqlDbType.Int, entity.PositionId)
            .Set("SalaryLevelId", SqlDbType.Int, entity.SalaryLevelId)
            .SetDirect("UpdatedAt", SqlDbType.DateTime, DateTime.Now)
            .Where("EmployeeId", SqlDbType.Int, employeeId);

        (string query, List<SqlParameter> parameters) = builder.Build();

        if (string.IsNullOrEmpty(query) || parameters.Count == 0)
        {
            return 0;
        }
        return DataProvider.Instance.ExecuteNonQuery(query, [.. parameters]);
    }

    public int DeleteEmployee(int employeeId) {
        string query = @"
            UPDATE Employee
            SET IsDeleted = 1,
                DeletedAt = GetDate()
            WHERE EmployeeId = @EmployeeId;
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("EmployeeId", SqlDbType.Int, employeeId);

        return DataProvider.Instance.ExecuteNonQuery(query, [.. parameters]);
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

    public Employee? AddEmployee(Employee employee)
    {
        string query = @"
            INSERT INTO [dbo].[Employee]
            (
                [FirstName]
                , [MiddleName]
                , [LastName]
                , [DateOfBirth]
                , [Gender]
                , [TaxCode]
                , [CitizenId]
                , [DepartmentId]
                , [PositionId]
                , [SalaryLevelId]
            )
            OUTPUT
                Inserted.[EmployeeId]
                , Inserted.[FirstName]
                , Inserted.[MiddleName]
                , Inserted.[LastName]
                , Inserted.[DateOfBirth]
                , Inserted.[Gender]
                , Inserted.[TaxCode]
                , Inserted.[CitizenId]
                , Inserted.[DepartmentId]
                , Inserted.[PositionId]
                , Inserted.[SalaryLevelId]
                , Inserted.[IsDeleted]
                , Inserted.[CreatedAt]
                , Inserted.[UpdatedAt]
                , Inserted.[DeletedAt]
            VALUES
            (
                @FirstName
                , @MiddleName
                , @LastName
                , @DateOfBirth
                , @Gender
                , @TaxCode
                , @CitizenId
                , @DepartmentId
                , @PositionId
                , @SalaryLevelId
            )
        ";
        List<SqlParameter> parameters = [];
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

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, [.. parameters]);
        if (dataTable.Rows.Count == 0)
        {
            return null;
        }

        DataRow row = dataTable.Rows[0];
        return EmployeeMapper.FromDataRow(row);
    }

    public int InsertEmployee(Employee employee)
    {
        string query = @"
            INSERT INTO [dbo].[Employee]
            (
                [FirstName]
                , [MiddleName]
                , [LastName]
                , [DateOfBirth]
                , [Gender]
                , [TaxCode]
                , [CitizenId]
                , [DepartmentId]
                , [PositionId]
                , [SalaryLevelId]
            )
            VALUES
            (
                @FirstName
                , @MiddleName
                , @LastName
                , @DateOfBirth
                , @Gender
                , @TaxCode
                , @CitizenId
                , @DepartmentId
                , @PositionId
                , @SalaryLevelId
            )
        ";
        List<SqlParameter> parameters = [];
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

    public Employee? GetEmployeeByEmployeeId(int employeeId) {
        string query = @"
            SELECT Employee.EmployeeId
                , Employee.FirstName
                , Employee.MiddleName
                , Employee.LastName
                , Employee.DateOfBirth
                , Employee.Gender
                , Employee.TaxCode
                , Employee.CitizenId
                , Employee.DepartmentId
                , Employee.PositionId
                , Employee.SalaryLevelId
                , Employee.IsDeleted
                , Employee.CreatedAt
                , Employee.UpdatedAt
                , Employee.DeletedAt
            FROM Employee
            WHERE Employee.EmployeeId = @EmployeeId
            AND Employee.IsDeleted = 0
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("EmployeeId", SqlDbType.Int, employeeId);

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, [.. parameters]);
        if (dataTable.Rows.Count == 0) {
            return null;
        }

        DataRow row = dataTable.Rows[0];
        return EmployeeMapper.FromDataRow(row);
    }

    //Lấy dữ liệu từ table ROLE trong database dựa vào EMPLOYEE_ID
    public CRole GetRolebyEmployeeID(string employeeID) {
        DataTable data = DataProvider.Instance.ExecuteQuery("Select * from ROLE where EMPLOYEE_ID = '" + employeeID + "'");
        foreach (DataRow item in data.Rows) {
            return new CRole(item);
        }
        return null;
    }

    public List<EmployeePhoneNumber> GetPhoneNumbersByEmployeeId(int employeeId) {
        string query = @"
            SELECT EmployeePhoneNumber.EmployeePhoneNumberId
                , EmployeePhoneNumber.PhoneNumber
                , EmployeePhoneNumber.EmployeeId
            FROM EmployeePhoneNumber
            INNER JOIN Employee
                    ON Employee.EmployeeId = EmployeePhoneNumber.EmployeeId
            WHERE Employee.EmployeeId = @EmployeeId
            AND Employee.IsDeleted = 0
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("EmployeeId", SqlDbType.Int, employeeId);

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, [.. parameters]);

        List<EmployeePhoneNumber> listPhoneNumber = [];
        foreach (DataRow row in dataTable.Rows)
        {
            EmployeePhoneNumber phoneNumber = EmployeePhoneNumberMapper.FromDataRow(row);
            listPhoneNumber.Add(phoneNumber);
        }
        return listPhoneNumber;
    }
}
