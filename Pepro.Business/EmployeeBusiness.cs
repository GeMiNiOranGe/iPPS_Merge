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

    public string GetDisplayName(string accountName)
    {
        EmployeeFullName? employeeFullName = EmployeeDataAccess.Instance.GetFullname(accountName);
        return employeeFullName != null
            ? employeeFullName.FirstName + ", " + employeeFullName.LastName
            : "";
    }

    public DataTable GetEmployeesByRoleID(int roleID)
    {
        return EmployeeDataAccess.Instance.GetEmployeeByRoleID(roleID);
    }

    public bool UpdateEmployee(int roleID, string valueList, string employeeID)
    {
        return EmployeeDataAccess.Instance.UpdateEmployee(roleID, valueList, employeeID);
    }

    public bool DeleteEmployee(int roleID, string employeeID)
    {
        return EmployeeDataAccess.Instance.DeleteEmployee(roleID, employeeID);
    }

    public void InsertEmployee(string employeeId, string fullname, bool? gender, DateTime? dateOfBirth, string phoneNumber, string salary, string allowance, string taxCode, string departmentId)
    {
        EmployeeDataAccess.Instance.InsertEmployee(employeeId, fullname, gender, dateOfBirth, phoneNumber, salary, allowance, taxCode, departmentId);
    }

    public Employee GetEmployeeByEmployeeId(string employeeID) {
        Employee? employee = EmployeeDataAccess.Instance.GetEmployeeByEmployeeId(employeeID);
        if (employee == null) {
            return new Employee();
        }
        return employee;
    }

    public CRole GetRolebyEmployeeID(string employeeID) {
        return EmployeeDataAccess.Instance.GetRolebyEmployeeID(employeeID);
    }

    public List<CEmployeeBelongToProject> GetProjectIDbyEmployeeID(string employeeID) {
        return EmployeeDataAccess.Instance.GetProjectIDbyEmployeeID(employeeID);
    }

    public CProject GetProjectbyProjectID(string projectID) {
        return EmployeeDataAccess.Instance.GetProjectbyProjectID(projectID);
    }

    public string[] GetPhoneNumberListByEmployeeId(string employeeID) {
        List<EmployeePhoneNumber> employeePhoneNumbers = EmployeeDataAccess.Instance.GetPhoneNumberListByEmployeeId(employeeID);
        List<string> phoneNumbers = [];
        foreach (EmployeePhoneNumber phoneNumber in employeePhoneNumbers)
        {
            phoneNumbers.Add(phoneNumber.PhoneNumber);
        }
        return [.. phoneNumbers];
    }
}
