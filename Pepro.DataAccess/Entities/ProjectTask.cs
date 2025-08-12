namespace Pepro.DataAccess.Entities;

public class ProjectTask
{
    private int _taskId;
    private string _name = "";
    private bool _isPublicToProject;
    private bool _isPublicToDepartment;
    private string _managerId = "";
    private DateTime _startDate;
    private DateTime _endDate;
    private string _projectId = "";
    private int _statusId;

    public required int TaskId
    {
        get => _taskId;
        set => _taskId = value;
    }

    public required string Name
    {
        get => _name;
        set => _name = value;
    }

    public required bool IsPublicToProject
    {
        get => _isPublicToProject;
        set => _isPublicToProject = value;
    }

    public required bool IsPublicToDepartment
    {
        get => _isPublicToDepartment;
        set => _isPublicToDepartment = value;
    }

    public required string ManagerId
    {
        get => _managerId;
        set => _managerId = value;
    }

    public required DateTime StartDate
    {
        get => _startDate;
        set => _startDate = value;
    }

    public required DateTime EndDate
    {
        get => _endDate;
        set => _endDate = value;
    }

    public required string ProjectId
    {
        get => _projectId;
        set => _projectId = value;
    }

    public required int StatusId
    {
        get => _statusId;
        set => _statusId = value;
    }
}
