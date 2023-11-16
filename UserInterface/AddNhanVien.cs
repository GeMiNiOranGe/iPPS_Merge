﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Config;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            loadCheck();
            loadMaNhanVien();
            loadCombobox();
        }
        public void loadCheck()
        {
            if ((string.IsNullOrEmpty(cbPhongBan.Text)) || (string.IsNullOrEmpty(cbChucVu.Text)) || (string.IsNullOrEmpty(cbNgachLuong.Text)) || (string.IsNullOrEmpty(cbBacLuong.Text)))
            {
                lbCheck1.ForeColor = System.Drawing.Color.Red;
                lbCheck2.ForeColor = System.Drawing.Color.Red;
                lbCheck3.ForeColor = System.Drawing.Color.Red;
                lbCheck4.ForeColor = System.Drawing.Color.Red;
                lbCheck5.ForeColor = System.Drawing.Color.Red;
                lbCheck6.ForeColor = System.Drawing.Color.Red;
                lbCheck7.ForeColor = System.Drawing.Color.Red;
                lbCheck8.ForeColor = System.Drawing.Color.Red;
            }
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

            lbCheck1.ForeColor = System.Drawing.Color.Black;
            lbCheck2.ForeColor = System.Drawing.Color.Black;
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

            lbCheck3.ForeColor = System.Drawing.Color.Black;
            lbCheck4.ForeColor = System.Drawing.Color.Black;
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

            lbCheck5.ForeColor = System.Drawing.Color.Black;
            lbCheck6.ForeColor = System.Drawing.Color.Black;

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

            lbCheck7.ForeColor = System.Drawing.Color.Black;
            lbCheck8.ForeColor = System.Drawing.Color.Black;
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
        private void btnThemCM_Click(object sender, EventArgs e)
        {
            string[] newColumns = new string[] { txtMaCM.Text, cbChuyenMon.Text };

            foreach (ListViewItem item in listViewChuyenMon.Items)
            {
                bool flag = true;
                for (int i = 0; i < listViewChuyenMon.Columns.Count; i++)
                {
                    if (item.SubItems[i].Text != newColumns[i])
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    MessageBox.Show("Dữ liệu bị trùng");
                    return;
                }
            }

            ListViewItem newItem = new ListViewItem(newColumns);
            listViewChuyenMon.Items.Add(newItem);
        }
        private void btnXoaCM_Click(object sender, EventArgs e)
        {
            listViewChuyenMon.Items.Remove(listViewChuyenMon.SelectedItems[0]);
        }
        private void saveChuyenMon()
        {
            string insertQuery = "INSERT INTO NHANVIEN_CHUYENMON (MANV, MACM) VALUES (@MANV, @MACM)";

            sqlConnection.Open();

            foreach (ListViewItem item in listViewChuyenMon.Items)
            {
                SqlCommand command = new SqlCommand(insertQuery, sqlConnection);
                command.Parameters.AddWithValue("@MANV", txtMaNV.Text);
                command.Parameters.AddWithValue("@MACM", item.SubItems[0].Text);
                command.ExecuteNonQuery();
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
        private void btnThemNN_Click(object sender, EventArgs e)
        {
            string[] newColumns = new string[] { txtMaNN.Text, cbNgoaiNgu.Text };

            foreach (ListViewItem item in listViewNgoaiNgu.Items)
            {
                bool flag = true;
                for (int i = 0; i < listViewNgoaiNgu.Columns.Count; i++)
                {
                    if (item.SubItems[i].Text != newColumns[i])
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    MessageBox.Show("Dữ liệu bị trùng");
                    return;
                }
            }

            ListViewItem newItem = new ListViewItem(newColumns);
            listViewNgoaiNgu.Items.Add(newItem);
        }
        private void btnXoaNN_Click(object sender, EventArgs e)
        {
            listViewNgoaiNgu.Items.Remove(listViewNgoaiNgu.SelectedItems[0]);
        }
        private void saveNgoaiNgu()
        {
            string insertQuery = "INSERT INTO NHANVIEN_NGOAINGU (MANV, MANN) VALUES (@MANV, @MANN)";

            sqlConnection.Open();

            foreach (ListViewItem item in listViewNgoaiNgu.Items)
            {
                SqlCommand command = new SqlCommand(insertQuery, sqlConnection);
                command.Parameters.AddWithValue("@MANV", txtMaNV.Text);
                command.Parameters.AddWithValue("@MANN", item.SubItems[0].Text);
                command.ExecuteNonQuery();
            }

            sqlConnection.Close();
        }
        public void loadMaNhanVien()
        {
            string iID0000 = "NV0000";
            string iID000 = "NV000";
            string iID00 = "NV00";
            string iID0 = "NV0";
            string iID = "NV";

            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT TOP 1 * FROM NHANVIEN ORDER BY MaNV DESC ", sqlConnection);
            string strID = Convert.ToString(sqlCommand.ExecuteScalar());
            strID = strID.Substring(2, 5);
            strID = strID.TrimStart('0');
            int iIDNV = Convert.ToInt32(strID);
            sqlConnection.Close();
            iIDNV++;
            if (iIDNV < 10)
            {
                txtMaNV.Text = iID0000 + iIDNV.ToString();
            }
            else if (iIDNV < 100)
            {
                txtMaNV.Text = iID000 + iIDNV.ToString();
            }
            else if (iIDNV < 1000)
            {
                txtMaNV.Text = iID00 + iIDNV.ToString();
            }
            else if (iIDNV < 10000)
            {
                txtMaNV.Text = iID0 + iIDNV.ToString();
            }
            else
            {
                txtMaNV.Text = iID + iIDNV.ToString();
            }
        }
        public void insertNhanVien()
        {
            string insertQuery = "INSERT INTO NHANVIEN (MANV, HOTENNV, GIOITINH, NGAYSINH, NOISINH, QUEQUAN, TRINHDOVANHOA, DANTOC, TONGIAO, DOANVIEN, DANGVIEN, CONGDOANVIEN, MAPB, MACV, MANL, MABL) " +
                                 "VALUES (@MANV, @HOTENNV, @GIOITINH, @NGAYSINH, @NOISINH, @QUEQUAN, @TRINHDOVANHOA, @DANTOC, @TONGIAO, @DOANVIEN, @DANGVIEN, @CONGDOANVIEN, @MAPB, @MACV, @MANL, @MABL)";

            sqlConnection.Open();

            SqlCommand command = new SqlCommand(insertQuery, sqlConnection);
            command.Parameters.AddWithValue("@MANV", txtMaNV.Text);
            command.Parameters.AddWithValue("@HOTENNV", txtHoTenNV.Text);
            if(radioNam.Checked)
            {
                command.Parameters.AddWithValue("@GIOITINH", "1");
            }
            else
            {
                command.Parameters.AddWithValue("@GIOITINH", "0");
            }
            dateNgaySinhNV.Format = DateTimePickerFormat.Custom;
            dateNgaySinhNV.CustomFormat = "yyyyMMdd";
            command.Parameters.AddWithValue("@NGAYSINH", dateNgaySinhNV.Text);
            command.Parameters.AddWithValue("@NOISINH", txtNoiSinh.Text);
            command.Parameters.AddWithValue("@QUEQUAN", txtQueQuan.Text);
            command.Parameters.AddWithValue("@TRINHDOVANHOA", cbTDVH.Text);
            command.Parameters.AddWithValue("@DANTOC", cbDanToc.Text);
            command.Parameters.AddWithValue("@TONGIAO", cbTonGiao.Text);
            if(checkDoanVien.Checked)
            {
                command.Parameters.AddWithValue("@DOANVIEN", "1");
            }
            else
            {
                command.Parameters.AddWithValue("@DOANVIEN", "0");
            }
            if (checkDangVien.Checked)
            {
                command.Parameters.AddWithValue("@DANGVIEN", "1");
            }
            else
            {
                command.Parameters.AddWithValue("@DANGVIEN", "0");
            }
            if (checkCongDoanVien.Checked)
            {
                command.Parameters.AddWithValue("@CONGDOANVIEN", "1");
            }
            else
            {
                command.Parameters.AddWithValue("@CONGDOANVIEN", "0");
            }
            command.Parameters.AddWithValue("@MAPB", txtMaPB.Text);
            command.Parameters.AddWithValue("@MACV", txtMaCV.Text);
            command.Parameters.AddWithValue("@MANL", txtMaNL.Text);
            command.Parameters.AddWithValue("@MABL", txtMaBL.Text);
            command.ExecuteNonQuery();
            
            sqlConnection.Close();
        }
        public string loadMaNguoiThan(string idNT)
        {
            string iID00 = "NT00";
            string iID0 = "NT0";
            string iID = "NT";

            sqlConnection.Open();
            sqlCommand = new SqlCommand("SELECT TOP 1 * FROM NGUOITHAN ORDER BY MaNT DESC ", sqlConnection);
            string strID = Convert.ToString(sqlCommand.ExecuteScalar());
            strID = strID.Substring(2, 3);
            strID = strID.TrimStart('0');
            int iIDNT = Convert.ToInt32(strID);
            sqlConnection.Close();
            iIDNT++;
            if (iIDNT < 10)
            {
                idNT = iID00 + iIDNT.ToString();
            }
            else if (iIDNT < 100)
            {
                idNT = iID0 + iIDNT.ToString();
            }
            else
            {
                idNT = iID + iIDNT.ToString();
            }
            return idNT;
        }
        public void insertNguoiThan()
        {
            if ((string.IsNullOrEmpty(txtHoTenCha.Text)) && (string.IsNullOrEmpty(txtNgheNghiepCha.Text)))
            {

            }
            else
            {
                string idNT = null;
                idNT = loadMaNguoiThan(idNT);

                string insertQuery = "INSERT INTO NGUOITHAN (MANT, LOAINT, HOTEN, NGAYSINH, NGHENGHIEP, MANV) " +
                                 "VALUES (@MANT, @LOAINT, @HOTEN, @NGAYSINH, @NGHENGHIEP, @MANV)";

                sqlConnection.Open();

                SqlCommand command = new SqlCommand(insertQuery, sqlConnection);
                command.Parameters.AddWithValue("@MANT", idNT);
                command.Parameters.AddWithValue("@LOAINT", "Cha");
                command.Parameters.AddWithValue("@HOTEN", txtHoTenCha.Text);
                dateNgaySinhCha.Format = DateTimePickerFormat.Custom;
                dateNgaySinhCha.CustomFormat = "yyyyMMdd";
                command.Parameters.AddWithValue("@NGAYSINH", dateNgaySinhCha.Text);
                command.Parameters.AddWithValue("@NGHENGHIEP", txtNgheNghiepCha.Text);
                command.Parameters.AddWithValue("@MANV", txtMaNV.Text);
                command.ExecuteNonQuery();

                sqlConnection.Close();
            }

            if ((string.IsNullOrEmpty(txtHoTenMe.Text)) && (string.IsNullOrEmpty(txtNgheNghiepMe.Text)))
            {
                
            }
            else
            {
                string idNT = null;
                idNT = loadMaNguoiThan(idNT);

                string insertQuery = "INSERT INTO NGUOITHAN (MANT, LOAINT, HOTEN, NGAYSINH, NGHENGHIEP, MANV) " +
                                 "VALUES (@MANT, @LOAINT, @HOTEN, @NGAYSINH, @NGHENGHIEP, @MANV)";

                sqlConnection.Open();

                SqlCommand command = new SqlCommand(insertQuery, sqlConnection);
                command.Parameters.AddWithValue("@MANT", idNT);
                command.Parameters.AddWithValue("@LOAINT", "Mẹ");
                command.Parameters.AddWithValue("@HOTEN", txtHoTenMe.Text);
                dateNgaySinhMe.Format = DateTimePickerFormat.Custom;
                dateNgaySinhMe.CustomFormat = "yyyyMMdd";
                command.Parameters.AddWithValue("@NGAYSINH", dateNgaySinhMe.Text);
                command.Parameters.AddWithValue("@NGHENGHIEP", txtNgheNghiepMe.Text);
                command.Parameters.AddWithValue("@MANV", txtMaNV.Text);
                command.ExecuteNonQuery();

                sqlConnection.Close();
            }

            if ((string.IsNullOrEmpty(txtHoTenVC.Text)) && (string.IsNullOrEmpty(txtNgheNghiepVC.Text)))
            {
                
            }
            else
            {
                string idNT = null;
                idNT = loadMaNguoiThan(idNT);

                string insertQuery = "INSERT INTO NGUOITHAN (MANT, LOAINT, HOTEN, NGAYSINH, NGHENGHIEP, MANV) " +
                                 "VALUES (@MANT, @LOAINT, @HOTEN, @NGAYSINH, @NGHENGHIEP, @MANV)";

                sqlConnection.Open();

                SqlCommand command = new SqlCommand(insertQuery, sqlConnection);
                command.Parameters.AddWithValue("@MANT", idNT);
                command.Parameters.AddWithValue("@LOAINT", "Vợ/Chồng");
                command.Parameters.AddWithValue("@HOTEN", txtHoTenVC.Text);
                dateNgaySinhVC.Format = DateTimePickerFormat.Custom;
                dateNgaySinhVC.CustomFormat = "yyyyMMdd";
                command.Parameters.AddWithValue("@NGAYSINH", dateNgaySinhVC.Text);
                command.Parameters.AddWithValue("@NGHENGHIEP", txtNgheNghiepVC.Text);
                command.Parameters.AddWithValue("@MANV", txtMaNV.Text);
                command.ExecuteNonQuery();

                sqlConnection.Close();
            }

            if ((string.IsNullOrEmpty(txtHoTenCon1.Text)) && (string.IsNullOrEmpty(txtNgheNghiepCon1.Text)))
            {
                
            }
            else
            {
                string idNT = null;
                idNT = loadMaNguoiThan(idNT);

                string insertQuery = "INSERT INTO NGUOITHAN (MANT, LOAINT, HOTEN, NGAYSINH, NGHENGHIEP, MANV) " +
                                 "VALUES (@MANT, @LOAINT, @HOTEN, @NGAYSINH, @NGHENGHIEP, @MANV)";

                sqlConnection.Open();

                SqlCommand command = new SqlCommand(insertQuery, sqlConnection);
                command.Parameters.AddWithValue("@MANT", idNT);
                command.Parameters.AddWithValue("@LOAINT", "Con");
                command.Parameters.AddWithValue("@HOTEN", txtHoTenCon1.Text);
                dateNgaySinhCon1.Format = DateTimePickerFormat.Custom;
                dateNgaySinhCon1.CustomFormat = "yyyyMMdd";
                command.Parameters.AddWithValue("@NGAYSINH", dateNgaySinhCon1.Text);
                command.Parameters.AddWithValue("@NGHENGHIEP", txtNgheNghiepCon1.Text);
                command.Parameters.AddWithValue("@MANV", txtMaNV.Text);
                command.ExecuteNonQuery();

                sqlConnection.Close();
            }

            if ((string.IsNullOrEmpty(txtHoTenCon2.Text)) && (string.IsNullOrEmpty(txtNgheNghiepCon2.Text)))
            {
                
            }
            else
            {
                string idNT = null;
                idNT = loadMaNguoiThan(idNT);

                string insertQuery = "INSERT INTO NGUOITHAN (MANT, LOAINT, HOTEN, NGAYSINH, NGHENGHIEP, MANV) " +
                                 "VALUES (@MANT, @LOAINT, @HOTEN, @NGAYSINH, @NGHENGHIEP, @MANV)";

                sqlConnection.Open();

                SqlCommand command = new SqlCommand(insertQuery, sqlConnection);
                command.Parameters.AddWithValue("@MANT", idNT);
                command.Parameters.AddWithValue("@LOAINT", "Con");
                command.Parameters.AddWithValue("@HOTEN", txtHoTenCon2.Text);
                dateNgaySinhCon2.Format = DateTimePickerFormat.Custom;
                dateNgaySinhCon2.CustomFormat = "yyyyMMdd";
                command.Parameters.AddWithValue("@NGAYSINH", dateNgaySinhCon2.Text);
                command.Parameters.AddWithValue("@NGHENGHIEP", txtNgheNghiepCon2.Text);
                command.Parameters.AddWithValue("@MANV", txtMaNV.Text);
                command.ExecuteNonQuery();

                sqlConnection.Close();
            }
        }
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(cbPhongBan.Text)) || (string.IsNullOrEmpty(txtMaPB.Text)) || (string.IsNullOrEmpty(cbChucVu.Text)) || (string.IsNullOrEmpty(txtMaCV.Text)) || (string.IsNullOrEmpty(cbNgachLuong.Text)) || (string.IsNullOrEmpty(txtMaNL.Text)) || (string.IsNullOrEmpty(cbBacLuong.Text)) || (string.IsNullOrEmpty(txtMaBL.Text)))
            {
                MessageBox.Show("Mời điền thông tin đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                insertNhanVien();
                insertNguoiThan();
                saveChuyenMon();
                saveNgoaiNgu();

                MessageBox.Show("Thêm Nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
