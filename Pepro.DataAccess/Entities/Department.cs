namespace Pepro.DataAccess.Entities;

public class Department
{
    private string _departmentId = null!;
    private string _name = null!;
    private string _managerId = null!;

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

    public required string ManagerId
    {
        get => _managerId;
        set => _managerId = value;
    }
}
