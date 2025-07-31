namespace Pepro.DTOs;

public class Employee {
    private string _employeeId = "";
    private string _firstName = "";
    private string? _middleName;
    private string _lastName = "";
    private DateTime _dateOfBirth;
    private bool? _gender; // true is male, false is female, null is other
    private byte[]? _taxCode;
    private string _citizenId = "";
    private string _departmentId = "";
    private int _jobPositionId;
    private int _salaryLevelId;

    public string EmployeeId {
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

    public int JobPositionId {
        get => _jobPositionId;
        set => _jobPositionId = value;
    }

    public int SalaryLevelId {
        get => _salaryLevelId;
        set => _salaryLevelId = value;
    }
}
