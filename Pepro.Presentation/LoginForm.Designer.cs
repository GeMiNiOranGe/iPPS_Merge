
namespace Pepro.Presentation {
    partial class LoginForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            accountNameTextBox = new TextBox();
            appNameLabel = new Label();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            errorLabel = new Label();
            accountNamePanel = new Panel();
            passwordPanel = new Panel();
            closePictureBox = new PictureBox();
            passwordPictureBox = new PictureBox();
            illustrationPictureBox = new PictureBox();
            welcomeLabel = new Label();
            accountNameLabel = new Label();
            passwordLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)closePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)illustrationPictureBox).BeginInit();
            SuspendLayout();
            // 
            // accountNameTextBox
            // 
            accountNameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            accountNameTextBox.BackColor = Color.FromArgb(29, 29, 29);
            accountNameTextBox.BorderStyle = BorderStyle.None;
            accountNameTextBox.Location = new Point(25, 180);
            accountNameTextBox.Margin = new Padding(16, 4, 16, 8);
            accountNameTextBox.Name = "accountNameTextBox";
            accountNameTextBox.PlaceholderText = "employee.here";
            accountNameTextBox.Size = new Size(256, 19);
            accountNameTextBox.TabIndex = 2;
            accountNameTextBox.Enter += AccountNameTextBox_Enter;
            accountNameTextBox.Leave += AccountNameTextBox_Leave;
            // 
            // appNameLabel
            // 
            appNameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            appNameLabel.AutoSize = true;
            appNameLabel.ForeColor = Color.BlueViolet;
            appNameLabel.Location = new Point(22, 48);
            appNameLabel.Margin = new Padding(0, 0, 0, 8);
            appNameLabel.Name = "appNameLabel";
            appNameLabel.Size = new Size(50, 19);
            appNameLabel.TabIndex = 0;
            appNameLabel.Text = "Pepro";
            appNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            appNameLabel.MouseDown += LoginForm_MouseDown;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.BackColor = Color.FromArgb(29, 29, 29);
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Location = new Point(25, 266);
            passwordTextBox.Margin = new Padding(16, 4, 4, 8);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "employee@123";
            passwordTextBox.Size = new Size(228, 19);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.Enter += PasswordTextBox_Enter;
            passwordTextBox.Leave += PasswordTextBox_Leave;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            loginButton.BackColor = Color.BlueViolet;
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(138, 3, 226);
            loginButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(138, 63, 226);
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(25, 367);
            loginButton.Margin = new Padding(16);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(256, 37);
            loginButton.TabIndex = 1;
            loginButton.Text = "Sign in";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += LoginButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(22, 307);
            errorLabel.Margin = new Padding(16, 4, 16, 8);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(259, 22);
            errorLabel.TabIndex = 0;
            errorLabel.TextAlign = ContentAlignment.MiddleLeft;
            errorLabel.MouseDown += LoginForm_MouseDown;
            // 
            // accountNamePanel
            // 
            accountNamePanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            accountNamePanel.BackColor = Color.White;
            accountNamePanel.Location = new Point(25, 209);
            accountNamePanel.Margin = new Padding(16, 0, 16, 32);
            accountNamePanel.Name = "accountNamePanel";
            accountNamePanel.Size = new Size(256, 2);
            accountNamePanel.TabIndex = 0;
            // 
            // passwordPanel
            // 
            passwordPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passwordPanel.BackColor = Color.White;
            passwordPanel.Location = new Point(25, 293);
            passwordPanel.Margin = new Padding(16, 0, 16, 8);
            passwordPanel.Name = "passwordPanel";
            passwordPanel.Size = new Size(256, 2);
            passwordPanel.TabIndex = 0;
            // 
            // closePictureBox
            // 
            closePictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closePictureBox.Image = Properties.Resources.CloseCircleFill;
            closePictureBox.Location = new Point(756, 12);
            closePictureBox.Name = "closePictureBox";
            closePictureBox.Size = new Size(32, 32);
            closePictureBox.TabIndex = 9;
            closePictureBox.TabStop = false;
            closePictureBox.Click += ClosePictureBox_Click;
            // 
            // passwordPictureBox
            // 
            passwordPictureBox.Anchor = AnchorStyles.Right;
            passwordPictureBox.BackgroundImage = Properties.Resources.CloseLockWhite;
            passwordPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            passwordPictureBox.Location = new Point(257, 263);
            passwordPictureBox.Margin = new Padding(0);
            passwordPictureBox.Name = "passwordPictureBox";
            passwordPictureBox.Size = new Size(24, 24);
            passwordPictureBox.TabIndex = 5;
            passwordPictureBox.TabStop = false;
            passwordPictureBox.Click += PasswordPictureBox_Click;
            // 
            // illustrationPictureBox
            // 
            illustrationPictureBox.Dock = DockStyle.Right;
            illustrationPictureBox.Location = new Point(300, 0);
            illustrationPictureBox.Name = "illustrationPictureBox";
            illustrationPictureBox.Size = new Size(500, 480);
            illustrationPictureBox.TabIndex = 10;
            illustrationPictureBox.TabStop = false;
            illustrationPictureBox.MouseDown += LoginForm_MouseDown;
            // 
            // welcomeLabel
            // 
            welcomeLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            welcomeLabel.ForeColor = Color.White;
            welcomeLabel.Location = new Point(22, 75);
            welcomeLabel.Margin = new Padding(0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(179, 32);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome back";
            welcomeLabel.MouseDown += LoginForm_MouseDown;
            // 
            // accountNameLabel
            // 
            accountNameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            accountNameLabel.AutoSize = true;
            accountNameLabel.ForeColor = Color.White;
            accountNameLabel.Location = new Point(22, 152);
            accountNameLabel.Margin = new Padding(0);
            accountNameLabel.Name = "accountNameLabel";
            accountNameLabel.Size = new Size(183, 19);
            accountNameLabel.TabIndex = 0;
            accountNameLabel.Text = "Username or employee id";
            accountNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Location = new Point(22, 243);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(73, 19);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "Password";
            // 
            // LoginForm
            // 
            AcceptButton = loginButton;
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 29);
            ClientSize = new Size(800, 480);
            Controls.Add(passwordLabel);
            Controls.Add(accountNameLabel);
            Controls.Add(welcomeLabel);
            Controls.Add(closePictureBox);
            Controls.Add(passwordPanel);
            Controls.Add(accountNamePanel);
            Controls.Add(passwordPictureBox);
            Controls.Add(passwordTextBox);
            Controls.Add(accountNameTextBox);
            Controls.Add(errorLabel);
            Controls.Add(loginButton);
            Controls.Add(appNameLabel);
            Controls.Add(illustrationPictureBox);
            Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            MouseDown += LoginForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)closePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)illustrationPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox accountNameTextBox;
        private Label appNameLabel;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Label errorLabel;
        private PictureBox passwordPictureBox;
        private Panel accountNamePanel;
        private Panel passwordPanel;
        private PictureBox closePictureBox;
        private PictureBox illustrationPictureBox;
        private Label welcomeLabel;
        private Label accountNameLabel;
        private Label passwordLabel;
    }
}

