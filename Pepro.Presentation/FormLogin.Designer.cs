
namespace Pepro.Presentation {
    partial class FormLogin {
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
            TxtUserId = new TextBox();
            LbAppName = new Label();
            TxtPassword = new TextBox();
            BtnLogin = new Button();
            LbError = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            PcbClose = new PictureBox();
            PicturePassWord = new PictureBox();
            PictureUserID = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PcbClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PicturePassWord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureUserID).BeginInit();
            SuspendLayout();
            // 
            // TxtUserId
            // 
            TxtUserId.Anchor = AnchorStyles.None;
            TxtUserId.BackColor = Color.FromArgb(29, 29, 29);
            TxtUserId.BorderStyle = BorderStyle.None;
            TxtUserId.ForeColor = Color.Gray;
            TxtUserId.Location = new Point(108, 89);
            TxtUserId.Margin = new Padding(4, 6, 4, 6);
            TxtUserId.Name = "TxtUserId";
            TxtUserId.Size = new Size(305, 24);
            TxtUserId.TabIndex = 2;
            TxtUserId.Click += TxtUserId_Click;
            // 
            // LbAppName
            // 
            LbAppName.Dock = DockStyle.Top;
            LbAppName.Font = new Font("Segoe UI", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbAppName.ForeColor = Color.FromArgb(248, 245, 168);
            LbAppName.Location = new Point(0, 0);
            LbAppName.Name = "LbAppName";
            LbAppName.Size = new Size(468, 59);
            LbAppName.TabIndex = 0;
            LbAppName.Text = "iPPS Ver.0";
            LbAppName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TxtPassword
            // 
            TxtPassword.Anchor = AnchorStyles.None;
            TxtPassword.BackColor = Color.FromArgb(29, 29, 29);
            TxtPassword.BorderStyle = BorderStyle.None;
            TxtPassword.ForeColor = Color.Gray;
            TxtPassword.Location = new Point(108, 164);
            TxtPassword.Margin = new Padding(4, 6, 4, 6);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(305, 24);
            TxtPassword.TabIndex = 3;
            TxtPassword.Click += TxtPassword_Click;
            TxtPassword.Enter += TxtPassword_Enter;
            TxtPassword.Leave += TxtPassword_Leave;
            // 
            // BtnLogin
            // 
            BtnLogin.Anchor = AnchorStyles.None;
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.Location = new Point(49, 250);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(364, 49);
            BtnLogin.TabIndex = 1;
            BtnLogin.Text = "Đăng nhập";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // LbError
            // 
            LbError.Anchor = AnchorStyles.None;
            LbError.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbError.ForeColor = Color.Red;
            LbError.Location = new Point(49, 217);
            LbError.Name = "LbError";
            LbError.Size = new Size(364, 30);
            LbError.TabIndex = 3;
            LbError.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(49, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 1);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(49, 207);
            panel2.Name = "panel2";
            panel2.Size = new Size(362, 1);
            panel2.TabIndex = 7;
            // 
            // PcbClose
            // 
            PcbClose.Image = Properties.Resources.CloseCircleFill;
            PcbClose.Location = new Point(422, 14);
            PcbClose.Margin = new Padding(5);
            PcbClose.Name = "PcbClose";
            PcbClose.Size = new Size(32, 32);
            PcbClose.TabIndex = 9;
            PcbClose.TabStop = false;
            PcbClose.Click += PcbClose_Click;
            // 
            // PicturePassWord
            // 
            PicturePassWord.BackgroundImage = Properties.Resources.CloseLockWhite;
            PicturePassWord.BackgroundImageLayout = ImageLayout.Zoom;
            PicturePassWord.Location = new Point(49, 151);
            PicturePassWord.Name = "PicturePassWord";
            PicturePassWord.Size = new Size(52, 50);
            PicturePassWord.TabIndex = 5;
            PicturePassWord.TabStop = false;
            PicturePassWord.Click += PicturePassWord_Click;
            // 
            // PictureUserID
            // 
            PictureUserID.BackgroundImage = Properties.Resources.UserWhite;
            PictureUserID.BackgroundImageLayout = ImageLayout.Zoom;
            PictureUserID.Location = new Point(49, 76);
            PictureUserID.Name = "PictureUserID";
            PictureUserID.Size = new Size(52, 50);
            PictureUserID.TabIndex = 4;
            PictureUserID.TabStop = false;
            // 
            // FormLogin
            // 
            AcceptButton = BtnLogin;
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 29);
            ClientSize = new Size(468, 311);
            Controls.Add(PcbClose);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(PicturePassWord);
            Controls.Add(PictureUserID);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUserId);
            Controls.Add(LbError);
            Controls.Add(BtnLogin);
            Controls.Add(LbAppName);
            Font = new Font("Segoe UI", 13.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 6, 4, 6);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)PcbClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)PicturePassWord).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureUserID).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox TxtUserId;
        private Label LbAppName;
        private TextBox TxtPassword;
        private Button BtnLogin;
        private Label LbError;
        private PictureBox PictureUserID;
        private PictureBox PicturePassWord;
        private Panel panel1;
        private Panel panel2;
        private PictureBox PcbClose;
    }
}

