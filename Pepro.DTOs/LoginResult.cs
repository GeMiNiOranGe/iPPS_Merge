namespace Pepro.DTOs;

public class LoginResult
{
    private string _employeeId = "";

    public string EmployeeId
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
