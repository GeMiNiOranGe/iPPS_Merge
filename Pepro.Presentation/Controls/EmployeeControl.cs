using Pepro.Business;
using Pepro.DTOs;

namespace Pepro.Presentation.Controls;

public partial class EmployeeControl : PeproCrudControlBase {
    public EmployeeControl() {
        Initialize();
    }

    public EmployeeControl(IMediator mediator) : base(mediator) {
        Initialize();
    }

    private void Initialize() {
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

    public void LoadEmployees() {
        List<EmployeeDto> employees = EmployeeBusiness.Instance.GetEmployees();
        employeeDataGridView.DataSource = employees;
        numberOfEmployeesInputField.Text = employees.Count.ToString();
    }

    private void EmployeeControl_Load(object sender, EventArgs e) {
        LoadEmployees();
    }

    private void EmployeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
        // Ignore clicks on the column header or invalid row indices
        if (e.RowIndex < 0 || e.RowIndex >= employeeDataGridView.Rows.Count) {
            return;
        }

        DataGridViewRow row = employeeDataGridView.Rows[e.RowIndex];

        if (row.DataBoundItem is EmployeeDto employee) {
            employeeIdInputField.Text = employee.EmployeeId.ToString();
            employeeNameInputField.Text = employee.FullName;
        }
    }

    private void SearchButton_Click(object sender, EventArgs e) {
        BindSearchButtonClick(
            searchTextBox.Text,
            employeeDataGridView,
            EmployeeBusiness.Instance.SearchEmployees,
            (items) => numberOfEmployeesInputField.Text = items.Count.ToString()
        );
    }

    private void ReloadButton_Click(object sender, EventArgs e) {
        LoadEmployees();
    }

    private void InsertButton_Click(object sender, EventArgs e) {
        BindInsertButtonClick<EmployeeDto>(
            new(),
            ControlUiEvent.OpenEmployeeEditorControl,
            LoadEmployees
        );
    }

    private void UpdateButton_Click(object sender, EventArgs e) {
        BindUpdateButtonClick<EmployeeDto>(
            employeeDataGridView,
            ControlUiEvent.OpenEmployeeEditorControl,
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
