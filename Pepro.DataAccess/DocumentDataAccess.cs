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

    public int CountDocumentsByAssignmentId(int assignmentId) {
        string query = @"
            SELECT Count(Document.AssignmentId)
            FROM Document
            WHERE Document.AssignmentId = @AssignmentId
                AND Document.IsDeleted = 0
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("AssignmentId", SqlDbType.Int, assignmentId);

        return (int)DataProvider.Instance.ExecuteScalar(query, [.. parameters]);
    }

    public List<Document> GetDocuments() {
        string query = @"
            SELECT Document.DocumentId
                , Document.Title
                , Document.CreateAt
                , Document.RevisionNumber
                , Document.RevisionStatus
                , Document.DocumentUrl
                , Document.NativeFileFormat
                , Document.PreparedBy
                , Document.CheckedBy
                , Document.ApprovedBy
                , Document.AssignmentId
                , Document.IsDeleted
            FROM Document
            WHERE Document.IsDeleted = 0
        ";

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

        List<Document> documents = [];
        foreach (DataRow row in dataTable.Rows) {
            Document document = DocumentMapper.FromDataRow(row);
            documents.Add(document);
        }
        return documents;
    }

    public List<Document> SearchDocuments(string searchValue) {
        string query = @"
            SELECT Document.DocumentId
                , Document.Title
                , Document.CreateAt
                , Document.RevisionNumber
                , Document.RevisionStatus
                , Document.DocumentUrl
                , Document.NativeFileFormat
                , Document.PreparedBy
                , Document.CheckedBy
                , Document.ApprovedBy
                , Document.AssignmentId
                , Document.IsDeleted
            FROM Document
            WHERE
                (
                    Document.DocumentId LIKE '%' + @SearchValue + '%'
                    OR Document.Title LIKE '%' + @SearchValue + '%'
                    OR Document.AssignmentId LIKE '%' + @SearchValue + '%'
                )
                AND Document.IsDeleted = 0
        ";
        List<SqlParameter> parameters = [];
        parameters.Add("SearchValue", SqlDbType.NVarChar, DatabaseConstants.SEARCH_SIZE, searchValue);

        DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, [.. parameters]);

        List<Document> documents = [];
        foreach (DataRow row in dataTable.Rows) {
            Document document = DocumentMapper.FromDataRow(row);
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
