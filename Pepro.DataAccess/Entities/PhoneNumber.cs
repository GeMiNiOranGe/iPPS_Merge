namespace Pepro.DataAccess.Entities;

public class PhoneNumber
{
    private int _phoneNumberId;
    private int _employeeId;
    private string _number = null!;

    public required int PhoneNumberId
    {
        get => _phoneNumberId;
        set => _phoneNumberId = value;
    }

    public required int EmployeeId
    {
        get => _employeeId;
        set => _employeeId = value;
    }

    public required string Number
    {
        get => _number;
        set => _number = value;
    }
}
