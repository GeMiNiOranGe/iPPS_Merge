using Microsoft.Data.SqlClient;
using Pepro.Business;

namespace Pepro.Presentation.Controls;

public partial class ProjectControl : PeproCrudControlBase
{
    SqlConnection conn = new SqlConnection(Config.CONNECTION_STRING);
    SqlCommand cmd = new SqlCommand();
    SqlCommand cmd2 = new SqlCommand();

    public ProjectControl()
    {
        Initialize();
    }

    public ProjectControl(IMediator mediator) : base(mediator)
    {
        Initialize();
    }

    private void Initialize()
    {
        InitializeComponent();
        projectDataGridView.SetupCellStyle();

        searchButton.ApplyFlatStyleWithIcon("Search", ThemeColors.Text);
        reloadButton.ApplyFlatStyleWithIcon("Refresh", ThemeColors.Text);
        insertButton.ApplyFlatStyleWithIcon("Plus", ThemeColors.Text);
        deleteButton.ApplyFlatStyleWithIcon("Trash", ThemeColors.Text);
        updateButton.ApplyFlatStyleWithIcon("EditPencil", ThemeColors.Text);
    }

    private void AdminProjects_Load(object sender, EventArgs e)
    {
        LoadProjects();
    }

    private void LoadProjects()
    {
        projectDataGridView.DataSource = ProjectBusiness.Instance.GetProjects();
    }

    private void ProjectDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        string strColName = projectDataGridView.Columns[e.ColumnIndex].Name;
        if(strColName == "Edit")
        {
            ProjectEditorControl adminProjectsModule = new();
        }
        else if(strColName == "Delete")
        {
            if(MessageBox.Show("Bạn có muốn xóa dự án này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                string strIDProject = projectDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                cmd2 = new SqlCommand($"DELETE FROM IMPLEMENT_PROJECT WHERE PROJECT_ID='{strIDProject}'", conn);
                cmd2.ExecuteNonQuery();

                cmd = new SqlCommand($"DELETE FROM EMPLOYEE_BELONG_TO_PROJECT WHERE PROJECT_ID = '{strIDProject}'", conn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand($"DELETE JOIN_JOB FROM JOIN_JOB JOIN JOB ON JOIN_JOB.JOB_ID = JOB.ID WHERE JOB.PROJECT_ID = '{strIDProject}'", conn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand($"DELETE DOCUMENT_NATIVE_FILE_FORMAT FROM DOCUMENT JOIN DOCUMENT_NATIVE_FILE_FORMAT ON DOCUMENT.ID = DOCUMENT_NATIVE_FILE_FORMAT.ID", conn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand($"DELETE DOCUMENT FROM DOCUMENT JOIN JOB ON DOCUMENT.JOB_ID = JOB.ID WHERE JOB.PROJECT_ID = '{strIDProject}'", conn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand($"DELETE FROM JOB WHERE PROJECT_ID = '{strIDProject}'", conn);
                cmd.ExecuteNonQuery();
                //$"DELETE FROM IMPLEMENT_PROJECT WHERE PROJECT_ID = '{strIDProject}'--6" +
                cmd = new SqlCommand($"DELETE FROM JOIN_PROJECT WHERE PROJECT_ID = '{strIDProject}'", conn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand($"DELETE FROM PROJECT WHERE ID = '{strIDProject}'", conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
            }
        }
        LoadProjects();
    }
}
