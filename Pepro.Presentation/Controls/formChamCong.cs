using Pepro.Business;
using Pepro.DTOs;
using System.Data;
using Pepro.DataAccess;

namespace Pepro.Presentation.Controls;

public partial class formChamCong : UserControl {
    #region Event
    public formChamCong() {
        InitializeComponent();
    }

    private void FromChamCong_Load(object sender, EventArgs e) {
        LoadAttendanceList();
        LoadComBoBoxMaNV();
        numberOfAttendanceNumericUpDown.Value = 0;
        numngaynghiBHXH.Value = 0;
        numngaynghi.Value = 0;

        attendanceDataGridView.ClearSelection();
    }

    private void AttendanceDataGridView_SelectionChanged(object sender, EventArgs e) {
        if (attendanceDataGridView.SelectedRows.Count > 0) {
            DataGridViewRow selectionrow = attendanceDataGridView.SelectedRows[0];
            string manv = selectionrow.Cells["MANV"].Value.ToString();
            DateTime thang = (DateTime)selectionrow.Cells["THANG"].Value;
            byte songaydilam = (byte)selectionrow.Cells["SONGAYTRONGTHANG"].Value;
            byte songaynghiBHXH = (byte)selectionrow.Cells["SONGAYNGHIBHXH"].Value;
            byte songaynghikhonglydo = (byte)selectionrow.Cells["SONGAYNGHIKHONGLYDO"].Value;
            employeeIdTextBox.Text = manv;
            attendanceDateTimePicker.Value = thang;
            numberOfAttendanceNumericUpDown.Value = songaydilam;
            numngaynghi.Value = songaynghikhonglydo;
            numngaynghiBHXH.Value = songaynghiBHXH;
        }
    }

    private void AddButton_Click(object sender, EventArgs e) {
        string MaCC = attendanceIdTextBox.Text.ToString();
        string MaNV = employeeIdTextBox.Text.ToString();
        DateTime Thang = attendanceDateTimePicker.Value;
        //byte Songaydilam = Convert.ToByte(numberOfAttendanceNumericUpDown.Value);
        byte SongaynghiBHXH = Convert.ToByte(numngaynghiBHXH.Value);
        byte Songaynghilam = Convert.ToByte(numngaynghi.Value);

        DatabaseHelper dbHelper = new();

        // Kiểm tra xem mã chấm công và mã nhân viên đã tồn tại hay chưa
        bool macAndManvExists = dbHelper.CheckMACCAndMANVExists(MaNV, MaCC);

        if (macAndManvExists) {
            MessageBox.Show("Mã chấm công hoặc Mã nhân viên đã tồn tại.");
        }
        else {
            if (string.IsNullOrEmpty(MaCC)) {
                MessageBox.Show("Nhập mã chấm công");
            }
            else {
                // Kiểm tra xem mã chấm công đã tồn tại cho nhân viên hay chưa
                bool maccExistsForNV = ChamCongDA.Instance.CheckMaccExist(MaCC, MaNV);
                if (maccExistsForNV) {
                    MessageBox.Show("Mã chấm công '" + MaCC + "' đã tồn tại cho nhân viên '" + MaNV + "'");
                }
                else {
                    // Thêm mới chấm công
                    ChamCongDA.Instance.insertAttendance(MaCC, MaNV, Thang, Songaynghilam, SongaynghiBHXH, Songaynghilam);
                    MessageBox.Show("Thêm mới thành công!");
                    LoadAttendanceList();
                }
            }
        }
    }

    private void UpdateButton_Click(object sender, EventArgs e) {
        if (attendanceDataGridView.SelectedRows.Count > 0) {
            string MaNV = employeeIdTextBox.Text.ToString();
            DateTime Thang = attendanceDateTimePicker.Value;
            byte Songaydilam = Convert.ToByte(numberOfAttendanceNumericUpDown.Value);
            byte SongaynghiBHXH = Convert.ToByte(numngaynghiBHXH.Value);
            byte Songaynghilam = Convert.ToByte(numngaynghi.Value);
            if (ChamCongBL.Instance.updateAttendanceBL(MaNV, Thang, Songaydilam, SongaynghiBHXH, Songaynghilam)) {
                MessageBox.Show("Cập nhật thành công!");
                LoadAttendanceList();
            }
            else {
                MessageBox.Show("Cập nhật không thành công!");
            }
        }
        else {
            MessageBox.Show("Vui lòng chọn nhân viên để cập nhật");
        }
    }

