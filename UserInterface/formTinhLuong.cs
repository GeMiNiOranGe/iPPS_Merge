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
        }
        private void dtgvLuongNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        //--------------------------------------Function--------------------------------------------------------------------------
        #region Function
        private void loadSalaryList()
        {
            List<Luong> tinhluong = LuongBL.Instance.showSalaryList();
            dtgvLuongNV.DataSource = tinhluong;
        }

        #endregion


    }
}
