using BusinessLogic;
using DTO;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText;
namespace UserInterface
{
    public partial class formTinhLuong : Form
    {
        #region Event
        
        public formTinhLuong()
        {
            InitializeComponent();
        }
        private void formTinhLuong_Load(object sender, EventArgs e)
        {
            
            loadSalaryList();
            loadComBoBoxMaNV();
            loadComBobBoxMaBL();
        }
        private void dtgvLuongNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvLuongNV.SelectedRows.Count > 0)
            {

                DataGridViewRow selectionrow = dtgvLuongNV.SelectedRows[0];

                string manv = selectionrow.Cells["MaNhanVien"].Value.ToString();
                DateTime thoidiem = (DateTime)selectionrow.Cells["Thoidiem"].Value;
                byte songaydilam = (byte)selectionrow.Cells["Songaydilam"].Value;
                Decimal hesobacluong = (Decimal)selectionrow.Cells["HeSoBacLuong"].Value;
                Decimal hesophucap = (Decimal)selectionrow.Cells["Hesophucapchucvu"].Value;
                int luongcoban = (int)selectionrow.Cells["LuongCoBan"].Value;
                int tongluong = (int)selectionrow.Cells["TongLuong"].Value;
                int tiennha = (int)selectionrow.Cells["TienNha"].Value;
                cbMaNV.Text = manv;
                tbLCB.Text = luongcoban.ToString("#,##0") +" VND";
                tbTienLuong.Text = tongluong.ToString("#,##0") +" VND";
                tbTienNha.Text = tiennha.ToString("#,##0") + " VND";
                cbBacLuong.Text = hesobacluong.ToString();
                tbPhuCap.Text=hesophucap.ToString();
                tbSoNgayCong.Text = songaydilam.ToString();
                dtpkThoiDiem.Value = thoidiem;
                rtbLuong.Text = tongluong.ToString("#,##0") + " VND";

            }
        }
        private void dtpkThoiDiem_ValueChanged(object sender, EventArgs e)
        {
            string manv = cbMaNV.Text;
            DateTime thoigian = dtpkThoiDiem.Value;
           if(LuongDA.Instance.updateSalaryForNewMonth(manv,thoigian))
            {
                loadSalaryList();
            }
            
        }
        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            string maNhanVien = cbMaNV.Text.Trim();

            // Kiểm tra xem Mã Nhân Viên có giá trị hợp lệ hay không
            if (string.IsNullOrEmpty(maNhanVien))
            {
                MessageBox.Show("Vui lòng chọn Mã Nhân Viên.");
                return;
            }

            // Tính lương cho nhân viên
            int tienLuong = LuongDA.Instance.calculateSalary(maNhanVien);
            // Hiển thị lương trên RichTextBox
            rtbLuong.Text = tienLuong.ToString("#,##0");

            // Cập nhật lương trong CSDL
            if (LuongDA.Instance.updateSalary(maNhanVien, tienLuong))
            {
                MessageBox.Show("Cập nhật lương thành công");
                // Tải lại danh sách lương
                loadSalaryList();
            }
            else
            {
                MessageBox.Show("Cập nhật lương thất bại");
            }

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string manv = rtbMaNhanVien.Text.ToString();
            if (string.IsNullOrEmpty(manv))
            {
                MessageBox.Show("Vui lòng nhập Mã Nhân Viên.");
                return;
            }
            SearchAndDisplaySalary(manv);
            DisplayEmployeeDataOnDataGridView(manv);

        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            loadSalaryList();
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                string maNhanVien = cbMaNV.Text;
                int luongCoBan = int.Parse(Regex.Replace(tbLCB.Text, @"[^\d]", ""));
                DateTime thoiDiem = dtpkThoiDiem.Value;

                
                if (LuongBL.Instance.updateSalaryInfo(maNhanVien, luongCoBan, thoiDiem))
                {
                    MessageBox.Show("Cập nhật thông tin lương thành công");
                    loadSalaryList();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin lương thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maNhanVien = cbMaNV.Text;
                if (LuongBL.Instance.deleteSalaryInfo(maNhanVien))
                {
                    MessageBox.Show("Xoá thành công");
                    loadSalaryList();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                string maNhanVien = cbMaNV.Text;
                int luongCoBan = int.Parse(Regex.Replace(tbLCB.Text, @"[^\d]", ""));
                int tongluong = int.Parse(Regex.Replace(tbTienLuong.Text, @"[^\d]", ""));
                DateTime thoidiem = dtpkThoiDiem.Value;
                DataTable dataTable = LuongDA.Instance.getEmployeeSalryInfo();
                // Hiển thị đường dẫn để kiểm tra
                DialogResult result = MessageBox.Show("Bạn muốn xuất toàn bộ bảng lương hay chỉ một nhân viên?", "Xuất Báo Cáo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (result)
                {
                    case DialogResult.Yes:
                        string filePath1 = LuongDA.Instance.ExportAlltoPdf(dataTable);
                        MessageBox.Show($"File PDF đã được xuất tại:\n{filePath1}", "Thông báo");
                        break;
                    case DialogResult.No:
                        string filePath = LuongDA.ExportToPdf(maNhanVien, luongCoBan, tongluong, thoidiem);
                        MessageBox.Show($"File PDF đã được xuất tại:\n{filePath}", "Thông báo");
                        break;
                    case DialogResult.Cancel:
                        break;
                }
               

                // Tiếp theo có thể thực hiện các công việc khác nếu cần
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        //--------------------------------------Function--------------------------------------------------------------------------
        #region Function
        private void loadSalaryList()
        {
            List<Luong> tinhluong = LuongDA.Instance.loadSalaryList();
            dtgvLuongNV.DataSource = tinhluong;
        }
        private void loadComBoBoxMaNV()
        {
            DataTable data = LuongBL.Instance.getEmployeeID();
            cbMaNV.DataSource = data;
            cbMaNV.DisplayMember = "MANV";
            cbMaNV.DisplayMember = "MANV";
        }
        private void loadComBobBoxMaBL()
        {
            DataTable data = LuongBL.Instance.getSalaryScale();
            cbBacLuong.DataSource = data;
            cbBacLuong.DisplayMember = "HESOBL";
            cbBacLuong.DisplayMember = "HESOBL";
        }

        private void DisplayEmployeeDataOnDataGridView(string maNhanVien)
        {
            // Thực hiện truy vấn trong CSDL để lấy thông tin của nhân viên
            DataTable employeeData = LuongDA.Instance.GetEmployeeData(maNhanVien);

            // Kiểm tra xem có dữ liệu hay không
            if (employeeData.Rows.Count > 0)
            {
                // Cập nhật dữ liệu lên DataGridView
                dtgvLuongNV.DataSource = employeeData;
            }
            else
            {
                MessageBox.Show("Không có thông tin cho nhân viên có mã: " + maNhanVien);
                loadSalaryList();
                rtbMaNhanVien.Clear();
            }
        }
        private void SearchAndDisplaySalary(string maNhanVien)
        {
            try
            {
                // Thực hiện gọi stored procedure CalculateSalary
                int tienLuong = LuongDA.Instance.calculateSalary(maNhanVien);

                // Hiển thị thông tin lương trên TextBox hoặc RichTextBox hoặc bất kỳ thành phần giao diện nào bạn mong muốn
                rtbLuong.Text = tienLuong.ToString("#,##0");
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }

        #endregion

      
    }
}
