namespace Pepro.DTOs;

public class EmployeePhoneNumberDto
{
    private int _employeePhoneNumberId;
    private int _employeeId;
    private string _phoneNumber = "";

    public int EmployeePhoneNumberId
    {
        get => _employeePhoneNumberId;
        set => _employeePhoneNumberId = value;
    }

    public int EmployeeId
    {
        get => _employeeId;
        set => _employeeId = value;
    }

    public string PhoneNumber
    {
        get => _phoneNumber;
        set => _phoneNumber = value;
    }
}
