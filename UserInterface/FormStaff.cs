using Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UserInterface {
    public partial class FormStaff : Form {
        SqlConnection sqlConnection = new SqlConnection(Database.CONNECTION_STRING);
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;
        //SqlDataAdapter sqlDataAdapter;
        //DataTable dataTable;

        public FormStaff() {
            InitializeComponent();
        }

        private void FormStaff_Load(object sender, EventArgs e) {
            loadDataStaff();
        }

        public void loadDataStaff() {
            int i = 0;

            sqlConnection.Open();

            sqlCommand = new SqlCommand("SELECT * FROM NHANVIEN", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(sqlDataReader[0].ToString());
                item.SubItems.Add(sqlDataReader[1].ToString());

                string gender = (bool)sqlDataReader[2] ? "Nam" : "Nữ";
                item.SubItems.Add(gender);

                var date = DateTime.Parse(sqlDataReader[3].ToString());
                item.SubItems.Add(date.ToString("dd/MM/yyyy"));

                item.SubItems.Add(sqlDataReader[4].ToString());
                item.SubItems.Add(sqlDataReader[5].ToString());
                item.SubItems.Add(sqlDataReader[6].ToString());
                item.SubItems.Add(sqlDataReader[7].ToString());
                item.SubItems.Add(sqlDataReader[8].ToString());

                string DoanVien = (bool)sqlDataReader[9] ? "Có" : "Không";
                item.SubItems.Add(DoanVien);

                string DangVien = (bool)sqlDataReader[10] ? "Có" : "Không";
                item.SubItems.Add(DangVien);

                string CongDoanVien = (bool)sqlDataReader[11] ? "Có" : "Không";
                item.SubItems.Add(CongDoanVien);

                listViewDataNV.Items.Add(item);
                i++;
            }
            lbSLNV.Text = i.ToString();

            sqlConnection.Close();
        }

        private void listViewDataNV_SelectedIndexChanged(object sender, EventArgs e) {
            if (listViewDataNV.SelectedItems.Count > 0) {
                ListViewItem item = listViewDataNV.SelectedItems[0];
                lbMaNV.Text = item.SubItems[1].Text;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtSearch.Text)) {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                listViewDataNV.Items.Clear();
                sqlConnection.Open();
                if (radioSearchMa.Checked) {
                    sqlCommand = new SqlCommand("SELECT * FROM NHANVIEN WHERE MANV LIKE '%" + txtSearch.Text + "%'", sqlConnection);
                }
                else if (radioSearchTen.Checked) {
                    sqlCommand = new SqlCommand("SELECT * FROM NHANVIEN WHERE HOTENNV LIKE '%" + txtSearch.Text + "%'", sqlConnection);
                }
                else {
                    MessageBox.Show("Vui lòng chọn mục tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                sqlDataReader = sqlCommand.ExecuteReader();
                int i = 0;
                while (sqlDataReader.Read()) {
                    ListViewItem item = new ListViewItem((i + 1).ToString());
                    item.SubItems.Add(sqlDataReader[0].ToString());
                    item.SubItems.Add(sqlDataReader[1].ToString());

                    string gender = (bool)sqlDataReader[2] ? "Nam" : "Nữ";
                    item.SubItems.Add(gender);

                    var date = DateTime.Parse(sqlDataReader[3].ToString());
                    item.SubItems.Add(date.ToString("dd/MM/yyyy"));

                    item.SubItems.Add(sqlDataReader[4].ToString());
                    item.SubItems.Add(sqlDataReader[5].ToString());
                    item.SubItems.Add(sqlDataReader[6].ToString());
                    item.SubItems.Add(sqlDataReader[7].ToString());
                    item.SubItems.Add(sqlDataReader[8].ToString());

                    string DoanVien = (bool)sqlDataReader[9] ? "Có" : "Không";
                    item.SubItems.Add(DoanVien);

                    string DangVien = (bool)sqlDataReader[10] ? "Có" : "Không";
                    item.SubItems.Add(DangVien);

                    string CongDoanVien = (bool)sqlDataReader[11] ? "Có" : "Không";
                    item.SubItems.Add(CongDoanVien);
                    listViewDataNV.Items.Add(item);
                    i++;
                }
                sqlConnection.Close();
            }
            txtSearch.Text = null;
        }

        private void btnReload_Click(object sender, EventArgs e) {
            listViewDataNV.Items.Clear();
            loadDataStaff();
        }
        
        private void btnAdd_Click(object sender, EventArgs e) {
            FormSaveStaff formInsertNhanVien = new FormSaveStaff();
            formInsertNhanVien.formStaff_TieuDe = "Thêm nhân viên";
            this.Close();
            formInsertNhanVien.Show();
        }
        
        private void btnEdit_Click(object sender, EventArgs e) {
            if (lbMaNV.Text == "null") {
                MessageBox.Show("Vui lòng chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                FormSaveStaff formInsertNhanVien = new FormSaveStaff();
                formInsertNhanVien.formStaff_MaNV = lbMaNV.Text;
                formInsertNhanVien.formStaff_TieuDe = "Cập nhật nhân viên";
                this.Close();
                formInsertNhanVien.Show();
            }
        }
        
        private void btnDel_Click(object sender, EventArgs e) {
            if (lbMaNV.Text != "null") {
                if (MessageBox.Show("Bạn có chắc là muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    // Xoá Lương
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("DELETE FROM LUONG WHERE MANV = '" + lbMaNV.Text + "'", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    // Xoá Bộ phận chấm công
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("DELETE FROM BOPHANCHAMCONG WHERE MANV = '" + lbMaNV.Text + "'", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    // Nếu 2 nhân viên cùng sống chung 1 Hộ gia đình thì update NULL ở nhân viên bị xoá
                    // Khi MANV1
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("UPDATE HOGIADINH SET MANV1 = NULL WHERE MANV1 = @MANV1 AND MANV2 IS NOT NULL", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@MANV1", lbMaNV.Text);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    // Khi MANV2
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("UPDATE HOGIADINH SET MANV2 = NULL WHERE MANV2 = @MANV2 AND MANV1 IS NOT NULL", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@MANV2", lbMaNV.Text);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    // Nếu 1 nhân viên thì xoá theo thứ tự Tiền nhà -> Nước -> Điện -> Hộ gia đình
                    // Khi MANV1
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("DELETE FROM TIENNHA WHERE MAHGD IN (SELECT MAHGD FROM HOGIADINH WHERE MANV1 = '" + lbMaNV.Text + "' AND MANV2 IS NULL)", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("DELETE FROM NUOC WHERE MAHGD IN (SELECT MAHGD FROM HOGIADINH WHERE MANV1 = '" + lbMaNV.Text + "' AND MANV2 IS NULL)", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("DELETE FROM DIEN WHERE MAHGD IN (SELECT MAHGD FROM HOGIADINH WHERE MANV1 = '" + lbMaNV.Text + "' AND MANV2 IS NULL)", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("DELETE FROM HOGIADINH WHERE MANV1 = '" + lbMaNV.Text + "' AND MANV2 IS NULL", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    // Khi MANV2
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("DELETE FROM TIENNHA WHERE MAHGD IN (SELECT MAHGD FROM HOGIADINH WHERE MANV2 = '" + lbMaNV.Text + "' AND MANV1 IS NULL)", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("DELETE FROM NUOC WHERE MAHGD IN (SELECT MAHGD FROM HOGIADINH WHERE MANV2 = '" + lbMaNV.Text + "' AND MANV1 IS NULL)", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("DELETE FROM DIEN WHERE MAHGD IN (SELECT MAHGD FROM HOGIADINH WHERE MANV2 = '" + lbMaNV.Text + "' AND MANV1 IS NULL)", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("DELETE FROM HOGIADINH WHERE MANV2 = '" + lbMaNV.Text + "' AND MANV1 IS NULL", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    // Xoá Nhân viên - Phòng tổ chức
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("DELETE FROM NHANVIEN_PHONGTOCHUC WHERE MANV = '" + lbMaNV.Text + "'", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    // Xoá Nhân viên - Chuyên môn
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("DELETE FROM NHANVIEN_CHUYENMON WHERE MANV = '" + lbMaNV.Text + "'", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    // Xoá nhân viên - Ngoại ngữ
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("DELETE FROM NHANVIEN_NGOAINGU WHERE MANV = '" + lbMaNV.Text + "'", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    // Xoá Người thân
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("DELETE FROM NGUOITHAN WHERE MANV = '" + lbMaNV.Text + "'", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    // Xoá nhân viên
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("DELETE FROM NHANVIEN WHERE MANV = '" + lbMaNV.Text + "'", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    MessageBox.Show("Bạn đã xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else {
                MessageBox.Show("Vui lòng chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void btnExport_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Save Excel File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                ExportToExcel(listViewDataNV, saveFileDialog.FileName);
            }
        }
        
        private void ExportToExcel(System.Windows.Forms.ListView listView, string filePath) {
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
    }
}
