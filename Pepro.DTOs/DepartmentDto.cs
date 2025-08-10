namespace Pepro.DTOs;

public class DepartmentDto
{
    private string _departmentId = "";
    private string _name = "";
    private string _managerId = "";

    public string DepartmentId
    {
        get => _departmentId;
        set => _departmentId = value;
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public string ManagerId
    {
        get => _managerId;
        set => _managerId = value;
    }
}
