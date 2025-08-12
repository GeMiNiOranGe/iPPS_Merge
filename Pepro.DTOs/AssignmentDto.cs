namespace Pepro.DTOs;

public class AssignmentDto {
    private int _assignmentId;
    private string _name = "";
    private bool _isPublicToProject;
    private bool _isPublicToDepartment;
    private string _managerId = "";
    private DateTime _startDate;
    private DateTime _endDate;
    private string _projectId = "";
    private int _statusId;
    private AccessLevel _accessRight;

    public int AssignmentId {
        get => _assignmentId;
        set => _assignmentId = value;
    }

    public string Name {
        get => _name;
        set => _name = value;
    }

    public bool IsPublicToProject {
        get => _isPublicToProject;
        set => _isPublicToProject = value;
    }

    public bool IsPublicToDepartment {
        get => _isPublicToDepartment;
        set => _isPublicToDepartment = value;
    }

    public string ManagerId {
        get => _managerId;
        set => _managerId = value;
    }

    public DateTime StartDate {
        get => _startDate;
        set => _startDate = value;
    }

    public DateTime EndDate {
        get => _endDate;
        set => _endDate = value;
    }

    public string ProjectId {
        get => _projectId;
        set => _projectId = value;
    }

    public int StatusId {
        get => _statusId;
        set => _statusId = value;
    }

    public AccessLevel AccessRight {
        get => _accessRight;
        set => _accessRight = value;
    }
}
