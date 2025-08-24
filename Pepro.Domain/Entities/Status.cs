namespace Pepro.Domain.Entities;

public class Status
{
    private int _statusId;
    private string _name = null!;

    public required int StatusId
    {
        get => _statusId;
        set => _statusId = value;
    }

    public required string Name
    {
        get => _name;
        set => _name = value;
    }
}
