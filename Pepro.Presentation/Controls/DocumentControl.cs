using Microsoft.Data.SqlClient;
using Pepro.Business;
using Pepro.DTOs;
using System.Data;

namespace Pepro.Presentation.Controls;

public partial class DocumentControl : UserControl
{
    SqlConnection sqlConnection;
    SqlCommand sqlCommand;
    SqlDataReader sqlDataReader;
    SqlDataAdapter sqlDataAdapter;
    DataTable dataTable;

    public DocumentControl()
    {
        InitializeComponent();
    }

    private void DocumentControl_Load(object sender, EventArgs e)
    {
        sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=Pepro;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
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

    private void btnOpenFile_Click(object sender, EventArgs e)
    {
        string id = txtIDDoc.Text;
        OpenFile(id);
    }
    public void OpenFile(string id)
    {
        sqlConnection.Open();
        using (sqlCommand = new SqlCommand("SELECT NAME,NATIVE_FILE_FORMAT,LINK FROM DOCUMENT_NATIVE_FILE_FORMAT WHERE ID=@id", sqlConnection))
        {
            sqlCommand.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
            sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                var name = sqlDataReader["NAME"].ToString();
                var type = sqlDataReader["NATIVE_FILE_FORMAT"].ToString();
                if (!Convert.IsDBNull(sqlDataReader["LINK"])) {
                    var link = (byte[])sqlDataReader["LINK"];
                    var newFile = name.Replace(type, DateTime.Now.ToString("ddMMyyyyhhmmss")) + type;
                    File.WriteAllBytes(newFile, link);
                    System.Diagnostics.Process.Start(newFile);
                }
                else
                    MessageBox.Show("Không có Data", "Thông báo", MessageBoxButtons.OK);
            }
        }
        sqlConnection.Close();
    }

    private void btnDownload_Click(object sender, EventArgs e)
    {
        using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Text DOCUMENT_NATIVE_FILE_FORMAT ('"+txtTypeFile.Text+ "') | *'"+ txtTypeFile.Text +"'", ValidateNames = true })
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn DownLoad?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string strFile = saveFileDialog.FileName;
                    Download(strFile);
                }
            }
        }
    }
    public void Download(string strFile)
    {
        sqlConnection.Open();
        bool bFlag = false;
        using (sqlCommand = new SqlCommand("select LINK from  DOCUMENT_NATIVE_FILE_FORMAT where ID='" + txtIDDoc.Text + "'", sqlConnection))
        {
            using (sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.Default))
            {
                if (sqlDataReader.Read())
                {
                    bFlag = true;
                    byte[] link = (byte[])sqlDataReader.GetValue(0);
                    using (FileStream fileStream = new FileStream(strFile, FileMode.Create, FileAccess.ReadWrite))
                    {
                        using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
                        {
                            binaryWriter.Write(link);
                            binaryWriter.Close();
                        }
                    }
                }
                if (bFlag == false)
                {
                    MessageBox.Show("Không có Data", "Thông báo", MessageBoxButtons.OK);
                }
                sqlDataReader.Close();
            }
        }
        sqlConnection.Close();
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
