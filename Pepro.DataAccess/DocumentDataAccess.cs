using Microsoft.Data.SqlClient;
using Pepro.DTOs;
using System.Data;

namespace Pepro.DataAccess;

public class DocumentDataAccess {
    private static DocumentDataAccess? instance;

    public static DocumentDataAccess Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private DocumentDataAccess() { }

    public int CountDocumentsByTaskId(int taskId) {
        string query = "SELECT Count(TaskId) FROM Document WHERE TaskId = @TaskId";
        SqlParameter[] parameters =
        [
            new()
            {
                ParameterName = "TaskId",
                SqlDbType = SqlDbType.Int,
                Value = taskId
            }
        ];

        return (int)DataProvider.Instance.ExecuteScalar(query, parameters);
    }

    public List<TaskDocument> GetDocuments() {
        string query = @"
            SELECT DocumentId
                , Title
                , CreateAt
                , RevisionNumber
                , RevisionStatus
                , DocumentUrl
                , NativeFileFormat
                , PreparedBy
                , CheckedBy
                , ApprovedBy
                , TaskId
            FROM Document
        ";

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

        List<TaskDocument> documents = [];
        foreach (DataRow row in dataTable.Rows) {
            TaskDocument document = new() {
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
            documents.Add(document);
        }
        return documents;
    }
}
