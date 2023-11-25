namespace UserInterface
{
    partial class formTienNuoc
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
            this.tbDonVi = new System.Windows.Forms.TextBox();
            this.DonVi = new System.Windows.Forms.Label();
            this.tbThangSau = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpkThang = new System.Windows.Forms.DateTimePicker();
            this.tbMaN = new System.Windows.Forms.TextBox();
            this.cbMaho = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numThangtruoc = new System.Windows.Forms.NumericUpDown();
            this.numThangSau = new System.Windows.Forms.NumericUpDown();
            this.btnReload = new System.Windows.Forms.Button();
            this.dtNuoc = new System.Windows.Forms.DataGridView();
            this.MaNUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HESONUOCTHANGTRUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HESONUOCHIENTAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThangtruoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThangSau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.numThangSau);
            this.groupBox1.Controls.Add(this.numThangtruoc);
            this.groupBox1.Controls.Add(this.tbDonVi);
            this.groupBox1.Controls.Add(this.DonVi);
            this.groupBox1.Controls.Add(this.tbThangSau);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpkThang);
            this.groupBox1.Controls.Add(this.tbMaN);
            this.groupBox1.Controls.Add(this.cbMaho);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(70, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 119);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // tbDonVi
            // 
            this.tbDonVi.Location = new System.Drawing.Point(535, 89);
            this.tbDonVi.Name = "tbDonVi";
            this.tbDonVi.Size = new System.Drawing.Size(104, 20);
            this.tbDonVi.TabIndex = 12;
            // 
            // DonVi
            // 
            this.DonVi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DonVi.AutoSize = true;
            this.DonVi.Location = new System.Drawing.Point(481, 92);
            this.DonVi.Name = "DonVi";
            this.DonVi.Size = new System.Drawing.Size(42, 13);
            this.DonVi.TabIndex = 11;
            this.DonVi.Text = "Đơn Vị:";
            // 
            // tbThangSau
            // 
            this.tbThangSau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbThangSau.AutoSize = true;
            this.tbThangSau.Location = new System.Drawing.Point(427, 59);
            this.tbThangSau.Name = "tbThangSau";
            this.tbThangSau.Size = new System.Drawing.Size(96, 13);
            this.tbThangSau.TabIndex = 9;
            this.tbThangSau.Text = "Hệ Số Tháng Sau:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hệ Số Tháng Trước:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tháng:";
            // 
            // dtpkThang
            // 
            this.dtpkThang.Location = new System.Drawing.Point(95, 93);
            this.dtpkThang.Name = "dtpkThang";
            this.dtpkThang.Size = new System.Drawing.Size(200, 20);
            this.dtpkThang.TabIndex = 5;
            this.dtpkThang.ValueChanged += new System.EventHandler(this.dtpkThang_ValueChanged);
            // 
            // tbMaN
            // 
            this.tbMaN.Location = new System.Drawing.Point(96, 18);
            this.tbMaN.Name = "tbMaN";
            this.tbMaN.Size = new System.Drawing.Size(104, 20);
            this.tbMaN.TabIndex = 4;
            // 
            // cbMaho
            // 
            this.cbMaho.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMaho.FormattingEnabled = true;
            this.cbMaho.Location = new System.Drawing.Point(95, 55);
            this.cbMaho.Name = "cbMaho";
            this.cbMaho.Size = new System.Drawing.Size(105, 21);
            this.cbMaho.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Hộ Gia Đình:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nước:";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(467, 405);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 30);
            this.btnXoa.TabIndex = 70;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCapnhat.BackColor = System.Drawing.Color.LightCoral;
            this.btnCapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapnhat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.Location = new System.Drawing.Point(351, 405);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(94, 30);
            this.btnCapnhat.TabIndex = 69;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = false;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThem.BackColor = System.Drawing.Color.LightCoral;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(228, 405);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 30);
            this.btnThem.TabIndex = 68;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 66;
            this.label2.Text = "Nước";
            // 
            // numThangtruoc
            // 
            this.numThangtruoc.Location = new System.Drawing.Point(535, 21);
            this.numThangtruoc.Name = "numThangtruoc";
            this.numThangtruoc.Size = new System.Drawing.Size(104, 20);
            this.numThangtruoc.TabIndex = 13;
            // 
            // numThangSau
            // 
            this.numThangSau.Location = new System.Drawing.Point(535, 57);
            this.numThangSau.Name = "numThangSau";
            this.numThangSau.Size = new System.Drawing.Size(104, 20);
            this.numThangSau.TabIndex = 14;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReload.Image = global::UserInterface.Properties.Resources.reload;
            this.btnReload.Location = new System.Drawing.Point(741, 53);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(32, 32);
            this.btnReload.TabIndex = 73;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // dtNuoc
            // 
            this.dtNuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtNuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNUOC,
            this.MaHGD,
            this.Thang,
            this.HESONUOCTHANGTRUOC,
            this.HESONUOCHIENTAI,
            this.DVN});
            this.dtNuoc.Location = new System.Drawing.Point(70, 169);
            this.dtNuoc.Name = "dtNuoc";
            this.dtNuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtNuoc.Size = new System.Drawing.Size(669, 215);
            this.dtNuoc.TabIndex = 74;
            this.dtNuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtNuoc_CellContentClick);
            // 
            // MaNUOC
            // 
            this.MaNUOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNUOC.DataPropertyName = "MaNUOC";
            this.MaNUOC.HeaderText = "Mã Nước";
            this.MaNUOC.Name = "MaNUOC";
            this.MaNUOC.ReadOnly = true;
            // 
            // MaHGD
            // 
            this.MaHGD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHGD.DataPropertyName = "MAHGD";
            this.MaHGD.HeaderText = "Mã Hộ";
            this.MaHGD.Name = "MaHGD";
            this.MaHGD.ReadOnly = true;
            // 
            // Thang
            // 
            this.Thang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Thang.DataPropertyName = "Thang";
            this.Thang.HeaderText = "Tháng";
            this.Thang.Name = "Thang";
            this.Thang.ReadOnly = true;
            // 
            // HESONUOCTHANGTRUOC
            // 
            this.HESONUOCTHANGTRUOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HESONUOCTHANGTRUOC.DataPropertyName = "HESONUOCTHANGTRUOC";
            this.HESONUOCTHANGTRUOC.HeaderText = "Hệ Số Tháng Trước";
            this.HESONUOCTHANGTRUOC.Name = "HESONUOCTHANGTRUOC";
            this.HESONUOCTHANGTRUOC.ReadOnly = true;
            // 
            // HESONUOCHIENTAI
            // 
            this.HESONUOCHIENTAI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HESONUOCHIENTAI.DataPropertyName = "HESONUOCHIENTAI";
            this.HESONUOCHIENTAI.HeaderText = "Hệ Số Tháng Sau";
            this.HESONUOCHIENTAI.Name = "HESONUOCHIENTAI";
            this.HESONUOCHIENTAI.ReadOnly = true;
            // 
            // DVN
            // 
            this.DVN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DVN.DataPropertyName = "DVN";
            this.DVN.HeaderText = "Đơn Vị";
            this.DVN.Name = "DVN";
            this.DVN.ReadOnly = true;
            // 
            // formTienNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.dtNuoc);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Name = "formTienNuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nước";
            this.Load += new System.EventHandler(this.formTienNuoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThangtruoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThangSau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbDonVi;
        private System.Windows.Forms.Label DonVi;
        private System.Windows.Forms.Label tbThangSau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpkThang;
        private System.Windows.Forms.TextBox tbMaN;
        private System.Windows.Forms.ComboBox cbMaho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numThangSau;
        private System.Windows.Forms.NumericUpDown numThangtruoc;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DataGridView dtNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn HESONUOCTHANGTRUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn HESONUOCHIENTAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVN;
    }
}