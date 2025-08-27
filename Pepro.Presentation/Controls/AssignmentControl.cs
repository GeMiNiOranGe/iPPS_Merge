namespace Pepro.Presentation.Controls;

public partial class AssignmentControl : PeproCrudControlBase
{
    public AssignmentControl()
    {
        Initialize();
    }

    public AssignmentControl(IMediator mediator) : base(mediator)
    {
        Initialize();
    }

    private void Initialize()
    {
        InitializeComponent();
        assignmentDataGridView.SetupCellStyle();

        searchButton.ApplyFlatStyleWithIcon("Search", ThemeColors.Text);
        reloadButton.ApplyFlatStyleWithIcon("Refresh", ThemeColors.Text);
        insertButton.ApplyFlatStyleWithIcon("Plus", ThemeColors.Text);
        deleteButton.ApplyFlatStyleWithIcon("Trash", ThemeColors.Text);
        updateButton.ApplyFlatStyleWithIcon("EditPencil", ThemeColors.Text);
    }

    private void LoadAssignments()
    {
    }

    private void AssignmentControl_Load(object sender, EventArgs e)
    {
        LoadAssignments();
    }
}
