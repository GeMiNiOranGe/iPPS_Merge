namespace Pepro.DataAccess.Entities;

public class Department
{
    private string _departmentId = "";
    private string _name = "";
    private string _managerId = "";

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
