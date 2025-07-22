using Pepro.Business;
using Pepro.DTOs;

namespace Pepro.Presentation.Controls;

public partial class DocumentControl : UserControl
{
    public DocumentControl()
    {
        InitializeComponent();
    }

    private void DocumentControl_Load(object sender, EventArgs e)
    {
        this.dgvDocument.DefaultCellStyle.Font = new Font("Tahoma", 10);
        this.dgvDocument.DefaultCellStyle.ForeColor = Color.Black;
        LoadDocuments();
    }

    private void LoadDocuments()
    {
        dgvDocument.DataSource = DocumentBusiness.Instance.GetDocuments();
    }

    private void DocumentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        // Ignore clicks on the column header or invalid row indices
        if (e.RowIndex < 0 || e.RowIndex >= dgvDocument.Rows.Count)
        {
            return;
        }

        DataGridViewRow row = dgvDocument.Rows[e.RowIndex];

        if (row.DataBoundItem is TaskDocument document)
        {
            txtIDDoc.Text = document.DocumentId.ToString();
            txtIDJob.Text = document.TaskId.ToString();
            txtTypeFile.Text = document.NativeFileFormat;
        }
    }

    private void btnInsert_Click(object sender, EventArgs e)
    {
        DocumentEditorForm formInsert = new("Thêm tài liệu")
        {
            Item = new()
        };
        formInsert.ShowDialog();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        string documentId = txtIDDoc.Text;
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

    private void btnEdit_Click(object sender, EventArgs e)
    {
        DataGridViewRow? row = dgvDocument.CurrentRow;
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

    private void btnSearch_Click(object sender, EventArgs e)
    {
        dgvDocument.DataSource = DocumentBusiness.Instance.SearchDocuments(txtSearch.Text);
    }

    private void btnReload_Click(object sender, EventArgs e)
    {
        LoadDocuments();
    }

    private void btnDownload_Click(object sender, EventArgs e)
    {
        MessageBoxWrapper.ShowInformation("TreasureFoundPremiumUnlock");
    }

    private void txtIDDoc_TextChanged(object sender, EventArgs e)
    {
        ProjectTask task = TaskBusiness.Instance.GetTaskByDocumentId(txtIDDoc.Text);
        txtNameJob.Text = task.Name;
    }

    private void txtIDJob_TextChanged(object sender, EventArgs e)
    {
        Project project = ProjectBusiness.Instance.GetProjectByTaskId(txtIDJob.Text);
        txtIDPro.Text = project.ProjectId;
        txtNameProject.Text = project.Name;
    }
}
