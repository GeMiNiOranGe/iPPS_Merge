using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
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
        public List<Luong> loadSalaryList()
        {
            List<Luong> luongs = new List<Luong>();

            string query = @"SELECT
                            LUONG.MANV AS MaNhanVien,
                            LUONG.LUONGCOBAN AS LuongCoBan,
                            BACLUONG.HESOBL AS HeSoBacLuong,
                            CHUCVU.HESOPHUCAP AS HeSoPhuCapChucVu,
                            BOPHANCHAMCONG.SONGAYTRONGTHANG AS SoNgayDiLam,
                            BOPHANCHAMCONG.SONGAYNGHIBHXH AS SoNgayNghiBHXH,
                            BOPHANCHAMCONG.SONGAYNGHIKHONGLYDO AS SoNgayNghiKhongLyDo,
                            TIENNHA.TIENNHA AS TienNha,
                            LUONG.TIENLUONG AS TongLuong,
                            LUONG.THOIDIEM AS ThoiDiem
                        FROM
                            LUONG
                        JOIN
                            NGACHLUONG ON LUONG.MANL = NGACHLUONG.MANL
                        JOIN
                            BACLUONG ON LUONG.MABL = BACLUONG.MABL
                        JOIN
                            CHUCVU ON LUONG.MACV = CHUCVU.MACV
                        JOIN
                            BOPHANCHAMCONG ON LUONG.MACC = BOPHANCHAMCONG.MACC
                        JOIN
                            TIENNHA ON LUONG.MATN = TIENNHA.MANTT";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {

                string manv = row["MaNhanVien"].ToString();
                int luongcb = (int)(row["LuongCoBan"]);
                decimal HeSoBacLuong = (decimal)(row["HeSoBacLuong"]);
                decimal HeSoPhuCapChucVu = (decimal)(row["HeSoPhuCapChucVu"]);
                byte SoNgayDiLam = (byte)(row["SoNgayDiLam"]);
                byte SoNgayNghiBHXH = (byte)(row["SoNgayNghiBHXH"]);
                byte SoNgayNghiKhongLyDo = (byte)(row["SoNgayNghiKhongLyDo"]);
                int TienNha = (int)(row["TienNha"]);
                int? TongLuong = row["TongLuong"].ToString() == string.Empty ? 0 : (int)row["TongLuong"];
                DateTime ThoiDiem = (DateTime)(row["ThoiDiem"]);
                Luong luong = new Luong(manv, luongcb, HeSoBacLuong, HeSoPhuCapChucVu, SoNgayDiLam, SoNgayNghiBHXH, SoNgayNghiKhongLyDo, TienNha, TongLuong, ThoiDiem);
                luongs.Add(luong);
            }

            return luongs;

        }
        public DataTable getEmployeeID()
        {
            string query = "select MANV from LUONG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public int calculateSalary(string maNhanVien)
        {
            string query = "EXEC CalculateSalary '" + maNhanVien + "'";


            object result = DataProvider.Instance.ExecuteScalar(query);

            // Chuyển đổi giá trị kết quả thành decimal
           int salary =Convert.ToInt32(result);

            return salary;

        }
        public bool updateSalary(string maNhanVien,int luong)
        {
            try
            {
                string query = "UPDATE LUONG SET TIENLUONG = '"+luong+"' WHERE MANV = '"+maNhanVien+"'";

               
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

        public DataTable GetEmployeeData(string maNhanVien)
        {
            DataTable employeeData = new DataTable();

            try
            {
                string query = @"SELECT
                            LUONG.MANV AS MaNhanVien,
                            LUONG.LUONGCOBAN AS LuongCoBan,
                            BACLUONG.HESOBL AS HeSoBacLuong,
                            CHUCVU.HESOPHUCAP AS HeSoPhuCapChucVu,
                            BOPHANCHAMCONG.SONGAYTRONGTHANG AS SoNgayDiLam,
                            BOPHANCHAMCONG.SONGAYNGHIBHXH AS SoNgayNghiBHXH,
                            BOPHANCHAMCONG.SONGAYNGHIKHONGLYDO AS SoNgayNghiKhongLyDo,
                            TIENNHA.TIENNHA AS TienNha,
                            LUONG.TIENLUONG AS TongLuong,
                            LUONG.THOIDIEM AS ThoiDiem
                        FROM
                            LUONG
                        JOIN
                            NGACHLUONG ON LUONG.MANL = NGACHLUONG.MANL
                        JOIN
                            BACLUONG ON LUONG.MABL = BACLUONG.MABL
                        JOIN
                            CHUCVU ON LUONG.MACV = CHUCVU.MACV
                        JOIN
                            BOPHANCHAMCONG ON LUONG.MACC = BOPHANCHAMCONG.MACC
                        JOIN
                            TIENNHA ON LUONG.MATN = TIENNHA.MANTT
                        WHERE
                            LUONG.MANV = '" + maNhanVien + "'";

                employeeData = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi
                Console.WriteLine($"Lỗi: {ex.Message}");
            }

            return employeeData;
        }

    }
}
