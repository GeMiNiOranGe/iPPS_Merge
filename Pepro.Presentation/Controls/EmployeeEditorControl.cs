using Microsoft.Data.SqlClient;
using Pepro.Business;
using Pepro.DTOs;
using System.ComponentModel;
using System.Data;

namespace Pepro.Presentation.Controls;

public partial class EmployeeEditorControl : PeproEditorControlBase, IEditorUserControl<Employee> {
    private Employee _item = null!;
    private EditorMode _mode;
    SqlConnection sqlConnection = new(Config.CONNECTION_STRING);
    SqlCommand sqlCommand;
    SqlDataReader sqlDataReader;
    SqlDataAdapter sqlDataAdapter;
    DataTable dataTable;

    public EmployeeEditorControl() {
        Initialize();
    }

    public EmployeeEditorControl(IMediator mediator) : base(mediator) {
        Initialize();
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public required Employee Item {
        get => _item;
        set {
            _item = value ?? throw new ArgumentNullException(nameof(Item));
            employeeIdInputField.Text = _item.EmployeeId;
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public required EditorMode Mode {
        get => _mode;
        set {
            _mode = value;
            HeaderText = _mode switch {
                EditorMode.Create => "Create a new employee",
                EditorMode.Edit => "Edit employee",
                _ => throw new InvalidEnumArgumentException(nameof(Mode), (int)_mode, typeof(EditorMode)),
            };
        }
    }

    private void Initialize() {
        InitializeComponent();

        saveButton.SetupRuntimeFlatStyle();
    }

    private void EmployeeEditorControl_Load(object sender, EventArgs e) {
        if (string.IsNullOrEmpty(departmentIdInputField.Text) ||
            string.IsNullOrEmpty(jobPositionIdInputField.Text) ||
            string.IsNullOrEmpty(salaryScaleIdInputField.Text) ||
            string.IsNullOrEmpty(salaryLevelIdInputField.Text)) {
            lbCheck1.ForeColor = Color.Red;
            lbCheck2.ForeColor = Color.Red;
            lbCheck3.ForeColor = Color.Red;
            lbCheck4.ForeColor = Color.Red;
        }

        departmentIdInputField.DataBindings.Add(
            nameof(departmentIdInputField.Text),
            departmentComboBoxField,
            nameof(departmentComboBoxField.SelectedValue)
        );

        salaryScaleIdInputField.DataBindings.Add(
            nameof(departmentIdInputField.Text),
            salaryScaleComboBoxField,
            nameof(salaryScaleComboBoxField.SelectedValue)
        );

        departmentComboBoxField.DisplayMember = nameof(Department.Name);
        departmentComboBoxField.ValueMember = nameof(Department.DepartmentId);

        salaryScaleComboBoxField.DisplayMember = nameof(SalaryScale.Name);
        salaryScaleComboBoxField.ValueMember = nameof(SalaryScale.SalaryScaleId);

        List<Department> departments = DepartmentBusiness.Instance.GetDepartments();
        departmentComboBoxField.DataSource = departments;
        departmentComboBoxField.SelectedIndex = -1;

        sqlConnection.Open();
        sqlCommand = new SqlCommand("SELECT * FROM CHUCVU", sqlConnection);
        sqlDataReader = sqlCommand.ExecuteReader();
        while (sqlDataReader.Read()) {
            jobPositionComboBoxField.Items.Add(sqlDataReader["TENCV"]);
        }
        sqlConnection.Close();

        List<SalaryScale> salaryScale = SalaryScaleBusiness.Instance.GetSalaryScales();
        salaryScaleComboBoxField.DataSource = salaryScale;
        salaryScaleComboBoxField.SelectedIndex = -1;
    }

    private void DepartmentComboBoxField_SelectedIndexChanged(object sender, EventArgs e) {
        sqlConnection.Open();
        sqlCommand = new SqlCommand("SELECT * FROM PHONGBAN WHERE TENPB = @TENPB", sqlConnection);
        sqlCommand.Parameters.AddWithValue("@TENPB", departmentComboBoxField.Text);
        sqlDataReader = sqlCommand.ExecuteReader();
        while (sqlDataReader.Read()) {
            departmentIdInputField.Text = sqlDataReader["MAPB"].ToString();
        }
        sqlConnection.Close();

        lbCheck1.ForeColor = Color.Black;
    }

    private void JobPositionComboBoxField_SelectedIndexChanged(object sender, EventArgs e) {
        sqlConnection.Open();
        sqlCommand = new SqlCommand("SELECT * FROM CHUCVU WHERE TENCV = @TENCV", sqlConnection);
        sqlCommand.Parameters.AddWithValue("@TENCV", jobPositionComboBoxField.Text);
        sqlDataReader = sqlCommand.ExecuteReader();
        while (sqlDataReader.Read()) {
            jobPositionIdInputField.Text = sqlDataReader["MACV"].ToString();
        }
        sqlConnection.Close();

        lbCheck2.ForeColor = Color.Black;
    }

    private void SalaryScaleComboBoxField_SelectedIndexChanged(object sender, EventArgs e) {
        sqlConnection.Open();
        sqlCommand = new SqlCommand("SELECT * FROM NGACHLUONG WHERE TENNL = @TENNL", sqlConnection);
        sqlCommand.Parameters.AddWithValue("@TENNL", salaryScaleComboBoxField.Text);
        sqlDataReader = sqlCommand.ExecuteReader();
        while (sqlDataReader.Read()) {
            salaryScaleIdInputField.Text = sqlDataReader["MANL"].ToString();
        }
        sqlConnection.Close();

        lbCheck3.ForeColor = Color.Black;

        sqlConnection.Open();
        sqlDataAdapter = new SqlDataAdapter("SELECT * FROM BACLUONG where MANL='" + salaryScaleIdInputField.Text + "'", sqlConnection);
        dataTable = new DataTable();
        sqlDataAdapter.Fill(dataTable);
        salaryLevelComboBoxField.DisplayMember = "TENBL";
        salaryLevelComboBoxField.ValueMember = "MABL";
        salaryLevelComboBoxField.DataSource = dataTable;
        salaryLevelIdInputField.DataBindings.Clear();
        salaryLevelIdInputField.DataBindings.Add("Text", salaryLevelComboBoxField.DataSource, "MABL");
        sqlConnection.Close();
    }

    public void InsertStaff() {
        string insertQuery = "INSERT INTO NHANVIEN (MANV, HOTENNV, GIOITINH, NGAYSINH, NOISINH, QUEQUAN, TRINHDOVANHOA, DANTOC, TONGIAO, DOANVIEN, DANGVIEN, CONGDOANVIEN, MAPB, MACV, MANL, MABL) " +
                             "VALUES (@MANV, @HOTENNV, @GIOITINH, @NGAYSINH, @NOISINH, @QUEQUAN, @TRINHDOVANHOA, @DANTOC, @TONGIAO, @DOANVIEN, @DANGVIEN, @CONGDOANVIEN, @MAPB, @MACV, @MANL, @MABL)";

        sqlConnection.Open();

        sqlCommand = new SqlCommand(insertQuery, sqlConnection);
        sqlCommand.Parameters.AddWithValue("@MANV", employeeIdInputField.Text);
        sqlCommand.Parameters.AddWithValue("@HOTENNV", fullNameInputField.Text);
        if (maleRadioButton.Checked) {
            sqlCommand.Parameters.AddWithValue("@GIOITINH", "1");
        }
        else {
            sqlCommand.Parameters.AddWithValue("@GIOITINH", "0");
        }
        dateOfBirthDateTimePicker.Format = DateTimePickerFormat.Custom;
        dateOfBirthDateTimePicker.CustomFormat = "yyyyMMdd";
        sqlCommand.Parameters.AddWithValue("@NGAYSINH", dateOfBirthDateTimePicker.Text);
        sqlCommand.Parameters.AddWithValue("@MAPB", departmentIdInputField.Text);
        sqlCommand.Parameters.AddWithValue("@MACV", jobPositionIdInputField.Text);
        sqlCommand.Parameters.AddWithValue("@MANL", salaryScaleIdInputField.Text);
        sqlCommand.Parameters.AddWithValue("@MABL", salaryLevelIdInputField.Text);
        sqlCommand.ExecuteNonQuery();

        sqlConnection.Close();
    }

    private void SaveButton_Click(object sender, EventArgs e) {
        if (Mode == EditorMode.Create) {
            if (string.IsNullOrEmpty(departmentIdInputField.Text) ||
                string.IsNullOrEmpty(jobPositionIdInputField.Text) ||
                string.IsNullOrEmpty(salaryScaleIdInputField.Text) ||
                string.IsNullOrEmpty(salaryLevelIdInputField.Text)) {
                MessageBox.Show("Mời điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                InsertStaff();

                MessageBox.Show("Thêm Nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        else {
            UpdateStaff();
        }
    }

    public void UpdateStaff() {
        sqlConnection.Open();
        sqlCommand = new SqlCommand("UPDATE NHANVIEN SET HOTENNV = @HOTENNV, GIOITINH = @GIOITINH, NGAYSINH = @NGAYSINH, @NOISINH = NOISINH, QUEQUAN = @QUEQUAN, TRINHDOVANHOA = @TRINHDOVANHOA, DANTOC = @DANTOC, TONGIAO = @TONGIAO, DOANVIEN = @DOANVIEN, DANGVIEN = @DANGVIEN, CONGDOANVIEN = @CONGDOANVIEN, MAPB = @MAPB, MACV = @MACV, MANL = @MANL, MABL = @MABL WHERE MANV = @MANV", sqlConnection);
        sqlCommand.Parameters.AddWithValue("@MANV", employeeIdInputField.Text);
        sqlCommand.Parameters.AddWithValue("@HOTENNV", fullNameInputField.Text);
        if (maleRadioButton.Checked) {
            sqlCommand.Parameters.AddWithValue("@GIOITINH", "1");
        }
        else {
            sqlCommand.Parameters.AddWithValue("@GIOITINH", "0");
        }
        dateOfBirthDateTimePicker.Format = DateTimePickerFormat.Custom;
        dateOfBirthDateTimePicker.CustomFormat = "yyyyMMdd";
        sqlCommand.Parameters.AddWithValue("@NGAYSINH", dateOfBirthDateTimePicker.Text);
        sqlCommand.Parameters.AddWithValue("@MAPB", departmentIdInputField.Text);
        sqlCommand.Parameters.AddWithValue("@MACV", jobPositionIdInputField.Text);
        sqlCommand.Parameters.AddWithValue("@MANL", salaryScaleIdInputField.Text);
        sqlCommand.Parameters.AddWithValue("@MABL", salaryLevelIdInputField.Text);
        sqlCommand.ExecuteNonQuery();

        sqlConnection.Close();

        MessageBox.Show("Cập nhật nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
