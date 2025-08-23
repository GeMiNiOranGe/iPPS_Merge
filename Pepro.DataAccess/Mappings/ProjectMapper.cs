using System.Data;
using Pepro.DataAccess.Entities;

namespace Pepro.DataAccess.Mappings;

static class ProjectMapper
{
    public static Project FromDataRow(DataRow row)
    {
        return new Project()
        {
            ProjectId = row.Field<string>("ProjectId") ?? "",
            Name = row.Field<string>("Name") ?? "",
            CustomerName = row.Field<string>("CustomerName") ?? "",
            ManagerId = row.Field<int>("ManagerId"),
            StartDate = row.Field<DateTime>("StartDate"),
            EndDate = row.Field<DateTime>("EndDate"),
            StatusId = row.Field<int>("StatusId"),
            IsDeleted = row.Field<bool>("IsDeleted"),
        };
    }
}
