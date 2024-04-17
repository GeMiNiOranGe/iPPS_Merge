using BusinessLogic;
using DataAccess;
using DTO;
using iText.Layout.Splitting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface {
    public partial class formKTX : Form {
        #region Evens
        public formKTX() {
            InitializeComponent();
        }

        private void điệnToolStripMenuItem_Click(object sender, EventArgs e) {
            formTienDien ftd = new formTienDien();
            ftd.ShowDialog();
        }

        private void nướcToolStripMenuItem_Click(object sender, EventArgs e) {
            formTienNuoc ftn = new formTienNuoc();
            ftn.ShowDialog();
        }

        private void tiềnNhàToolStripMenuItem_Click(object sender, EventArgs e) {
            formTienNha ftn = new formTienNha();
            ftn.ShowDialog();
        }

        private void formKTX_Load(object sender, EventArgs e)
        {
            showHouseHoldList();
            loadComBobBoxNV1();
            loadComBobBoxNV2();
        }
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (dtHoGiaDinh.SelectedRows.Count > 0)
            {
                try
                {
                    if (KTXBL.Instance.updateEmployee(tbHoGiaDinh.Text, cbMaNV2.Text))
                    {
                        MessageBox.Show("Cập nhật thành công");
                        showHouseHoldList();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi: Không thể thêm nhân viên vào danh sách!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi cập nhật: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin cần chỉnh sửa");
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string mahgd = rtbTimKiem.Text.ToString();
            if (string.IsNullOrEmpty(mahgd))
            {
                MessageBox.Show("Vui lòng nhập Mã Hộ");
                return;
            }
            DisplaHouseHoldDataOnDataGridView(mahgd);
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            showHouseHoldList();
            rtbTimKiem.Clear();
        }
        private void cbMaNV1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void cbMaNV2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maNV2 = cbMaNV2.SelectedItem != null ? cbMaNV2.Text : string.Empty;
                string maNV1 = cbMaNV1.Text;
                string maHGD=tbHoGiaDinh.Text;

                insertNewHouseHold(maHGD, maNV1, maNV2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }

        }
        private void dtHoGiaDinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtHoGiaDinh.SelectedRows.Count > 0)
            {
                DataGridViewRow selectionrow = dtHoGiaDinh.SelectedRows[0];

                string mahogd = selectionrow.Cells["MaHoGD"].Value.ToString();
                string maNV1 = selectionrow.Cells["MaNV1"].Value.ToString();
                string maNV2 = selectionrow.Cells["MaNV2"].Value.ToString();
                tbHoGiaDinh.Text = mahogd;
                cbMaNV1.Text = maNV1;
                cbMaNV2.Text = maNV2;
            }
        }
        #endregion
        //-------------------------------------------------------------Function------------------------------------------------------------------------
        #region Function
        private void showHouseHoldList()
        {
          List<HoGD> list =KTXBL.Instance.showHouseholdlist();
          dtHoGiaDinh.DataSource = list;
          
        }
        private void DisplaHouseHoldDataOnDataGridView(string maHGD)
        {
            // Thực hiện truy vấn trong CSDL để lấy thông tin của nhân viên
            DataTable householdData = KTXBL.Instance.getHouseHoldList(maHGD);
            // Kiểm tra xem có dữ liệu hay không
            if (householdData.Rows.Count > 0)
            {
                // Cập nhật dữ liệu lên DataGridView
               dtHoGiaDinh.DataSource = householdData;
            }
            else
            {
                MessageBox.Show("Không có thông tin cho hộ gia đình có mã: " + maHGD);
                showHouseHoldList();
                rtbTimKiem.Clear();
            }
        }

        private void loadComBobBoxNV1()
        {
           
            DataTable data = KTXBL.Instance.getEmployeeID1();
            cbMaNV1.DataSource = data;
            cbMaNV1.DisplayMember = "MANV";
          
        }
        private void loadComBobBoxNV2()
        {
            DataTable data = KTXBL.Instance.getEmployeeID2();

            if (data != null)
            {
                var allMaNV2 = data.AsEnumerable().Select(row => row.Field<string>("MANV")).ToList();

                var maNV2ChuaCoHoGD = allMaNV2.Where(maNV2 => !KTXBL.Instance.checkHouseHoldList(maNV2)).ToList();

                if (maNV2ChuaCoHoGD.Any())
                {
                    DataTable filteredData = data.Clone();

                    foreach (var maNV2 in maNV2ChuaCoHoGD)
                    {
                        DataRow[] rows = data.Select($"MANV = '{maNV2}'");
                        if (rows.Any())
                        {
                            filteredData.ImportRow(rows.First());
                        }
                    }

                    cbMaNV2.DataSource = filteredData;
                    cbMaNV2.DisplayMember = "MANV";
                }
                else
                {
                    MessageBox.Show("Tất cả mã nhân viên 2 đã có mã hộ gia đình.");
                }
            }

        }
        private void insertNewHouseHold(string maHGD,string maNV1,string maNV2)
        {
            if (!KTXBL.Instance.checkHouseHoldID(maHGD) && !KTXBL.Instance.checkEmployeeID(maNV1,maNV2))
            {
                if (KTXBL.Instance.canAddEmployeeinList(maNV1))
                {
                    MessageBox.Show("Thêm thành công");
                    KTXBL.Instance.insertHouHoldList(maHGD, maNV1, maNV2);
                    showHouseHoldList(); // Giả sử bạn có một hàm để hiển thị danh sách hộ gia đình
                    cbMaNV2.Items.Remove(maNV2);
                }
            } 
            else
            {
                MessageBox.Show("Lỗi! Mã hộ gia đình đã tồn tại hoặc mã nhân viên đã có trong hộ gia đình.");
            }
        }
        private void insertEmployeeinHouseHold(string maHGD, string maNV1, string maNV2)
        {
            if (!KTXBL.Instance.checkHouseHoldID(maHGD) && !KTXBL.Instance.checkEmployeeID(maNV1, maNV2))
            {
                if (KTXBL.Instance.canAddEmployeeinList(maNV1))
                {
                    MessageBox.Show("Thêm thành công");
                    KTXBL.Instance.insertHouHoldList(maHGD, maNV1, maNV2);
                    showHouseHoldList(); // Giả sử bạn có một hàm để hiển thị danh sách hộ gia đình
                    cbMaNV2.Items.Remove(maNV2);
                }
            }
            else
            {
                MessageBox.Show("Lỗi!");
            }
        }





        #endregion

      
    }
}
