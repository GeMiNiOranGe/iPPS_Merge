
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
            accountNamePictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)closePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountNamePictureBox).BeginInit();
            SuspendLayout();
            // 
            // accountNameTextBox
            // 
            accountNameTextBox.Anchor = AnchorStyles.None;
            accountNameTextBox.BackColor = Color.FromArgb(29, 29, 29);
            accountNameTextBox.BorderStyle = BorderStyle.None;
            accountNameTextBox.ForeColor = Color.Gray;
            accountNameTextBox.Location = new Point(108, 89);
            accountNameTextBox.Margin = new Padding(4, 6, 4, 6);
            accountNameTextBox.Name = "accountNameTextBox";
            accountNameTextBox.Size = new Size(305, 24);
            accountNameTextBox.TabIndex = 2;
            accountNameTextBox.Click += AccountNameTextBox_Click;
            // 
            // appNameLabel
            // 
            appNameLabel.Dock = DockStyle.Top;
            appNameLabel.Font = new Font("Segoe UI", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appNameLabel.ForeColor = Color.FromArgb(248, 245, 168);
            appNameLabel.Location = new Point(0, 0);
            appNameLabel.Name = "appNameLabel";
            appNameLabel.Size = new Size(468, 59);
            appNameLabel.TabIndex = 0;
            appNameLabel.Text = "iPPS Ver.0";
            appNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.None;
            passwordTextBox.BackColor = Color.FromArgb(29, 29, 29);
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.ForeColor = Color.Gray;
            passwordTextBox.Location = new Point(108, 164);
            passwordTextBox.Margin = new Padding(4, 6, 4, 6);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(305, 24);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.Click += PasswordTextBox_Click;
            passwordTextBox.Enter += PasswordTextBox_Enter;
            passwordTextBox.Leave += PasswordTextBox_Leave;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.None;
            loginButton.Cursor = Cursors.Hand;
            loginButton.Location = new Point(49, 250);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(364, 49);
            loginButton.TabIndex = 1;
            loginButton.Text = "Đăng nhập";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += LoginButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.Anchor = AnchorStyles.None;
            errorLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(49, 217);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(364, 30);
            errorLabel.TabIndex = 3;
            errorLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // accountNamePanel
            // 
            accountNamePanel.BackColor = Color.White;
            accountNamePanel.Location = new Point(49, 132);
            accountNamePanel.Name = "accountNamePanel";
            accountNamePanel.Size = new Size(362, 1);
            accountNamePanel.TabIndex = 6;
            // 
            // passwordPanel
            // 
            passwordPanel.BackColor = Color.White;
            passwordPanel.Location = new Point(49, 207);
            passwordPanel.Name = "passwordPanel";
            passwordPanel.Size = new Size(362, 1);
            passwordPanel.TabIndex = 7;
            // 
            // closePictureBox
            // 
            closePictureBox.Image = Properties.Resources.CloseCircleFill;
            closePictureBox.Location = new Point(422, 14);
            closePictureBox.Margin = new Padding(5);
            closePictureBox.Name = "closePictureBox";
            closePictureBox.Size = new Size(32, 32);
            closePictureBox.TabIndex = 9;
            closePictureBox.TabStop = false;
            closePictureBox.Click += ClosePictureBox_Click;
            // 
            // passwordPictureBox
            // 
            passwordPictureBox.BackgroundImage = Properties.Resources.CloseLockWhite;
            passwordPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            passwordPictureBox.Location = new Point(49, 151);
            passwordPictureBox.Name = "passwordPictureBox";
            passwordPictureBox.Size = new Size(52, 50);
            passwordPictureBox.TabIndex = 5;
            passwordPictureBox.TabStop = false;
            passwordPictureBox.Click += PasswordPictureBox_Click;
            // 
            // accountNamePictureBox
            // 
            accountNamePictureBox.BackgroundImage = Properties.Resources.UserWhite;
            accountNamePictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            accountNamePictureBox.Location = new Point(49, 76);
            accountNamePictureBox.Name = "accountNamePictureBox";
            accountNamePictureBox.Size = new Size(52, 50);
            accountNamePictureBox.TabIndex = 4;
            accountNamePictureBox.TabStop = false;
            // 
            // LoginForm
            // 
            AcceptButton = loginButton;
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 29);
            ClientSize = new Size(468, 311);
            Controls.Add(closePictureBox);
            Controls.Add(passwordPanel);
            Controls.Add(accountNamePanel);
            Controls.Add(passwordPictureBox);
            Controls.Add(accountNamePictureBox);
            Controls.Add(passwordTextBox);
            Controls.Add(accountNameTextBox);
            Controls.Add(errorLabel);
            Controls.Add(loginButton);
            Controls.Add(appNameLabel);
            Font = new Font("Segoe UI", 13.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 6, 4, 6);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)closePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountNamePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox accountNameTextBox;
        private Label appNameLabel;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Label errorLabel;
        private PictureBox accountNamePictureBox;
        private PictureBox passwordPictureBox;
        private Panel accountNamePanel;
        private Panel passwordPanel;
        private PictureBox closePictureBox;
    }
}

