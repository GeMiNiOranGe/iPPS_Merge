namespace Pepro.DataAccess.Contracts;

public class EmployeeInsertModel
{
    private string _firstName = null!;
    private string? _middleName = null!;
    private string _lastName = null!;
    private DateOnly _dateOfBirth;
    private bool? _gender;
    private byte[]? _taxCode = null!;
    private string _citizenId = null!;
    private int _departmentId;
    private int _positionId;
    private int _salaryLevelId;

    public string FirstName
    {
        get => _firstName;
        set => _firstName = value;
    }

    public string? MiddleName
    {
        get => _middleName;
        set => _middleName = value;
    }

    public string LastName
    {
        get => _lastName;
        set => _lastName = value;
    }

    public DateOnly DateOfBirth
    {
        get => _dateOfBirth;
        set => _dateOfBirth = value;
    }

    public bool? Gender
    {
        get => _gender;
        set => _gender = value;
    }

    public byte[]? TaxCode
    {
        get => _taxCode;
        set => _taxCode = value;
    }

    public string CitizenId
    {
        get => _citizenId;
        set => _citizenId = value;
    }

    public int DepartmentId
    {
        get => _departmentId;
        set => _departmentId = value;
    }

    public int PositionId
    {
        get => _positionId;
        set => _positionId = value;
    }

    public int SalaryLevelId
    {
        get => _salaryLevelId;
        set => _salaryLevelId = value;
    }
}