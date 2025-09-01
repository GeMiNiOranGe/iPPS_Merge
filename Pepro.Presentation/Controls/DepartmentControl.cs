using Pepro.Business;
using System.Data;

namespace Pepro.Presentation.Controls;

public partial class DepartmentControl : PeproCrudControlBase
{
    public DepartmentControl()
    {
        Initialize();
    }

    public DepartmentControl(IMediator mediator) : base(mediator)
    {
        Initialize();
    }

    private void Initialize()
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
