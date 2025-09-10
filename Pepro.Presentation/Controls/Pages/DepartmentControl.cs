using Pepro.Business;
using Pepro.DTOs;
using Pepro.Presentation.Base;
using Pepro.Presentation.Extensions;

namespace Pepro.Presentation.Controls.Pages;

public partial class DepartmentControl : PeproCrudControlBase
{
    public DepartmentControl()
    {
        InitializeComponent();
        departmentDataGridView.SetupCellStyle();
        managerColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

        searchButton.ApplyFlatStyleWithIcon("Search", ThemeColors.Text);
        reloadButton.ApplyFlatStyleWithIcon("Refresh", ThemeColors.Text);
        insertButton.ApplyFlatStyleWithIcon("Plus", ThemeColors.Text);
        deleteButton.ApplyFlatStyleWithIcon("Trash", ThemeColors.Text);
        updateButton.ApplyFlatStyleWithIcon("EditPencil", ThemeColors.Text);
    }

    private void LoadDepartments()
    {
        departmentDataGridView.DataSource = DepartmentBusiness.Instance.GetDepartmentViews();
    }

    private void DepartmentControl_Load(object sender, EventArgs e)
    {
        LoadDepartments();
    }

    private void DepartmentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        BindDataGridViewCellClick<DepartmentDto>(
            (DataGridView)sender,
            e,
            (item) =>
            {
                managerInputField.Text = item.DepartmentId.ToString();
                departmentNameInputField.Text = item.Name;
            }
        );
    }

    private void SearchButton_Click(object sender, EventArgs e)
    {
        BindSearchButtonClick(
            searchTextBox.Text,
            departmentDataGridView,
            DepartmentBusiness.Instance.SearchDepartmentViews
        );
    }

    private void ReloadButton_Click(object sender, EventArgs e)
    {
        LoadDepartments();
    }

    private void InsertButton_Click(object sender, EventArgs e)
    {
        BindInsertButtonClick<DepartmentDto>(
            new(),
            ControlUiEvent.PushDepartmentEditorControl,
            LoadDepartments
        );
    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
        BindUpdateButtonClick<DepartmentDto>(
            departmentDataGridView,
            ControlUiEvent.PushDepartmentEditorControl,
            LoadDepartments
        );
    }

    private void DeleteButton_Click(object sender, EventArgs e)
    {
        BindDeleteButtonClick<DepartmentDto>(
            departmentDataGridView,
            (item) => DepartmentBusiness.Instance.DeleteDepartment(item.DepartmentId),
            LoadDepartments
        );
    }
}
