namespace Pepro.DataAccess.Entities;

public class Employee
{
    private string _employeeId = "";
    private string _firstName = "";
    private string? _middleName;
    private string _lastName = "";
    private DateTime _dateOfBirth;
    private bool? _gender;
    private byte[]? _taxCode;
    private string _citizenId = "";
    private string _departmentId = "";
    private int _PositionId;
    private int _salaryLevelId;

    public required string EmployeeId
    {
        get => _employeeId;
        set => _employeeId = value;
    }

    public required string FirstName
    {
        get => _firstName;
        set => _firstName = value;
    }

    public required string? MiddleName
    {
        get => _middleName;
        set => _middleName = value;
    }

    public required string LastName
    {
        get => _lastName;
        set => _lastName = value;
    }

    public required DateTime DateOfBirth
    {
        get => _dateOfBirth;
        set => _dateOfBirth = value;
    }

    public required bool? Gender
    {
        get => _gender;
        set => _gender = value;
    }

    public required byte[]? TaxCode
    {
        get => _taxCode;
        set => _taxCode = value;
    }

    public required string CitizenId
    {
        get => _citizenId;
        set => _citizenId = value;
    }

    public required string DepartmentId
    {
        get => _departmentId;
        set => _departmentId = value;
    }

    public required int PositionId
    {
        get => _PositionId;
        set => _PositionId = value;
    }

    public required int SalaryLevelId
    {
        get => _salaryLevelId;
        set => _salaryLevelId = value;
    }
}
