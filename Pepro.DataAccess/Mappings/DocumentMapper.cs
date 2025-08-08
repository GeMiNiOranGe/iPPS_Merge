using System.Data;
using Pepro.DTOs;

namespace Pepro.DataAccess.Mappings;

static class DocumentMapper
{
    public static TaskDocument FromDataRow(DataRow row)
    {
        return new TaskDocument()
        {
            DocumentId = row.Field<int>("DocumentId"),
            Title = row.Field<string>("Title") ?? "",
            CreateAt = row.Field<DateTime>("CreateAt"),
            RevisionNumber = row.Field<int>("RevisionNumber"),
            RevisionStatus = row.Field<string>("RevisionStatus") ?? "",
            DocumentUrl = row.Field<string>("DocumentUrl") ?? "",
            NativeFileFormat = row.Field<string>("NativeFileFormat") ?? "",
            PreparedBy = row.Field<string>("PreparedBy") ?? "",
            CheckedBy = row.Field<string>("CheckedBy") ?? "",
            ApprovedBy = row.Field<string>("ApprovedBy") ?? "",
            TaskId = row.Field<int>("TaskId")
        };
    }
}
