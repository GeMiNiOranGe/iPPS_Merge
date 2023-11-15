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
using Config;

namespace UserInterface
{
    public partial class AddNhanVien : Form
    {
        SqlConnection sqlConnection = new SqlConnection(Database.CONNECTION_STRING);
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;

        private HashSet<string> uniqueValues = new HashSet<string>(); // kiểm tra trùng lặp trong listbox
        public AddNhanVien()
        {
            InitializeComponent();
        }

        private void AddNhanVien_Load(object sender, EventArgs e)
        {
            loadCombobox();
        }

        public void loadCombobox()
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT * FROM PHONGBAN", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cbPhongBan.Items.Add(sqlDataReader["TENPB"]);
            }
            sqlConnection.Close();

            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT * FROM CHUCVU", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cbChucVu.Items.Add(sqlDataReader["TENCV"]);
            }
            sqlConnection.Close();

            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT * FROM NGACHLUONG", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cbNgachLuong.Items.Add(sqlDataReader["TENNL"]);
            }
            sqlConnection.Close();

            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT * FROM CHUYENMON", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cbChuyenMon.Items.Add(sqlDataReader["TENCM"]);
            }
            sqlConnection.Close();

            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT * FROM NGOAINGU", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cbNgoaiNgu.Items.Add(sqlDataReader["TENNN"]);
            }
            sqlConnection.Close();
        }

        private void cbPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT * FROM PHONGBAN WHERE TENPB = @TENPB", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@TENPB", cbPhongBan.Text);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                txtMaPB.Text = sqlDataReader["MAPB"].ToString();
            }
            sqlConnection.Close();
        }

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT * FROM CHUCVU WHERE TENCV = @TENCV", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@TENCV", cbChucVu.Text);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                txtMaCV.Text = sqlDataReader["MACV"].ToString();
            }
            sqlConnection.Close();
        }

        private void cbNgachLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT * FROM NGACHLUONG WHERE TENNL = @TENNL", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@TENNL", cbNgachLuong.Text);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                txtMaNL.Text = sqlDataReader["MANL"].ToString();
            }
            sqlConnection.Close();

            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM BACLUONG where MANL='" + txtMaNL.Text + "'", sqlConnection);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            cbBacLuong.DisplayMember = "TENBL";
            cbBacLuong.ValueMember = "MABL";
            cbBacLuong.DataSource = dataTable;
            txtMaBL.DataBindings.Clear();
            txtMaBL.DataBindings.Add("Text", cbBacLuong.DataSource, "MABL");
            sqlConnection.Close();
        }

        private void cbChuyenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT * FROM CHUYENMON WHERE TENCM = @TENCM", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@TENCM", cbChuyenMon.Text);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                txtMaCM.Text = sqlDataReader["MACM"].ToString();
            }
            sqlConnection.Close();
        }

        private void cbNgoaiNgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT * FROM NGOAINGU WHERE TENNN = @TENNN", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@TENNN", cbNgoaiNgu.Text);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                txtMaNN.Text = sqlDataReader["MANN"].ToString();
            }
            sqlConnection.Close();
        }
        private void btnThemCM_Click(object sender, EventArgs e)
        {
            string newItem = cbChuyenMon.Text + " - " + txtMaCM.Text;
            if (!string.IsNullOrEmpty(cbChuyenMon.Text))
            {
                if (!uniqueValues.Contains(newItem))
                {
                    // Nếu không tồn tại, thêm vào HashSet và ListBox
                    uniqueValues.Add(newItem);
                    listBoxChuyenMon.Items.Add(newItem);
                }
            }
        }

        private void btnXoaCM_Click(object sender, EventArgs e)
        {
            if (listBoxChuyenMon.SelectedIndex != -1)
            {
                listBoxChuyenMon.Items.RemoveAt(listBoxChuyenMon.SelectedIndex);
            }
        }
    }
}
