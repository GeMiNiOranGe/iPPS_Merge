namespace Pepro.DataAccess.Contracts;

public class DepartmentInsertModel
{
    private string _name = null!;
    private int? _managerId;

    public required string Name
    {
        get => _name;
        set => _name = value;
    }

    public required int? ManagerId
    {
        get => _managerId;
        set => _managerId = value;
    }
}
