using System.Data;
using Pepro.DataAccess.Entities;

namespace Pepro.DataAccess.Mappings;

static class DocumentMapper
{
    public static Document FromDataRow(DataRow row)
    {
        return new Document()
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
            AssignmentId = row.Field<int>("AssignmentId"),
        };
    }
}
