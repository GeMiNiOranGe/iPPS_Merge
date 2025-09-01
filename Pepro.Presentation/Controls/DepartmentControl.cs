using Pepro.Business;

namespace Pepro.Presentation.Controls;

public partial class DepartmentControl : PeproCrudControlBase
{
    public DepartmentControl()
    {
        InitializeComponent();
        departmentDataGridView.SetupCellStyle();

        searchButton.ApplyFlatStyleWithIcon("Search", ThemeColors.Text);
        reloadButton.ApplyFlatStyleWithIcon("Refresh", ThemeColors.Text);
        insertButton.ApplyFlatStyleWithIcon("Plus", ThemeColors.Text);
        deleteButton.ApplyFlatStyleWithIcon("Trash", ThemeColors.Text);
        updateButton.ApplyFlatStyleWithIcon("EditPencil", ThemeColors.Text);
    }

    private void LoadDepartments()
    {
        departmentDataGridView.DataSource = DepartmentBusiness.Instance.GetDepartments();
    }

    private void DepartmentControl_Load(object sender, EventArgs e)
    {
        LoadDepartments();
    }
}
