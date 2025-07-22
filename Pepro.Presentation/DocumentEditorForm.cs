using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using Pepro.DTOs;
using Pepro.Presentation.Controls;

namespace Pepro.Presentation;

public partial class DocumentEditorForm : PeproForm
{
    private TaskDocument _item = null!;
    SqlConnection sqlConnection;
    SqlCommand sqlCommand;
    SqlDataReader sqlDataReader;
    SqlDataAdapter sqlDataAdapter;
    DataTable dataTable;

    public DocumentEditorForm()
    {
        InitializeComponent();
    }

    public DocumentEditorForm(string name)
    {
        InitializeComponent();
        label24.Text = name;
    }

    private void FormInsert_Load(object sender, EventArgs e)
    {
        sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=Pepro;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        sqlConnection.Open();
        sqlCommand = new SqlCommand("SELECT * FROM PROJECT", sqlConnection);
        sqlDataReader = sqlCommand.ExecuteReader();
        while (sqlDataReader.Read())
        {
            cbNameProject.Items.Add(sqlDataReader["NAME"]);
        }
        sqlConnection.Close();
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public required TaskDocument Item
    {
        get => _item;
        set
        {
            _item = value ?? throw new ArgumentNullException(nameof(Item));
            txtIDDoc.Text = _item.DocumentId.ToString();
            txtTitle.Text = _item.Title;
            dateDate.Value = _item.CreateAt <= dateDate.MinDate ? dateDate.MinDate : _item.CreateAt;
            cbRevision_Number.Text = _item.RevisionNumber.ToString();
            cbLastest_Revision.Text = _item.RevisionStatus;


            txtPrepared_By.Text = _item.PreparedBy;
            txtChecked_By.Text = _item.CheckedBy;
            txtApproved_By.Text = _item.ApprovedBy;
            txtIDJob.Text = _item.TaskId.ToString();
        }
    }

    private void cbNameProject_SelectedIndexChanged(object sender, EventArgs e)
    {
        sqlConnection.Open();
        sqlCommand = new SqlCommand("SELECT * FROM PROJECT WHERE NAME=@NAME", sqlConnection);
        sqlCommand.Parameters.AddWithValue("@NAME", cbNameProject.Text);
        sqlDataReader = sqlCommand.ExecuteReader();
        while (sqlDataReader.Read())
        {
            txtIDPro.Text = sqlDataReader["ID"].ToString();
        }
        sqlConnection.Close();

        sqlConnection.Open();
        sqlDataAdapter = new SqlDataAdapter("select * from JOB where PROJECT_ID='" + txtIDPro.Text + "'", sqlConnection);
        dataTable = new DataTable();
        sqlDataAdapter.Fill(dataTable);
        cbNameJob.DisplayMember = "NAME";
        cbNameJob.ValueMember = "ID";
        cbNameJob.DataSource = dataTable;
        txtIDJob.DataBindings.Clear();
        txtIDJob.DataBindings.Add("Text", cbNameJob.DataSource, "ID");
        sqlConnection.Close();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (label24.Text == "1")
        {
            if (string.IsNullOrEmpty(cbNameProject.Text) || string.IsNullOrEmpty(cbRevision_Number.Text)) 
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(@"
                    INSERT INTO DOCUMENT
                           (JOB_ID, REVISION_NUMBER, LASTEST_REVISION, DATE, PREPARED_BY, CHECKED_BY, APPROVED_BY, TITLE)
                    VALUES ('" + "', '" + txtIDJob.Text + "', '" + cbRevision_Number.Text + "', '" + cbLastest_Revision.Text + "', '" + dateDate.Text + "', '" + txtPrepared_By.Text + "', '" + txtChecked_By.Text + "', '" + txtApproved_By.Text + "', '" + "', N'" + txtTitle.Text + "')", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                if (!string.IsNullOrEmpty(txtLink.Text)) {
                    SaveFile(txtLink.Text);
                }
                else
                {
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("INSERT INTO DOCUMENT_NATIVE_FILE_FORMAT VALUES ('" + txtIDDoc.Text + "', null, null, null)", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }

                MessageBox.Show("Thêm tài liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        else
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand(@"
                UPDATE DOCUMENT
                SET JOB_ID='" + txtIDJob.Text +
                "', REVISION_NUMBER='" + cbRevision_Number.Text +
                "', LASTEST_REVISION='" + cbLastest_Revision.Text +
                "', DATE='" + dateDate.Text +
                "', PREPARED_BY='" + txtPrepared_By.Text +
                "', CHECKED_BY='" + txtChecked_By.Text +
                "', APPROVED_BY='" + txtApproved_By.Text +
                "', TITLE=N'" + txtTitle.Text +
                "' where ID='" + txtIDDoc.Text +
                "'", sqlConnection
            );
            MessageBox.Show("Cập nhật tài liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            if (!string.IsNullOrEmpty(txtLink.Text))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("DELETE DOCUMENT_NATIVE_FILE_FORMAT WHERE ID='" + txtIDDoc.Text + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                SaveFile(txtLink.Text);
            }
        }
    }

    private void btnBroser_Click(object sender, EventArgs e)
    {
        MessageBoxWrapper.ShowInformation("TreasureFoundPremiumUnlock1");
    }

    public void SaveFile(string fileName)
    {
        sqlConnection.Open();
        using (Stream stream = File.OpenRead(fileName))
        {
            byte[] buffer = new byte[stream.Length];
            _ = stream.Read(buffer, 0, buffer.Length);
            string name = new FileInfo(fileName).Name;
            string extension = new FileInfo(fileName).Extension;
            using (sqlCommand = new SqlCommand("INSERT INTO DOCUMENT_NATIVE_FILE_FORMAT(ID, NAME, NATIVE_FILE_FORMAT, LINK) VALUES(@ID, @NAME, @NATIVE_FILE_FORMAT, @LINK)", sqlConnection))
            {
                sqlCommand.Parameters.AddWithValue("@ID", txtIDDoc.Text);
                sqlCommand.Parameters.AddWithValue("@NAME", SqlDbType.VarChar).Value = name;
                sqlCommand.Parameters.AddWithValue("@NATIVE_FILE_FORMAT", SqlDbType.Char).Value = extension;
                sqlCommand.Parameters.AddWithValue("@LINK", SqlDbType.VarBinary).Value = buffer;
                sqlCommand.ExecuteNonQuery();
            }
        }
        sqlConnection.Close();
    }
}
