using Pepro.Business;
using Pepro.DTOs;
using Svg;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Pepro.Presentation;

public partial class LoginForm : Form {
    private readonly SvgColourServer passwordIconColor = new(Color.White);
    private string _accountName = "";

    public LoginForm() {
        InitializeComponent();

        passwordPictureBox.BackgroundImage = IconProvider.GetIcon(
            "EyeClosed",
            colorServer: passwordIconColor
        );
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string AccountName {
        get => _accountName;
        private set => _accountName = value;
    }

    /* 
    private void BtnSignIn_Click(object sender, EventArgs e)
    {
        LoginStatus loginStatus = LoginStatus.None;
        try
        {
            loginStatus = AccountBusiness.Instance.GetLoginStatus(TxtUserId.Text, TxtPassword.Text);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

        switch (loginStatus)
        {
        case LoginStatus.Success:
            FormDashboard formDashboard = new()
            {
                RootForm = this
            };
            formDashboard.Show();
            Hide();
            break;
        case LoginStatus.InvalidInput:
            //lblError.Text = "Tên tài khoản và mật khẩu không được để trống!";
            break;
        case LoginStatus.InvalidAccount:
            //lblError.Text = "Tên tài khoản hoặc mật khẩu sai!";
            break;
        case LoginStatus.OtherError:
            //lblError.Text = "Đã xảy ra lỗi trong quá trình đăng nhập!";
            break;
        }
    }
     */

    private void LoginButton_Click(object sender, EventArgs e) {
        string accountName = accountNameTextBox.Text;
        string password = passwordTextBox.Text;

        LoginStatus status = AccountBusiness.Instance.GetLoginStatus(accountName, password);

        switch (status) {
        case LoginStatus.Success:
            _accountName = accountName;
            DialogResult = DialogResult.OK;
            Close();
            break;
        case LoginStatus.InvalidInput:
            errorLabel.Text = "ID người dùng và mật khẩu không được để trống!";
            break;
        case LoginStatus.InvalidAccount:
            errorLabel.Text = "ID người dùng hoặc mật khẩu sai!";
            break;
        case LoginStatus.LockedAccount:
            errorLabel.Text = "Tài khoản của bạn đã bị khóa!";
            break;
        case LoginStatus.OtherError:
            errorLabel.Text = "Đã xảy ra lỗi trong quá trình đăng nhập!";
            break;
        }
        accountNameTextBox.Clear();
        passwordTextBox.Clear();
        accountNameTextBox.Focus();
    }

    public const int WM_NCLBUTTONDOWN = 0xA1;
    public const int HT_CAPTION = 0x2;

    [DllImport("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
    [DllImport("user32.dll")]
    public static extern bool ReleaseCapture();

    private void LoginForm_MouseDown(object sender, MouseEventArgs e) {
        if (e.Button == MouseButtons.Left) {
            ReleaseCapture();
            _ = SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }

    private void AccountNameTextBox_Enter(object sender, EventArgs e) {
        accountNameTextBox.ForeColor = Color.FromArgb(248, 245, 168);
        accountNamePanel.BackColor = Color.FromArgb(248, 245, 168);
    }

    private void AccountNameTextBox_Leave(object sender, EventArgs e) {
        accountNameTextBox.ForeColor = Color.White;
        accountNamePanel.BackColor = Color.White;
    }

    private void PasswordTextBox_Enter(object sender, EventArgs e) {
        passwordTextBox.ForeColor = Color.FromArgb(248, 245, 168);
        passwordPanel.BackColor = Color.FromArgb(248, 245, 168);
    }

    private void PasswordTextBox_Leave(object sender, EventArgs e) {
        passwordTextBox.ForeColor = Color.White;
        passwordPanel.BackColor = Color.White;
    }

    private void PasswordPictureBox_Click(object sender, EventArgs e) {
        if (passwordTextBox.UseSystemPasswordChar) {
            passwordTextBox.UseSystemPasswordChar = false;
            passwordPictureBox.BackgroundImage = IconProvider.GetIcon(
                "Eye",
                colorServer: passwordIconColor
            );
        }
        else {
            passwordTextBox.UseSystemPasswordChar = true;
            passwordPictureBox.BackgroundImage = IconProvider.GetIcon(
                "EyeClosed",
                colorServer: passwordIconColor
            );
        }
    }

    private void ClosePictureBox_Click(object sender, EventArgs e) {
        Close();
    }
}
