namespace Pepro.DataAccess.Entities;

public class EmployeePhoneNumber
{
    private int _employeePhoneNumberId;
    private string _employeeId = "";
    private string _phoneNumber = "";

    public required int EmployeePhoneNumberId
    {
        get => _employeePhoneNumberId;
        set => _employeePhoneNumberId = value;
    }

    public required string EmployeeId
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
