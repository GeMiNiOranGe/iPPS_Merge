using DTO;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess
{
    public class DienDA
    {
        private static DienDA instance;
        public static DienDA Instance
        {
            get => instance ?? (instance = new DienDA());
        }
        public List<Dien> loadDien()
        {
            List<Dien> dien = new List<Dien>();
            string query = "select * from DIEN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in data.Rows)
            {
                string mad = dr["MAD"].ToString();
                string mahogd = dr["MAHGD"].ToString();
                DateTime thang = (DateTime)dr["THANG"];
                int hesohangtruoc = (int)dr["HESOTHANGTRUOC"];
                int hesohientai = (int)dr["HESOHIENTAI"];
                string donvi = dr["DONVI"].ToString();
                Dien d = new Dien(mad,mahogd,thang,hesohangtruoc,hesohientai,donvi);
                dien.Add(d);
            }
            return dien;

        }
        public DataTable getHGD()
        {
            string query = "SELECT MAHGD FROM HOGIADINH hg WHERE NOT EXISTS (SELECT 1 FROM DIEN d WHERE d.MAHGD = hg.MAHGD)";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public bool deleteDien(string maD)
        {
            try
            {
                // Gọi stored procedure từ DataProvider và kiểm tra kết quả
                return DataProvider.Instance.ExecuteNonQuery("exec usp_XoaMaDien @MaDien", new object[] { maD }) > 0;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
        }
        public bool insertDien(string mad,string maho,DateTime thang,int hesothangtruoc,int hesoohientai,string donvi)
        {
            try
            {
                string query = "insert into DIEN values('"+mad+"','"+maho+"','"+thang+"','"+hesothangtruoc+"','"+hesoohientai+"','"+donvi+"')";
                int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
        }
        public bool CheckMaDienExists(string maD)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM DIEN WHERE MAD = '"+maD+"'";
                int count = (int)DataProvider.Instance.ExecuteScalar(query);

                // Nếu count > 0, tức là mã đã tồn tại
                return count > 0;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần thiết
                Console.WriteLine("Lỗi kiểm tra mã điện: " + ex.Message);
                return false;
            }
        }
        public bool updateDien(string maD,DateTime thang,int hesothangtruoc,int hesohientai,string donvi)
        {
            try
            {
                string query = "update DIEN set THANG='" + thang + "',HESOTHANGTRUOC='" + hesothangtruoc + "',HESOHIENTAI='" + hesohientai + "',DONVI='" + donvi + "' where MAD='"+maD+"'";
                int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query);
                return rowsAffected > 0;
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
