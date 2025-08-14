namespace Pepro.DTOs;

public class LoginResult
{
    private int _employeeId;

    public int EmployeeId
    {
        get => _employeeId;
        set => _employeeId = value;
    }

    public LoginStatus Status
    {
        get;
        set;
    }
}
