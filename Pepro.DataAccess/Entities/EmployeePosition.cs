namespace Pepro.DataAccess.Entities;

public class EmployeePosition
{
    private int _positionId;
    private string _title = "";
    private decimal _allowanceCoefficient;

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

    public required decimal AllowanceCoefficient
    {
        get => _allowanceCoefficient;
        set => _allowanceCoefficient = value;
    }
}
