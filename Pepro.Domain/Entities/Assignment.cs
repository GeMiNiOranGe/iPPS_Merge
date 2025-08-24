namespace Pepro.Domain.Entities;

public class Assignment
{
    private int _assignmentId;
    private string _name = null!;
    private bool _isPublicToProject;
    private bool _isPublicToDepartment;
    private int _managerId;
    private DateTime _startDate;
    private DateTime _endDate;
    private int _requiredDocumentCount;
    private string _projectId = null!;
    private int _statusId;

    public required int AssignmentId
    {
        get => _assignmentId;
        set => _assignmentId = value;
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

    public required int ManagerId
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

    public required int RequiredDocumentCount
    {
        get => _requiredDocumentCount;
        set => _requiredDocumentCount = value;
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
