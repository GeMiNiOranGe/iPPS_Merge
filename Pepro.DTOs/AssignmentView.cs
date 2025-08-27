namespace Pepro.DTOs;

public class AssignmentView : AssignmentDto
{
    private string _statusName = "";

    public string StatusName
    {
        get => _statusName;
        set => _statusName = value;
    }
}