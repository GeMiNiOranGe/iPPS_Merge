namespace Pepro.DataAccess.Contracts;

public class ProjectUpdate
{
    private TrackedValue<string> _projectId = new();
    private TrackedValue<string> _name = new();
    private TrackedValue<string> _customerName = new();
    private TrackedValue<int> _managerId = new();
    private TrackedValue<DateTime> _startDate = new();
    private TrackedValue<DateTime> _endDate = new();
    private TrackedValue<int> _statusId = new();

    public TrackedValue<string> ProjectId
    {
        get => _projectId;
        set => _projectId = value;
    }

    public TrackedValue<string> Name
    {
        get => _name;
        set => _name = value;
    }

    public TrackedValue<string> CustomerName
    {
        get => _customerName;
        set => _customerName = value;
    }

    public TrackedValue<int> ManagerId
    {
        get => _managerId;
        set => _managerId = value;
    }

    public TrackedValue<DateTime> StartDate
    {
        get => _startDate;
        set => _startDate = value;
    }

    public TrackedValue<DateTime> EndDate
    {
        get => _endDate;
        set => _endDate = value;
    }

    public TrackedValue<int> StatusId
    {
        get => _statusId;
        set => _statusId = value;
    }
}
