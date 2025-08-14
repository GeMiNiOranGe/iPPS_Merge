namespace Pepro.DTOs;

public class DepartmentDto
{
    private string _departmentId = "";
    private string _name = "";
    private int _managerId;

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

    public int ManagerId
    {
        get => _managerId;
        set => _managerId = value;
    }
}
