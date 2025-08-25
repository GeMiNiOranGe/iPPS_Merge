using System.Data;
using Pepro.DataAccess.Entities;

namespace Pepro.DataAccess.Mappings;

static class DepartmentMapper
{
    public static Department FromDataRow(DataRow row)
    {
        return new Department()
        {
            DepartmentId = row.Field<string>("DepartmentId") ?? "",
            Name = row.Field<string>("Name") ?? "",
            ManagerId = row.Field<int>("ManagerId"),
        };
    }
}
