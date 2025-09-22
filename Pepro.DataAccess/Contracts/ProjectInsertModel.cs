namespace Pepro.DataAccess.Contracts;

public class ProjectInsertModel
{
    private string _name = null!;
    private string _customerName = null!;
    private DateTime _startDate;
    private DateTime _endDate;
    private int? _managerId;
    private int _statusId;

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public string CustomerName
    {
        get => _customerName;
        set => _customerName = value;
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

    public int? ManagerId
    {
        get => _managerId;
        set => _managerId = value;
    }

    public int StatusId
    {
        get => _statusId;
        set => _statusId = value;
    }
}
