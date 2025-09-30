using System.Data;
using Pepro.DataAccess.Entities;

namespace Pepro.DataAccess.Mappings;

static class RoleMapper
{
    public static Role FromDataRow(DataRow row)
    {
        return new Role()
        {
            RoleId = row.Field<int>("RoleId"),
            Name = row.Field<string>("Name") ?? "",
            IsDeleted = row.Field<bool>("IsDeleted"),
            CreatedAt = row.Field<DateTime>("CreatedAt"),
            UpdatedAt = row.Field<DateTime>("UpdatedAt"),
            DeletedAt = row.Field<DateTime?>("DeletedAt"),
        };
    }
}
