using System.Data;
using Pepro.DataAccess.Entities;

namespace Pepro.DataAccess.Mappings;

static class AssignmentMapper
{
    public static Assignment FromDataRow(DataRow row)
    {
        return new Assignment()
        {
            AssignmentId = row.Field<int>("AssignmentId"),
            Name = row.Field<string>("Name") ?? "",
            IsPublicToProject = row.Field<bool>("IsPublicToProject"),
            IsPublicToDepartment = row.Field<bool>("IsPublicToDepartment"),
            ManagerId = row.Field<int>("ManagerId"),
            StartDate = row.Field<DateTime>("StartDate"),
            EndDate = row.Field<DateTime>("EndDate"),
            RequiredDocumentCount = row.Field<int>("RequiredDocumentCount"),
            ProjectId = row.Field<string>("ProjectId") ?? "",
            StatusId = row.Field<int>("StatusId"),
        };
    }
}