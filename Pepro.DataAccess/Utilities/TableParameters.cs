using System.Data;

namespace Pepro.DataAccess.Utilities;

public static class TableParameters
{
    public static DataTable CreateEntityIds(IEnumerable<int> ids)
    {
        DataTable dataTable = new();
        dataTable.Columns.Add("Id", typeof(int));
        foreach (int id in ids)
        {
            dataTable.Rows.Add(id);
        }

        return dataTable;
    }
}
