namespace Pepro.Domain.Entities;

public class EmployeePhoneNumber
{
    private int _employeePhoneNumberId;
    private int _employeeId;
    private string _phoneNumber = null!;

    public required int EmployeePhoneNumberId
    {
        get => _employeePhoneNumberId;
        set => _employeePhoneNumberId = value;
    }

    public required int EmployeeId
    {
        get => _employeeId;
        set => _employeeId = value;
    }

    public required string PhoneNumber
    {
        get => _phoneNumber;
        set => _phoneNumber = value;
    }
}
