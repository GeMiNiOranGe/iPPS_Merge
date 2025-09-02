namespace Pepro.DataAccess.Contracts;

public class EmployeeUpdate
{
    private TrackedValue<string> _firstName = new();
    private TrackedValue<string?> _middleName = new();
    private TrackedValue<string> _lastName = new();
    private TrackedValue<DateOnly> _dateOfBirth = new();
    private TrackedValue<bool?> _gender = new();
    private TrackedValue<byte[]?> _taxCode = new();
    private TrackedValue<string> _citizenId = new();
    private TrackedValue<int> _departmentId = new();
    private TrackedValue<int> _positionId = new();
    private TrackedValue<int> _salaryLevelId = new();

    public required TrackedValue<string> FirstName
    {
        get => _firstName;
        set => _firstName = value;
    }

    public required TrackedValue<string?> MiddleName
    {
        get => _middleName;
        set => _middleName = value;
    }

    public required TrackedValue<string> LastName
    {
        get => _lastName;
        set => _lastName = value;
    }

    public required TrackedValue<DateOnly> DateOfBirth
    {
        get => _dateOfBirth;
        set => _dateOfBirth = value;
    }

    public required TrackedValue<bool?> Gender
    {
        get => _gender;
        set => _gender = value;
    }

    public required TrackedValue<byte[]?> TaxCode
    {
        get => _taxCode;
        set => _taxCode = value;
    }

    public required TrackedValue<string> CitizenId
    {
        get => _citizenId;
        set => _citizenId = value;
    }

    public required TrackedValue<int> DepartmentId
    {
        get => _departmentId;
        set => _departmentId = value;
    }

    public required TrackedValue<int> PositionId
    {
        get => _positionId;
        set => _positionId = value;
    }

    public required TrackedValue<int> SalaryLevelId
    {
        get => _salaryLevelId;
        set => _salaryLevelId = value;
    }
}
