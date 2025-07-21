using Pepro.DataAccess;
using Pepro.DTOs;

namespace Pepro.Business;

public class DocumentBusiness {
    private static DocumentBusiness? instance;

    public static DocumentBusiness Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private DocumentBusiness() { }

    public List<TaskDocument> GetDocuments() {
        return DocumentDataAccess.Instance.GetDocuments();
    }

    public List<TaskDocument> SearchDocuments(string searchValue) {
        return DocumentDataAccess.Instance.SearchDocuments(searchValue);
    }

    public int DeleteDocument(int documentId) {
        return DocumentDataAccess.Instance.DeleteDocument(documentId);
    }

    public int DeleteDocument(string documentId) {
        int id = Convert.ToInt32(documentId);
        return Instance.DeleteDocument(id);
    }
}
