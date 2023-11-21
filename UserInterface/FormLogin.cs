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

namespace UserInterface {
    public partial class FormLogin : Form {
        SqlConnection sqlConnection = new SqlConnection(Database.CONNECTION_STRING);
        //SqlCommand sqlCommand;
        //SqlDataReader sqlDataReader;
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;

        bool isImageClose = true;
        public FormLogin() {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e) {
            if ((string.IsNullOrEmpty(txtTaiKhoan.Text)) || (string.IsNullOrEmpty(txtPassWord.Text))) {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter("SELECT * FROM TAIKHOAN WHERE USERNAME = '" + txtTaiKhoan.Text + "' AND PASSWORD = N'" + txtPassWord.Text + "'", sqlConnection);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0) {
                    //MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FormMenu formMenu = new FormMenu();
                    formMenu.Show();
                }
                else {
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sqlConnection.Close();
            }
        }

        private void picYey_Click(object sender, EventArgs e) {
            Image imageClose = Properties.Resources.eyeclose;
            Image imageOpen = Properties.Resources.eyeopen;

            if (isImageClose) {
                picYey.Image = imageOpen;
                isImageClose = false;
                txtPassWord.PasswordChar = '\0';
            }
            else {
                picYey.Image = imageClose;
                isImageClose = true;
                txtPassWord.PasswordChar = '●';
            }
        }

        private void btnExit_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) {
                Application.Exit();
            }
        }
    }
}
