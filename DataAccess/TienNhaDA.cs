using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TienNhaDA
    {
        private static TienNhaDA instance;
        public static TienNhaDA Instance
        {
            get => instance ?? (instance = new TienNhaDA());
        }
        public List<TienNha> loadTienNhaList()
        {
            List<TienNha> list = new List<TienNha>();
            string query = @"SELECT
                            TIENNHA.MANTT,
                            TIENNHA.MAHGD,
                            TIENNHA.THANG,
                            TIENNHA.TIENNHA,
                            DIEN.HESOHIENTAI AS HESODIENHIENTAI,
                            NUOC.HESOHIENTAI AS HESONUOCHIENTAI,
                            TIENNHA.TIENPHIVESINHANNINHTRATTU,
                            TIENNHA.TONGTIEN
                             FROM
                            TIENNHA
                            JOIN DIEN ON TIENNHA.MAD = DIEN.MAD
                            JOIN NUOC ON TIENNHA.MAN = NUOC.MAN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                string mantt = row["MANTT"].ToString();
                string mahgd = row["MAHGD"].ToString();
                DateTime thang =(DateTime) row["THANG"];
                int tiennha = (int)row["TIENNHA"];
                int hesodien = (int)row["HESODIENHIENTAI"];
                int hesonuoc = (int)row["HESONUOCHIENTAI"];
                int tienantt = (int)row["TIENPHIVESINHANNINHTRATTU"];
                int? tongtien = row["TONGTIEN"].ToString()==string.Empty?0: (int)row["TONGTIEN"];
                TienNha tn=new TienNha(mantt,mahgd, thang,tiennha,hesodien,hesonuoc,tienantt,tongtien);
                list.Add(tn);
            }
            return list;
        }
        public DataTable getMaHGD()
        {
            string query = "SELECT MAHGD FROM HOGIADINH hg WHERE NOT EXISTS (SELECT 1 FROM TIENNHA tn WHERE tn.MAHGD = hg.MAHGD)";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public bool calculateTienNha(string mantt)
        {
            string updateQuery = @"
                UPDATE TIENNHA
                SET TONGTIEN = (
                    TIENNHA.TIENNHA +
                    (DIEN.HESOHIENTAI - DIEN.HESOTHANGTRUOC) * 1 +
                    (NUOC.HESOHIENTAI - NUOC.HESOTHANGTRUOC) * 1 +
                    TIENNHA.TIENPHIVESINHANNINHTRATTU
                )
                FROM
                    TIENNHA
                    JOIN DIEN ON TIENNHA.MAD = DIEN.MAD
                    JOIN NUOC ON TIENNHA.MAN = NUOC.MAN
                WHERE MANTT='"+mantt+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(updateQuery);
            return result > 0;
        }
        public int GetTongTienByMANTT(string mantt)
        {
            // Thực hiện truy vấn SQL để lấy giá trị TONGTIEN
            string query = "SELECT TONGTIEN FROM TIENNHA WHERE MANTT = '"+mantt+"'";
            object result = DataProvider.Instance.ExecuteScalar(query);

            // Kiểm tra nếu kết quả là null hoặc không phải là số nguyên
            if (result == null || !int.TryParse(result.ToString(), out int tongTien))
            {
                return 0; 
            }

            return tongTien;
        }
        public bool updateTienNha(string mantt, DateTime thang,int tiennha,int tienantt)
        {
            try
            {
                string query = "update TIENNHA set THANG='" + thang + "',TIENNHA='" + tiennha + "',TIENPHIVESINHANNINHTRATTU='" + tienantt + "' where MANTT='" + mantt + "'";
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            catch (Exception ex)
            {
                return false;
            }   
        }
        
      
    }
}
