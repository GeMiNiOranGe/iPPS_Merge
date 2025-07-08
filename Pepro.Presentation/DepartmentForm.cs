using Pepro.Business;
using System.Data;

namespace Pepro.Presentation;

public partial class DepartmentForm : Form
{
    public DepartmentForm()
    {
        InitializeComponent();
        LoadDepartments();
    }

    private void LoadDepartments()
    {
        try
        {
            DataTable dt = DepartmentBusiness.Instance.GetAllDepartments();
           
            if (dt == null || dt.Columns.Count == 0)
            {
                MessageBox.Show("No data returned from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           dtgvDepartment.DataSource = dt;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
