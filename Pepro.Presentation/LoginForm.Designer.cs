
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
            signinButton = new Button();
            errorLabel = new Label();
            accountNamePanel = new Panel();
            passwordPanel = new Panel();
            closeButton = new Button();
            showPasswordButton = new Button();
            illustrationPictureBox = new PictureBox();
            welcomeLabel = new Label();
            accountNameLabel = new Label();
            passwordLabel = new Label();
            logoPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)illustrationPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // accountNameTextBox
            // 
            accountNameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            accountNameTextBox.BackColor = Color.FromArgb(29, 29, 29);
            accountNameTextBox.BorderStyle = BorderStyle.None;
            accountNameTextBox.ForeColor = Color.White;
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
            appNameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            appNameLabel.ForeColor = Color.White;
            appNameLabel.Location = new Point(48, 48);
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
            passwordTextBox.ForeColor = Color.White;
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
            // signinButton
            // 
            signinButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            signinButton.BackColor = Color.BlueViolet;
            signinButton.Cursor = Cursors.Hand;
            signinButton.FlatAppearance.BorderSize = 0;
            signinButton.FlatStyle = FlatStyle.Flat;
            signinButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            signinButton.ForeColor = Color.White;
            signinButton.Location = new Point(25, 367);
            signinButton.Margin = new Padding(16);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(256, 37);
            signinButton.TabIndex = 1;
            signinButton.Text = "Sign in";
            signinButton.UseVisualStyleBackColor = false;
            signinButton.Click += LoginButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            errorLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(22, 307);
            errorLabel.Margin = new Padding(16, 4, 16, 8);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(259, 48);
            errorLabel.TabIndex = 0;
            errorLabel.TextAlign = ContentAlignment.BottomLeft;
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
            accountNamePanel.MouseDown += LoginForm_MouseDown;
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
            passwordPanel.MouseDown += LoginForm_MouseDown;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Location = new Point(768, 0);
            closeButton.Margin = new Padding(0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(32, 32);
            closeButton.TabIndex = 0;
            closeButton.TabStop = false;
            closeButton.Click += ClosePictureBox_Click;
            // 
            // showPasswordButton
            // 
            showPasswordButton.Anchor = AnchorStyles.Right;
            showPasswordButton.Cursor = Cursors.Hand;
            showPasswordButton.Location = new Point(257, 263);
            showPasswordButton.Margin = new Padding(0);
            showPasswordButton.Name = "showPasswordButton";
            showPasswordButton.Size = new Size(24, 24);
            showPasswordButton.TabIndex = 0;
            showPasswordButton.TabStop = false;
            showPasswordButton.Click += PasswordPictureBox_Click;
            // 
            // illustrationPictureBox
            // 
            illustrationPictureBox.Dock = DockStyle.Right;
            illustrationPictureBox.Location = new Point(300, 0);
            illustrationPictureBox.Name = "illustrationPictureBox";
            illustrationPictureBox.Size = new Size(500, 480);
            illustrationPictureBox.TabIndex = 0;
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
            accountNameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            accountNameLabel.ForeColor = Color.White;
            accountNameLabel.Location = new Point(22, 152);
            accountNameLabel.Margin = new Padding(0);
            accountNameLabel.Name = "accountNameLabel";
            accountNameLabel.Size = new Size(183, 19);
            accountNameLabel.TabIndex = 0;
            accountNameLabel.Text = "Username or employee id";
            accountNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            accountNameLabel.MouseDown += LoginForm_MouseDown;
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Location = new Point(22, 243);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(73, 19);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "Password";
            passwordLabel.MouseDown += LoginForm_MouseDown;
            // 
            // logoPictureBox
            // 
            logoPictureBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            logoPictureBox.Location = new Point(25, 45);
            logoPictureBox.Margin = new Padding(0);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(24, 24);
            logoPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            logoPictureBox.TabIndex = 0;
            logoPictureBox.TabStop = false;
            logoPictureBox.MouseDown += LoginForm_MouseDown;
            // 
            // LoginForm
            // 
            AcceptButton = signinButton;
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 29);
            ClientSize = new Size(800, 480);
            Controls.Add(passwordLabel);
            Controls.Add(accountNameLabel);
            Controls.Add(welcomeLabel);
            Controls.Add(closeButton);
            Controls.Add(passwordPanel);
            Controls.Add(accountNamePanel);
            Controls.Add(logoPictureBox);
            Controls.Add(showPasswordButton);
            Controls.Add(passwordTextBox);
            Controls.Add(accountNameTextBox);
            Controls.Add(errorLabel);
            Controls.Add(signinButton);
            Controls.Add(appNameLabel);
            Controls.Add(illustrationPictureBox);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            MouseDown += LoginForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)illustrationPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox accountNameTextBox;
        private Label appNameLabel;
        private TextBox passwordTextBox;
        private Button signinButton;
        private Label errorLabel;
        private Button showPasswordButton;
        private Panel accountNamePanel;
        private Panel passwordPanel;
        private Button closeButton;
        private PictureBox illustrationPictureBox;
        private Label welcomeLabel;
        private Label accountNameLabel;
        private Label passwordLabel;
        private PictureBox logoPictureBox;
    }
}