    private void DeleteButton_Click(object sender, EventArgs e) {
        string manv = employeeIdTextBox.Text.ToString();
        ChamCongDA.Instance.deleteAttendance(manv);
        LoadAttendanceList();
    }

    private void AttendanceButton_Click(object sender, EventArgs e) {
        string MaNV = employeeIdTextBox.Text.ToString();
        DateTime Thang = attendanceDateTimePicker.Value;
        byte Songaydilam = Convert.ToByte(numberOfAttendanceNumericUpDown.Value);
        byte SongaynghiBHXH = Convert.ToByte(numngaynghiBHXH.Value);
        byte Songaynghilam = Convert.ToByte(numngaynghi.Value);


        int workStatusValue = WorkStatus(statusComboBox.Text);
        int numberDaysInMonth = DateTime.DaysInMonth(Thang.Year, Thang.Month);

        if (workStatusValue == 0 && Songaydilam < numberDaysInMonth) {
            Songaydilam++;
        }
        else if (workStatusValue == 1 && SongaynghiBHXH < 30) {
            SongaynghiBHXH++;
        }
        else {
            // Kiểm tra số ngày nghỉ làm không được quá 3 ngày
            if (Songaynghilam < 3) {
                Songaynghilam++;
            }
            else {
                MessageBox.Show("Số ngày nghỉ làm không được quá 3 ngày.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Không thực hiện cập nhật nếu có lỗi
            }
        }

        if (Songaydilam > 26) {
            MessageBox.Show("Số ngày đi làm không được lớn hơn 26 ngày.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return; // Không thực hiện cập nhật nếu có lỗi
        }

        ChamCongBL.Instance.updateAttendanceBL(MaNV, Thang, Songaydilam, SongaynghiBHXH, Songaynghilam);
        LoadAttendanceList();
    }

    private void AttendanceDateTimePicker_ValueChanged(object sender, EventArgs e) {
        string manv = employeeIdTextBox.Text;
        DateTime thoigian = attendanceDateTimePicker.Value;
        if (ChamCongDA.Instance.updateAttendanceForNewMonth(manv, thoigian)) {
            LoadAttendanceList();
        }
    }

    private void ExportReportButton_Click(object sender, EventArgs e) {
        DataTable dataTable = ChamCongDA.Instance.GetAllChamCongInfo();
        string filePath = ChamCongDA.Instance.ExportAlltoPdf(dataTable);
        MessageBox.Show($"File PDF đã được xuất tại:\n{filePath}", "Thông báo");
    }

    private void NumberOfAttendanceNumericUpDown_ValueChanged(object sender, EventArgs e) {
        if (numberOfAttendanceNumericUpDown.Value > 26) {
            numberOfAttendanceNumericUpDown.Value = 0;
        }
    }

    private void Numngaynghi_ValueChanged(object sender, EventArgs e) {
        if (numngaynghi.Value > 3) {
            numngaynghi.Value = 0;
        }
    }

    private void NumngaynghiBHXH_ValueChanged(object sender, EventArgs e) {
        if (numngaynghiBHXH.Value > 30) {
            numngaynghiBHXH.Value = 0;
        }
    }
    #endregion

    //-------------------------------------------------------------Function------------------------------------------------
    #region Function
    private void LoadAttendanceList() {
        List<ChamCong> chamcong = ChamCongBL.Instance.getAttendanceList();
        attendanceDataGridView.DataSource = chamcong;
    }

    private void LoadComBoBoxMaNV() {
        DataTable data = ChamCongBL.Instance.getEmployeeID();
        employeeIdTextBox.DataSource = data;
        employeeIdTextBox.DisplayMember = "MANV";
        employeeIdTextBox.ValueMember = "MANV";
    }

    private int WorkStatus(string status) {
        if (status == "Đi làm") {
            return 0;
        }
        else if (status == "Nghỉ có phép") {
            return 1;
        }
        else {
            return 2;
        }
    }
    #endregion
}
