namespace Pepro.DTOs;

public class ProjectView : ProjectDto
{
    private string _statusName = "";

    public string StatusName
    {
        get => _statusName;
        set => _statusName = value;
    }
}
