using Pepro.Business;
using Pepro.DTOs;

namespace Pepro.Presentation.Controls;

public partial class AssignmentControl : PeproCrudControlBase
{
    public AssignmentControl()
    {
        InitializeComponent();
        assignmentDataGridView.SetupCellStyle();
        managerColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

        searchButton.ApplyFlatStyleWithIcon("Search", ThemeColors.Text);
        reloadButton.ApplyFlatStyleWithIcon("Refresh", ThemeColors.Text);
        insertButton.ApplyFlatStyleWithIcon("Plus", ThemeColors.Text);
        deleteButton.ApplyFlatStyleWithIcon("Trash", ThemeColors.Text);
        updateButton.ApplyFlatStyleWithIcon("EditPencil", ThemeColors.Text);
    }

    private void LoadAssignments()
    {
        assignmentDataGridView.DataSource = AssignmentBusiness.Instance.GetAssignmentViews();
    }

    private void AssignmentControl_Load(object sender, EventArgs e)
    {
        LoadAssignments();
    }

    private void AssignmentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        BindDataGridViewCellClick<AssignmentDto>((DataGridView)sender, e);
    }

    private void SearchButton_Click(object sender, EventArgs e)
    {
        BindSearchButtonClick(
            searchTextBox.Text,
            assignmentDataGridView,
            AssignmentBusiness.Instance.SearchAssignmentViews
        );
    }

    private void ReloadButton_Click(object sender, EventArgs e)
    {
        LoadAssignments();
    }

    private void InsertButton_Click(object sender, EventArgs e)
    {
        BindInsertButtonClick<AssignmentDto>(
            new(),
            ControlUiEvent.PushAssignmentEditorControl,
            LoadAssignments
        );
    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
        BindUpdateButtonClick<AssignmentDto>(
            assignmentDataGridView,
            ControlUiEvent.PushAssignmentEditorControl,
            LoadAssignments
        );
    }

    private void DeleteButton_Click(object sender, EventArgs e)
    {
        BindDeleteButtonClick<AssignmentDto>(
            assignmentDataGridView,
            (item) => AssignmentBusiness.Instance.DeleteAssignment(item.AssignmentId),
            LoadAssignments
        );
    }
}
