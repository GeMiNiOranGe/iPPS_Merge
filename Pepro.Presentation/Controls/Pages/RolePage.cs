using Pepro.Presentation.Controls.Templates;
using Pepro.Presentation.Extensions;

namespace Pepro.Presentation.Controls.Pages;

public partial class RolePage : CrudTemplate
{
    public RolePage()
    {
        InitializeComponent();
        roleDataGridView.SetupCellStyle();

        searchButton.ApplyFlatStyleWithIcon("Search", ThemeColors.Text);
        reloadButton.ApplyFlatStyleWithIcon("Refresh", ThemeColors.Text);
        insertButton.ApplyFlatStyleWithIcon("Plus", ThemeColors.Text);
        deleteButton.ApplyFlatStyleWithIcon("Trash", ThemeColors.Text);
        updateButton.ApplyFlatStyleWithIcon("EditPencil", ThemeColors.Text);

        insertButton.ApplyPermission("Project.Create");
        deleteButton.ApplyPermission("Project.Delete");
        updateButton.ApplyPermission("Project.Update");
    }
}
