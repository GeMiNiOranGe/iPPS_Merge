using Microsoft.Data.SqlClient;
using Pepro.Business;
using Pepro.DTOs;
//using Excel = Microsoft.Office.Interop.Excel;

namespace Pepro.Presentation.Controls;

public partial class EmployeeControl : PeproMediatedUserControl {
    SqlConnection sqlConnection = new(Config.CONNECTION_STRING);
    SqlCommand sqlCommand;
    SqlDataReader sqlDataReader;

    public EmployeeControl() {
        Initialize();
    }

    public EmployeeControl(IMediator mediator) : base(mediator) {
        Initialize();
    }

    private void Initialize() {
        InitializeComponent();
        employeeDataGridView.SetupCellStyle();
    }

    private void EmployeeControl_Load(object sender, EventArgs e) {
        LoadEmployees();
    }

    public void LoadEmployees() {
        List<Employee> employees = EmployeeBusiness.Instance.GetEmployees();
        employeeDataGridView.DataSource = employees;
        numberOfEmployeesInputField.Text = employees.Count.ToString();
    }

    /*
    private void listViewDataNV_SelectedIndexChanged(object sender, EventArgs e) {
        if (employeeDataGridView.SelectedItems.Count > 0) {
            ListViewItem item = employeeDataGridView.SelectedItems[0];
            employeeIdInputField.Text = item.SubItems[1].Text;
        }
    }
    */

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
        if (employeeIdInputField.Text != "null") {
            if (MessageBox.Show("Bạn có chắc là muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                // Xoá Lương
                sqlConnection.Open();
                sqlCommand = new SqlCommand("DELETE FROM LUONG WHERE MANV = '" + employeeIdInputField.Text + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                // Xoá Bộ phận chấm công
                sqlConnection.Open();
                sqlCommand = new SqlCommand("DELETE FROM BOPHANCHAMCONG WHERE MANV = '" + employeeIdInputField.Text + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                // Nếu 2 nhân viên cùng sống chung 1 Hộ gia đình thì update NULL ở nhân viên bị xoá
                // Khi MANV1
                sqlConnection.Open();
                sqlCommand = new SqlCommand("UPDATE HOGIADINH SET MANV1 = NULL WHERE MANV1 = @MANV1 AND MANV2 IS NOT NULL", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@MANV1", employeeIdInputField.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                // Khi MANV2
                sqlConnection.Open();
                sqlCommand = new SqlCommand("UPDATE HOGIADINH SET MANV2 = NULL WHERE MANV2 = @MANV2 AND MANV1 IS NOT NULL", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@MANV2", employeeIdInputField.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                // Nếu 1 nhân viên thì xoá theo thứ tự Tiền nhà -> Nước -> Điện -> Hộ gia đình
                // Khi MANV1
                sqlConnection.Open();
                sqlCommand = new SqlCommand("DELETE FROM TIENNHA WHERE MAHGD IN (SELECT MAHGD FROM HOGIADINH WHERE MANV1 = '" + employeeIdInputField.Text + "' AND MANV2 IS NULL)", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                sqlConnection.Open();
                sqlCommand = new SqlCommand("DELETE FROM NUOC WHERE MAHGD IN (SELECT MAHGD FROM HOGIADINH WHERE MANV1 = '" + employeeIdInputField.Text + "' AND MANV2 IS NULL)", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                sqlConnection.Open();
                sqlCommand = new SqlCommand("DELETE FROM DIEN WHERE MAHGD IN (SELECT MAHGD FROM HOGIADINH WHERE MANV1 = '" + employeeIdInputField.Text + "' AND MANV2 IS NULL)", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                sqlConnection.Open();
                sqlCommand = new SqlCommand("DELETE FROM HOGIADINH WHERE MANV1 = '" + employeeIdInputField.Text + "' AND MANV2 IS NULL", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                // Khi MANV2
                sqlConnection.Open();
                sqlCommand = new SqlCommand("DELETE FROM TIENNHA WHERE MAHGD IN (SELECT MAHGD FROM HOGIADINH WHERE MANV2 = '" + employeeIdInputField.Text + "' AND MANV1 IS NULL)", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                sqlConnection.Open();
                sqlCommand = new SqlCommand("DELETE FROM NUOC WHERE MAHGD IN (SELECT MAHGD FROM HOGIADINH WHERE MANV2 = '" + employeeIdInputField.Text + "' AND MANV1 IS NULL)", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                sqlConnection.Open();
                sqlCommand = new SqlCommand("DELETE FROM DIEN WHERE MAHGD IN (SELECT MAHGD FROM HOGIADINH WHERE MANV2 = '" + employeeIdInputField.Text + "' AND MANV1 IS NULL)", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                sqlConnection.Open();
                sqlCommand = new SqlCommand("DELETE FROM HOGIADINH WHERE MANV2 = '" + employeeIdInputField.Text + "' AND MANV1 IS NULL", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                // Xoá Nhân viên - Phòng tổ chức
                sqlConnection.Open();
                sqlCommand = new SqlCommand("DELETE FROM NHANVIEN_PHONGTOCHUC WHERE MANV = '" + employeeIdInputField.Text + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                // Xoá Nhân viên - Chuyên môn
                sqlConnection.Open();
                sqlCommand = new SqlCommand("DELETE FROM NHANVIEN_CHUYENMON WHERE MANV = '" + employeeIdInputField.Text + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                // Xoá nhân viên - Ngoại ngữ
                sqlConnection.Open();
                sqlCommand = new SqlCommand("DELETE FROM NHANVIEN_NGOAINGU WHERE MANV = '" + employeeIdInputField.Text + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                // Xoá Người thân
                sqlConnection.Open();
                sqlCommand = new SqlCommand("DELETE FROM NGUOITHAN WHERE MANV = '" + employeeIdInputField.Text + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                // Xoá nhân viên
                sqlConnection.Open();
                sqlCommand = new SqlCommand("DELETE FROM NHANVIEN WHERE MANV = '" + employeeIdInputField.Text + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                MessageBox.Show("Bạn đã xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        else {
            MessageBox.Show("Vui lòng chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
    private void ExportButton_Click(object sender, EventArgs e) {
        SaveFileDialog saveFileDialog = new() {
            Filter = "Excel Files|*.xlsx",
            Title = "Save Excel File"
        };

        if (saveFileDialog.ShowDialog() == DialogResult.OK) {
            //ExportToExcel(listViewDataNV, saveFileDialog.FileName);
        }
    }

    /*
    private void ExportToExcel(ListView listView, string filePath) {
        Excel.Application excelApp = new Excel.Application();
        excelApp.Visible = true;
        Excel.Workbook workbook = excelApp.Workbooks.Add();
        Excel.Worksheet worksheet = workbook.Sheets[1];

        int row = 1;
        int col = 1;

        // Xuất tiêu đề của các cột
        foreach (ColumnHeader header in listView.Columns) {
            worksheet.Cells[row, col] = header.Text;
            col++;
        }

        // Xuất dữ liệu từ ListView
        row++;
        foreach (ListViewItem item in listView.Items) {
            col = 1;
            foreach (ListViewItem.ListViewSubItem subItem in item.SubItems) {
                worksheet.Cells[row, col] = subItem.Text;
                col++;
            }
            row++;
        }

        // Lưu tệp Excel
        workbook.SaveAs(filePath);
        workbook.Close();
        excelApp.Quit();

        ReleaseObject(worksheet);
        ReleaseObject(workbook);
        ReleaseObject(excelApp);

        MessageBox.Show("Dữ liệu đã được xuất ra Excel.");
    }

    private void ReleaseObject(object obj) {
        try {
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
            obj = null;
        }
        catch (Exception ex) {
            obj = null;
            MessageBox.Show("Lỗi" + ex.ToString());
        }
        finally {
            GC.Collect();
        }
    }
    */
}
