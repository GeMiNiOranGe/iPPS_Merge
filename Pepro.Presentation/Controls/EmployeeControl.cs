using Pepro.Business;
using Pepro.DTOs;
using Svg;

namespace Pepro.Presentation.Controls;

public partial class EmployeeControl : PeproMediatedUserControl {
    public EmployeeControl() {
        Initialize();
    }

    public EmployeeControl(IMediator mediator) : base(mediator) {
        Initialize();
    }

    private void Initialize() {
        InitializeComponent();
        employeeDataGridView.SetupCellStyle();

        searchButton.SetupRuntimeFlatStyle();
        searchButton.SetupRuntimeIcon(
            "Search",
            colorServer: new SvgColourServer(ThemeColors.Text)
        );
        reloadButton.SetupRuntimeFlatStyle();
        reloadButton.SetupRuntimeIcon(
            "Refresh",
            colorServer: new SvgColourServer(ThemeColors.Text)
        );
        insertButton.SetupRuntimeFlatStyle();
        insertButton.SetupRuntimeIcon(
            "Plus",
            colorServer: new SvgColourServer(ThemeColors.Text)
        );
        deleteButton.SetupRuntimeFlatStyle();
        deleteButton.SetupRuntimeIcon(
            "Trash",
            colorServer: new SvgColourServer(ThemeColors.Text)
        );
        updateButton.SetupRuntimeFlatStyle();
        updateButton.SetupRuntimeIcon(
            "EditPencil",
            colorServer: new SvgColourServer(ThemeColors.Text)
        );
        exportButton.SetupRuntimeFlatStyle();
    }

    private void EmployeeControl_Load(object sender, EventArgs e) {
        LoadEmployees();
    }

    public void LoadEmployees() {
        List<Employee> employees = EmployeeBusiness.Instance.GetEmployees();
        employeeDataGridView.DataSource = employees;
        numberOfEmployeesInputField.Text = employees.Count.ToString();
    }

    private void EmployeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
        // Ignore clicks on the column header or invalid row indices
        if (e.RowIndex < 0 || e.RowIndex >= employeeDataGridView.Rows.Count) {
            return;
        }

        DataGridViewRow row = employeeDataGridView.Rows[e.RowIndex];

        if (row.DataBoundItem is Employee employee) {
            employeeIdInputField.Text = employee.EmployeeId;
            employeeNameInputField.Text = employee.LastName + " "
                + (employee.MiddleName != null ? employee.MiddleName + " " : "")
                + employee.FirstName;
        }
    }

    private void SearchButton_Click(object sender, EventArgs e) {
        if (string.IsNullOrEmpty(searchTextBox.Text)) {
            MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        List<Employee> employees = EmployeeBusiness.Instance.SearchEmployees(searchTextBox.Text);
        employeeDataGridView.DataSource = employees;
        numberOfEmployeesInputField.Text = employees.Count.ToString();
    }

    private void ReloadButton_Click(object sender, EventArgs e) {
        LoadEmployees();
    }

    private void InsertButton_Click(object sender, EventArgs e) {
        EmployeeEditorForm formInsertNhanVien = new() {
            formStaff_TieuDe = "Thêm nhân viên"
        };
        formInsertNhanVien.Show();
    }

    private void UpdateButton_Click(object sender, EventArgs e) {
        if (employeeIdInputField.Text == "null") {
            MessageBox.Show("Vui lòng chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else {
            EmployeeEditorForm formInsertNhanVien = new() {
                formStaff_MaNV = employeeIdInputField.Text,
                formStaff_TieuDe = "Cập nhật nhân viên"
            };
            formInsertNhanVien.Show();
        }
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
