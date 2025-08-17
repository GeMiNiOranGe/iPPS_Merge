using Pepro.Business.Mappings;
using Pepro.DataAccess;
using Pepro.DataAccess.Entities;
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

    public List<EmployeeDto> GetEmployees()
    {
        List<Employee> employees = EmployeeDataAccess.Instance.GetEmployees();
        return employees.ToDtos();
    }

    public List<EmployeeDto> SearchEmployees(string searchValue)
    {
        List<Employee> employees = EmployeeDataAccess.Instance.SearchEmployees(searchValue);
        return employees.ToDtos();
    }

    public string GetDisplayNameByEmployeeId(int employeeId)
    {
        Employee? employee = EmployeeDataAccess.Instance.GetEmployeeByEmployeeId(employeeId);
        return employee != null
            ? employee.FirstName + ", " + employee.LastName
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

    public int DeleteEmployee(int employeeId)
    {
        return EmployeeDataAccess.Instance.DeleteEmployee(employeeId);
    }

    public bool DeleteEmployee(int roleID, string employeeID)
    {
        return EmployeeDataAccess.Instance.DeleteEmployee(roleID, employeeID);
    }

    public void InsertEmployee(string employeeId, string fullname, bool? gender, DateTime? dateOfBirth, string phoneNumber, string salary, string allowance, string taxCode, string departmentId)
    {
        EmployeeDataAccess.Instance.InsertEmployee(employeeId, fullname, gender, dateOfBirth, phoneNumber, salary, allowance, taxCode, departmentId);
    }

    public int InsertEmployee(EmployeeDto dto) {
        Employee entity = dto.ToEntity();
        Employee? employee = EmployeeDataAccess.Instance.AddEmployee(entity);
        if (employee == null) {
            return 0;
        }
        return AccountBusiness.Instance.InsertDefaultAccountByEmployee(employee);
    }

    public EmployeeDto? GetEmployeeByEmployeeId(int employeeID) {
        Employee? employee = EmployeeDataAccess.Instance.GetEmployeeByEmployeeId(employeeID);
        return employee?.ToDto();
    }

    public CRole GetRolebyEmployeeID(string employeeID) {
        return EmployeeDataAccess.Instance.GetRolebyEmployeeID(employeeID);
    }

    public string[] GetPhoneNumbersByEmployeeId(int employeeID) {
        List<EmployeePhoneNumber> employeePhoneNumbers = EmployeeDataAccess.Instance.GetPhoneNumbersByEmployeeId(employeeID);
        List<string> phoneNumbers = [];
        foreach (EmployeePhoneNumber phoneNumber in employeePhoneNumbers)
        {
            phoneNumbers.Add(phoneNumber.PhoneNumber);
        }
        return [.. phoneNumbers];
    }
}
