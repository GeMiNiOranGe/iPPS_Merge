namespace Pepro.DataAccess.Contracts;

public class InsertProjectModel
{
    private string _name = null!;
    private string _customerName = null!;
    private DateTime _startDate;
    private DateTime _endDate;
    private int? _managerId;
    private int _statusId;

    public required string Name
    {
        get => _name;
        set => _name = value;
    }

    public required string CustomerName
    {
        get => _customerName;
        set => _customerName = value;
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

    public required int? ManagerId
    {
        get => _managerId;
        set => _managerId = value;
    }

    public required int StatusId
    {
        get => _statusId;
        set => _statusId = value;
    }
}
