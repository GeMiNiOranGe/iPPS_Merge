using Pepro.Business.Mappings;
using Pepro.DataAccess;
using Pepro.DataAccess.Entities;
using Pepro.DTOs;

namespace Pepro.Business;

public class StatusBusiness
{
    private static StatusBusiness? _instance;

    public static StatusBusiness Instance
    {
        get => _instance ??= new();
        private set => _instance = value;
    }

    private StatusBusiness() { }

    public List<StatusDto> GetStatuses()
    {
        List<Status> statuses = StatusDataAccess.Instance.GetStatuses();
        return statuses.ToDtos();
    }
}
