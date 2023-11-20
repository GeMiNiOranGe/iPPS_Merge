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
using iText.Layout.Splitting;
using iText;

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

            // Kiểm tra xem mã chấm công và mã nhân viên đã tồn tại hay chưa
            bool macAndManvExists = dbHelper.CheckMACCAndMANVExists(MaNV, MaCC);

            if (macAndManvExists)
            {
                MessageBox.Show("Mã chấm công hoặc Mã nhân viên đã tồn tại.");
            }
            else
            {
                if (string.IsNullOrEmpty(MaCC))
                {
                    MessageBox.Show("Nhập mã chấm công");
                }
                else
                {
                    // Kiểm tra xem mã chấm công đã tồn tại cho nhân viên hay chưa
                    bool maccExistsForNV = ChamCongDA.Instance.CheckMaccExist_01(MaCC, MaNV);

                    if (maccExistsForNV)
                    {
                        MessageBox.Show("Mã chấm công '" + MaCC + "' đã tồn tại cho nhân viên '" + MaNV + "'");
                    }
                    else
                    {
                        // Thêm mới chấm công
                        ChamCongDA.Instance.insertAttendance(MaCC, MaNV, Thang, Songaynghilam, SongaynghiBHXH, Songaynghilam);
                        MessageBox.Show("Thêm mới thành công!");
                        loadAttendanceList();
                    }
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
            if (ChamCongBL.Instance.updateAttendanceBL(MaNV,Thang,Songaydilam,SongaynghiBHXH,Songaynghilam))
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
        private void btnChamCong_Click_1(object sender, EventArgs e)
        {
            string MaNV = cboManv.Text.ToString();
            DateTime Thang = (DateTime)dtpNgayLV.Value;
            Byte Songaydilam = Convert.ToByte(numDiLam.Value);
            Byte SongaynghiBHXH = Convert.ToByte(numngaynghiBHXH.Value);
            Byte Songaynghilam = Convert.ToByte(numngaynghi.Value);

            int workStatusValue = workStatus(cbTinhTrang.Text);
            int numberDaysInMonth = numberDaysinMonth(Thang.Month, Thang.Year);

            if (workStatusValue == 0 && Songaydilam < numberDaysInMonth)
            {
                Songaydilam++;
            }
            else if (workStatusValue == 1 && SongaynghiBHXH < 30)
            {
                SongaynghiBHXH++;
            }
            else
            {
                // Kiểm tra số ngày nghỉ làm không được quá 3 ngày
                if (Songaynghilam < 3)
                {
                    Songaynghilam++;
                }
                else
                {
                    MessageBox.Show("Số ngày nghỉ làm không được quá 3 ngày.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Không thực hiện cập nhật nếu có lỗi
                }
            }

            if (Songaydilam > 26)
            {
                MessageBox.Show("Số ngày đi làm không được lớn hơn 26 ngày.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Không thực hiện cập nhật nếu có lỗi
            }

            ChamCongBL.Instance.updateAttendanceBL(MaNV, Thang, Songaydilam, SongaynghiBHXH, Songaynghilam);
            loadAttendanceList();
        }
        private void dtpNgayLV_ValueChanged(object sender, EventArgs e)
        {
            string manv=cboManv.Text;
            DateTime thoigian=dtpNgayLV.Value;
            if (ChamCongDA.Instance.updateAttendanceForNewMonth(manv, thoigian))
            {
                loadAttendanceList();
            }
        }
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            DataTable dataTable = ChamCongDA.Instance.GetAllChamCongInfo();
            string filePath=ChamCongDA.Instance.ExportAlltoPdf(dataTable);
            MessageBox.Show($"File PDF đã được xuất tại:\n{filePath}", "Thông báo");
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
        private int workStatus(string status)
        {
            if(status=="Đi làm")
            {
                return 0;
            } else if(status=="Nghỉ có phép")
            {
                return 1;
            }
            else
            {
                return 2;
            }
            
        }
        private int numberDaysinMonth(int thang,int nam)
        {
            int ngay=0;
            switch(thang)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    ngay= 31;
                    break;
                case 4: case 6: case 9: case 11:
                    ngay=30;
                    break;
                case 2:
                    if (nam% 4 == 0 && (nam % 100 != 0 || nam % 400 == 0))
                    {
                        ngay=29;
                        break;
                    } else
                    {
                        ngay=28;
                        break;
                    }
            }
            return ngay;
        }
       










        #endregion


    }
}
