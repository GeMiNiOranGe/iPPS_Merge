namespace Pepro.DataAccess.Contracts;

public class RoleInsertModel
{
    private string _name = null!;

    public required string Name
    {
        get => _name;
        set => _name = value;
    }
}
