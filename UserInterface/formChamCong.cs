using BusinessLogic;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UserInterface
{
    public partial class formChamCong : Form
    {
        private ChamCongBL businessLogic;
        private ChamCong chamcong;
        
       
        #region Event
        public formChamCong()
        {
            InitializeComponent();
            this.businessLogic = new ChamCongBL();
            
        }
        
        private void fromChamCong_Load(object sender, EventArgs e)
        {
            loadAttendanceList();
            loadComBoBoxMaNV();
           

        }
        private void dataChamCong_SelectionChanged(object sender, EventArgs e)
        {
           if(dataChamCong.SelectedRows.Count > 0)
            {

               DataGridViewRow selectionrow = dataChamCong.SelectedRows[0];
               
               string manv = selectionrow.Cells["MANV"].Value.ToString();
               DateTime thang =(DateTime) selectionrow.Cells["THANG"].Value;
               byte songaydilam =(byte) selectionrow.Cells["SONGAYTRONGTHANG"].Value;
               byte songaynghiBHXH = (byte)selectionrow.Cells["SONGAYNGHIBHXH"].Value;
               byte songaynghikhonglydo = (byte)selectionrow.Cells["SONGAYNGHIKHONGLYDO"].Value;
               cboManv.Text = manv;
               dtpNgayLV.Value = thang;
               numDiLam.Value = songaydilam;
               numngaynghi.Value = songaynghikhonglydo;
               numngaynghiBHXH.Value= songaynghiBHXH;
                
            }
            
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
          
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaCC = tbMaCC.Text.ToString();
            string MaNV = cboManv.Text.ToString();
            DateTime Thang = (DateTime)dtpNgayLV.Value;
            Byte Songaydilam = Convert.ToByte(numDiLam.Value);
            Byte SongaynghiBHXH = Convert.ToByte(numngaynghiBHXH.Value);
            Byte Songaynghilam = Convert.ToByte(numngaynghi.Value);
            DatabaseHelper dbHelper = new DatabaseHelper();
            bool result = dbHelper.CheckMACCAndMANVExists(MaNV,MaCC);

            if (result)
            {
                MessageBox.Show("MACC đã tồn tại.");
                
            }
            else
            {
                if (MaCC == string.Empty)
                {
                    MessageBox.Show("Nhập mã chấm công");
                }
                else
                {
                    ChamCongDA.Instance.insertAttendance(MaCC, MaNV, Thang, Songaydilam, SongaynghiBHXH, Songaynghilam);
                    loadAttendanceList();
                }

            }
           

        }
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            string MaNV = cboManv.Text.ToString();
            DateTime Thang=(DateTime)dtpNgayLV.Value;
            Byte Songaydilam=Convert.ToByte(numDiLam.Value);
            Byte SongaynghiBHXH = Convert.ToByte(numngaynghiBHXH.Value);
            Byte Songaynghilam = Convert.ToByte(numngaynghi.Value);
            if (ChamCongDA.Instance.updateAttendace(MaNV, Thang, Songaydilam, SongaynghiBHXH, Songaynghilam))
            {
                MessageBox.Show("Cập nhật thành công!");
                loadAttendanceList();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công!");
            }
          
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string manv = cboManv.Text.ToString();
            ChamCongDA.Instance.deleteAttendance(manv);
            loadAttendanceList();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        #endregion
        //-------------------------------------------------------------Function------------------------------------------------
        #region Function
        private void loadAttendanceList()
        {
            List<ChamCong> chamcong = businessLogic.getAttendanceList();
            dataChamCong.DataSource = chamcong;
        }
        private void loadComBoBoxMaNV()
        {
            DataTable data=businessLogic.getEmployeeID();
            cboManv.DataSource = data;
            cboManv.DisplayMember= "MANV";
        }





        #endregion

       
    }
}
