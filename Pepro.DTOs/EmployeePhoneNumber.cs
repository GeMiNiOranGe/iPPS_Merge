namespace Pepro.DTOs;

public class EmployeePhoneNumber
{
    private int _employeePhoneNumberId;
    private string _employeeId = "";
    private string _phoneNumber = "";

    public int EmployeePhoneNumberId
    {
        get => _employeePhoneNumberId;
        set => _employeePhoneNumberId = value;
    }

    public string EmployeeId
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
