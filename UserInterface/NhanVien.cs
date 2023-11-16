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

namespace UserInterface
{
    public partial class NhanVien : Form
    {
        SqlConnection sqlConnection = new SqlConnection(Database.CONNECTION_STRING);
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            sqlConnection.Open();

            sqlCommand = new SqlCommand("SELECT * FROM NHANVIEN", sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while(sqlDataReader.Read())
            {
                var item = listViewDataNV.Items.Add(sqlDataReader[0].ToString());
                item.SubItems.Add(sqlDataReader[1].ToString());
                item.SubItems.Add(sqlDataReader[2].ToString());
                var date = DateTime.Parse(sqlDataReader[3].ToString());
                item.SubItems.Add(date.ToString("dd/MM/yyyy"));
                item.SubItems.Add(sqlDataReader[4].ToString());
                item.SubItems.Add(sqlDataReader[5].ToString());
                item.SubItems.Add(sqlDataReader[6].ToString());
                item.SubItems.Add(sqlDataReader[7].ToString());
                item.SubItems.Add(sqlDataReader[8].ToString());
                item.SubItems.Add(sqlDataReader[9].ToString());
                item.SubItems.Add(sqlDataReader[10].ToString());
                item.SubItems.Add(sqlDataReader[11].ToString());  
            }

            sqlConnection.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
