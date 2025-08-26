namespace Pepro.DTOs;

public class ProjectProgress {
    private int _projectId;
    private string _name = "";
    private string _customerName = "";
    private int _managerId;
    private DateTime _startDate;
    private DateTime _endDate;
    private int _statusId;
    private decimal _progressPercent;

    public int ProjectId {
        get => _projectId;
        set => _projectId = value;
    }

    public string Name {
        get => _name;
        set => _name = value;
    }

    public string CustomerName {
        get => _customerName;
        set => _customerName = value;
    }

    public int ManagerId {
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

    public int StatusId {
        get => _statusId;
        set => _statusId = value;
    }

    public decimal ProgressPercent {
        get => _progressPercent;
        set => _progressPercent = value;
    }
}
