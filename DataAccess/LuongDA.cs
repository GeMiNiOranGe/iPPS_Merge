using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class LuongDA
    {
        private static LuongDA instance;
        public static LuongDA Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LuongDA();
                }
                return instance;
            }
        }
        public List<Luong> showSalaryList()
        {
            List<Luong> salarylis = new List<Luong>();
            string query = "SELECT MAL, THOIDIEM, LUONGCOBAN, MANL, MABL, SONGAYTRONGTHANG, TIENNHA.TIENNHA, LUONG.MANV FROM LUONG JOIN BOPHANCHAMCONG ON LUONG.MACC = BOPHANCHAMCONG.MACC JOIN TIENNHA ON LUONG.MATN = TIENNHA.MANTT;";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in data.Rows)
            {
                string mal = dr["MAL"].ToString();
                DateTime thoidiem = (DateTime)dr["THOIDIEM"];
                int luongcb = (int)dr["LUONGCOBAN"];
                string manl = dr["MANL"].ToString();
                string mabl = dr["MABL"].ToString();
                byte? songaycong = dr["SONGAYTRONGTHANG"].ToString() == string.Empty ? null : (byte?)dr["SONGAYTRONGTHANG"];
                int tiennha = (int)dr["TIENNHA"];
                string manv = dr["MANV"].ToString();

                Luong tinhluong = new Luong(mal,thoidiem,luongcb,manl,mabl,songaycong,tiennha,manv);
                salarylis.Add( tinhluong );
            }
            return salarylis;
        }
    }
}
