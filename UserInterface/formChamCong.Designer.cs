﻿namespace UserInterface
{
    partial class formChamCong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMaCC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numDiLam = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numngaynghiBHXH = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numngaynghi = new System.Windows.Forms.NumericUpDown();
            this.dtpNgayLV = new System.Windows.Forms.DateTimePicker();
            this.cboManv = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dataChamCong = new System.Windows.Forms.DataGridView();
            this.MACC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SONGAYTRONGTHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SONGAYNGHIBHXH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SONGAYNGHIKHONGLYDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiLam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numngaynghiBHXH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numngaynghi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(89)))));
            this.groupBox1.Controls.Add(this.cbTinhTrang);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbMaCC);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numDiLam);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numngaynghiBHXH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numngaynghi);
            this.groupBox1.Controls.Add(this.dtpNgayLV);
            this.groupBox1.Controls.Add(this.cboManv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1129, 174);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chấm Công";
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.BackColor = System.Drawing.SystemColors.Info;
            this.cbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTinhTrang.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "Đi làm",
            "Nghỉ có phép",
            "Nghỉ không phép"});
            this.cbTinhTrang.Location = new System.Drawing.Point(185, 83);
            this.cbTinhTrang.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(176, 30);
            this.cbTinhTrang.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 22);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tình Trạng:";
            // 
            // tbMaCC
            // 
            this.tbMaCC.Location = new System.Drawing.Point(185, 39);
            this.tbMaCC.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaCC.Name = "tbMaCC";
            this.tbMaCC.Size = new System.Drawing.Size(176, 28);
            this.tbMaCC.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 40);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 22);
            this.label10.TabIndex = 23;
            this.label10.Text = "Mã Chấm Công:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(868, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 22);
            this.label9.TabIndex = 22;
            this.label9.Text = "Số ngày đi làm:";
            // 
            // numDiLam
            // 
            this.numDiLam.Location = new System.Drawing.Point(1010, 29);
            this.numDiLam.Margin = new System.Windows.Forms.Padding(4);
            this.numDiLam.Name = "numDiLam";
            this.numDiLam.Size = new System.Drawing.Size(91, 28);
            this.numDiLam.TabIndex = 21;
            this.numDiLam.ValueChanged += new System.EventHandler(this.numDiLam_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(831, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Số ngày nghỉ BHXH:";
            // 
            // numngaynghiBHXH
            // 
            this.numngaynghiBHXH.Location = new System.Drawing.Point(1010, 117);
            this.numngaynghiBHXH.Margin = new System.Windows.Forms.Padding(4);
            this.numngaynghiBHXH.Name = "numngaynghiBHXH";
            this.numngaynghiBHXH.Size = new System.Drawing.Size(91, 28);
            this.numngaynghiBHXH.TabIndex = 19;
            this.numngaynghiBHXH.ValueChanged += new System.EventHandler(this.numngaynghiBHXH_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(782, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Số ngày nghỉ không phép:";
            // 
            // numngaynghi
            // 
            this.numngaynghi.Location = new System.Drawing.Point(1010, 73);
            this.numngaynghi.Margin = new System.Windows.Forms.Padding(4);
            this.numngaynghi.Name = "numngaynghi";
            this.numngaynghi.Size = new System.Drawing.Size(91, 28);
            this.numngaynghi.TabIndex = 17;
            this.numngaynghi.ValueChanged += new System.EventHandler(this.numngaynghi_ValueChanged);
            // 
            // dtpNgayLV
            // 
            this.dtpNgayLV.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLV.Location = new System.Drawing.Point(528, 84);
            this.dtpNgayLV.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtpNgayLV.Name = "dtpNgayLV";
            this.dtpNgayLV.Size = new System.Drawing.Size(228, 29);
            this.dtpNgayLV.TabIndex = 16;
            this.dtpNgayLV.ValueChanged += new System.EventHandler(this.dtpNgayLV_ValueChanged);
            // 
            // cboManv
            // 
            this.cboManv.BackColor = System.Drawing.SystemColors.Info;
            this.cboManv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboManv.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboManv.FormattingEnabled = true;
            this.cboManv.Location = new System.Drawing.Point(528, 38);
            this.cboManv.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cboManv.Name = "cboManv";
            this.cboManv.Size = new System.Drawing.Size(228, 30);
            this.cboManv.TabIndex = 15;
            this.cboManv.SelectedIndexChanged += new System.EventHandler(this.cboManv_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ngày làm việc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã nhân viên:";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(434, 610);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(125, 37);
            this.btnThem.TabIndex = 50;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapnhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.btnCapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapnhat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.Location = new System.Drawing.Point(591, 610);
            this.btnCapnhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(125, 37);
            this.btnCapnhat.TabIndex = 51;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = false;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(748, 610);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(125, 37);
            this.btnXoa.TabIndex = 52;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(905, 610);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(125, 37);
            this.btnThoat.TabIndex = 53;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dataChamCong
            // 
            this.dataChamCong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MACC,
            this.THANG,
            this.SONGAYTRONGTHANG,
            this.SONGAYNGHIBHXH,
            this.SONGAYNGHIKHONGLYDO,
            this.MANV});
            this.dataChamCong.Location = new System.Drawing.Point(2, 246);
            this.dataChamCong.Margin = new System.Windows.Forms.Padding(4);
            this.dataChamCong.Name = "dataChamCong";
            this.dataChamCong.RowHeadersWidth = 51;
            this.dataChamCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataChamCong.Size = new System.Drawing.Size(1147, 335);
            this.dataChamCong.TabIndex = 54;
            this.dataChamCong.SelectionChanged += new System.EventHandler(this.dataChamCong_SelectionChanged);
            // 
            // MACC
            // 
            this.MACC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MACC.DataPropertyName = "MACC";
            this.MACC.HeaderText = "Mã Chấm Công";
            this.MACC.MinimumWidth = 6;
            this.MACC.Name = "MACC";
            this.MACC.ReadOnly = true;
            // 
            // THANG
            // 
            this.THANG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.THANG.DataPropertyName = "THANG";
            this.THANG.HeaderText = "Tháng";
            this.THANG.MinimumWidth = 6;
            this.THANG.Name = "THANG";
            this.THANG.ReadOnly = true;
            // 
            // SONGAYTRONGTHANG
            // 
            this.SONGAYTRONGTHANG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SONGAYTRONGTHANG.DataPropertyName = "SONGAYTRONGTHANG";
            this.SONGAYTRONGTHANG.HeaderText = "Số ngày trong tháng";
            this.SONGAYTRONGTHANG.MinimumWidth = 6;
            this.SONGAYTRONGTHANG.Name = "SONGAYTRONGTHANG";
            this.SONGAYTRONGTHANG.ReadOnly = true;
            // 
            // SONGAYNGHIBHXH
            // 
            this.SONGAYNGHIBHXH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SONGAYNGHIBHXH.DataPropertyName = "SONGAYNGHIBHXH";
            this.SONGAYNGHIBHXH.HeaderText = "Số ngày nghỉ BHXH";
            this.SONGAYNGHIBHXH.MinimumWidth = 6;
            this.SONGAYNGHIBHXH.Name = "SONGAYNGHIBHXH";
            this.SONGAYNGHIBHXH.ReadOnly = true;
            // 
            // SONGAYNGHIKHONGLYDO
            // 
            this.SONGAYNGHIKHONGLYDO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SONGAYNGHIKHONGLYDO.DataPropertyName = "SONGAYNGHIKHONGLYDO";
            this.SONGAYNGHIKHONGLYDO.HeaderText = "Số ngày nghỉ không lý do";
            this.SONGAYNGHIKHONGLYDO.MinimumWidth = 6;
            this.SONGAYNGHIKHONGLYDO.Name = "SONGAYNGHIKHONGLYDO";
            // 
            // MANV
            // 
            this.MANV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã Nhân Viên";
            this.MANV.MinimumWidth = 6;
            this.MANV.Name = "MANV";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 34);
            this.label2.TabIndex = 55;
            this.label2.Text = "Chấm Công";
            // 
            // btnChamCong
            // 
            this.btnChamCong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChamCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.btnChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChamCong.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamCong.Location = new System.Drawing.Point(277, 610);
            this.btnChamCong.Margin = new System.Windows.Forms.Padding(4);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(125, 37);
            this.btnChamCong.TabIndex = 56;
            this.btnChamCong.Text = "Chấm công";
            this.btnChamCong.UseVisualStyleBackColor = false;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click_1);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(96)))), ((int)(((byte)(0)))));
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaoCao.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.Location = new System.Drawing.Point(120, 610);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(125, 37);
            this.btnBaoCao.TabIndex = 57;
            this.btnBaoCao.Text = "Xuất báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // formChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(1150, 660);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.btnChamCong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataChamCong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formChamCong";
            this.Text = "Chấm Công";
            this.Load += new System.EventHandler(this.fromChamCong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiLam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numngaynghiBHXH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numngaynghi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataChamCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dataChamCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACC;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn SONGAYTRONGTHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn SONGAYNGHIBHXH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SONGAYNGHIKHONGLYDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.ComboBox cboManv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numngaynghi;
        private System.Windows.Forms.DateTimePicker dtpNgayLV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numDiLam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numngaynghiBHXH;
        private System.Windows.Forms.TextBox tbMaCC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnChamCong;
        private System.Windows.Forms.Button btnBaoCao;
    }
}