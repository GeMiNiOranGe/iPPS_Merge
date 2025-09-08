namespace Pepro.DataAccess.Entities;

public class Position
{
    private int _positionId;
    private string _title = null!;
    private decimal _allowancePercent;

    public required int PositionId
    {
        get => _positionId;
        set => _positionId = value;
    }

    public required string Title
    {
        get => _title;
        set => _title = value;
    }

    public required decimal AllowancePercent
    {
        get => _allowancePercent;
        set => _allowancePercent = value;
    }
}
