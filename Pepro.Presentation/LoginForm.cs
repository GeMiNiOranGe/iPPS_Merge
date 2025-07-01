using Pepro.Business;
using Pepro.DTOs;
using Pepro.Presentation.Controls;
using Svg;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Pepro.Presentation;

public partial class LoginForm : PeproForm {
    private readonly SvgColourServer textIconColor = new(ThemeColors.Text);
    private string _accountName = "";

    public LoginForm() {
        InitializeComponent();

        signinButton.FlatAppearance.MouseDownBackColor = ThemeColors.Secondary.Dark;
        signinButton.FlatAppearance.MouseOverBackColor = ThemeColors.Secondary.Light;

        passwordPictureBox.BackgroundImage = IconProvider.GetIcon(
            "EyeClosed",
            colorServer: textIconColor
        );
        logoPictureBox.BackgroundImage = IconProvider.GetLogo();
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string AccountName {
        get => _accountName;
        private set => _accountName = value;
    }

    private void LoginButton_Click(object sender, EventArgs e) {
        string accountName = accountNameTextBox.Text;
        string password = passwordTextBox.Text;

        try
        {
            LoginStatus status = AccountBusiness.Instance.GetLoginStatus(accountName, password);

            switch (status) {
            case LoginStatus.Success:
                _accountName = accountName;
                DialogResult = DialogResult.OK;
                Close();
                break;
            case LoginStatus.InvalidInput:
                errorLabel.Text = "Tên người dùng và mật khẩu không được để trống!";
                break;
            case LoginStatus.InvalidAccount:
                errorLabel.Text = "Tên người dùng hoặc mật khẩu sai!";
                break;
            case LoginStatus.LockedAccount:
                errorLabel.Text = "Tài khoản của bạn đã bị khóa!";
                break;
            }
        }
        catch (Exception ex)
        {
            errorLabel.Text = "Đã xảy ra lỗi trong quá trình đăng nhập!";
            MessageBox.Show(ex.Message);
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
        accountNamePanel.BackColor = ThemeColors.Secondary.Base;
    }

    private void AccountNameTextBox_Leave(object sender, EventArgs e) {
        accountNamePanel.BackColor = ThemeColors.Text ;
    }

    private void PasswordTextBox_Enter(object sender, EventArgs e) {
        passwordPanel.BackColor = ThemeColors.Secondary.Base;
    }

    private void PasswordTextBox_Leave(object sender, EventArgs e) {
        passwordPanel.BackColor = ThemeColors.Text;
    }

    private void PasswordPictureBox_Click(object sender, EventArgs e) {
        if (passwordTextBox.UseSystemPasswordChar) {
            passwordTextBox.UseSystemPasswordChar = false;
            passwordPictureBox.BackgroundImage = IconProvider.GetIcon(
                "Eye",
                colorServer: textIconColor
            );
        }
        else {
            passwordTextBox.UseSystemPasswordChar = true;
            passwordPictureBox.BackgroundImage = IconProvider.GetIcon(
                "EyeClosed",
                colorServer: textIconColor
            );
        }
    }

    private void ClosePictureBox_Click(object sender, EventArgs e) {
        Close();
    }
}
