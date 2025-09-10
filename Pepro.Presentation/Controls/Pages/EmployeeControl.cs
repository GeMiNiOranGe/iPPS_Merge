using Pepro.Business;
using Pepro.DTOs;
using Pepro.Presentation.Base;
using Pepro.Presentation.Extensions;

namespace Pepro.Presentation.Controls.Pages;

public partial class EmployeeControl : PeproCrudControlBase {
    public EmployeeControl() {
        InitializeComponent();
        employeeDataGridView.SetupCellStyle();
        fullNameColumn.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

        searchButton.ApplyFlatStyleWithIcon("Search", ThemeColors.Text);
        reloadButton.ApplyFlatStyleWithIcon("Refresh", ThemeColors.Text);
        insertButton.ApplyFlatStyleWithIcon("Plus", ThemeColors.Text);
        deleteButton.ApplyFlatStyleWithIcon("Trash", ThemeColors.Text);
        updateButton.ApplyFlatStyleWithIcon("EditPencil", ThemeColors.Text);
        exportButton.ApplyFlatStyle();
    }

    private void LoadEmployees() {
        List<EmployeeView> employees = EmployeeBusiness.Instance.GetEmployeeViews();
        employeeDataGridView.DataSource = employees;
        numberOfEmployeesInputField.Text = employees.Count.ToString();
    }

    private void EmployeeControl_Load(object sender, EventArgs e) {
        LoadEmployees();
    }

    private void EmployeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
        BindDataGridViewCellClick<EmployeeDto>(
            (DataGridView)sender,
            e,
            (item) =>
            {
                employeeIdInputField.Text = item.EmployeeId.ToString();
                employeeNameInputField.Text = item.FullName;
            }
        );
    }

    private void SearchButton_Click(object sender, EventArgs e) {
        BindSearchButtonClick(
            searchTextBox.Text,
            employeeDataGridView,
            EmployeeBusiness.Instance.SearchEmployeeViews,
            (items) => numberOfEmployeesInputField.Text = items.Count.ToString()
        );
    }

    private void ReloadButton_Click(object sender, EventArgs e) {
        LoadEmployees();
    }

    private void InsertButton_Click(object sender, EventArgs e) {
        BindInsertButtonClick<EmployeeDto>(
            new(),
            ControlUiEvent.PushEmployeeEditorControl,
            LoadEmployees
        );
    }

    private void UpdateButton_Click(object sender, EventArgs e) {
        BindUpdateButtonClick<EmployeeDto>(
            employeeDataGridView,
            ControlUiEvent.PushEmployeeEditorControl,
            LoadEmployees
        );
    }

    private void DeleteButton_Click(object sender, EventArgs e) {
        BindDeleteButtonClick<EmployeeDto>(
            employeeDataGridView,
            (item) => EmployeeBusiness.Instance.DeleteEmployee(item.EmployeeId),
            LoadEmployees
        );
    }

    private void ExportButton_Click(object sender, EventArgs e) {
        SaveFileDialog saveFileDialog = new() {
            FileName = "Employees-" + DateTime.Now.ToString("ddMMyyyy-HHmmss"),
            Filter = "Excel Files|*.xlsx",
            Title = "Save Excel File"
        };

        if (saveFileDialog.ShowDialog() == DialogResult.OK) {
            ExcelExporter.Export(saveFileDialog.FileName, employeeDataGridView);
        }
    }
}
