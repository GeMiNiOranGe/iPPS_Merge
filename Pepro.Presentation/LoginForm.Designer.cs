using Pepro.Presentation.Controls.Atoms;
using Pepro.Presentation.Controls.Molecules;

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
            logoPictureBox = new PictureBox();
            appNameLabel = new Label();
            welcomeLabel = new PeproLabel();
            accountNameInputField = new PeproInputField();
            passwordField = new PeproPasswordField();
            errorLabel = new PeproLabel();
            signinButton = new Button();
            closeButton = new Button();
            illustrationPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)illustrationPictureBox).BeginInit();
            SuspendLayout();
            // 
            // logoPictureBox
            // 
            logoPictureBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            logoPictureBox.Location = new Point(25, 49);
            logoPictureBox.Margin = new Padding(24, 48, 4, 8);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(24, 24);
            logoPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            logoPictureBox.TabIndex = 0;
            logoPictureBox.TabStop = false;
            logoPictureBox.MouseDown += LoginForm_MouseDown;
            // 
            // appNameLabel
            // 
            appNameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            appNameLabel.AutoSize = true;
            appNameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            appNameLabel.ForeColor = Color.White;
            appNameLabel.Location = new Point(53, 51);
            appNameLabel.Margin = new Padding(0);
            appNameLabel.Name = "appNameLabel";
            appNameLabel.Size = new Size(50, 19);
            appNameLabel.TabIndex = 0;
            appNameLabel.Text = "Pepro";
            appNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            appNameLabel.MouseDown += LoginForm_MouseDown;
            // 
            // welcomeLabel
            // 
            welcomeLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Pixel, 0);
            welcomeLabel.ForeColor = Color.White;
            welcomeLabel.Location = new Point(25, 80);
            welcomeLabel.Margin = new Padding(0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(165, 24);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome back";
            welcomeLabel.MouseDown += LoginForm_MouseDown;
            // 
            // accountNameInputField
            // 
            accountNameInputField.ForeColor = Color.White;
            accountNameInputField.LabelFont = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            accountNameInputField.LabelText = "Username or email";
            accountNameInputField.Location = new Point(25, 173);
            accountNameInputField.Margin = new Padding(24, 0, 0, 24);
            accountNameInputField.Name = "accountNameInputField";
            accountNameInputField.PlaceholderText = "e.g. employee.here";
            accountNameInputField.Size = new Size(275, 48);
            accountNameInputField.TabIndex = 2;
            // 
            // passwordField
            // 
            passwordField.ForeColor = Color.White;
            passwordField.LabelFont = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            passwordField.LabelText = "Password";
            passwordField.Location = new Point(25, 245);
            passwordField.Margin = new Padding(24, 0, 0, 40);
            passwordField.Name = "passwordField";
            passwordField.PlaceholderText = "e.g. employee@123";
            passwordField.Size = new Size(275, 48);
            passwordField.TabIndex = 3;
            // 
            // errorLabel
            // 
            errorLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            errorLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(25, 383);
            errorLabel.Margin = new Padding(24, 8, 0, 48);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(275, 48);
            errorLabel.TabIndex = 0;
            errorLabel.MouseDown += LoginForm_MouseDown;
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
            signinButton.Location = new Point(25, 333);
            signinButton.Margin = new Padding(24, 0, 0, 0);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(275, 42);
            signinButton.TabIndex = 1;
            signinButton.Text = "Sign in";
            signinButton.UseVisualStyleBackColor = false;
            signinButton.Click += LoginButton_Click;
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
            // illustrationPictureBox
            // 
            illustrationPictureBox.Dock = DockStyle.Right;
            illustrationPictureBox.Location = new Point(300, 0);
            illustrationPictureBox.Margin = new Padding(0);
            illustrationPictureBox.Name = "illustrationPictureBox";
            illustrationPictureBox.Size = new Size(500, 480);
            illustrationPictureBox.TabIndex = 0;
            illustrationPictureBox.TabStop = false;
            illustrationPictureBox.MouseDown += LoginForm_MouseDown;
            // 
            // LoginForm
            // 
            AcceptButton = signinButton;
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 29);
            ClientSize = new Size(800, 480);
            Controls.Add(closeButton);
            Controls.Add(illustrationPictureBox);
            Controls.Add(logoPictureBox);
            Controls.Add(appNameLabel);
            Controls.Add(welcomeLabel);
            Controls.Add(accountNameInputField);
            Controls.Add(passwordField);
            Controls.Add(errorLabel);
            Controls.Add(signinButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            MouseDown += LoginForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)illustrationPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Label appNameLabel;
        private Button signinButton;
        private PeproLabel errorLabel;
        private Button closeButton;
        private PictureBox illustrationPictureBox;
        private PeproLabel welcomeLabel;
        private PictureBox logoPictureBox;
        private PeproInputField accountNameInputField;
        private PeproPasswordField passwordField;
    }
}

