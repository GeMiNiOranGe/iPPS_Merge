namespace Pepro.Presentation
{
    partial class formTinhLuong
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
            groupBox1 = new GroupBox();
            cbBacLuong = new ComboBox();
            tbPhuCap = new TextBox();
            label5 = new Label();
            tbTienLuong = new TextBox();
            label3 = new Label();
            tbTienNha = new TextBox();
            label10 = new Label();
            dtpkThoiDiem = new DateTimePicker();
            label9 = new Label();
            tbSoNgayCong = new TextBox();
            label7 = new Label();
            label6 = new Label();
            tbLCB = new TextBox();
            label4 = new Label();
            cbMaNV = new ComboBox();
            label1 = new Label();
            dtgvLuongNV = new DataGridView();
            MaNhanVien = new DataGridViewTextBoxColumn();
            LuongCoBan = new DataGridViewTextBoxColumn();
            HeSoBacLuong = new DataGridViewTextBoxColumn();
            Hesophucapchucvu = new DataGridViewTextBoxColumn();
            Songaydilam = new DataGridViewTextBoxColumn();
            Songaynghibhxh = new DataGridViewTextBoxColumn();
            Songaynghikhonglydo = new DataGridViewTextBoxColumn();
            TienNha = new DataGridViewTextBoxColumn();
            TongLuong = new DataGridViewTextBoxColumn();
            Thoidiem = new DataGridViewTextBoxColumn();
            btnTinhLuong = new Button();
            rtbLuong = new RichTextBox();
            btnCapNhat = new Button();
            btnThoat = new Button();
            rtbMaNhanVien = new RichTextBox();
            btnTimKiem = new Button();
            btnHuy = new Button();
            label2 = new Label();
            btnBaoCao = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvLuongNV).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.FromArgb(255, 165, 89);
            groupBox1.Controls.Add(cbBacLuong);
            groupBox1.Controls.Add(tbPhuCap);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbTienLuong);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbTienNha);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(dtpkThoiDiem);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(tbSoNgayCong);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbLCB);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbMaNV);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(64, 88);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(906, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin lương";
            // 
            // cbBacLuong
            // 
            cbBacLuong.Anchor = AnchorStyles.Top;
            cbBacLuong.FormattingEnabled = true;
            cbBacLuong.Location = new Point(433, 30);
            cbBacLuong.Margin = new Padding(4);
            cbBacLuong.Name = "cbBacLuong";
            cbBacLuong.Size = new Size(117, 25);
            cbBacLuong.TabIndex = 23;
            // 
            // tbPhuCap
            // 
            tbPhuCap.Anchor = AnchorStyles.Top;
            tbPhuCap.Location = new Point(433, 114);
            tbPhuCap.Margin = new Padding(4);
            tbPhuCap.Name = "tbPhuCap";
            tbPhuCap.Size = new Size(117, 24);
            tbPhuCap.TabIndex = 22;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(321, 116);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 16);
            label5.TabIndex = 21;
            label5.Text = "Hệ Số Phụ Cấp:";
            // 
            // tbTienLuong
            // 
            tbTienLuong.Anchor = AnchorStyles.Top;
            tbTienLuong.Enabled = false;
            tbTienLuong.Location = new Point(117, 113);
            tbTienLuong.Margin = new Padding(4);
            tbTienLuong.Name = "tbTienLuong";
            tbTienLuong.Size = new Size(140, 24);
            tbTienLuong.TabIndex = 20;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 115);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 16);
            label3.TabIndex = 19;
            label3.Text = "Tiền Lương:";
            // 
            // tbTienNha
            // 
            tbTienNha.Anchor = AnchorStyles.Top;
            tbTienNha.Location = new Point(689, 36);
            tbTienNha.Margin = new Padding(4);
            tbTienNha.Name = "tbTienNha";
            tbTienNha.Size = new Size(122, 24);
            tbTienNha.TabIndex = 18;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(586, 81);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(71, 16);
            label10.TabIndex = 17;
            label10.Text = "Thời Điểm:";
            // 
            // dtpkThoiDiem
            // 
            dtpkThoiDiem.Anchor = AnchorStyles.Top;
            dtpkThoiDiem.Format = DateTimePickerFormat.Short;
            dtpkThoiDiem.Location = new Point(689, 73);
            dtpkThoiDiem.Margin = new Padding(4);
            dtpkThoiDiem.Name = "dtpkThoiDiem";
            dtpkThoiDiem.Size = new Size(123, 24);
            dtpkThoiDiem.TabIndex = 16;
            dtpkThoiDiem.ValueChanged += dtpkThoiDiem_ValueChanged;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(595, 38);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(63, 16);
            label9.TabIndex = 14;
            label9.Text = "Tiền Nhà:";
            // 
            // tbSoNgayCong
            // 
            tbSoNgayCong.Anchor = AnchorStyles.Top;
            tbSoNgayCong.Location = new Point(433, 70);
            tbSoNgayCong.Margin = new Padding(4);
            tbSoNgayCong.Name = "tbSoNgayCong";
            tbSoNgayCong.Size = new Size(117, 24);
            tbSoNgayCong.TabIndex = 11;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(326, 73);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(92, 16);
            label7.TabIndex = 10;
            label7.Text = "Số Ngày Công:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(334, 30);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(85, 16);
            label6.TabIndex = 8;
            label6.Text = "Hệ Số Lương:";
            // 
            // tbLCB
            // 
            tbLCB.Anchor = AnchorStyles.Top;
            tbLCB.Location = new Point(117, 71);
            tbLCB.Margin = new Padding(4);
            tbLCB.Name = "tbLCB";
            tbLCB.Size = new Size(140, 24);
            tbLCB.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 74);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 16);
            label4.TabIndex = 4;
            label4.Text = "Lương Cơ Bản:";
            // 
            // cbMaNV
            // 
            cbMaNV.Anchor = AnchorStyles.Top;
            cbMaNV.FormattingEnabled = true;
            cbMaNV.Location = new Point(117, 31);
            cbMaNV.Margin = new Padding(4);
            cbMaNV.Name = "cbMaNV";
            cbMaNV.Size = new Size(140, 25);
            cbMaNV.TabIndex = 1;
            cbMaNV.SelectedIndexChanged += cbMaNV_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 16);
            label1.TabIndex = 0;
            label1.Text = "Mã Nhân Viên:";
            // 
            // dtgvLuongNV
            // 
            dtgvLuongNV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvLuongNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvLuongNV.Columns.AddRange(new DataGridViewColumn[] { MaNhanVien, LuongCoBan, HeSoBacLuong, Hesophucapchucvu, Songaydilam, Songaynghibhxh, Songaynghikhonglydo, TienNha, TongLuong, Thoidiem });
            dtgvLuongNV.Location = new Point(64, 268);
            dtgvLuongNV.Margin = new Padding(4);
            dtgvLuongNV.Name = "dtgvLuongNV";
            dtgvLuongNV.RowHeadersWidth = 51;
            dtgvLuongNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvLuongNV.Size = new Size(906, 243);
            dtgvLuongNV.TabIndex = 57;
            dtgvLuongNV.CellContentClick += dtgvLuongNV_CellContentClick;
            // 
            // MaNhanVien
            // 
            MaNhanVien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaNhanVien.DataPropertyName = "MaNhanVien";
            MaNhanVien.HeaderText = "Mã Nhân Viên";
            MaNhanVien.MinimumWidth = 6;
            MaNhanVien.Name = "MaNhanVien";
            MaNhanVien.ReadOnly = true;
            // 
            // LuongCoBan
            // 
            LuongCoBan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LuongCoBan.DataPropertyName = "LuongCoBan";
            LuongCoBan.HeaderText = "Lương Cơ Bản";
            LuongCoBan.MinimumWidth = 6;
            LuongCoBan.Name = "LuongCoBan";
            LuongCoBan.ReadOnly = true;
            // 
            // HeSoBacLuong
            // 
            HeSoBacLuong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HeSoBacLuong.DataPropertyName = "HeSoBacLuong";
            HeSoBacLuong.HeaderText = "Hệ Số Lương";
            HeSoBacLuong.MinimumWidth = 6;
            HeSoBacLuong.Name = "HeSoBacLuong";
            HeSoBacLuong.ReadOnly = true;
            // 
            // Hesophucapchucvu
            // 
            Hesophucapchucvu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Hesophucapchucvu.DataPropertyName = "Hesophucapchucvu";
            Hesophucapchucvu.HeaderText = "Hệ Số Phụ Cấp Chức Vụ";
            Hesophucapchucvu.MinimumWidth = 6;
            Hesophucapchucvu.Name = "Hesophucapchucvu";
            Hesophucapchucvu.ReadOnly = true;
            // 
            // Songaydilam
            // 
            Songaydilam.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Songaydilam.DataPropertyName = "Songaydilam";
            Songaydilam.HeaderText = "Số Ngày Đi Làm";
            Songaydilam.MinimumWidth = 6;
            Songaydilam.Name = "Songaydilam";
            Songaydilam.ReadOnly = true;
            // 
            // Songaynghibhxh
            // 
            Songaynghibhxh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Songaynghibhxh.DataPropertyName = "Songaynghibhxh";
            Songaynghibhxh.HeaderText = "Số Ngày Nghỉ BHXH";
            Songaynghibhxh.MinimumWidth = 6;
            Songaynghibhxh.Name = "Songaynghibhxh";
            Songaynghibhxh.ReadOnly = true;
            // 
            // Songaynghikhonglydo
            // 
            Songaynghikhonglydo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Songaynghikhonglydo.DataPropertyName = "Songaynghikhonglydo";
            Songaynghikhonglydo.HeaderText = "Số Ngày Nghỉ Không  Lý Do";
            Songaynghikhonglydo.MinimumWidth = 6;
            Songaynghikhonglydo.Name = "Songaynghikhonglydo";
            Songaynghikhonglydo.ReadOnly = true;
            // 
            // TienNha
            // 
            TienNha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TienNha.DataPropertyName = "TienNha";
            TienNha.HeaderText = "Tiền Nhà";
            TienNha.MinimumWidth = 6;
            TienNha.Name = "TienNha";
            TienNha.ReadOnly = true;
            // 
            // TongLuong
            // 
            TongLuong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TongLuong.DataPropertyName = "TongLuong";
            TongLuong.HeaderText = "Tổng Lương";
            TongLuong.MinimumWidth = 6;
            TongLuong.Name = "TongLuong";
            TongLuong.ReadOnly = true;
            // 
            // Thoidiem
            // 
            Thoidiem.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Thoidiem.DataPropertyName = "Thoidiem";
            Thoidiem.HeaderText = "Thời Điểm";
            Thoidiem.MinimumWidth = 6;
            Thoidiem.Name = "Thoidiem";
            Thoidiem.ReadOnly = true;
            // 
            // btnTinhLuong
            // 
            btnTinhLuong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTinhLuong.BackColor = Color.FromArgb(255, 96, 0);
            btnTinhLuong.FlatStyle = FlatStyle.Popup;
            btnTinhLuong.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTinhLuong.Location = new Point(662, 31);
            btnTinhLuong.Margin = new Padding(4);
            btnTinhLuong.Name = "btnTinhLuong";
            btnTinhLuong.Size = new Size(116, 32);
            btnTinhLuong.TabIndex = 58;
            btnTinhLuong.Text = "Tính Lương";
            btnTinhLuong.UseVisualStyleBackColor = false;
            btnTinhLuong.Click += btnTinhLuong_Click;
            // 
            // rtbLuong
            // 
            rtbLuong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rtbLuong.Location = new Point(798, 31);
            rtbLuong.Margin = new Padding(4);
            rtbLuong.Name = "rtbLuong";
            rtbLuong.Size = new Size(172, 32);
            rtbLuong.TabIndex = 59;
            rtbLuong.Text = "";
            // 
            // btnCapNhat
            // 
            btnCapNhat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCapNhat.BackColor = Color.FromArgb(255, 96, 0);
            btnCapNhat.FlatStyle = FlatStyle.Popup;
            btnCapNhat.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.Location = new Point(732, 524);
            btnCapNhat.Margin = new Padding(4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(98, 32);
            btnCapNhat.TabIndex = 60;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnThoat.BackColor = Color.FromArgb(255, 96, 0);
            btnThoat.FlatStyle = FlatStyle.Popup;
            btnThoat.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(872, 524);
            btnThoat.Margin = new Padding(4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(98, 32);
            btnThoat.TabIndex = 62;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // rtbMaNhanVien
            // 
            rtbMaNhanVien.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            rtbMaNhanVien.Location = new Point(64, 526);
            rtbMaNhanVien.Margin = new Padding(4);
            rtbMaNhanVien.Name = "rtbMaNhanVien";
            rtbMaNhanVien.Size = new Size(274, 32);
            rtbMaNhanVien.TabIndex = 63;
            rtbMaNhanVien.Text = "";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTimKiem.BackColor = Color.FromArgb(255, 96, 0);
            btnTimKiem.FlatStyle = FlatStyle.Popup;
            btnTimKiem.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTimKiem.Location = new Point(358, 526);
            btnTimKiem.Margin = new Padding(4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(122, 32);
            btnTimKiem.TabIndex = 64;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnHuy.BackColor = Color.FromArgb(255, 96, 0);
            btnHuy.FlatStyle = FlatStyle.Popup;
            btnHuy.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.Location = new Point(358, 575);
            btnHuy.Margin = new Padding(4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(122, 32);
            btnHuy.TabIndex = 65;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 31);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(237, 31);
            label2.TabIndex = 66;
            label2.Text = "Lương Nhân Viên";
            // 
            // btnBaoCao
            // 
            btnBaoCao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBaoCao.BackColor = Color.FromArgb(255, 96, 0);
            btnBaoCao.FlatStyle = FlatStyle.Popup;
            btnBaoCao.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBaoCao.Location = new Point(530, 31);
            btnBaoCao.Margin = new Padding(4);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Size = new Size(112, 32);
            btnBaoCao.TabIndex = 67;
            btnBaoCao.Text = "Xuất báo cáo";
            btnBaoCao.UseVisualStyleBackColor = false;
            btnBaoCao.Click += btnBaoCao_Click;
            // 
            // formTinhLuong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 230, 199);
            ClientSize = new Size(1006, 619);
            Controls.Add(btnBaoCao);
            Controls.Add(label2);
            Controls.Add(btnHuy);
            Controls.Add(btnTimKiem);
            Controls.Add(rtbMaNhanVien);
            Controls.Add(btnThoat);
            Controls.Add(btnCapNhat);
            Controls.Add(btnTinhLuong);
            Controls.Add(dtgvLuongNV);
            Controls.Add(rtbLuong);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "formTinhLuong";
            Text = "Tính Lương";
            WindowState = FormWindowState.Maximized;
            Load += formTinhLuong_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvLuongNV).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSoNgayCong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpkThoiDiem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtgvLuongNV;
        private System.Windows.Forms.Button btnTinhLuong;
        private System.Windows.Forms.RichTextBox rtbLuong;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox tbTienNha;
        private System.Windows.Forms.TextBox tbTienLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPhuCap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtbMaNhanVien;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBacLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongCoBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeSoBacLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hesophucapchucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Songaydilam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Songaynghibhxh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Songaynghikhonglydo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienNha;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thoidiem;
        private System.Windows.Forms.Button btnBaoCao;
    }
}