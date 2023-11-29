using BusinessLogic;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface {
    public partial class formTienDien : Form {
        public formTienDien() {
            InitializeComponent();
        }
        #region Even
        private void formTienDien_Load(object sender, EventArgs e) {
            showDienList();
            loadHouseHoldID();
        }
        private void dtpkThang_ValueChanged(object sender, EventArgs e)
        {
           

        }
        private void dtDien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtDien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectionrow = dtDien.SelectedRows[0];
                string mad= selectionrow.Cells["MaDien"].Value.ToString();
                string mahogd = selectionrow.Cells["MaHGD"].Value.ToString();
                DateTime thang =(DateTime)selectionrow.Cells["Thang"].Value;
                int hesothangtruoc = (int)selectionrow.Cells["HeSoDienThangTruoc"].Value;
                int hesohientai = (int)selectionrow.Cells["HeSoDienHienTai"].Value;
                string donvi = selectionrow.Cells["donvi"].Value.ToString();
                tbMaDien.Text = mad;
                cbHGD.Text = mahogd;
                dtpkThang.Value= thang;
                numThangTruoc.Value = hesothangtruoc;
                numThangSau.Value = hesohientai;
                tbDonVi.Text = donvi;

            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtDien.SelectedRows.Count > 0)
            {
                string mad = tbMaDien.Text;
                DienBL.Instance.deleteDienBL(mad);
                showDienList();
                loadHouseHoldID();
               
             } else
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu");
                }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string mad =tbMaDien.Text;
            string mahogd = cbHGD.Text;
            DateTime thang = (DateTime)dtpkThang.Value;
            int hesothangtruoc = (int)numThangTruoc.Value;
            int hesohientai = (int)numThangSau.Value;
            string donvi = tbDonVi.Text;
            if (!DienBL.Instance.CheckMaDienExistsBL(tbMaDien.Text))
            {
                if (DienBL.Instance.insertDienBL(mad, mahogd, thang, hesothangtruoc, hesohientai, donvi))
                {
                    MessageBox.Show("Thêm '" + mad + "' thành công");
                    showDienList();
                    loadHouseHoldID();
                } else
                {
                    MessageBox.Show("Không thành công");
                }
            } else
            {
                MessageBox.Show("Mã điện đã tồn tại");
            }
        }
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            string mad = tbMaDien.Text;
            DateTime thang = (DateTime)dtpkThang.Value;
            int hesothangtruoc = (int)numThangTruoc.Value;
            int hesohientai = (int)numThangSau.Value;
            string donvi = tbDonVi.Text;
            if (dtDien.SelectedRows.Count > 0)
            {
                if (DienBL.Instance.updateDienBL(mad, thang, hesothangtruoc, hesohientai, donvi))
                {
                    MessageBox.Show("Cập nhật thành công");
                    showDienList();
                    loadHouseHoldID();
                } else
                {
                    MessageBox.Show("Cập nhật không thành công");
                }
            } else
            {
                MessageBox.Show("Vui lòng thực hiện lại");
            }
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            tbMaDien.Text = string.Empty;
            cbHGD.Text=string.Empty;
            numThangTruoc.Value = 0;
            numThangSau.Value = 0;
            showDienList();
            loadHouseHoldID();
        }
        #endregion
        //----------------------------------------------------------------------Function--------------------------------------------------------
        #region Function
        private void showDienList()
        {
            List<Dien> list = DienBL.Instance.loadDienBL();
            dtDien.DataSource = list;
        }
        private void loadHouseHoldID()
        {
            DataTable data = DienBL.Instance.showHouseHoldID();
               cbHGD.DataSource = data;
               cbHGD.DisplayMember = "MAHGD";
        }


        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
