namespace Pepro.DataAccess.Entities;

public class Document
{
    private int _documentId;
    private string _title = "";
    private DateTime _createAt;
    private int _revisionNumber;
    private string _revisionStatus = "";
    private string _documentUrl = "";
    private string _nativeFileFormat = "";
    private string _preparedBy = "";
    private string _checkedBy = "";
    private string _approvedBy = "";
    private int _taskId;

    public required int DocumentId
    {
        get => _documentId;
        set => _documentId = value;
    }

    public required string Title
    {
        get => _title;
        set => _title = value;
    }

    public required DateTime CreateAt
    {
        get => _createAt;
        set => _createAt = value;
    }

    public required int RevisionNumber
    {
        get => _revisionNumber;
        set => _revisionNumber = value;
    }

    public required string RevisionStatus
    {
        get => _revisionStatus;
        set => _revisionStatus = value;
    }

    public required string DocumentUrl
    {
        get => _documentUrl;
        set => _documentUrl = value;
    }

    public required string NativeFileFormat
    {
        get => _nativeFileFormat;
        set => _nativeFileFormat = value;
    }

    public required string PreparedBy
    {
        get => _preparedBy;
        set => _preparedBy = value;
    }

    public required string CheckedBy
    {
        get => _checkedBy;
        set => _checkedBy = value;
    }

    public required string ApprovedBy
    {
        get => _approvedBy;
        set => _approvedBy = value;
    }

    public required int TaskId
    {
        get => _taskId;
        set => _taskId = value;
    }
}
