using System.Data;
using Pepro.DataAccess.Entities;

namespace Pepro.DataAccess.Mappings;

static class StatusMapper
{
    public static Status FromDataRow(DataRow row)
    {
        return new Status()
        {
            StatusId = row.Field<int>("StatusId"),
            Name = row.Field<string>("Name") ?? "",
        };
    }
}
