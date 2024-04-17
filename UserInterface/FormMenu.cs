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
    public partial class FormMenu : Form {
        public FormMenu() {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e) {

        }

        private void btnExit_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e) {
            panelSide.Height = btnNhanVien.Height;
            panelSide.Top = btnNhanVien.Top;

            panelChinh.Controls.Clear();
            FormStaff formStaff = new FormStaff();
            formStaff.TopLevel = false;
            formStaff.Dock = DockStyle.Fill;
            formStaff.FormBorderStyle = FormBorderStyle.None;
            panelChinh.Controls.Add(formStaff);
            formStaff.Show();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnNhanVien.Height;
            panelSide.Top = btnNhanVien.Top;
            panelChinh.Controls.Clear();
            formChamCong formchamcong = new formChamCong();
            formchamcong.TopLevel = false;
            formchamcong.TopLevel=false;
            formchamcong.Dock = DockStyle.Fill;
            formchamcong.FormBorderStyle = FormBorderStyle.None;
            panelChinh.Controls.Add(formchamcong);
            formchamcong.Show();
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnLuong.Height;
            panelSide.Top = btnLuong.Top;
            panelChinh.Controls.Clear();
           formTinhLuong formtinhluong= new formTinhLuong();
            formtinhluong.TopLevel = false;
            formtinhluong.TopLevel = false;
            formtinhluong.Dock = DockStyle.Fill;
            formtinhluong.FormBorderStyle = FormBorderStyle.None;
            panelChinh.Controls.Add(formtinhluong);
            formtinhluong.Show();
        }

        private void btnDormitory_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnDormitory.Height;
            panelSide.Top = btnDormitory.Top;
            panelChinh.Controls.Clear();
            formKTX formktx = new formKTX();
            formktx.TopLevel = false;
            formktx.TopLevel = false;
            formktx.Dock = DockStyle.Fill;
            formktx.FormBorderStyle = FormBorderStyle.None;
            panelChinh.Controls.Add(formktx);
            formktx.Show();
        }
    }
}
