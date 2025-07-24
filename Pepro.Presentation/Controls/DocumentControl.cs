using Pepro.Business;
using Pepro.DTOs;

namespace Pepro.Presentation.Controls;

public partial class DocumentControl : PeproUserControl
{
    public DocumentControl()
    {
        InitializeComponent();
        documentDataGridView.SetupCellStyle();
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

        if (row.DataBoundItem is TaskDocument document)
        {
            documentIdInputField.Text = document.DocumentId.ToString();
            taskIdInputField.Text = document.TaskId.ToString();
            fileTypeInputField.Text = document.NativeFileFormat;
        }
    }

    private void InsertButton_Click(object sender, EventArgs e)
    {
        DocumentEditorForm formInsert = new("Thêm tài liệu")
        {
            Item = new()
        };
        formInsert.ShowDialog();
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

    private void EditButton_Click(object sender, EventArgs e)
    {
        DataGridViewRow? row = documentDataGridView.CurrentRow;
        if (row != null && row.DataBoundItem is TaskDocument document)
        {
            DocumentEditorForm editorForm = new("Sửa tài liệu")
            {
                Item = document,
            };
            editorForm.ShowDialog();
            //editorForm.TopLevel = false;
            //editorForm.FormBorderStyle = FormBorderStyle.None;
            //editorForm.Dock = DockStyle.Fill;
            //editorForm.Opacity = 0.5;
            //Controls.Add(editorForm);
            //editorForm.BringToFront();
            //editorForm.Show();
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
        ProjectTask task = TaskBusiness.Instance.GetTaskByDocumentId(documentIdInputField.Text);
        taskNameInputField.Text = task.Name;
    }

    private void TaskIdInputField_TextChanged(object sender, EventArgs e)
    {
        Project project = ProjectBusiness.Instance.GetProjectByTaskId(taskIdInputField.Text);
        projectIdInputField.Text = project.ProjectId;
        projectNameInputField.Text = project.Name;
    }
}
