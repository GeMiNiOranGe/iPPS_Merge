using Microsoft.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Pepro.Presentation
{
    public partial class AdminProjectsModule : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        SqlConnection conn = new SqlConnection(Config.CONNECTION_STRING);
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        public AdminProjectsModule()
        {
            InitializeComponent();
        }

        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(projectIdTextBox.Text=="" || projectNameTextBox.Text == "" 
                || accessTextBox.Text == "" || statusTextBox.Text == ""
                || customerTextBox.Text == "" || managerIdTextBox.Text == ""
                || departmentTextBox.Text == "" || startDateTimePicker.Text == "" || endDateTimePicker.Text == "")
            {
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin!");
                return;
            }
            try
            {
                if(MessageBox.Show("Bạn có muốn lưu dự án này?", "Xác nhận",
                           MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO PROJECT VALUES(@idPrj,@name,@access,@status,@cus,@idMng)", conn);
                    cmd.Parameters.AddWithValue("@idPrj", projectIdTextBox.Text);
                    cmd.Parameters.AddWithValue("@name", projectNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@access", accessTextBox.Text);
                    cmd.Parameters.AddWithValue("@status", statusTextBox.Text);
                    cmd.Parameters.AddWithValue("@cus", customerTextBox.Text);
                    cmd.Parameters.AddWithValue("@idMng", managerIdTextBox.Text);

                    cmd2 = new SqlCommand("INSERT INTO IMPLEMENT_PROJECT VALUES(@idDep,@idPrj2,@start,@end)", conn);
                    cmd2.Parameters.AddWithValue("@idDep", departmentTextBox.Text);
                    cmd2.Parameters.AddWithValue("@idPrj2", projectIdTextBox.Text);
                    cmd2.Parameters.AddWithValue("@start", startDateTimePicker.Text);
                    cmd2.Parameters.AddWithValue("@end", endDateTimePicker.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    ResetTextBox();
                    MessageBox.Show("Lưu dự án thành công!");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (projectIdTextBox.Text == "" || projectNameTextBox.Text == ""
                || accessTextBox.Text == "" || statusTextBox.Text == ""
                || customerTextBox.Text == "" || managerIdTextBox.Text == ""
                || departmentTextBox.Text == "" || startDateTimePicker.Text == "" || endDateTimePicker.Text == "")
            {
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin!");
                return;
            }
            try
            {
                if (MessageBox.Show("Bạn có muốn cập nhật dự án này?", "Xác nhận",
                           MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    conn.Open();
                    string updateProjectQuery = @"
                        UPDATE PROJECT
                        SET NAME = @name,
                            ACCESS_RIGHT = @access,
                            STATUS = @status,
                            CUSTOMER_NAME = @cus,
                            PROJECT_MANAGER_ID = @idMng
                        FROM PROJECT P
                        INNER JOIN IMPLEMENT_PROJECT IP ON P.ID = IP.PROJECT_ID
                        WHERE P.ID = @idPrj";

                    cmd = new SqlCommand(updateProjectQuery, conn);
                    cmd.Parameters.AddWithValue("@name", projectNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@access", accessTextBox.Text);
                    cmd.Parameters.AddWithValue("@status", statusTextBox.Text);
                    cmd.Parameters.AddWithValue("@cus", customerTextBox.Text);
                    cmd.Parameters.AddWithValue("@idMng", managerIdTextBox.Text);
                    cmd.Parameters.AddWithValue("@idPrj", projectIdTextBox.Text);
                    cmd.ExecuteNonQuery();

                    string updateImplementProjectQuery = @"
                        UPDATE IMPLEMENT_PROJECT
                        SET DEPARTMENT_ID = @idDep,
                            PROJECT_START_DATE = @start,
                            PROJECT_END_DATE = @end
                        FROM PROJECT P
                        INNER JOIN IMPLEMENT_PROJECT IP ON P.ID = IP.PROJECT_ID
                        WHERE P.ID = @idPrj";

                    cmd = new SqlCommand(updateImplementProjectQuery, conn);
                    cmd.Parameters.AddWithValue("@idDep", departmentTextBox.Text);
                    cmd.Parameters.AddWithValue("@start", startDateTimePicker.Text);
                    cmd.Parameters.AddWithValue("@end", endDateTimePicker.Text);
                    cmd.Parameters.AddWithValue("@idPrj", projectIdTextBox.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    ResetTextBox();
                    MessageBox.Show("Sửa dự án thành công!");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResetTextBox();
            saveButton.Enabled = true;
            updateButton.Enabled = false;
        }

        public void ResetTextBox()
        {
            projectIdTextBox.ResetText();
            projectNameTextBox.ResetText();
            accessTextBox.ResetText();
            statusTextBox.ResetText();
            customerTextBox.ResetText();
            managerIdTextBox.ResetText();
            departmentTextBox.ResetText();
        }

        private void ClosePictureBox_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
