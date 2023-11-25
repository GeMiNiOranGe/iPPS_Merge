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
    public class KTXDA
    {
        private static KTXDA instance;
        public static KTXDA Instance
        {
            get => instance ?? (instance = new KTXDA());
        }
        public List<HoGD> loadHouseHoldList()
        {
            List<HoGD> hogiadinh = new List<HoGD>();
            string query = "select * from HOGIADINH";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in data.Rows)
            {
                string mahogd = dr["MAHGD"].ToString();
                string manv1 = dr["MANV1"].ToString();
                string manv2 = dr["MANV2"].ToString();
                HoGD hgd = new HoGD(mahogd, manv1, manv2);
                hogiadinh.Add(hgd);
            }
            return hogiadinh;

        }
        public DataTable getEmployeeID1()
        {
            string query = "select MANV from NHANVIEN, HOGIADINH where MANV=HOGIADINH.MANV1 and HOGIADINH.MANV2 IS NULL";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable getEmployeeID2()
        {
            string query = "SELECT MANV FROM NHANVIEN nv WHERE NOT EXISTS (SELECT 1 FROM HOGIADINH hg WHERE hg.MANV1 = nv.MANV)";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable getHouseHoldData(string mahgd)
        {

            DataTable data = new DataTable();
            try
            {
                string query = "select* from HOGIADINH where MAHGD='" + mahgd + "'";
                data=DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
            return data;
        }
        public bool checkEmployeeID(string manv)
        {
            string query = "SELECT COUNT(*) FROM HOGIADINH WHERE MANV1 = '"+manv+"' OR MANV2 = '"+manv+"'";
            int result=(int)DataProvider.Instance.ExecuteScalar(query);
            return result > 0;

        }
        public bool checkEmployeeID(string manv1,string manv2)
        {
            string query = "SELECT COUNT(*) FROM HOGIADINH WHERE MANV1 = '" + manv1 + "' OR MANV2 = '" + manv2 + "'";
            int result = (int)DataProvider.Instance.ExecuteScalar(query);
            return result > 0;

        }
        public bool checkHouseHoldID(string mahgd)
        {
            string query = "SELECT COUNT(*) FROM HOGIADINH WHERE MAHGD = '"+mahgd+"'";
            int result=(int)(DataProvider.Instance.ExecuteScalar(query));
            return result > 0;
        }
        public bool insertHouseHold(string householdid,string manv1,string manv2)
        {
            try
            {
              
                string query = "insert into HOGIADINH set MAHGD='" + householdid + "', MANV1='" + manv1 + "',MANV2='" + manv2 + "'";
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
        public bool updateEmployee(string maHGD, string maNV2)
        {
            try
            {
                string query = "UPDATE HOGIADINH SET MANV2 = '"+maNV2+"' WHERE MAHGD = '"+maHGD+"'";
                int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query);

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
        }
        public bool canaddEmployeeinHouseHold(string manv1)
        {
            // Kiểm tra xem MANV1 đã có MANV2 hay chưa
            string query = "SELECT COUNT(*) FROM HOGIADINH WHERE MANV1 ='"+manv1+"'  AND MANV2 IS NOT NULL";
            int result = (int)DataProvider.Instance.ExecuteScalar(query);
            return result > 0;
        }
    }
}
