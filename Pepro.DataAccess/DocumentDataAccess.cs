using Microsoft.Data.SqlClient;
using Pepro.DataAccess.Entities;
using Pepro.DataAccess.Mappings;
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
        string query = @"
            SELECT Count(TaskId)
            FROM Document
            WHERE TaskId = @TaskId
                AND IsDeleted = 0
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("TaskId", SqlDbType.Int, taskId);

        return (int)DataProvider.Instance.ExecuteScalar(query, [.. parameters]);
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
            WHERE IsDeleted = 0
        ";

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

        List<TaskDocument> documents = [];
        foreach (DataRow row in dataTable.Rows) {
            TaskDocument document = DocumentMapper.FromDataRow(row);
            documents.Add(document);
        }
        return documents;
    }

    public List<TaskDocument> SearchDocuments(string searchValue) {
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
            WHERE
                (
                    DocumentId LIKE '%' + @SearchValue + '%'
                    OR Title LIKE '%' + @SearchValue + '%'
                    OR TaskId LIKE '%' + @SearchValue + '%'
                )
                AND IsDeleted = 0
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("SearchValue", SqlDbType.NVarChar, DatabaseConstants.SEARCH_SIZE, searchValue);

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, [.. parameters]);

        List<TaskDocument> documents = [];
        foreach (DataRow row in dataTable.Rows) {
            TaskDocument document = DocumentMapper.FromDataRow(row);
            documents.Add(document);
        }
        return documents;
    }

    public int DeleteDocument(int documentId) {
        string query = @"
            UPDATE Document
            SET IsDeleted = 1
            WHERE DocumentId = @DocumentId;
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("DocumentId", SqlDbType.Int, documentId);

        return DataProvider.Instance.ExecuteNonQuery(query, [.. parameters]);
    }
}
