using Microsoft.Data.SqlClient;
using Pepro.DataAccess;
using Pepro.DTOs;
using System.Data;

namespace Pepro.Business;

public class EmployeeBusiness
{
    private static EmployeeBusiness? instance;

    public static EmployeeBusiness Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private EmployeeBusiness() { }

    public string GetFullname(string accountName) {
        return EmployeeDataAccess.Instance.GetFullname(accountName);
    }

    public DataTable GetEmployeesByRoleID(int roleID)
    {
        return EmployeeDataAccess.Instance.getEmployeeByRoleID(roleID);
    }

    public bool updateEmployee(int roleID, string valueList, string employeeID)
    {
        SqlParameter[] parameters = new SqlParameter[]
        {
            new SqlParameter("@RoleID", SqlDbType.Int) { Value = roleID },
            new SqlParameter("@ValueList", SqlDbType.NVarChar) { Value = valueList },
            new SqlParameter("@EmployeeID", SqlDbType.VarChar) { Value = employeeID }
        };

        int kq = EmployeeDataAccess.Instance.ExecuteStoredProcedure("usp_UpdateEmployee", parameters);
        return kq > 0;
    }

    public bool deleteEmployee(int roleID, string employeeID)
    {
        return EmployeeDataAccess.Instance.deleteEmployee(roleID, employeeID);
    }

    public void InsertEmployee(string employeeId, string fullname, bool? gender, DateTime? dateOfBirth, string phoneNumber, string salary, string allowance, string taxCode, string departmentId)
    {
        EmployeeDataAccess.Instance.InsertEmployee(employeeId, fullname, gender, dateOfBirth, phoneNumber, salary, allowance, taxCode, departmentId);
    }

    public CEmployee getEmployeebyEmployeeID(string employeeID) {
        return EmployeeDataAccess.Instance.getEmployeebyEmployeeID(employeeID);
    }

    public CRole getRolebyEmployeeID(string employeeID) {
        return EmployeeDataAccess.Instance.getRolebyEmployeeID(employeeID);
    }

    public CDepartment getDepartmentbyDepartmentID(string departmentID) {
        return EmployeeDataAccess.Instance.getDepartmentbyDepartmentID(departmentID);
    }

    public List<CEmployeeBelongToProject> getProjectIDbyEmployeeID(string employeeID) {
        return EmployeeDataAccess.Instance.getProjectIDbyEmployeeID(employeeID);
    }

    public CProject getProjectbyProjectID(string projectID) {
        return EmployeeDataAccess.Instance.getProjectbyProjectID(projectID);
    }

    public List<CEmployeePhoneNumber> getPhoneNumberbyEmployeeID(string employeeID) {
        return EmployeeDataAccess.Instance.getPhoneNumberbyEmployeeID(employeeID);
    }
}
