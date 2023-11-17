using Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UserInterface
{
    public partial class FormNhanVien : Form
    {
        SqlConnection sqlConnection = new SqlConnection(Database.CONNECTION_STRING);
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            int i = 0;

            sqlConnection.Open();

            sqlCommand = new SqlCommand("SELECT * FROM NHANVIEN", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while(sqlDataReader.Read())
            {
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
        private void listViewDataNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDataNV.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewDataNV.SelectedItems[0];
                lbMaNV.Text = item.SubItems[1].Text;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            listViewDataNV.Items.Clear();
            sqlConnection.Open();
            if (radioSearchMa.Checked)
            {
                sqlCommand = new SqlCommand("SELECT * FROM NHANVIEN WHERE MANV LIKE '%" + txtSearch.Text + "%'", sqlConnection);
            }
            else if (radioSearchTen.Checked)
            {
                sqlCommand = new SqlCommand("SELECT * FROM NHANVIEN WHERE HOTENNV LIKE '%" + txtSearch.Text + "%'", sqlConnection);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mục tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            sqlDataReader = sqlCommand.ExecuteReader();
            int i = 0;
            while (sqlDataReader.Read())
            {
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

            txtSearch.Text = null;
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            listViewDataNV.Items.Clear();
            loadData();
        }
        private void btnRead_Click(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormInsertNhanVien formInsertNhanVien = new FormInsertNhanVien();
            formInsertNhanVien.formNhanVien_TieuDe = "Thêm nhân viên";
            formInsertNhanVien.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbMaNV.Text == "null")
            {
                MessageBox.Show("Vui lòng chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FormInsertNhanVien formInsertNhanVien = new FormInsertNhanVien();
                formInsertNhanVien.formNhanVien_MaNV = lbMaNV.Text;
                formInsertNhanVien.formNhanVien_TieuDe = "Cập nhật nhân viên";
                formInsertNhanVien.Show();
                this.Hide();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lbMaNV.Text != "null")
            {
                if (MessageBox.Show("Bạn có chắc là muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("DELETE FROM NHANVIEN_CHUYENMON WHERE MANV = '" + lbMaNV.Text + "'", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("DELETE FROM NHANVIEN_NGOAINGU WHERE MANV = '" + lbMaNV.Text + "'", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("DELETE FROM NGUOITHAN WHERE MANV = '" + lbMaNV.Text + "'", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("DELETE FROM NHANVIEN WHERE MANV = '" + lbMaNV.Text + "'", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    MessageBox.Show("Bạn đã xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
