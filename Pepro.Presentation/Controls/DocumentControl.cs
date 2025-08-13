using Pepro.Business;
using Pepro.DTOs;

namespace Pepro.Presentation.Controls;

public partial class DocumentControl : PeproCrudControlBase
{
    public DocumentControl()
    {
        Initialize();
    }

    public DocumentControl(IMediator mediator) : base(mediator)
    {
        Initialize();
    }

    private void Initialize()
    {
        InitializeComponent();
        documentDataGridView.SetupCellStyle();

        searchButton.ApplyFlatStyleWithIcon("Search", ThemeColors.Text);
        reloadButton.ApplyFlatStyleWithIcon("Refresh", ThemeColors.Text);
        insertButton.ApplyFlatStyleWithIcon("Plus", ThemeColors.Text);
        deleteButton.ApplyFlatStyleWithIcon("Trash", ThemeColors.Text);
        updateButton.ApplyFlatStyleWithIcon("EditPencil", ThemeColors.Text);
        downloadButton.ApplyFlatStyle();
    }

    private void DocumentControl_Load(object sender, EventArgs e)
    {
        LoadDocuments();
    }

    private void LoadDocuments()
    {
        documentDataGridView.DataSource = DocumentBusiness.Instance.GetDocuments();
    }

    private void DocumentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        // Ignore clicks on the column header or invalid row indices
        if (e.RowIndex < 0 || e.RowIndex >= documentDataGridView.Rows.Count)
        {
            return;
        }

        DataGridViewRow row = documentDataGridView.Rows[e.RowIndex];

        if (row.DataBoundItem is DocumentDto document)
        {
            documentIdInputField.Text = document.DocumentId.ToString();
            assignmentIdInputField.Text = document.AssignmentId.ToString();
            fileTypeInputField.Text = document.NativeFileFormat;
        }
    }

    private void DocumentDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
        documentDataGridView.ClearSelection();
        documentDataGridView.CurrentCell = null;
    }

    private void InsertButton_Click(object sender, EventArgs e)
    {
        BindInsertButtonClick<DocumentDto>(
            new(),
            ControlUiEvent.OpenDocumentEditorControl,
            LoadDocuments
        );
    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
        BindUpdateButtonClick<DocumentDto>(
            documentDataGridView,
            ControlUiEvent.OpenDocumentEditorControl,
            LoadDocuments
        );
    }

    private void DeleteButton_Click(object sender, EventArgs e)
    {
        string documentId = documentIdInputField.Text;
        if (string.IsNullOrEmpty(documentId))
        {
            MessageBoxWrapper.ShowInformation("SelectDocument");
            return;
        }

        if (MessageBoxWrapper.ConfirmDelete() == DialogResult.Yes)
        {
            int numberOfRowsAffected = DocumentBusiness.Instance.DeleteDocument(documentId);
            MessageBoxWrapper.ShowInformation("DeleteDocumentSuccess", numberOfRowsAffected);
            LoadDocuments();
        }
    }

    private void SearchButton_Click(object sender, EventArgs e)
    {
        documentDataGridView.DataSource = DocumentBusiness.Instance.SearchDocuments(searchTextBox.Text);
    }

    private void ReloadButton_Click(object sender, EventArgs e)
    {
        LoadDocuments();
    }

    private void DownloadButton_Click(object sender, EventArgs e)
    {
        MessageBoxWrapper.ShowInformation("TreasureFoundPremiumUnlock");
    }

    private void DocumentIdInputField_TextChanged(object sender, EventArgs e)
    {
        if (!int.TryParse(documentIdInputField.Text, out int documentId))
        {
            return;
        }

        AssignmentDto? assignment = AssignmentBusiness.Instance.GetAssignmentByDocumentId(documentId);
        if (assignment == null)
        {
            return;
        }

        assignmentNameInputField.Text = assignment.Name;
    }

    private void AssignmentIdInputField_TextChanged(object sender, EventArgs e)
    {
        if (!int.TryParse(assignmentIdInputField.Text, out int assignmentId))
        {
            return;
        }

        ProjectDto? project = ProjectBusiness.Instance.GetProjectByAssignmentId(assignmentId);
        if (project == null)
        {
            return;
        }

        projectIdInputField.Text = project.ProjectId;
        projectNameInputField.Text = project.Name;
    }
}
