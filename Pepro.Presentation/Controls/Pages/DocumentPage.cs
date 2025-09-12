using Pepro.Business;
using Pepro.DTOs;
using Pepro.Presentation.Controls.Templates;
using Pepro.Presentation.Enums;
using Pepro.Presentation.Extensions;
using Pepro.Presentation.Utilities;

namespace Pepro.Presentation.Controls.Pages;

public partial class DocumentPage : CrudTemplate
{
    public DocumentPage()
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

    private void LoadDocuments()
    {
        documentDataGridView.DataSource = DocumentBusiness.Instance.GetDocuments();
    }

    private void DocumentPage_Load(object sender, EventArgs e)
    {
        LoadDocuments();
    }

    private void DocumentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        BindDataGridViewCellClick<DocumentDto>(
            (DataGridView)sender,
            e,
            (item) =>
            {
                documentIdInputField.Text = item.DocumentId.ToString();
                assignmentIdInputField.Text = item.AssignmentId.ToString();
                fileTypeInputField.Text = item.NativeFileFormat;
            }
        );
    }

    private void SearchButton_Click(object sender, EventArgs e)
    {
        BindSearchButtonClick(
            searchTextBox.Text,
            documentDataGridView,
            DocumentBusiness.Instance.SearchDocuments
        );
    }

    private void ReloadButton_Click(object sender, EventArgs e)
    {
        LoadDocuments();
    }

    private void InsertButton_Click(object sender, EventArgs e)
    {
        BindInsertButtonClick<DocumentDto>(
            new(),
            ControlUiEvent.PushDocumentEditorPage,
            LoadDocuments
        );
    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
        BindUpdateButtonClick<DocumentDto>(
            documentDataGridView,
            ControlUiEvent.PushDocumentEditorPage,
            LoadDocuments
        );
    }

    private void DeleteButton_Click(object sender, EventArgs e)
    {
        BindDeleteButtonClick<DocumentDto>(
            documentDataGridView,
            (item) => DocumentBusiness.Instance.DeleteDocument(item.DocumentId),
            LoadDocuments
        );
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

        projectIdInputField.Text = project.ProjectId.ToString();
        projectNameInputField.Text = project.Name;
    }
}
