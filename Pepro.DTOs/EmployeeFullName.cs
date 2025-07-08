namespace Pepro.DTOs;

public class EmployeeFullName
{
    private string _firstName = "";
    private string? _middleName;
    private string _lastName = "";

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
}