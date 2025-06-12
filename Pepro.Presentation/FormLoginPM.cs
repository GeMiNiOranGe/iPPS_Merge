using Pepro.Business;

namespace Pepro.Presentation
{
    public partial class FormLoginPM : Form
    {
        public int RoleID { get; private set; }

        public FormLoginPM()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            AccountBusiness.Instance.Login(
                username,
                password,
                out int result,
                out int roleID,
                out string _
            );

            if (result == 1)
            {
                //if (cbRemember.Checked)
                //{
                //    Properties.Settings.Default.Username = username;
                //    Properties.Settings.Default.Password = password;
                //    Properties.Settings.Default.Save();
                //}
                RoleID = roleID;
                FormMenuPM fmn=new(roleID);
                fmn.Show();
               
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // if (!string.IsNullOrEmpty(Properties.Settings.Default.Username))
            // {
            //     txtUsername.Text = Properties.Settings.Default.Username;
            //     txtPassword.Text = Properties.Settings.Default.Password;
            // }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
