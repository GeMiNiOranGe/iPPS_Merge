namespace Pepro.Domain.Entities;

public class Department
{
    private string _departmentId = null!;
    private string _name = null!;
    private int _managerId;

    public required string DepartmentId
    {
        get => _departmentId;
        set => _departmentId = value;
    }

    public required string Name
    {
        get => _name;
        set => _name = value;
    }

    public required int ManagerId
    {
        get => _managerId;
        set => _managerId = value;
    }
}
