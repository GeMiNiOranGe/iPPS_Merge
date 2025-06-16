using Microsoft.Data.SqlClient;

namespace Pepro.Presentation;

public partial class EmployeeTasks : UserControl
{
    SqlConnection conn = new SqlConnection(Config.Database.CONNECTION_STRING);
    SqlCommand cmd = new SqlCommand();
    SqlDataReader rd = null;

    public EmployeeTasks()
    {
        InitializeComponent();
    }

    private void EmployeeTasks_Load(object sender, EventArgs e)
    {
        LoadEmployeeTasks();
    }

    public void LoadEmployeeTasks()
    {
        taskDataGridView.Rows.Clear();
        conn.Open();
        cmd = new SqlCommand("SELECT * FROM JOB", conn);
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

    private void ProjectIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (projectIdTextBox.Text == "")
            LoadEmployeeTasks();
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

    private void TaskIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (taskIdTextBox.Text == "")
            LoadEmployeeTasks();
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
