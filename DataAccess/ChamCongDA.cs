using DTO;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DataAccess {

    public class ChamCongDA {
        // thêm đường dẫn
        private static string folderPath = @"C:\Users\Administrator\Desktop\Môn HĐT"; // thêm đường dẫn 
        private static string filePath = Path.Combine(folderPath, $"ChamCongReport.pdf");
        private static ChamCongDA instance;
        public static ChamCongDA Instance {
            get => instance ?? (instance = new ChamCongDA());
        }

        public List<ChamCong> showAttendanceList() {
            List<ChamCong> dschamcong = new List<ChamCong>();
            string query = "select *from BOPHANCHAMCONG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in data.Rows) {
                string macc = dr["MACC"].ToString();
                DateTime thang = (DateTime)dr["THANG"];
                byte? songaytrongthang = dr["SONGAYTRONGTHANG"].ToString() == string.Empty ? null : (byte?)dr["SONGAYTRONGTHANG"];
                byte? songaynghiBHXH = dr["SONGAYNGHIBHXH"].ToString() == string.Empty ? null : (byte?)dr["SONGAYNGHIBHXH"];
                byte? songaynghikhonglydo = dr["SONGAYNGHIKHONGLYDO"].ToString() == string.Empty ? null : (byte?)dr["SONGAYNGHIKHONGLYDO"];
                string manv = dr["MANV"].ToString();

                ChamCong chamcong = new ChamCong(macc, thang, songaytrongthang, songaynghiBHXH, songaynghikhonglydo, manv);
                dschamcong.Add(chamcong);
            }
            return dschamcong;
        }

        public DataTable getEmployeeID() {
            string query = "select MANV from NHANVIEN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public bool deleteAttendance(string manv) {
            try {
                // Gọi stored procedure từ DataProvider và kiểm tra kết quả
                return DataProvider.Instance.ExecuteNonQuery("exec usp_XoaChamCong @MaNhanVienCanXoa", new object[] { manv }) > 0;
            }
            catch (Exception ex) {
                // Xử lý ngoại lệ nếu có lỗi
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
        }

        public bool updateAttendace(string manv, DateTime thang, byte songaytrongthang, byte songaynghibhxh, byte songaynghikhonglydo) {
            if (songaytrongthang > 26) {
                Console.WriteLine("Số đi làm trong tháng không được lớn hơn 26");
                return false;
            }
            string query = "Update BOPHANCHAMCONG set THANG='" + thang + "', SONGAYTRONGTHANG='" + songaytrongthang + "', SONGAYNGHIBHXH='" + songaynghibhxh + "', SONGAYNGHIKHONGLYDO='" + songaynghikhonglydo + "' where MANV='" + manv + "'";

            try {
                return DataProvider.Instance.ExecuteNonQuery(query) > 0;
            }
            catch (Exception ex) {
                // Xử lý ngoại lệ nếu có lỗi
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
        }

        public bool insertAttendance(string MaCC, string MaNV, DateTime Thang, Byte Songaynghilam, Byte SongaynghiBHXH, Byte Songaydilam) {
            try {
                // Kiểm tra xem MANV đã có MACC hay chưa
                if (CheckMaccExist_01(MaCC, MaNV)) {
                    return false;
                }
                // Tạo câu lệnh SQL Insert
                string query = "INSERT INTO BOPHANCHAMCONG (MACC, THANG, SONGAYTRONGTHANG, SONGAYNGHIBHXH, SONGAYNGHIKHONGLYDO, MANV) " +
                               "VALUES ('" + MaCC + "', '" + Thang + "', '" + Songaynghilam + "', '" + SongaynghiBHXH + "', '" + Songaynghilam + "', '" + MaNV + "')";

                return DataProvider.Instance.ExecuteNonQuery(query) > 0;
            }
            catch (Exception ex) {
                // Xử lý ngoại lệ, hiển thị hoặc ghi log lỗi
                Console.WriteLine("Lỗi thêm mới chấm công: " + ex.Message);
                return false;
            }
        }

        public bool CheckMaccExist(string macc) {
            string query = "SELECT COUNT(*) FROM BOPHANCHAMCONG WHERE MACC = '" + macc + "'";
            int count = Convert.ToInt32(DataProvider.Instance.ExecuteQuery(query).Rows[0][0]);
            return count > 0;
        }

        public bool CheckMaccExist_01(string macc, string maNV) {
            string query = "SELECT COUNT(*) FROM BOPHANCHAMCONG WHERE MACC = '" + macc + "' OR MANV = '" + maNV + "'";

            int count = Convert.ToInt32(DataProvider.Instance.ExecuteQuery(query).Rows[0][0]);

            return count > 0;
        }

        public bool updateAttendanceForNewMonth(string maNhanVien, DateTime thoidiem) {
            int kq = 0;
            try {
                // Kiểm tra xem lương đã được tính cho tháng mới chưa
                string checkQuery = $"SELECT COUNT(*) FROM BOPHANCHAMCONG WHERE MANV = '{maNhanVien}' AND MONTH(THANG) = '" + thoidiem.Month + "'";
                int rowCount = (int)DataProvider.Instance.ExecuteScalar(checkQuery);
                if (rowCount == 0) {
                    // Nếu lương chưa được tính, thực hiện cập nhật về 0
                    string updateQuery = $"UPDATE BOPHANCHAMCONG SET SONGAYTRONGTHANG=0, SONGAYNGHIBHXH=0,SONGAYNGHIKHONGLYDO=0 WHERE MANV = '{maNhanVien}'";
                    kq = DataProvider.Instance.ExecuteNonQuery(updateQuery);
                }
                return kq > 0;
            }
            catch (Exception ex) {
                // Xử lý ngoại lệ nếu có lỗi
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
        }

        public string ExportAlltoPdf(DataTable dataTable) {
            try {
                using (FileStream fs = new FileStream(filePath, FileMode.Create)) {
                    using (var pdfWriter = new PdfWriter(fs)) {
                        using (var pdf = new PdfDocument(pdfWriter)) {
                            var document = new Document(pdf);
                            // Tiêu đề báo cáo
                            document.Add(new Paragraph("ATTENDANCE REPORT").SetFontSize(16));

                            // Chọn các cột bạn muốn xuất
                            var selectedColumns = new List<string> { "MaCC", "SONGAYTRONGTHANG", "SONGAYNGHIBHXH", "SONGAYNGHIKHONGLYDO", "THANG" };

                            // Tạo bảng với số cột bằng với số cột bạn đã chọn
                            var table = new Table(selectedColumns.Count);

                            // Thêm header bảng
                            foreach (var columnName in selectedColumns) {
                                table.AddCell(new Cell()
                                     .Add(new Paragraph(columnName))
                                     .SetFontColor(DeviceRgb.WHITE)
                                     .SetBackgroundColor(DeviceRgb.BLACK)
                                     .SetFontSize(12));
                            }

                            // Thêm dữ liệu từ DataTable vào bảng
                            foreach (DataRow row in dataTable.Rows) {
                                foreach (var columnName in selectedColumns) {
                                    var cellValue = row[columnName].ToString();
                                    table.AddCell(new Cell().Add(new Paragraph(cellValue)).SetFontSize(10));
                                }
                            }

                            // Thêm bảng vào tài liệu
                            document.Add(table);
                        }
                    }
                }
                return filePath;
            }
            catch (Exception ex) {
                Console.WriteLine($"Lỗi: {ex.Message}");
                throw;
            }
        }

        public DataTable GetAllChamCongInfo() {
            DataTable chamCongTable = new DataTable();
            try {
                string query = "SELECT * FROM BOPHANCHAMCONG";
                chamCongTable = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex) {
                Console.WriteLine($"Lỗi khi lấy tất cả thông tin chấm công: {ex.Message}");
            }
            return chamCongTable;
        }
    }
}

