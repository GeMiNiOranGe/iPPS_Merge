using Microsoft.Data.SqlClient;

namespace Pepro.Presentation.Controls;

public partial class AdminProjectControl : UserControl
{
    SqlConnection conn = new SqlConnection(Config.CONNECTION_STRING);
    SqlCommand cmd = new SqlCommand();
    SqlCommand cmd2 = new SqlCommand();
    SqlDataReader rd = null;

    public AdminProjectControl()
    {
        InitializeComponent();
    }

    private void AdminProjects_Load(object sender, EventArgs e)
    {
        LoadAdminProjects();
    }

    public void LoadAdminProjects()
    {
        projectDataGridView.Rows.Clear();
        conn.Open();
        cmd=new SqlCommand("SELECT P.ID, P.NAME, P.ACCESS_RIGHT, P.STATUS, P.CUSTOMER_NAME, P.PROJECT_MANAGER_ID, IP.DEPARTMENT_ID, IP.PROJECT_START_DATE, IP.PROJECT_END_DATE FROM PROJECT AS P INNER JOIN IMPLEMENT_PROJECT AS IP ON P.ID = IP.PROJECT_ID", conn);
        rd= cmd.ExecuteReader();
        while (rd.Read())
        {
            string strFirstDay = GetDate(rd["PROJECT_START_DATE"]);
            string strLastDay = GetDate(rd["PROJECT_END_DATE"]);

            projectDataGridView.Rows.Add(rd["ID"].ToString(), rd["NAME"].ToString(),
                rd["ACCESS_RIGHT"].ToString(), rd["STATUS"].ToString(),
                rd["CUSTOMER_NAME"].ToString(), rd["PROJECT_MANAGER_ID"].ToString(),
                rd["DEPARTMENT_ID"].ToString(), strFirstDay, strLastDay);
        }
        rd.Close();
        conn.Close();
    }

    private string GetDate(object dateObj)
    {
        if (dateObj is DateTime)
        {
            DateTime date = (DateTime)dateObj;
            return date.ToString("MM/dd/yyyy");
        }
        return string.Empty;
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        AdminProjectEditorForm adminProjectsModule = new AdminProjectEditorForm();
        adminProjectsModule.updateButton.Enabled = false;
        adminProjectsModule.saveButton.Enabled = true;
        adminProjectsModule.ShowDialog();
        LoadAdminProjects();
    }

    private void ProjectDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        string strColName = projectDataGridView.Columns[e.ColumnIndex].Name;
        if(strColName == "Edit")
        {
            AdminProjectEditorForm adminProjectsModule = new AdminProjectEditorForm();
            adminProjectsModule.projectIdTextBox.Text = projectDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            adminProjectsModule.projectNameTextBox.Text = projectDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            adminProjectsModule.accessTextBox.Text = projectDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            adminProjectsModule.statusTextBox.Text = projectDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            adminProjectsModule.customerTextBox.Text = projectDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            adminProjectsModule.managerIdTextBox.Text = projectDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            adminProjectsModule.departmentTextBox.Text = projectDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            adminProjectsModule.startDateTimePicker.Text = projectDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
            adminProjectsModule.endDateTimePicker.Text = projectDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();

            adminProjectsModule.saveButton.Enabled = false;
            adminProjectsModule.updateButton.Enabled = true;
            adminProjectsModule.clearButton.Enabled = false;
            adminProjectsModule.projectIdTextBox.Enabled = false;
            adminProjectsModule.managerIdTextBox.Enabled = false;
            adminProjectsModule.departmentTextBox.Enabled = false;
            adminProjectsModule.ShowDialog();
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
        LoadAdminProjects();
    }
}
