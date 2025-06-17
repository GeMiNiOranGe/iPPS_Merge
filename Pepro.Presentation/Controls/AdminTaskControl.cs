using Microsoft.Data.SqlClient;

namespace Pepro.Presentation.Controls;

public partial class AdminTaskControl : UserControl
{
    SqlConnection conn = new SqlConnection(Config.CONNECTION_STRING);
    SqlCommand cmd = new SqlCommand();
    SqlDataReader rd = null;

    public AdminTaskControl()
    {
        InitializeComponent();
    }

    private void AdminTasks_Load(object sender, EventArgs e)
    {
        LoadAdminTasks();
    }

    public void LoadAdminTasks()
    {
        taskDataGridView.Rows.Clear();
        conn.Open();
        cmd=new SqlCommand("SELECT * FROM JOB", conn);
        rd= cmd.ExecuteReader();
        while (rd.Read())
        {
            taskDataGridView.Rows.Add(rd["ID"].ToString(), rd["JOB_MANAGER_ID"].ToString(),
                rd["NAME"].ToString(), rd["ACCESS_RIGHT"].ToString(), 
                rd["STATUS"].ToString(), rd["PROJECT_PUBLIC"].ToString(),
                rd["DEPARTMENT_PUBLIC"].ToString(), rd["PROJECT_ID"].ToString());
        }
        rd.Close();
        conn.Close();
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        AdminTaskEditorForm adminTasksModule = new AdminTaskEditorForm();
        adminTasksModule.saveButton.Enabled = true;
        adminTasksModule.updateButton.Enabled = false;
        adminTasksModule.ShowDialog();
        LoadAdminTasks();
    }

    private void TaskDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        string strColName = taskDataGridView.Columns[e.ColumnIndex].Name;
        if (strColName == "Edit")
        {
            AdminTaskEditorForm adminTasksModule = new AdminTaskEditorForm();
            adminTasksModule.taskIdTextBox.Text = taskDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            adminTasksModule.managerIdTextBox.Text = taskDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            adminTasksModule.taskNameTextBox.Text = taskDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            adminTasksModule.accessTextBox.Text = taskDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            adminTasksModule.statusTextBox.Text = taskDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            adminTasksModule.publicProjectTextBox.Text = taskDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            adminTasksModule.publicDepartmentTextBox.Text = taskDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            adminTasksModule.projectIdTextBox.Text = taskDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();

            adminTasksModule.saveButton.Enabled = false;
            adminTasksModule.updateButton.Enabled = true;
            adminTasksModule.clearButton.Enabled = false;
            adminTasksModule.projectIdTextBox.Enabled = false;
            adminTasksModule.taskIdTextBox.Enabled = false;
            adminTasksModule.managerIdTextBox.Enabled = false;
            adminTasksModule.ShowDialog();
        }
        else if (strColName == "Delete")
        {
            if (MessageBox.Show("Bạn có muốn xóa công việc này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                string strIDTask = taskDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                cmd = new SqlCommand($"DELETE FROM JOIN_JOB WHERE JOB_ID = '{strIDTask}' --1", conn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand($"DELETE DOCUMENT_NATIVE_FILE_FORMAT " +
                    $"FROM DOCUMENT_NATIVE_FILE_FORMAT JOIN DOCUMENT ON DOCUMENT_NATIVE_FILE_FORMAT.ID = DOCUMENT.ID WHERE DOCUMENT.JOB_ID = '{strIDTask}'--2", conn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand($"DELETE FROM DOCUMENT WHERE JOB_ID = '{strIDTask}' --3", conn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand($"DELETE FROM JOB WHERE ID='{strIDTask}' --4", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
            }
        }
        LoadAdminTasks();
    }

    private void ProjectIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (projectIdTextBox.Text == "")
            LoadAdminTasks();
        else
        {
            taskDataGridView.Rows.Clear();
            conn.Open();
            cmd = new SqlCommand($"SELECT * FROM JOB WHERE PROJECT_ID LIKE '%{projectIdTextBox.Text}%'", conn);
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                taskDataGridView.Rows.Add(rd["ID"].ToString(), rd["JOB_MANAGER_ID"].ToString(),
                    rd["NAME"].ToString(), rd["ACCESS_RIGHT"].ToString(),
                    rd["STATUS"].ToString(), rd["PROJECT_PUBLIC"].ToString(),
                    rd["DEPARTMENT_PUBLIC"].ToString(), rd["PROJECT_ID"].ToString());
            }
            rd.Close();
            conn.Close();
        }
    }

    private void TaskTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (taskIdTextBox.Text == "")
            LoadAdminTasks();
        else
        {
            taskDataGridView.Rows.Clear();
            conn.Open();
            cmd = new SqlCommand($"SELECT * FROM JOB WHERE ID LIKE '%{taskIdTextBox.Text}%'", conn);
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                taskDataGridView.Rows.Add(rd["ID"].ToString(), rd["JOB_MANAGER_ID"].ToString(),
                    rd["NAME"].ToString(), rd["ACCESS_RIGHT"].ToString(),
                    rd["STATUS"].ToString(), rd["PROJECT_PUBLIC"].ToString(),
                    rd["DEPARTMENT_PUBLIC"].ToString(), rd["PROJECT_ID"].ToString());
            }
            rd.Close();
            conn.Close();
        }
    }
}
