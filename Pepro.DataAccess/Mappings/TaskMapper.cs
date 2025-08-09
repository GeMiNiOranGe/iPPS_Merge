using System.Data;
using Pepro.DTOs;

namespace Pepro.DataAccess.Mappings;

static class TaskMapper
{
    public static ProjectTask FromDataRow(DataRow row)
    {
        return new ProjectTask()
        {
            TaskId = row.Field<int>("TaskId"),
            Name = row.Field<string>("Name") ?? "",
            IsPublicToProject = row.Field<bool>("IsPublicToProject"),
            IsPublicToDepartment = row.Field<bool>("IsPublicToDepartment"),
            ManagerId = row.Field<string>("ManagerId") ?? "",
            StartDate = row.Field<DateTime>("StartDate"),
            EndDate = row.Field<DateTime>("EndDate"),
            ProjectId = row.Field<string>("ProjectId") ?? "",
            StatusId = row.Field<int>("StatusId")
        };
    }
}