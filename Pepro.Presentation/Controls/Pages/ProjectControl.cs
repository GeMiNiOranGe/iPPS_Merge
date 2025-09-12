using Pepro.Business;
using Pepro.DTOs;
using Pepro.Presentation.Controls.Templates;
using Pepro.Presentation.Enums;
using Pepro.Presentation.Extensions;

namespace Pepro.Presentation.Controls.Pages;

public partial class ProjectControl : CrudTemplate
{
    public ProjectControl()
    {
        InitializeComponent();
        projectDataGridView.SetupCellStyle();
        managerColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

        searchButton.ApplyFlatStyleWithIcon("Search", ThemeColors.Text);
        reloadButton.ApplyFlatStyleWithIcon("Refresh", ThemeColors.Text);
        insertButton.ApplyFlatStyleWithIcon("Plus", ThemeColors.Text);
        deleteButton.ApplyFlatStyleWithIcon("Trash", ThemeColors.Text);
        updateButton.ApplyFlatStyleWithIcon("EditPencil", ThemeColors.Text);
    }

    private void LoadProjects()
    {
        projectDataGridView.DataSource = ProjectBusiness.Instance.GetProjectViews();
    }

    private void ProjectControl_Load(object sender, EventArgs e)
    {
        LoadProjects();
    }

    private void ProjectDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
        BindDataGridViewCellClick<ProjectDto>((DataGridView)sender, e);
    }

    private void SearchButton_Click(object sender, EventArgs e) {
        BindSearchButtonClick(
            searchTextBox.Text,
            projectDataGridView,
            ProjectBusiness.Instance.SearchProjectViews
        );
    }

    private void ReloadButton_Click(object sender, EventArgs e) {
        LoadProjects();
    }

    private void InsertButton_Click(object sender, EventArgs e) {
        BindInsertButtonClick<ProjectDto>(
            new(),
            ControlUiEvent.PushProjectEditorControl,
            LoadProjects
        );
    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
        BindUpdateButtonClick<ProjectDto>(
            projectDataGridView,
            ControlUiEvent.PushProjectEditorControl,
            LoadProjects
        );
    }

    private void DeleteButton_Click(object sender, EventArgs e) {
        BindDeleteButtonClick<ProjectDto>(
            projectDataGridView,
            (item) => ProjectBusiness.Instance.DeleteProject(item.ProjectId),
            LoadProjects
        );
    }
}
