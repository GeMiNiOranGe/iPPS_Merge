using Pepro.Business.Mappings;
using Pepro.DataAccess;
using Pepro.Domain.Entities;
using Pepro.DTOs;

namespace Pepro.Business;

public class DocumentBusiness {
    private static DocumentBusiness? instance;

    public static DocumentBusiness Instance {
        get => instance ??= new();
        private set => instance = value;
    }

    private DocumentBusiness() { }

    public List<DocumentDto> GetDocuments() {
        List<Document> documents =  DocumentDataAccess.Instance.GetDocuments();
        return documents.ToDtos();
    }

    public List<DocumentDto> SearchDocuments(string searchValue) {
        List<Document> documents = DocumentDataAccess.Instance.SearchDocuments(searchValue);
        return documents.ToDtos();
    }

    public int DeleteDocument(int documentId) {
        return DocumentDataAccess.Instance.DeleteDocument(documentId);
    }

    public int DeleteDocument(string documentId) {
        int id = Convert.ToInt32(documentId);
        return Instance.DeleteDocument(id);
    }
}
