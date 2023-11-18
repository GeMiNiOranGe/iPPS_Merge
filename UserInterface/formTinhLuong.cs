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
                tbBL.Text = hesobacluong.ToString();
                tbPhuCap.Text=hesophucap.ToString();
                tbSoNgayCong.Text = songaydilam.ToString();
                dtpkThoiDiem.Value = thoidiem;


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
                // Tải lại danh sách lương hoặc thực hiện các công việc khác cần thiết
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
                dtgvLuongNV.DataSource = null; // Xóa dữ liệu trên DataGridView nếu không có thông tin
            }
        }
        public void SearchAndDisplaySalary(string maNhanVien)
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
