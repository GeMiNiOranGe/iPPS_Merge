using Microsoft.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Pepro.Presentation
{
    public partial class AdminTasksModule : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        SqlConnection conn = new SqlConnection(Config.CONNECTION_STRING);
        SqlCommand cmd = new SqlCommand();

        public AdminTasksModule()
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
            if (projectIdTextBox.Text == "" || taskIdTextBox.Text == "" 
                || managerIdTextBox.Text == "" || accessTextBox.Text == "" 
                || publicDepartmentTextBox.Text == "" || publicProjectTextBox.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin!");
                return;
            }
            try
            {
                if (MessageBox.Show("Bạn có muốn lưu công việc này?", "Xác nhận",
                           MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT INTO JOB VALUES (@idJob,@idMng,@name,@access,@status,@prjPub,@depPub,@idPrj)", conn);
                    cmd.Parameters.AddWithValue("@idJob", taskIdTextBox.Text);
                    cmd.Parameters.AddWithValue("@idMng", managerIdTextBox.Text);
                    cmd.Parameters.AddWithValue("@name", taskNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@access", accessTextBox.Text);
                    cmd.Parameters.AddWithValue("@status", statusTextBox.Text);
                    cmd.Parameters.AddWithValue("@prjPub", publicProjectTextBox.Text);
                    cmd.Parameters.AddWithValue("@depPub", publicDepartmentTextBox.Text);
                    cmd.Parameters.AddWithValue("@idPrj", projectIdTextBox.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    ResetTextBox();
                    MessageBox.Show("Lưu công việc thành công!");
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
            if (projectIdTextBox.Text == "" || taskIdTextBox.Text == ""
                || managerIdTextBox.Text == "" || accessTextBox.Text == ""
                || publicDepartmentTextBox.Text == "" || publicProjectTextBox.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin!");
                return;
            }
            try
            {
                if (MessageBox.Show("Bạn có muốn cập nhật công việc này?", "Xác nhận",
                           MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cmd = new SqlCommand($"UPDATE JOB SET ID=@idJob, JOB_MANAGER_ID=@idMng, NAME=@name, ACCESS_RIGHT=@access, STATUS=@status, PROJECT_PUBLIC=@prjPub, DEPARTMENT_PUBLIC=@depPub, PROJECT_ID=@idPrj WHERE ID='{taskIdTextBox.Text}'", conn);
                    cmd.Parameters.AddWithValue("@idJob", taskIdTextBox.Text);
                    cmd.Parameters.AddWithValue("@idMng", managerIdTextBox.Text);
                    cmd.Parameters.AddWithValue("@name", taskNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@access", accessTextBox.Text);
                    cmd.Parameters.AddWithValue("@status", statusTextBox.Text);
                    cmd.Parameters.AddWithValue("@prjPub", publicProjectTextBox.Text);
                    cmd.Parameters.AddWithValue("@depPub", publicDepartmentTextBox.Text);
                    cmd.Parameters.AddWithValue("@idPrj", projectIdTextBox.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    ResetTextBox();
                    MessageBox.Show("Sửa công việc thành công!");
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

        private void ResetTextBox()
        {
            taskNameTextBox.ResetText();
            taskIdTextBox.ResetText();
            managerIdTextBox.ResetText();
            accessTextBox.ResetText();
            statusTextBox.ResetText();
            publicProjectTextBox.ResetText();
            publicDepartmentTextBox.ResetText();
            projectIdTextBox.ResetText();
        }

        private void ClosePictureBox_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
