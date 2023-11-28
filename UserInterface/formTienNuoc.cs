using BusinessLogic;
using DataAccess;
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
    public partial class formTienNuoc : Form {
        #region Even
        public formTienNuoc() {
            InitializeComponent();
        }

        private void formTienNuoc_Load(object sender, EventArgs e)
        {
            loadTienNuoc();
            loadHouseHoldID();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            tbMaN.Text=string.Empty;
            cbMaho.Text=string.Empty;
            numThangtruoc.Value = 0;
            numThangSau.Value = 0;
            tbDonVi.Text=string.Empty;
            loadTienNuoc();
            loadHouseHoldID();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string man = tbMaN.Text;
            string mahogd = cbMaho.Text;
            DateTime thang = (DateTime)dtpkThang.Value;
            int hesothangtruoc = (int)numThangtruoc.Value;
            int hesohientai = (int)numThangSau.Value;
            string donvi = tbDonVi.Text;
            if (!NuocBL.Instance.checkMaNuocExist(tbMaN.Text))
            {
                if (NuocBL.Instance.insertNuocBL(man, mahogd, thang, hesothangtruoc, hesohientai, donvi))
                {
                    MessageBox.Show("Thêm '" + man + "' thành công");
                    loadTienNuoc();
                    loadHouseHoldID();
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
            else
            {
                MessageBox.Show("Mã nước đã tồn tại");
            }
        }
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            string man = tbMaN.Text;
            string mahogd = cbMaho.Text;
            DateTime thang = (DateTime)dtpkThang.Value;
            int hesothangtruoc = (int)numThangtruoc.Value;
            int hesohientai = (int)numThangSau.Value;
            string donvi = tbDonVi.Text;

            if (dtNuoc.SelectedRows.Count > 0)
            {
                if (NuocBL.Instance.updateNuocBL(man, thang, hesothangtruoc, hesohientai, donvi))
                {
                    MessageBox.Show("Cập nhật thành công");
                    loadTienNuoc();
                    loadHouseHoldID();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng thực hiện lại");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
           
            if (dtNuoc.SelectedRows.Count > 0)
            {
                string manuoc = tbMaN.Text.Trim();
                    NuocBL.Instance.deleteNuocBL(manuoc);
                    loadTienNuoc() ;
                    loadHouseHoldID();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu");
            }
        }
        private void dtpkThang_ValueChanged(object sender, EventArgs e)
        {
           
            
        }
        private void dtNuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtNuoc.SelectedRows.Count > 0)
            {
                DataGridViewRow selectionrow = dtNuoc.SelectedRows[0];
                string man = selectionrow.Cells["MaNUOC"].Value.ToString();
                string mahogd = selectionrow.Cells["MaHGD"].Value.ToString();
                DateTime thang = (DateTime)selectionrow.Cells["Thang"].Value;
                int hesothangtruoc = (int)selectionrow.Cells["HESONUOCTHANGTRUOC"].Value;
                int hesohientai = (int)selectionrow.Cells["HESONUOCHIENTAI"].Value;
                string donvi = selectionrow.Cells["DVN"].Value.ToString();
                tbMaN.Text=man;
                cbMaho.Text=mahogd;
                dtpkThang.Value=thang;
                numThangtruoc.Value=hesothangtruoc;
                numThangSau.Value=hesohientai;
                tbDonVi.Text=donvi;


            }
        }
        #endregion
        //------------------------------------------------------------------------------------Function-----------------------------------------------
        private void loadTienNuoc()
        {
            List<Nuoc> list = NuocBL.Instance.loadNuocBL();
            dtNuoc.DataSource = list;

        }
        private void loadHouseHoldID()
        {
            DataTable data = NuocBL.Instance.showHouseHold();
            cbMaho.DataSource = data;
            cbMaho.DisplayMember = "MAHGD";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
