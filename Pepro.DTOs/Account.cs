namespace Pepro.DTOs;

public class Account {
    private int accountId;
    private string username = "";
    private byte[] salt = [];
    private byte[] password = [];
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

    public byte[] Salt {
        get => salt;
        set => salt = value;
    }

    public byte[] Password {
        get => password;
        set => password = value;
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
