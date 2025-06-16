using Microsoft.Data.SqlClient;

namespace Pepro.Presentation;

public partial class EmployeeProjects : UserControl
{
    SqlConnection conn = new SqlConnection(Config.Database.CONNECTION_STRING);
    SqlCommand cmd = new SqlCommand();
    SqlDataReader rd = null;
    public EmployeeProjects()
    {
        InitializeComponent();
    }

    private void EmployeeProjects_Load(object sender, EventArgs e)
    {
        LoadEmployeeProjects();
    }

    public void LoadEmployeeProjects()
    {
        projectDataGridView.Rows.Clear();
        conn.Open();
        cmd = new SqlCommand("SELECT P.ID, P.NAME, P.ACCESS_RIGHT, P.STATUS, P.CUSTOMER_NAME, P.PROJECT_MANAGER_ID, IP.DEPARTMENT_ID, IP.PROJECT_START_DATE, IP.PROJECT_END_DATE FROM PROJECT AS P INNER JOIN IMPLEMENT_PROJECT AS IP ON P.ID = IP.PROJECT_ID", conn);
        rd = cmd.ExecuteReader();
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
}
