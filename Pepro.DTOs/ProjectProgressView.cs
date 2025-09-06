namespace Pepro.DTOs;

public class ProjectProgressView : ProjectDto
{
    private decimal _progressPercent;

    public decimal ProgressPercent
    {
        get => _progressPercent;
        set => _progressPercent = value;
    }
}
