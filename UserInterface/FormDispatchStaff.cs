using Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface {
    public partial class FormDispatchStaff : Form {
        SqlConnection sqlConnection = new SqlConnection(Database.CONNECTION_STRING);
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;
        //SqlDataAdapter sqlDataAdapter;
        //DataTable dataTable;

        string maPB;
        public string MaPB {
            get { return maPB; }
        }

        public FormDispatchStaff() {
            InitializeComponent();
        }

        private void FormDispatchStaff_Load(object sender, EventArgs e) {
            loadIDDispatchStaff();
            loadCombobox();
        }

        public void loadIDDispatchStaff() {
            string iSQD = "/QD-PB";
            int i = 1;

            DateTime ngay = DateTime.Now;
            string customNgay = ngay.ToString("ddMMyyyy");

            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT TOP 1 * FROM PHONGTOCHUC ORDER BY SOQUYETDINH DESC ", sqlConnection);

            string strSQD = Convert.ToString(sqlCommand.ExecuteScalar());
            strSQD = strSQD.Substring(2, 8);

            string strSttSQD = Convert.ToString(sqlCommand.ExecuteScalar());
            strSttSQD = strSttSQD.Substring(0, 1);
            int iSttSQD = Convert.ToInt32(strSttSQD);
            sqlConnection.Close();
            DateTime ngaySQD;

            if (DateTime.TryParseExact(strSQD, "ddMMyyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySQD)) {
                if (ngaySQD.Date == ngay.Date) {
                    txtSoQuyetDinh.Text = (iSttSQD + 1) + "/" + customNgay + iSQD;
                    iSttSQD++;
                }
                else if (ngaySQD.Date < ngay.Date) {
                    txtSoQuyetDinh.Text = i + "/" + customNgay + iSQD;
                }
                else {
                    MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void loadCombobox() {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT * FROM PHONGBAN", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                cbPhongBanHT.Items.Add(sqlDataReader["TENPB"]);
                cbPhongBanTC.Items.Add(sqlDataReader["TENPB"]);
            }
            sqlConnection.Close();

            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT * FROM CHUCVU", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                cbChucVu.Items.Add(sqlDataReader["TENCV"]);
            }
            sqlConnection.Close();
        }

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e) {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT * FROM CHUCVU WHERE TENCV = @TENCV", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@TENCV", cbChucVu.Text);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                txtMaCV.Text = sqlDataReader["MACV"].ToString();
            }
            sqlConnection.Close();
        }

        private void cbPhongBanHT_SelectedIndexChanged(object sender, EventArgs e) {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT * FROM PHONGBAN WHERE TENPB = @TENPB", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@TENPB", cbPhongBanHT.Text);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                txtMaPBHT.Text = sqlDataReader["MAPB"].ToString();
            }
            sqlConnection.Close();
        }

        private void cbPhongBanTC_SelectedIndexChanged(object sender, EventArgs e) {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT * FROM PHONGBAN WHERE TENPB = @TENPB", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@TENPB", cbPhongBanTC.Text);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) {
                txtMaPBTC.Text = sqlDataReader["MAPB"].ToString();
            }
            sqlConnection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtMaPBTC.Text) || string.IsNullOrEmpty(txtMaPBHT.Text)) {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                string insertQuery = "INSERT INTO PHONGTOCHUC (SOQUYETDINH, TENNGUOIKY, CHUCVUNGUOIKY, PHONGBANHIENTAI, PHONGBANTHUYENCHUYEN) " +
                                     "VALUES (@SOQUYETDINH, @TENNGUOIKY, @CHUCVUNGUOIKY, @PHONGBANHIENTAI, @PHONGBANTHUYENCHUYEN)";

                sqlConnection.Open();

                sqlCommand = new SqlCommand(insertQuery, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@SOQUYETDINH", txtSoQuyetDinh.Text);
                sqlCommand.Parameters.AddWithValue("@TENNGUOIKY", txtNguoiKy.Text);
                sqlCommand.Parameters.AddWithValue("@CHUCVUNGUOIKY", txtMaCV.Text);
                sqlCommand.Parameters.AddWithValue("@PHONGBANHIENTAI", txtMaPBHT.Text);
                sqlCommand.Parameters.AddWithValue("@PHONGBANTHUYENCHUYEN", txtMaPBTC.Text);

                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();

                MessageBox.Show("Thuyên chuyển thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                maPB = txtMaPBTC.Text;
                this.Close();
            }
        }
    }
}
