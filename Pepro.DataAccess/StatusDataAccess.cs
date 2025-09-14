using System.Data;
using Pepro.DataAccess.Entities;
using Pepro.DataAccess.Mappings;
using Pepro.DataAccess.Utilities;

namespace Pepro.DataAccess;

public class StatusDataAccess
{
    private static StatusDataAccess? _instance;

    public static StatusDataAccess Instance
    {
        get => _instance ??= new();
        private set => _instance = value;
    }

    private StatusDataAccess() { }

    public List<Status> GetStatuses()
    {
        string query = @"
            SELECT Status.StatusId
                , Status.Name
            FROM Status
        ";

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

        List<Status> statuses = [];
        foreach (DataRow row in dataTable.Rows)
        {
            Status status = StatusMapper.FromDataRow(row);
            statuses.Add(status);
        }
        return statuses;
    }
}
