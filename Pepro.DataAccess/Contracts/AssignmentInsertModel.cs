namespace Pepro.DataAccess.Contracts;

public class AssignmentInsertModel
{
    private string _name = null!;
    private bool _isPublicToProject;
    private bool _isPublicToDepartment;
    private DateTime _startDate;
    private DateTime _endDate;
    private int _requiredDocumentCount;
    private int? _managerId;
    private int _projectId;
    private int _statusId;

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public bool IsPublicToProject
    {
        get => _isPublicToProject;
        set => _isPublicToProject = value;
    }

    public bool IsPublicToDepartment
    {
        get => _isPublicToDepartment;
        set => _isPublicToDepartment = value;
    }

    public DateTime StartDate
    {
        get => _startDate;
        set => _startDate = value;
    }

    public DateTime EndDate
    {
        get => _endDate;
        set => _endDate = value;
    }

    public int RequiredDocumentCount
    {
        get => _requiredDocumentCount;
        set => _requiredDocumentCount = value;
    }

    public int? ManagerId
    {
        get => _managerId;
        set => _managerId = value;
    }

    public int ProjectId
    {
        get => _projectId;
        set => _projectId = value;
    }

    public int StatusId
    {
        get => _statusId;
        set => _statusId = value;
    }
}