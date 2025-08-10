namespace Pepro.DTOs;

public class AccountDto {
    private int accountId;
    private string username = "";
    private bool isActive;
    private string employeeId = "";

    public int AccountId {
        get => accountId;
        set => accountId = value;
    }

    public string Username {
        get => username;
        set => username = value;
    }

    public bool IsActive {
        get => isActive;
        set => isActive = value;
    }

    public string EmployeeId {
        get => employeeId;
        set => employeeId = value;
    }
}
