using BusinessLogic;
using DTO;
using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface {
    public partial class formTienNha : Form {
        #region Even
        public formTienNha() {
            InitializeComponent();
        }

        private void dtTienNha_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtTienNha.SelectedRows.Count > 0)
            {
                DataGridViewRow selectionrow = dtTienNha.SelectedRows[0];
                string mantt = selectionrow.Cells["MANTT"].Value.ToString();
                string mahgd = selectionrow.Cells["MaHGD"].Value.ToString();
                DateTime thang = (DateTime)selectionrow.Cells["Thang"].Value;
                int tiennha = (int)selectionrow.Cells["TienNhaCoDinh"].Value;
                int hesodien = (int)selectionrow.Cells["HeSoDien"].Value;
                int hesonuoc = (int)selectionrow.Cells["HeSoNuoc"].Value;
                int tienantt = (int)selectionrow.Cells["PhiVSANTT"].Value;
                tbMNTT.Text = mantt;
                cbHGD.Text= mahgd;
                dtpkThang.Value= thang;
                tbTienNha.Text = tiennha.ToString("#,##0") + "VND";
                numDien.Value = hesodien;
                numNuoc.Value=hesonuoc;
                tbPTT.Text=tienantt.ToString("#,##0") + "VND";
            }
        }

        private void formTienNha_Load(object sender, EventArgs e)
        {
            loadTienNhaList();
            loadHOGD();
        }
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            string mantt = tbMNTT.Text;
            bool success =TienNhaBL.Instance.calculateTienNha(mantt );
            if (dtTienNha.SelectedRows.Count > 0)
            {
                if (success)
                {
                    // Hiển thị giá trị TONGTIEN lên TextBox 
                    rtbTinhTien.Text =TienNhaBL.Instance.getTongTien(mantt).ToString("#,##0")+" VND";
                    loadTienNhaList();
                }
                else
                {
                    // Xử lý lỗi nếu cần
                    MessageBox.Show("Có lỗi xảy ra khi tính tiền nhà.");
                }
               
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã nhà");
            }
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            tbMNTT.Text = string.Empty;
            cbHGD.Text=string.Empty;
            tbTienNha.Text = string.Empty;
            numDien.Value = 0;
            numNuoc.Value = 0;
            tbPTT.Text = string.Empty;
        }
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            string mantt = tbMNTT.Text;
            DateTime thang = dtpkThang.Value;

            // Kiểm tra và chuyển đổi giá trị tiền nhà
            int tiennha;
            if (int.TryParse(Regex.Replace(tbTienNha.Text, @"[^\d]", ""), out tiennha))
            {
                // Kiểm tra và chuyển đổi giá trị tiền an ninh trật tự
                int tienantt;
                if (int.TryParse(Regex.Replace(tbPTT.Text, @"[^\d]", ""), out tienantt))
                {
                    // Kiểm tra xem có dòng nào được chọn không
                    if (dtTienNha.SelectedRows.Count > 0)
                    {
                        bool result = TienNhaBL.Instance.updateTienNha(mantt, thang, tiennha, tienantt);

                        if (result)
                        {
                            MessageBox.Show("Cập nhật thành công");
                            loadTienNhaList();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật không thành công");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn mã nhà");
                    }
                }
                else
                {
                    MessageBox.Show("Giá trị Tiền An Ninh Trật Tự không hợp lệ");
                }
            }
            else
            {
                MessageBox.Show("Giá trị Tiền Nhà không hợp lệ");
            }
        }
      

        #endregion
        //-------------------------------------------------------------------------Function-----------------------------------------------------------------
        #region Function
        public void loadTienNhaList()
        {
            List<TienNha> ltn = TienNhaBL.Instance.loadTienNhaBL();
            dtTienNha.DataSource= ltn;
        }
        public void loadHOGD()
        {
            DataTable data=TienNhaBL.Instance.getMaHGD();
            cbHGD.DataSource= data;
            cbHGD.DisplayMember = "MAHGD";
        }






        #endregion

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
