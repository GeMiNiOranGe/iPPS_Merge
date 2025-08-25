namespace Pepro.DataAccess.Entities;

public class Employee
{
    private int _employeeId;
    private string _firstName = null!;
    private string? _middleName;
    private string _lastName = null!;
    private DateOnly _dateOfBirth;
    private bool? _gender;
    private byte[]? _taxCode;
    private string _citizenId = null!;
    private string _departmentId = null!;
    private int _positionId;
    private int _salaryLevelId;

    #region Optional fields
    private bool _isDeleted;
    private DateTime _createdAt;
    private DateTime _updatedAt;
    private DateTime? _deletedAt;
    #endregion

    public required int EmployeeId
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

    public required DateOnly DateOfBirth
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
        get => _positionId;
        set => _positionId = value;
    }

    public required int SalaryLevelId
    {
        get => _salaryLevelId;
        set => _salaryLevelId = value;
    }

    public bool IsDeleted
    {
        get => _isDeleted;
        set => _isDeleted = value;
    }

    public DateTime CreatedAt
    {
        get => _createdAt;
        set => _createdAt = value;
    }

    public DateTime UpdatedAt
    {
        get => _updatedAt;
        set => _updatedAt = value;
    }

    public DateTime? DeletedAt
    {
        get => _deletedAt;
        set => _deletedAt = value;
    }
}
