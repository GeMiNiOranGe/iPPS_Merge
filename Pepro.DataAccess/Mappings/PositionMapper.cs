using System.Data;
using Pepro.DataAccess.Entities;

namespace Pepro.DataAccess.Mappings;

static class PositionMapper
{
    public static Position FromDataRow(DataRow row)
    {
        return new Position()
        {
            PositionId = row.Field<int>("PositionId"),
            Title = row.Field<string>("Title") ?? "",
            AllowancePercent = row.Field<decimal>("AllowancePercent"),
        };
    }
}
