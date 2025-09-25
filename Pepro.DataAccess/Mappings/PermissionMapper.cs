using System.Data;
using Pepro.DataAccess.Entities;

namespace Pepro.DataAccess.Mappings;

static class PermissionMapper
{
    public static Permission FromDataRow(DataRow row)
    {
        return new Permission
        {
            PermissionId = row.Field<int>("PermissionId"),
            Key = row.Field<string>("Key") ?? "",
        };
    }
}
