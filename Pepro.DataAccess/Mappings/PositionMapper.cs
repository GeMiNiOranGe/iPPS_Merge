using System.Data;
using Pepro.DataAccess.Entities;

namespace Pepro.DataAccess.Mappings;

static class PositionMapper
{
    public static EmployeePosition FromDataRow(DataRow row)
    {
        return new EmployeePosition()
        {
            PositionId = row.Field<int>("PositionId"),
            Title = row.Field<string>("Title") ?? "",
            AllowanceCoefficient = row.Field<decimal>("AllowanceCoefficient"),
        };
    }
}
