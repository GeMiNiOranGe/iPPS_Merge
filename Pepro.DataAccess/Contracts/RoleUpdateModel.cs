namespace Pepro.DataAccess.Contracts;

public class RoleUpdateModel
{
    private TrackedValue<string> _name = new();

    public TrackedValue<string> Name
    {
        get => _name;
        set => _name = value;
    }
}
