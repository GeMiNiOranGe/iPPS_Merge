namespace Pepro.DTOs;

public class AssignmentProgressView : AssignmentDto 
{
    private decimal _progressPercent;

    public decimal ProgressPercent
    {
        get => _progressPercent;
        set => _progressPercent = value;
    }
}
