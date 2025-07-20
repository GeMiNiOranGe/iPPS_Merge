using System.Data;
using Microsoft.Data.SqlClient;
using Pepro.Business;
using Pepro.DTOs;

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
        DocumentEditorForm  formInsert = new DocumentEditorForm("Thêm tài liệu");
        formInsert.ShowDialog();
;        }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (!(string.IsNullOrEmpty(txtIDDoc.Text)))
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("DELETE DOCUMENT_NATIVE_FILE_FORMAT WHERE ID='" + txtIDDoc.Text + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                sqlConnection.Open();
                sqlCommand = new SqlCommand("DELETE DOCUMENT WHERE ID='" + txtIDDoc.Text + "'", sqlConnection);
                MessageBox.Show("Xóa tài liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                LoadDocuments();
            }
        }
        else
        {
            MessageBox.Show("Vui chọn tài liệu để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        DocumentEditorForm formInsert = new DocumentEditorForm("Sửa tài liệu");
        formInsert.ID = dgvDocument.CurrentRow.Cells[0].Value.ToString();
        formInsert.JOB_ID = dgvDocument.CurrentRow.Cells[1].Value.ToString();
        formInsert.PACKAGE = dgvDocument.CurrentRow.Cells[2].Value.ToString();
        formInsert.WORK_ITEM = dgvDocument.CurrentRow.Cells[3].Value.ToString();
        formInsert.TYPE = dgvDocument.CurrentRow.Cells[4].Value.ToString();
        formInsert.PARTNER_CODE = dgvDocument.CurrentRow.Cells[5].Value.ToString();
        formInsert.REVISION_NUMBER = dgvDocument.CurrentRow.Cells[6].Value.ToString();
        formInsert.LASTEST_REVISION = dgvDocument.CurrentRow.Cells[7].Value.ToString();
        formInsert.DATE = dgvDocument.CurrentRow.Cells[8].Value.ToString();
        formInsert.ISSUE_PURPOSE = dgvDocument.CurrentRow.Cells[9].Value.ToString();
        formInsert.PREPARED_BY = dgvDocument.CurrentRow.Cells[10].Value.ToString();
        formInsert.CHECKED_BY = dgvDocument.CurrentRow.Cells[11].Value.ToString();
        formInsert.APPROVED_BY = dgvDocument.CurrentRow.Cells[12].Value.ToString();
        formInsert.ACTION = dgvDocument.CurrentRow.Cells[13].Value.ToString();
        formInsert.SUPPORT = dgvDocument.CurrentRow.Cells[14].Value.ToString();
        formInsert.REFERRENCE = dgvDocument.CurrentRow.Cells[15].Value.ToString();
        formInsert.TO_COMPANY = dgvDocument.CurrentRow.Cells[16].Value.ToString();
        formInsert.ISSUSED_ON = dgvDocument.CurrentRow.Cells[17].Value.ToString();
        formInsert.ISSUSED_VIA = dgvDocument.CurrentRow.Cells[18].Value.ToString();
        formInsert.TITLE = dgvDocument.CurrentRow.Cells[19].Value.ToString();
        formInsert.Show();
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
