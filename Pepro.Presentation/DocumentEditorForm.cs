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
        sqlCommand = new SqlCommand("SELECT * FROM Project WHERE NAME = @Name", sqlConnection);
        sqlCommand.Parameters.AddWithValue("@Name", cbNameProject.Text);
        sqlDataReader = sqlCommand.ExecuteReader();
        while (sqlDataReader.Read())
        {
            txtIDPro.Text = sqlDataReader["ProjectId"].ToString();
        }
        sqlConnection.Close();

        sqlConnection.Open();
        sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Task WHERE ProjectId = '" + txtIDPro.Text + "'", sqlConnection);
        dataTable = new DataTable();
        sqlDataAdapter.Fill(dataTable);
        cbNameJob.DisplayMember = "Name";
        cbNameJob.ValueMember = "TaskId";
        cbNameJob.DataSource = dataTable;
        txtIDJob.DataBindings.Clear();
        txtIDJob.DataBindings.Add("Text", cbNameJob.DataSource, "TaskId");
        sqlConnection.Close();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        MessageBoxWrapper.ShowInformation("TreasureFoundPremiumUnlock2");
    }

    private void btnBroser_Click(object sender, EventArgs e)
    {
        MessageBoxWrapper.ShowInformation("TreasureFoundPremiumUnlock1");
    }
}
