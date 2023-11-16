using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
   public class DatabaseHelper
    {
        public bool CheckMACCAndMANVExists(string manv, string macc)
        {
            try
            {
                using (SqlConnection connection = DataProvider.Instance.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("CheckMACCAndMANVexists", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số cho hàm
                        command.Parameters.Add("@MANV", SqlDbType.VarChar).Value = manv;
                        command.Parameters.Add("@MACC", SqlDbType.VarChar).Value = macc;

                        // Thêm tham số đầu ra
                        SqlParameter returnParameter = command.Parameters.Add("RetVal", SqlDbType.Bit);
                        returnParameter.Direction = ParameterDirection.ReturnValue;

                        // Thực hiện hàm
                        command.ExecuteNonQuery();

                        // Lấy giá trị trả về từ hàm
                        int result = (int)returnParameter.Value;

                        // Kiểm tra giá trị trả về
                        return result == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
        }
    }
}
