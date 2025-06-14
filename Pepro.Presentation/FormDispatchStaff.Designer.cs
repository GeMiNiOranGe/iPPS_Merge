namespace Pepro.Presentation
{
    partial class FormDispatchStaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            label1 = new Label();
            txtSoQuyetDinh = new TextBox();
            txtNguoiKy = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            cbChucVu = new ComboBox();
            txtMaCV = new TextBox();
            txtMaPBHT = new TextBox();
            txtMaPBTC = new TextBox();
            cbPhongBanTC = new ComboBox();
            btnAdd = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(161, 94);
            label1.Name = "label1";
            label1.Size = new Size(107, 19);
            label1.TabIndex = 0;
            label1.Text = "Số quyết định";
            // 
            // txtSoQuyetDinh
            // 
            txtSoQuyetDinh.Enabled = false;
            txtSoQuyetDinh.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoQuyetDinh.Location = new Point(295, 91);
            txtSoQuyetDinh.Name = "txtSoQuyetDinh";
            txtSoQuyetDinh.ReadOnly = true;
            txtSoQuyetDinh.Size = new Size(190, 27);
            txtSoQuyetDinh.TabIndex = 1;
            // 
            // txtNguoiKy
            // 
            txtNguoiKy.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNguoiKy.Location = new Point(295, 143);
            txtNguoiKy.Name = "txtNguoiKy";
            txtNguoiKy.Size = new Size(190, 27);
            txtNguoiKy.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(166, 146);
            label2.Name = "label2";
            label2.Size = new Size(103, 19);
            label2.TabIndex = 2;
            label2.Text = "Tên người ký";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(114, 23);
            label3.Name = "label3";
            label3.Size = new Size(293, 27);
            label3.TabIndex = 4;
            label3.Text = "Thuyên chuyển nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(138, 199);
            label4.Name = "label4";
            label4.Size = new Size(130, 19);
            label4.TabIndex = 5;
            label4.Text = "Chức vụ người kí";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(66, 356);
            label6.Name = "label6";
            label6.Size = new Size(193, 19);
            label6.TabIndex = 7;
            label6.Text = "Phòng ban thuyên chuyển";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(180, 251);
            label7.Name = "label7";
            label7.Size = new Size(89, 19);
            label7.TabIndex = 8;
            label7.Text = "Mã chức vụ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(94, 304);
            label8.Name = "label8";
            label8.Size = new Size(167, 19);
            label8.TabIndex = 9;
            label8.Text = "Mã phòng ban hiện tại";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(38, 409);
            label9.Name = "label9";
            label9.Size = new Size(218, 19);
            label9.TabIndex = 10;
            label9.Text = "Mã phòng ban thuyên chuyển";
            // 
            // cbChucVu
            // 
            cbChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChucVu.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbChucVu.FormattingEnabled = true;
            cbChucVu.Location = new Point(295, 196);
            cbChucVu.Name = "cbChucVu";
            cbChucVu.Size = new Size(190, 27);
            cbChucVu.TabIndex = 11;
            cbChucVu.SelectedIndexChanged += cbChucVu_SelectedIndexChanged;
            // 
            // txtMaCV
            // 
            txtMaCV.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaCV.Location = new Point(295, 248);
            txtMaCV.Name = "txtMaCV";
            txtMaCV.ReadOnly = true;
            txtMaCV.Size = new Size(190, 27);
            txtMaCV.TabIndex = 12;
            // 
            // txtMaPBHT
            // 
            txtMaPBHT.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaPBHT.Location = new Point(295, 301);
            txtMaPBHT.Name = "txtMaPBHT";
            txtMaPBHT.ReadOnly = true;
            txtMaPBHT.Size = new Size(190, 27);
            txtMaPBHT.TabIndex = 13;
            // 
            // txtMaPBTC
            // 
            txtMaPBTC.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaPBTC.Location = new Point(295, 406);
            txtMaPBTC.Name = "txtMaPBTC";
            txtMaPBTC.ReadOnly = true;
            txtMaPBTC.Size = new Size(190, 27);
            txtMaPBTC.TabIndex = 14;
            // 
            // cbPhongBanTC
            // 
            cbPhongBanTC.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPhongBanTC.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPhongBanTC.FormattingEnabled = true;
            cbPhongBanTC.Location = new Point(295, 353);
            cbPhongBanTC.Name = "cbPhongBanTC";
            cbPhongBanTC.Size = new Size(190, 27);
            cbPhongBanTC.TabIndex = 16;
            cbPhongBanTC.SelectedIndexChanged += cbPhongBanTC_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 96, 0);
            btnAdd.DialogResult = DialogResult.OK;
            btnAdd.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(209, 461);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(122, 48);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 230, 199);
            btnExit.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(500, -1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(26, 28);
            btnExit.TabIndex = 103;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // FormDispatchStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 230, 199);
            ClientSize = new Size(523, 538);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Controls.Add(cbPhongBanTC);
            Controls.Add(txtMaPBTC);
            Controls.Add(txtMaPBHT);
            Controls.Add(txtMaCV);
            Controls.Add(cbChucVu);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNguoiKy);
            Controls.Add(label2);
            Controls.Add(txtSoQuyetDinh);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDispatchStaff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDispatchStaff";
            Load += FormDispatchStaff_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtSoQuyetDinh;
        private TextBox txtNguoiKy;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox cbChucVu;
        private TextBox txtMaCV;
        private TextBox txtMaPBHT;
        private TextBox txtMaPBTC;
        private ComboBox cbPhongBanTC;
        private Button btnAdd;
        private Button btnExit;
    }
}