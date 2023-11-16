namespace UserInterface
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
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
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
            this.groupBox1.Location = new System.Drawing.Point(22, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 114);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chấm Công";
            // 
            // tbMaCC
            // 
            this.tbMaCC.Location = new System.Drawing.Point(120, 37);
            this.tbMaCC.Name = "tbMaCC";
            this.tbMaCC.Size = new System.Drawing.Size(112, 20);
            this.tbMaCC.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 18);
            this.label10.TabIndex = 23;
            this.label10.Text = "Mã Chấm Công:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(653, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "Số ngày đi làm:";
            // 
            // numDiLam
            // 
            this.numDiLam.Location = new System.Drawing.Point(769, 19);
            this.numDiLam.Name = "numDiLam";
            this.numDiLam.Size = new System.Drawing.Size(95, 20);
            this.numDiLam.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(625, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Số ngày nghỉ BHXH:";
            // 
            // numngaynghiBHXH
            // 
            this.numngaynghiBHXH.Location = new System.Drawing.Point(769, 75);
            this.numngaynghiBHXH.Name = "numngaynghiBHXH";
            this.numngaynghiBHXH.Size = new System.Drawing.Size(95, 20);
            this.numngaynghiBHXH.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(586, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Số ngày nghỉ không lý do:";
            // 
            // numngaynghi
            // 
            this.numngaynghi.Location = new System.Drawing.Point(769, 47);
            this.numngaynghi.Name = "numngaynghi";
            this.numngaynghi.Size = new System.Drawing.Size(95, 20);
            this.numngaynghi.TabIndex = 17;
            // 
            // dtpNgayLV
            // 
            this.dtpNgayLV.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLV.Location = new System.Drawing.Point(370, 68);
            this.dtpNgayLV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayLV.Name = "dtpNgayLV";
            this.dtpNgayLV.Size = new System.Drawing.Size(172, 25);
            this.dtpNgayLV.TabIndex = 16;
            // 
            // cboManv
            // 
            this.cboManv.BackColor = System.Drawing.SystemColors.Info;
            this.cboManv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboManv.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboManv.FormattingEnabled = true;
            this.cboManv.Location = new System.Drawing.Point(367, 30);
            this.cboManv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboManv.Name = "cboManv";
            this.cboManv.Size = new System.Drawing.Size(175, 25);
            this.cboManv.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ngày làm việc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã nhân viên:";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThem.BackColor = System.Drawing.Color.LightCoral;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(512, 447);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 30);
            this.btnThem.TabIndex = 50;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCapnhat.BackColor = System.Drawing.Color.LightCoral;
            this.btnCapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapnhat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.Location = new System.Drawing.Point(622, 447);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(94, 30);
            this.btnCapnhat.TabIndex = 51;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = false;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(728, 447);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 30);
            this.btnXoa.TabIndex = 52;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThoat.BackColor = System.Drawing.Color.LightCoral;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(839, 447);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 30);
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
            this.dataChamCong.Location = new System.Drawing.Point(71, 178);
            this.dataChamCong.Name = "dataChamCong";
            this.dataChamCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataChamCong.Size = new System.Drawing.Size(872, 243);
            this.dataChamCong.TabIndex = 54;
            this.dataChamCong.SelectionChanged += new System.EventHandler(this.dataChamCong_SelectionChanged);
            // 
            // MACC
            // 
            this.MACC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MACC.DataPropertyName = "MACC";
            this.MACC.HeaderText = "Mã Chấm Công";
            this.MACC.Name = "MACC";
            this.MACC.ReadOnly = true;
            // 
            // THANG
            // 
            this.THANG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.THANG.DataPropertyName = "THANG";
            this.THANG.HeaderText = "Tháng";
            this.THANG.Name = "THANG";
            this.THANG.ReadOnly = true;
            // 
            // SONGAYTRONGTHANG
            // 
            this.SONGAYTRONGTHANG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SONGAYTRONGTHANG.DataPropertyName = "SONGAYTRONGTHANG";
            this.SONGAYTRONGTHANG.HeaderText = "Số ngày trong tháng";
            this.SONGAYTRONGTHANG.Name = "SONGAYTRONGTHANG";
            this.SONGAYTRONGTHANG.ReadOnly = true;
            // 
            // SONGAYNGHIBHXH
            // 
            this.SONGAYNGHIBHXH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SONGAYNGHIBHXH.DataPropertyName = "SONGAYNGHIBHXH";
            this.SONGAYNGHIBHXH.HeaderText = "Số ngày nghỉ BHXH";
            this.SONGAYNGHIBHXH.Name = "SONGAYNGHIBHXH";
            this.SONGAYNGHIBHXH.ReadOnly = true;
            // 
            // SONGAYNGHIKHONGLYDO
            // 
            this.SONGAYNGHIKHONGLYDO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SONGAYNGHIKHONGLYDO.DataPropertyName = "SONGAYNGHIKHONGLYDO";
            this.SONGAYNGHIKHONGLYDO.HeaderText = "Số ngày nghỉ không lý do";
            this.SONGAYNGHIKHONGLYDO.Name = "SONGAYNGHIKHONGLYDO";
            // 
            // MANV
            // 
            this.MANV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã Nhân Viên";
            this.MANV.Name = "MANV";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 55;
            this.label2.Text = "Chấm Công";
            // 
            // formChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1028, 503);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataChamCong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Name = "formChamCong";
            this.Text = "Chấm Công";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
    }
}