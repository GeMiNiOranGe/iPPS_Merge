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

    public string GetFullname(string accountName) {
        string query = $"SELECT FirstName, MiddleName, LastName FROM Employee WHERE Employee.EmployeeId = N'{accountName}'";

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
        if (dataTable.Rows.Count == 0) {
            return "";
        }

        DataRow row = dataTable.Rows[0];

        return row.Field<string>("FirstName") + ", " + row.Field<string>("LastName");
    }

    public int ExecuteStoredProcedure(string storedProcedureName, SqlParameter[] parameters) {
        using (SqlConnection connection = new SqlConnection("")) {
            connection.Open();
            SqlCommand command = new SqlCommand(storedProcedureName, connection);
            command.CommandType = CommandType.StoredProcedure;

            if (parameters != null) {
                command.Parameters.AddRange(parameters);
            }

            return command.ExecuteNonQuery();
        }
    }

    public DataTable getEmployeeByRoleID(int roleID) {
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

    public bool updateEmployee(int roleID, string valueList, string employeeID) {
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

    public bool deleteEmployee(int roleID, string employeeID) {
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

    //Lấy dữ liệu từ table EMPLOYEE trong database dựa vào ID 
    public CEmployee getEmployeebyEmployeeID(string employeeID) {
        DataTable data = DataProvider.Instance.ExecuteQuery("Select * from EMPLOYEE where ID = '" + employeeID + "'");
        foreach (DataRow item in data.Rows) {
            return new CEmployee(item);
        }
        return null;
    }

    //Lấy dữ liệu từ table ROLE trong database dựa vào EMPLOYEE_ID
    public CRole getRolebyEmployeeID(string employeeID) {
        DataTable data = DataProvider.Instance.ExecuteQuery("Select * from ROLE where EMPLOYEE_ID = '" + employeeID + "'");
        foreach (DataRow item in data.Rows) {
            return new CRole(item);
        }
        return null;
    }

    //Lấy dữ liệu từ table DEPARTMENT trong database dựa vào ID
    public CDepartment getDepartmentbyDepartmentID(string departmentID) {
        DataTable data = DataProvider.Instance.ExecuteQuery("Select * from DEPARTMENT where ID = '" + departmentID + "'");
        foreach (DataRow item in data.Rows) {
            return new CDepartment(item);
        }
        return null;
    }

    //Lấy dữ liệu từ table EMPLOYEE_BELONG_TO_PROJECT trong database dựa vào EMPLOYEE_ID
    public List<CEmployeeBelongToProject> getProjectIDbyEmployeeID(string employeeID) {
        List<CEmployeeBelongToProject> listProjectID = new List<CEmployeeBelongToProject>();
        DataTable data = DataProvider.Instance.ExecuteQuery("Select * from EMPLOYEE_BELONG_TO_PROJECT where EMPLOYEE_ID = '" + employeeID + "'");
        foreach (DataRow item in data.Rows) {
            CEmployeeBelongToProject projectID = new CEmployeeBelongToProject(item);
            listProjectID.Add(projectID);
        }
        return listProjectID;
    }

    //Lấy dữ liệu từ table PROJECT trong database dựa vào ID
    public CProject getProjectbyProjectID(string projectID) {
        DataTable data = DataProvider.Instance.ExecuteQuery("Select * from PROJECT where ID = '" + projectID + "'");
        foreach (DataRow item in data.Rows) {
            return new CProject(item);
        }
        return null;
    }

    //Lấy dữ liệu từ table EMPLOYEE_PHONE_NUMBER trong database dựa vào EMPLOYEE_ID
    public List<CEmployeePhoneNumber> getPhoneNumberbyEmployeeID(string employeeID) {
        List<CEmployeePhoneNumber> listPhoneNumber = new List<CEmployeePhoneNumber>();
        DataTable data = DataProvider.Instance.ExecuteQuery("Select * from EMPLOYEE_PHONE_NUMBER where EMPLOYEE_ID = '" + employeeID + "'");
        foreach (DataRow item in data.Rows) {
            CEmployeePhoneNumber phoneNumber = new CEmployeePhoneNumber(item);
            listPhoneNumber.Add(phoneNumber);
        }
        return listPhoneNumber;
    }
}
