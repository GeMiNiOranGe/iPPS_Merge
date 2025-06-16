using Pepro.Business;
using Pepro.DTOs;
using System.ComponentModel;

namespace Pepro.Presentation;

public partial class FormLogin : Form {
    private string _accountName = "";

    public FormLogin() {
        InitializeComponent();
        ForTextbox.SetPlaceHolder(accountNameTextBox, AccountBusiness.USER_ID_PLACEHOLDER);
        ForTextbox.SetPlaceHolder(passwordTextBox, AccountBusiness.PASSWORD_PLACEHOLDER);
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
            AccountName = accountName;
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
        accountNameTextBox.Text = AccountBusiness.USER_ID_PLACEHOLDER;
        passwordTextBox.Text = AccountBusiness.PASSWORD_PLACEHOLDER;
        accountNameTextBox.ForeColor = Color.Gray;
        passwordTextBox.ForeColor = Color.Gray;
        passwordTextBox.UseSystemPasswordChar = false;
        accountNameTextBox.Focus();
    }

    private void PasswordTextBox_Enter(object sender, EventArgs e) {
        if (passwordTextBox.Text == AccountBusiness.PASSWORD_PLACEHOLDER) {
            TextBox textBox = (TextBox)sender;
            passwordTextBox.UseSystemPasswordChar = true;
            textBox.ForeColor = Color.FromArgb(248, 245, 168);
        }
    }

    private void PasswordTextBox_Leave(object sender, EventArgs e) {
        if (passwordTextBox.Text == AccountBusiness.PASSWORD_PLACEHOLDER)
            passwordTextBox.UseSystemPasswordChar = false;
    }

    private void AccountNameTextBox_Click(object sender, EventArgs e) {
        accountNamePictureBox.BackgroundImage = Properties.Resources.UserYellow;
        accountNamePanel.BackColor = Color.FromArgb(248, 245, 168);
        if (passwordTextBox.UseSystemPasswordChar == true) {
            passwordPictureBox.BackgroundImage = Properties.Resources.CloseLockWhite;
            passwordPanel.BackColor = Color.White;
        }
        else {
            passwordPictureBox.BackgroundImage = Properties.Resources.OpenLockWhite;
            passwordPanel.BackColor = Color.White;
        }
    }

    private void PasswordTextBox_Click(object sender, EventArgs e) {
        accountNamePictureBox.BackgroundImage = Properties.Resources.UserWhite;
        accountNamePanel.BackColor = Color.White;

        if (passwordTextBox.UseSystemPasswordChar == true) {
            passwordPictureBox.BackgroundImage = Properties.Resources.CloseLockYellow;
            passwordPanel.BackColor = Color.FromArgb(248, 245, 168);
        }
        else {
            passwordPictureBox.BackgroundImage = Properties.Resources.OpenLockYellow;
            passwordPanel.BackColor = Color.FromArgb(248, 245, 168);
        }
    }

    private void PasswordPictureBox_Click(object sender, EventArgs e) {
        if (passwordTextBox.UseSystemPasswordChar == true && passwordPanel.BackColor == Color.FromArgb(248, 245, 168)) {
            passwordTextBox.UseSystemPasswordChar = false;
            passwordPictureBox.BackgroundImage = Properties.Resources.OpenLockYellow;
        }
        else if (passwordTextBox.UseSystemPasswordChar == false && passwordPanel.BackColor == Color.FromArgb(248, 245, 168)) {
            passwordTextBox.UseSystemPasswordChar = true;
            passwordPictureBox.BackgroundImage = Properties.Resources.CloseLockYellow;
        }
        else if (passwordTextBox.UseSystemPasswordChar == true && passwordPanel.BackColor == Color.White) {
            passwordTextBox.UseSystemPasswordChar = false;
            passwordPictureBox.BackgroundImage = Properties.Resources.OpenLockWhite;
        }
        else {
            passwordTextBox.UseSystemPasswordChar = true;
            passwordPictureBox.BackgroundImage = Properties.Resources.CloseLockWhite;
        }
    }

    private void ClosePictureBox_Click(object sender, EventArgs e) {
        Close();
    }
}
