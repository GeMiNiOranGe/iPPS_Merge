using Pepro.Business;
using Pepro.DTOs;

namespace Pepro.Presentation.Controls;

public partial class ProjectControl : PeproCrudControlBase
{
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

    private void LoadProjects()
    {
        projectDataGridView.DataSource = ProjectBusiness.Instance.GetProjectViews();
    }

    private void AdminProjects_Load(object sender, EventArgs e)
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
            ControlUiEvent.OpenProjectEditorControl,
            LoadProjects
        );
    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
        BindUpdateButtonClick<ProjectDto>(
            projectDataGridView,
            ControlUiEvent.OpenProjectEditorControl,
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
