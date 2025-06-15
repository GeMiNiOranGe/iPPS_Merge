using Pepro.Business;
using Pepro.DTOs;

namespace Pepro.Presentation;

public partial class FormLogin : Form {
    public FormLogin() {
        InitializeComponent();
        ForTextbox.SetPlaceHolder(TxtUserId, AccountBusiness.USER_ID_PLACEHOLDER);
        ForTextbox.SetPlaceHolder(TxtPassword, AccountBusiness.PASSWORD_PLACEHOLDER);
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

    private void BtnLogin_Click(object sender, EventArgs e) {
        string accountName = TxtUserId.Text;
        string password = TxtPassword.Text;

        LoginStatus status = AccountBusiness.Instance.GetLoginStatus(accountName, password);

        switch (status) {
        case LoginStatus.Success:
            LbError.Text = "Đăng nhập thành công!";
            FormMenu formMenu = new()
            {
                UserId = TxtUserId.Text
            };
            formMenu.Show();
            Hide();
            break;
        case LoginStatus.InvalidInput:
            LbError.Text = "ID người dùng và mật khẩu không được để trống!";
            break;
        case LoginStatus.InvalidAccount:
            LbError.Text = "ID người dùng hoặc mật khẩu sai!";
            break;
        case LoginStatus.LockedAccount:
            LbError.Text = "Tài khoản của bạn đã bị khóa!";
            break;
        case LoginStatus.OtherError:
            LbError.Text = "Đã xảy ra lỗi trong quá trình đăng nhập!";
            break;
        }
        TxtUserId.Text = AccountBusiness.USER_ID_PLACEHOLDER;
        TxtPassword.Text = AccountBusiness.PASSWORD_PLACEHOLDER;
        TxtUserId.ForeColor = Color.Gray;
        TxtPassword.ForeColor = Color.Gray;
        TxtPassword.UseSystemPasswordChar = false;
        TxtUserId.Focus();
    }

    private void TxtPassword_Enter(object sender, EventArgs e) {
        if (TxtPassword.Text == AccountBusiness.PASSWORD_PLACEHOLDER) {
            TextBox textBox = (TextBox)sender;
            TxtPassword.UseSystemPasswordChar = true;
            textBox.ForeColor = Color.FromArgb(248, 245, 168);
        }
    }

    private void TxtPassword_Leave(object sender, EventArgs e) {
        if (TxtPassword.Text == AccountBusiness.PASSWORD_PLACEHOLDER)
            TxtPassword.UseSystemPasswordChar = false;
    }

    private void TxtUserId_Click(object sender, EventArgs e) {
        PictureUserID.BackgroundImage = Properties.Resources.UserYellow;
        panel1.BackColor = Color.FromArgb(248, 245, 168);
        if (TxtPassword.UseSystemPasswordChar == true) {
            PicturePassWord.BackgroundImage = Properties.Resources.CloseLockWhite;
            panel2.BackColor = Color.White;
        }
        else {
            PicturePassWord.BackgroundImage = Properties.Resources.OpenLockWhite;
            panel2.BackColor = Color.White;
        }
    }

    private void TxtPassword_Click(object sender, EventArgs e) {
        PictureUserID.BackgroundImage = Properties.Resources.UserWhite;
        panel1.BackColor = Color.White;

        if (TxtPassword.UseSystemPasswordChar == true) {
            PicturePassWord.BackgroundImage = Properties.Resources.CloseLockYellow;
            panel2.BackColor = Color.FromArgb(248, 245, 168);
        }
        else {
            PicturePassWord.BackgroundImage = Properties.Resources.OpenLockYellow;
            panel2.BackColor = Color.FromArgb(248, 245, 168);
        }
    }

    private void PicturePassWord_Click(object sender, EventArgs e) {
        if (TxtPassword.UseSystemPasswordChar == true && panel2.BackColor == Color.FromArgb(248, 245, 168)) {
            TxtPassword.UseSystemPasswordChar = false;
            PicturePassWord.BackgroundImage = Properties.Resources.OpenLockYellow;
        }
        else if (TxtPassword.UseSystemPasswordChar == false && panel2.BackColor == Color.FromArgb(248, 245, 168)) {
            TxtPassword.UseSystemPasswordChar = true;
            PicturePassWord.BackgroundImage = Properties.Resources.CloseLockYellow;
        }
        else if (TxtPassword.UseSystemPasswordChar == true && panel2.BackColor == Color.White) {
            TxtPassword.UseSystemPasswordChar = false;
            PicturePassWord.BackgroundImage = Properties.Resources.OpenLockWhite;
        }
        else {
            TxtPassword.UseSystemPasswordChar = true;
            PicturePassWord.BackgroundImage = Properties.Resources.CloseLockWhite;
        }
    }

    private void PcbClose_Click(object sender, EventArgs e) {
        Application.Exit();
    }
}
