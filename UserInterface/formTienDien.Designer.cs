namespace UserInterface
{
    partial class formTienDien
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
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numThangSau = new System.Windows.Forms.NumericUpDown();
            this.numThangTruoc = new System.Windows.Forms.NumericUpDown();
            this.tbDonVi = new System.Windows.Forms.TextBox();
            this.DonVi = new System.Windows.Forms.Label();
            this.tbThangSau = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpkThang = new System.Windows.Forms.DateTimePicker();
            this.tbMaDien = new System.Windows.Forms.TextBox();
            this.cbHGD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDien = new System.Windows.Forms.DataGridView();
            this.MaDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeSoDienThangTruoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeSoDienHienTai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThangSau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThangTruoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDien)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(484, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 33);
            this.label2.TabIndex = 56;
            this.label2.Text = "Điện";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(628, 538);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(125, 37);
            this.btnXoa.TabIndex = 63;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCapnhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.btnCapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapnhat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.Location = new System.Drawing.Point(471, 538);
            this.btnCapnhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(125, 37);
            this.btnCapnhat.TabIndex = 62;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = false;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(314, 538);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(125, 37);
            this.btnThem.TabIndex = 61;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(89)))));
            this.groupBox1.Controls.Add(this.numThangSau);
            this.groupBox1.Controls.Add(this.numThangTruoc);
            this.groupBox1.Controls.Add(this.tbDonVi);
            this.groupBox1.Controls.Add(this.DonVi);
            this.groupBox1.Controls.Add(this.tbThangSau);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpkThang);
            this.groupBox1.Controls.Add(this.tbMaDien);
            this.groupBox1.Controls.Add(this.cbHGD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(87, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(892, 165);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // numThangSau
            // 
            this.numThangSau.Location = new System.Drawing.Point(650, 72);
            this.numThangSau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numThangSau.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numThangSau.Name = "numThangSau";
            this.numThangSau.Size = new System.Drawing.Size(139, 28);
            this.numThangSau.TabIndex = 14;
            // 
            // numThangTruoc
            // 
            this.numThangTruoc.Location = new System.Drawing.Point(650, 28);
            this.numThangTruoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numThangTruoc.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numThangTruoc.Name = "numThangTruoc";
            this.numThangTruoc.Size = new System.Drawing.Size(139, 28);
            this.numThangTruoc.TabIndex = 13;
            // 
            // tbDonVi
            // 
            this.tbDonVi.Location = new System.Drawing.Point(650, 116);
            this.tbDonVi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDonVi.Name = "tbDonVi";
            this.tbDonVi.Size = new System.Drawing.Size(137, 28);
            this.tbDonVi.TabIndex = 12;
            // 
            // DonVi
            // 
            this.DonVi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DonVi.AutoSize = true;
            this.DonVi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonVi.Location = new System.Drawing.Point(562, 122);
            this.DonVi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DonVi.Name = "DonVi";
            this.DonVi.Size = new System.Drawing.Size(65, 21);
            this.DonVi.TabIndex = 11;
            this.DonVi.Text = "Đơn Vị:";
            // 
            // tbThangSau
            // 
            this.tbThangSau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbThangSau.AutoSize = true;
            this.tbThangSau.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThangSau.Location = new System.Drawing.Point(485, 77);
            this.tbThangSau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbThangSau.Name = "tbThangSau";
            this.tbThangSau.Size = new System.Drawing.Size(142, 21);
            this.tbThangSau.TabIndex = 9;
            this.tbThangSau.Text = "Hệ Số Tháng Sau:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(469, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hệ Số Tháng Trước:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tháng:";
            // 
            // dtpkThang
            // 
            this.dtpkThang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkThang.Location = new System.Drawing.Point(261, 117);
            this.dtpkThang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpkThang.Name = "dtpkThang";
            this.dtpkThang.Size = new System.Drawing.Size(142, 28);
            this.dtpkThang.TabIndex = 5;
            this.dtpkThang.ValueChanged += new System.EventHandler(this.dtpkThang_ValueChanged);
            // 
            // tbMaDien
            // 
            this.tbMaDien.Location = new System.Drawing.Point(262, 28);
            this.tbMaDien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMaDien.Name = "tbMaDien";
            this.tbMaDien.Size = new System.Drawing.Size(137, 28);
            this.tbMaDien.TabIndex = 4;
            // 
            // cbHGD
            // 
            this.cbHGD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbHGD.FormattingEnabled = true;
            this.cbHGD.Location = new System.Drawing.Point(261, 72);
            this.cbHGD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbHGD.Name = "cbHGD";
            this.cbHGD.Size = new System.Drawing.Size(139, 29);
            this.cbHGD.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Hộ Gia Đình:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Điện:";
            // 
            // dtDien
            // 
            this.dtDien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDien,
            this.MaHGD,
            this.Thang,
            this.HeSoDienThangTruoc,
            this.HeSoDienHienTai});
            this.dtDien.Location = new System.Drawing.Point(87, 242);
            this.dtDien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtDien.Name = "dtDien";
            this.dtDien.RowHeadersWidth = 51;
            this.dtDien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtDien.Size = new System.Drawing.Size(892, 272);
            this.dtDien.TabIndex = 66;
            this.dtDien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDien_CellContentClick);
            // 
            // MaDien
            // 
            this.MaDien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaDien.DataPropertyName = "MaDien";
            this.MaDien.HeaderText = "Mã Điện";
            this.MaDien.MinimumWidth = 6;
            this.MaDien.Name = "MaDien";
            this.MaDien.ReadOnly = true;
            // 
            // MaHGD
            // 
            this.MaHGD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHGD.DataPropertyName = "MaHGD";
            this.MaHGD.HeaderText = "Mã Hộ";
            this.MaHGD.MinimumWidth = 6;
            this.MaHGD.Name = "MaHGD";
            this.MaHGD.ReadOnly = true;
            // 
            // Thang
            // 
            this.Thang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Thang.DataPropertyName = "Thang";
            this.Thang.HeaderText = "Tháng";
            this.Thang.MinimumWidth = 6;
            this.Thang.Name = "Thang";
            this.Thang.ReadOnly = true;
            // 
            // HeSoDienThangTruoc
            // 
            this.HeSoDienThangTruoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeSoDienThangTruoc.DataPropertyName = "HeSoDienThangTruoc";
            this.HeSoDienThangTruoc.HeaderText = "Hệ Số Tháng Trước";
            this.HeSoDienThangTruoc.MinimumWidth = 6;
            this.HeSoDienThangTruoc.Name = "HeSoDienThangTruoc";
            this.HeSoDienThangTruoc.ReadOnly = true;
            // 
            // HeSoDienHienTai
            // 
            this.HeSoDienHienTai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeSoDienHienTai.DataPropertyName = "HeSoDienHienTai";
            this.HeSoDienHienTai.HeaderText = "Hệ Số Hiện Tại";
            this.HeSoDienHienTai.MinimumWidth = 6;
            this.HeSoDienHienTai.Name = "HeSoDienHienTai";
            this.HeSoDienHienTai.ReadOnly = true;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.btnReload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReload.Image = global::UserInterface.Properties.Resources.reload;
            this.btnReload.Location = new System.Drawing.Point(987, 58);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(43, 39);
            this.btnReload.TabIndex = 15;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(199)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(1032, -1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 34);
            this.btnExit.TabIndex = 67;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // formTienDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(1067, 590);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dtDien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formTienDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điện";
            this.Load += new System.EventHandler(this.formTienDien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThangSau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThangTruoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpkThang;
        private System.Windows.Forms.TextBox tbMaDien;
        private System.Windows.Forms.ComboBox cbHGD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDonVi;
        private System.Windows.Forms.Label DonVi;
        private System.Windows.Forms.Label tbThangSau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeSoDienThangTruoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeSoDienHienTai;
        private System.Windows.Forms.NumericUpDown numThangSau;
        private System.Windows.Forms.NumericUpDown numThangTruoc;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnExit;
    }
}