namespace Pepro.DTOs;

public class PositionDto {
    private int _positionId;
    private string _title = "";
    private decimal _allowanceCoefficient;

    public int PositionId {
        get => _positionId;
        set => _positionId = value;
    }

    public string Title {
        get => _title;
        set => _title = value;
    }

    public decimal AllowanceCoefficient {
        get => _allowanceCoefficient;
        set => _allowanceCoefficient = value;
    }
}
