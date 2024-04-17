using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class NuocDA
    {
        private static NuocDA instance;
        public static NuocDA Instance
        {
            get => instance ?? (instance = new NuocDA());
        }
        public List<Nuoc> loadNuoc()
        {
            List<Nuoc> nuoc = new List<Nuoc>();
            string query = "select * from NUOC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in data.Rows)
            {
                string man = dr["MAN"].ToString();
                string mahogd = dr["MAHGD"].ToString();
                DateTime thang = (DateTime)dr["THANG"];
                int hesohangtruoc = (int)dr["HESOTHANGTRUOC"];
                int hesohientai = (int)dr["HESOHIENTAI"];
                string donvi = dr["DONVI"].ToString();
                Nuoc d = new Nuoc(man, mahogd, thang, hesohangtruoc, hesohientai, donvi);
                nuoc.Add(d);
            }
            return nuoc;

        }
        public DataTable getHGD()
        {
            string query = "SELECT MAHGD FROM HOGIADINH hg WHERE NOT EXISTS (SELECT 1 FROM NUOC n WHERE n.MAHGD = hg.MAHGD)";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public bool CheckMaNuocExists(string maN)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM NUOC WHERE MAN = '" + maN + "'";
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
        public bool insertNuoc(string man, string maho, DateTime thang, int hesothangtruoc, int hesoohientai, string donvi)
        {
            try
            {
                string query = "insert into NUOC values('" + man + "','" + maho + "','" + thang + "','" + hesothangtruoc + "','" + hesoohientai + "','" + donvi + "')";
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
        public bool updateNuoc(string maN, DateTime thang, int hesothangtruoc, int hesohientai, string donvi)
        {
            try
            {
                string query = "update NUOC set THANG='" + thang + "',HESOTHANGTRUOC='" + hesothangtruoc + "',HESOHIENTAI='" + hesohientai + "',DONVI='" + donvi + "' where MAN='" + maN + "'";
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
        public bool deleteNuoc(string man)
        {

            try
            {
                // Gọi stored procedure từ DataProvider và kiểm tra kết quả
                return DataProvider.Instance.ExecuteNonQuery("exec usp_XoaMaNuoc @MaNuoc", new object[] { man }) > 0;
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
