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

        searchButton.SetupRuntimeFlatStyleWithIcon("Search", ThemeColors.Text);
        reloadButton.SetupRuntimeFlatStyleWithIcon("Refresh", ThemeColors.Text);
        insertButton.SetupRuntimeFlatStyleWithIcon("Plus", ThemeColors.Text);
        deleteButton.SetupRuntimeFlatStyleWithIcon("Trash", ThemeColors.Text);
        updateButton.SetupRuntimeFlatStyleWithIcon("EditPencil", ThemeColors.Text);
        exportButton.SetupRuntimeFlatStyle();
    }

    private void EmployeeControl_Load(object sender, EventArgs e) {
        LoadEmployees();
    }

    public void LoadEmployees() {
        List<EmployeeDto> employees = EmployeeBusiness.Instance.GetEmployees();
        employeeDataGridView.DataSource = employees;
        numberOfEmployeesInputField.Text = employees.Count.ToString();
    }

    private void EmployeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
        // Ignore clicks on the column header or invalid row indices
        if (e.RowIndex < 0 || e.RowIndex >= employeeDataGridView.Rows.Count) {
            return;
        }

        DataGridViewRow row = employeeDataGridView.Rows[e.RowIndex];

        if (row.DataBoundItem is EmployeeDto employee) {
            employeeIdInputField.Text = employee.EmployeeId;
            employeeNameInputField.Text = employee.LastName + " "
                + (employee.MiddleName != null ? employee.MiddleName + " " : "")
                + employee.FirstName;
        }
    }

    private void EmployeeDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
        employeeDataGridView.ClearSelection();
        employeeDataGridView.CurrentCell = null;
    }

    private void SearchButton_Click(object sender, EventArgs e) {
        if (string.IsNullOrEmpty(searchTextBox.Text)) {
            MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        List<EmployeeDto> employees = EmployeeBusiness.Instance.SearchEmployees(searchTextBox.Text);
        employeeDataGridView.DataSource = employees;
        numberOfEmployeesInputField.Text = employees.Count.ToString();
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
        string employeeId = employeeIdInputField.Text;
        if (string.IsNullOrEmpty(employeeId)) {
            MessageBoxWrapper.ShowInformation("SelectEmployee");
            return;
        }

        if (MessageBoxWrapper.ConfirmDelete() == DialogResult.Yes) {
            int numberOfRowsAffected = EmployeeBusiness.Instance.DeleteEmployee(employeeId);
            MessageBoxWrapper.ShowInformation("DeleteEmployeeSuccess", numberOfRowsAffected);
            LoadEmployees();
        }
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
