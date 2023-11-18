using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DataAccess
{
    
    public class ChamCongDA
    {
        private static ChamCongDA instance;
        public static ChamCongDA Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChamCongDA();
                }
                return instance;
            }
        }

        public List<ChamCong> showAttendanceList()
        {
            List<ChamCong> dschamcong= new List<ChamCong>();
            string query = "select *from BOPHANCHAMCONG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in data.Rows) {
              string macc=dr["MACC"].ToString();
              DateTime thang=(DateTime)dr["THANG"];
              byte? songaytrongthang =dr["SONGAYTRONGTHANG"].ToString()==string.Empty?null :(byte?)dr["SONGAYTRONGTHANG"];
              byte? songaynghiBHXH =dr["SONGAYNGHIBHXH"].ToString()==string.Empty?null:(byte?) dr["SONGAYNGHIBHXH"];
              byte? songaynghikhonglydo =dr["SONGAYNGHIKHONGLYDO"].ToString()==string.Empty?null: (byte?)dr["SONGAYNGHIKHONGLYDO"];
              string manv = dr["MANV"].ToString();

              ChamCong chamcong = new ChamCong(macc,thang,songaytrongthang,songaynghiBHXH,songaynghikhonglydo,manv);
              dschamcong.Add(chamcong);
            }
            return dschamcong;
        }
        public DataTable getEmployeeID()
        {
            string query = "select MANV from NHANVIEN";
            DataTable data=DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

       public bool deleteAttendance(string manv)
        {

            try
            {
                
                // Gọi stored procedure từ DataProvider và kiểm tra kết quả
                return  DataProvider.Instance.ExecuteNonQuery("exec usp_XoaChamCong @MaNhanVienCanXoa", new object[] { manv })>0;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
        }
       public bool updateAttendace(string manv,DateTime thang,byte songaytrongthang,byte songaynghibhxh,byte  songaynghikhonglydo)
        {
            string query = "Update BOPHANCHAMCONG set THANG='" + thang + "', SONGAYTRONGTHANG='" + songaytrongthang + "', SONGAYNGHIBHXH='" + songaynghibhxh + "', SONGAYNGHIKHONGLYDO='" + songaynghikhonglydo + "' where MANV='" + manv + "'";
          
            try
            {
                return DataProvider.Instance.ExecuteNonQuery(query) > 0;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
        }
       public bool insertAttendance(string macc,string manv, DateTime thang, byte songaytrongthang, byte songaynghibhxh, byte songaynghikhonglydo)
        {

            try
            {
                string query = "insert into BOPHANCHAMCONG VALUES ('"+macc+"', '"+thang+"', '"+songaytrongthang+"', '"+songaynghibhxh+"', '"+songaynghikhonglydo+"', '"+manv+"')";

                return DataProvider.Instance.ExecuteNonQuery(query)>0;
              
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
               
            }
        }

        
    }

 }

