namespace Pepro.DTOs;

public class EmployeeDto {
    private int _employeeId;
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

    public int EmployeeId {
        get => _employeeId;
        set => _employeeId = value;
    }

    public string FirstName {
        get => _firstName;
        set => _firstName = value;
    }

    public string? MiddleName {
        get => _middleName;
        set => _middleName = value;
    }

    public string LastName {
        get => _lastName;
        set => _lastName = value;
    }

    public DateTime DateOfBirth {
        get => _dateOfBirth;
        set => _dateOfBirth = value;
    }

    public bool? Gender {
        get => _gender;
        set => _gender = value;
    }

    public byte[]? TaxCode {
        get => _taxCode;
        set => _taxCode = value;
    }

    public string CitizenId {
        get => _citizenId;
        set => _citizenId = value;
    }

    public string DepartmentId {
        get => _departmentId;
        set => _departmentId = value;
    }

    public int PositionId {
        get => _PositionId;
        set => _PositionId = value;
    }

    public int SalaryLevelId {
        get => _salaryLevelId;
        set => _salaryLevelId = value;
    }
}
