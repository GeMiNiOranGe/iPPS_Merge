using Pepro.Business.Mappings;
using Pepro.DataAccess;
using Pepro.DataAccess.Entities;
using Pepro.DTOs;

namespace Pepro.Business;

public class StatusBusiness
{
    private static StatusBusiness? instance;

    public static StatusBusiness Instance
    {
        get => instance ??= new();
        private set => instance = value;
    }

    private StatusBusiness() { }

    public List<StatusDto> GetStatuses()
    {
        List<Status> statuses = StatusDataAccess.Instance.GetStatuses();
        return statuses.ToDtos();
    }
}
