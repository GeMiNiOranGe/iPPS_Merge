using DocumentFormat.OpenXml.Bibliography;
using Pepro.Business.Mappings;
using Pepro.Business.Utilities;
using Pepro.DataAccess;
using Pepro.DataAccess.Contracts;
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

    public int UpdateEmployee(EmployeeDto dto)
    {
        Employee? entity = EmployeeDataAccess.Instance.GetEmployeeByEmployeeId(dto.EmployeeId);
        if (entity == null)
        {
            return 0;
        }

        bool? gender = EmployeeHelper.ParseGender(dto.Gender);
        byte[]? encryptedTaxCode = EncryptionConverter.EncryptFromString(dto.TaxCode);
        string? taxCode = EncryptionConverter.DecryptToString(entity.TaxCode);

        EmployeeUpdate updateInfo = new()
        {
            FirstName = new(dto.FirstName, entity.FirstName != dto.FirstName),
            MiddleName = new(dto.MiddleName, entity.MiddleName != dto.MiddleName),
            LastName = new(dto.LastName, entity.LastName != dto.LastName),
            DateOfBirth = new(dto.DateOfBirth, entity.DateOfBirth != dto.DateOfBirth),
            Gender = new(gender, entity.Gender != gender),
            TaxCode = new(encryptedTaxCode, taxCode != dto.TaxCode),
            CitizenId = new(dto.CitizenId, entity.CitizenId != dto.CitizenId),
            DepartmentId = new(dto.DepartmentId, entity.DepartmentId != dto.DepartmentId),
            PositionId = new(dto.PositionId, entity.PositionId != dto.PositionId),
            SalaryLevelId = new(dto.SalaryLevelId, entity.SalaryLevelId != dto.SalaryLevelId)
        };
        return EmployeeDataAccess.Instance.UpdateEmployee(dto.EmployeeId, updateInfo);
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

    public List<EmployeeDto> GetEmployeesByDepartmentId(int departmentId)
    {
        List<Employee> employees = EmployeeDataAccess.Instance.GetEmployeesByDepartmentId(departmentId);
        return employees.ToDtos();
    }

    public object? GetEmployeesByAssignmentId(int assignmentId)
    {
        List<Employee> employees = EmployeeDataAccess.Instance.GetEmployeesByAssignmentId(assignmentId);
        return employees.ToDtos();
    }
}
