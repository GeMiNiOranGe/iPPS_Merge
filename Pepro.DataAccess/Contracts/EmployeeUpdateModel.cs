namespace Pepro.DataAccess.Contracts;

public class EmployeeUpdateModel
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

    public TrackedValue<string> FirstName
    {
        get => _firstName;
        set => _firstName = value;
    }

    public TrackedValue<string?> MiddleName
    {
        get => _middleName;
        set => _middleName = value;
    }

    public TrackedValue<string> LastName
    {
        get => _lastName;
        set => _lastName = value;
    }

    public TrackedValue<DateOnly> DateOfBirth
    {
        get => _dateOfBirth;
        set => _dateOfBirth = value;
    }

    public TrackedValue<bool?> Gender
    {
        get => _gender;
        set => _gender = value;
    }

    public TrackedValue<byte[]?> TaxCode
    {
        get => _taxCode;
        set => _taxCode = value;
    }

    public TrackedValue<string> CitizenId
    {
        get => _citizenId;
        set => _citizenId = value;
    }

    public TrackedValue<int> DepartmentId
    {
        get => _departmentId;
        set => _departmentId = value;
    }

    public TrackedValue<int> PositionId
    {
        get => _positionId;
        set => _positionId = value;
    }

    public TrackedValue<int> SalaryLevelId
    {
        get => _salaryLevelId;
        set => _salaryLevelId = value;
    }
}
