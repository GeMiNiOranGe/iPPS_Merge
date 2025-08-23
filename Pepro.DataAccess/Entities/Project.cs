namespace Pepro.DataAccess.Entities;

public class Project {
    private string _projectId = null!;
    private string _name = null!;
    private string _customerName = null!;
    private int _managerId;
    private DateTime _startDate;
    private DateTime _endDate;
    private int _statusId;

    #region Optional fields
    private bool _isDeleted;
    #endregion

    public required string ProjectId {
        get => _projectId;
        set => _projectId = value;
    }

    public required string Name {
        get => _name;
        set => _name = value;
    }

    public required string CustomerName {
        get => _customerName;
        set => _customerName = value;
    }

    public required int ManagerId {
        get => _managerId;
        set => _managerId = value;
    }

    public required DateTime StartDate {
        get => _startDate;
        set => _startDate = value;
    }

    public required DateTime EndDate {
        get => _endDate;
        set => _endDate = value;
    }

    public required int StatusId {
        get => _statusId;
        set => _statusId = value;
    }

    public bool IsDeleted {
        get => _isDeleted;
        set => _isDeleted = value;
    }
}
