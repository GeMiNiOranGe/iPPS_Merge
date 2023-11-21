using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using System.IO;
using iText.Layout;
using iText;
using iText.Kernel.Colors;
using iText.Forms.Fields.Merging;

namespace DataAccess {
    public class LuongDA {
        // Đường dẫn để xuất báo cáo
        private static string folderPath = @""; // thêm đường dẫn 
        private static string filePath = Path.Combine(folderPath, $"LuongReport.pdf");
        private static LuongDA instance;
        public static LuongDA Instance {
            get => instance ?? (instance = new LuongDA());
        }

        public List<Luong> loadSalaryList() {
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
            foreach (DataRow row in data.Rows) {
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

        public DataTable getEmployeeID() {
            string query = "select MANV from LUONG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        
        public DataTable getSalaryScale() {
            string query = "select HESOBL from LUONG,BACLUONG where LUONG.MABL=BACLUONG.MABL";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public int calculateSalary(string maNhanVien) {
            string query = "EXEC CalculateSalary '" + maNhanVien + "'";
            object result = DataProvider.Instance.ExecuteScalar(query);

            // Chuyển đổi giá trị kết quả thành decimal
            int salary = Convert.ToInt32(result);
            return salary;
        }

        public bool updateSalary(string maNhanVien, int luong) {
            try {
                string query = "UPDATE LUONG SET TIENLUONG = '" + luong + "' WHERE MANV = '" + maNhanVien + "'";
                int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query);
                return rowsAffected > 0;
            }
            catch (Exception ex) {
                // Xử lý ngoại lệ nếu có lỗi
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
        }

        public DataTable GetEmployeeData(string maNhanVien) {
            DataTable employeeData = new DataTable();
            try {
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
            catch (Exception ex) {
                // Xử lý ngoại lệ nếu có lỗi
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
            return employeeData;
        }

        public DataTable getEmployeeSalryInfo() {
            DataTable employeeData = new DataTable();
            try {
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
                employeeData = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex) {
                // Xử lý ngoại lệ nếu có lỗi
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
            return employeeData;
        }

        public bool updateSalaryForNewMonth(string maNhanVien, DateTime thoidiem) {
            int kq = 0;
            try {
                // Kiểm tra xem lương đã được tính cho tháng mới chưa
                string checkQuery = $"SELECT COUNT(*) FROM LUONG WHERE MANV = '{maNhanVien}' AND MONTH(THOIDIEM) = '" + thoidiem.Month + "'";
                int rowCount = (int)DataProvider.Instance.ExecuteScalar(checkQuery);

                if (rowCount == 0) {
                    // Nếu lương chưa được tính, thực hiện cập nhật về 0
                    string updateQuery = $"UPDATE LUONG SET TIENLUONG = 0 WHERE MANV = '{maNhanVien}'";
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

        public bool updateSalaryInfo(string manv, int luongcb, DateTime thoidiem) {
            try {
                string query = @"UPDATE LUONG SET LUONGCOBAN = '" + luongcb + "', THOIDIEM = '" + thoidiem + "' WHERE MANV = '" + manv + "'";
                int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query);
                return rowsAffected > 0;
            }
            catch (Exception ex) {
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
        }

        public bool deleteSalaryInfo(string maNhanVien) {
            try {
                string query = "DELETE FROM LUONG WHERE MANV = @MaNhanVien";
                int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maNhanVien });
                return rowsAffected > 0;
            }
            catch (Exception ex) {
                // Xử lý ngoại lệ nếu có lỗi
                Console.WriteLine($"Lỗi: {ex.Message}");
                return false;
            }
        }

        public static string ExportToPdf(string maNhanVien, int luongCoBan, int tongLuong, DateTime thoigian) {
            try {
                using (FileStream fs = new FileStream(filePath, FileMode.Create)) {
                    PdfWriter writer = new PdfWriter(fs);
                    PdfDocument pdf = new PdfDocument(writer);
                    Document document = new Document(pdf);

                    // Thêm nội dung vào tài liệu PDF
                    document.Add(new Paragraph($"ID: - ({maNhanVien})"));
                    document.Add(new Paragraph($"Basic Salary: {luongCoBan} VND"));
                    document.Add(new Paragraph($"Total Salary: {tongLuong} VND"));
                    document.Add(new Paragraph($"Date:{thoigian}"));
                    // Lưu và đóng tài liệu
                    document.Close();
                }
                return filePath;
            }
            catch (Exception ex) {
                Console.WriteLine($"Error creating PDF: {ex.Message}");
                throw;
            }
        }

        public string ExportAlltoPdf(DataTable dataTable) {
            try {
                using (FileStream fs = new FileStream(filePath, FileMode.Create)) {
                    using (var pdfWriter = new PdfWriter(fs)) {
                        using (var pdf = new PdfDocument(pdfWriter)) {
                            var document = new Document(pdf);

                            // Tiêu đề báo cáo
                            document.Add(new Paragraph("BÁO CÁO TOÀN BỘ DỮ LIỆU NHÂN VIÊN").SetFontSize(16));

                            // Chọn các cột bạn muốn xuất
                            var selectedColumns = new List<string> { "MaNhanVien", "LuongCoBan", "HeSoBacLuong", "TienNha", "TongLuong" };

                            // Tạo bảng với số cột bằng với số cột bạn đã chọn
                            var table = new Table(selectedColumns.Count);

                            // Thêm header bảng
                            foreach (var columnName in selectedColumns) {
                                table.AddCell(new Cell().Add(new Paragraph(columnName)).SetFontColor(DeviceRgb.WHITE)
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
    }
}

