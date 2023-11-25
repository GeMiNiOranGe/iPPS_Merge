namespace UserInterface
{
    partial class formTienNha
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
            this.dtTienNha = new System.Windows.Forms.DataGridView();
            this.MANTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienNhaCoDinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeSoDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeSoNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhiVSANTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbThangSau = new System.Windows.Forms.Label();
            this.tbTienNha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpkThang = new System.Windows.Forms.DateTimePicker();
            this.tbMNTT = new System.Windows.Forms.TextBox();
            this.cbHGD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numNuoc = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numDien = new System.Windows.Forms.NumericUpDown();
            this.tbPTT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbTinhTien = new System.Windows.Forms.RichTextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtTienNha)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDien)).BeginInit();
            this.SuspendLayout();
            // 
            // dtTienNha
            // 
            this.dtTienNha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTienNha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTienNha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANTT,
            this.MaHGD,
            this.Thang,
            this.TienNhaCoDinh,
            this.HeSoDien,
            this.HeSoNuoc,
            this.PhiVSANTT,
            this.TongTienNha});
            this.dtTienNha.Location = new System.Drawing.Point(50, 190);
            this.dtTienNha.Name = "dtTienNha";
            this.dtTienNha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtTienNha.Size = new System.Drawing.Size(706, 237);
            this.dtTienNha.TabIndex = 74;
            this.dtTienNha.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtTienNha_CellContentClick);
            // 
            // MANTT
            // 
            this.MANTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MANTT.DataPropertyName = "MANTT";
            this.MANTT.HeaderText = "Mã Nhà Tập Thể";
            this.MANTT.Name = "MANTT";
            this.MANTT.ReadOnly = true;
            // 
            // MaHGD
            // 
            this.MaHGD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHGD.DataPropertyName = "MaHGD";
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
            // TienNhaCoDinh
            // 
            this.TienNhaCoDinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TienNhaCoDinh.DataPropertyName = "TienNhaCoDinh";
            this.TienNhaCoDinh.HeaderText = "Tiền Nhà";
            this.TienNhaCoDinh.Name = "TienNhaCoDinh";
            this.TienNhaCoDinh.ReadOnly = true;
            // 
            // HeSoDien
            // 
            this.HeSoDien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeSoDien.DataPropertyName = "HeSoDien";
            this.HeSoDien.HeaderText = "Hệ Số Điện";
            this.HeSoDien.Name = "HeSoDien";
            this.HeSoDien.ReadOnly = true;
            // 
            // HeSoNuoc
            // 
            this.HeSoNuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HeSoNuoc.DataPropertyName = "HeSoNuoc";
            this.HeSoNuoc.HeaderText = "Hệ Số Nước";
            this.HeSoNuoc.Name = "HeSoNuoc";
            this.HeSoNuoc.ReadOnly = true;
            // 
            // PhiVSANTT
            // 
            this.PhiVSANTT.DataPropertyName = "PhiVSANTT";
            this.PhiVSANTT.HeaderText = "Phí Vệ Sinh và An Ninh";
            this.PhiVSANTT.Name = "PhiVSANTT";
            this.PhiVSANTT.ReadOnly = true;
            // 
            // TongTienNha
            // 
            this.TongTienNha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongTienNha.DataPropertyName = "TongTienNha";
            this.TongTienNha.HeaderText = "Tổng Tiền";
            this.TongTienNha.Name = "TongTienNha";
            this.TongTienNha.ReadOnly = true;
            // 
            // tbThangSau
            // 
            this.tbThangSau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbThangSau.AutoSize = true;
            this.tbThangSau.Location = new System.Drawing.Point(459, 51);
            this.tbThangSau.Name = "tbThangSau";
            this.tbThangSau.Size = new System.Drawing.Size(62, 13);
            this.tbThangSau.TabIndex = 9;
            this.tbThangSau.Text = "Hệ số điện:";
            // 
            // tbTienNha
            // 
            this.tbTienNha.Location = new System.Drawing.Point(535, 18);
            this.tbTienNha.Name = "tbTienNha";
            this.tbTienNha.Size = new System.Drawing.Size(104, 20);
            this.tbTienNha.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tiền Nhà:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tháng:";
            // 
            // dtpkThang
            // 
            this.dtpkThang.Location = new System.Drawing.Point(120, 93);
            this.dtpkThang.Name = "dtpkThang";
            this.dtpkThang.Size = new System.Drawing.Size(200, 20);
            this.dtpkThang.TabIndex = 5;
            // 
            // tbMNTT
            // 
            this.tbMNTT.Location = new System.Drawing.Point(123, 18);
            this.tbMNTT.Name = "tbMNTT";
            this.tbMNTT.Size = new System.Drawing.Size(104, 20);
            this.tbMNTT.TabIndex = 4;
            // 
            // cbHGD
            // 
            this.cbHGD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbHGD.FormattingEnabled = true;
            this.cbHGD.Location = new System.Drawing.Point(122, 55);
            this.cbHGD.Name = "cbHGD";
            this.cbHGD.Size = new System.Drawing.Size(105, 21);
            this.cbHGD.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Hộ Gia Đình:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Người Thu Tiền:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.numNuoc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numDien);
            this.groupBox1.Controls.Add(this.tbPTT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbThangSau);
            this.groupBox1.Controls.Add(this.tbTienNha);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpkThang);
            this.groupBox1.Controls.Add(this.tbMNTT);
            this.groupBox1.Controls.Add(this.cbHGD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(66, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 140);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // numNuoc
            // 
            this.numNuoc.Location = new System.Drawing.Point(535, 79);
            this.numNuoc.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numNuoc.Name = "numNuoc";
            this.numNuoc.Size = new System.Drawing.Size(104, 20);
            this.numNuoc.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hệ số nước:";
            // 
            // numDien
            // 
            this.numDien.Location = new System.Drawing.Point(535, 49);
            this.numDien.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDien.Name = "numDien";
            this.numDien.Size = new System.Drawing.Size(104, 20);
            this.numDien.TabIndex = 15;
            // 
            // tbPTT
            // 
            this.tbPTT.Location = new System.Drawing.Point(535, 107);
            this.tbPTT.Name = "tbPTT";
            this.tbPTT.Size = new System.Drawing.Size(104, 20);
            this.tbPTT.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tiền Vệ Sinh và Trật Tự:";
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCapnhat.BackColor = System.Drawing.Color.LightCoral;
            this.btnCapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapnhat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.Location = new System.Drawing.Point(662, 439);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(94, 30);
            this.btnCapnhat.TabIndex = 76;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = false;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 73;
            this.label2.Text = "Tiền Nhà";
            // 
            // rtbTinhTien
            // 
            this.rtbTinhTien.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtbTinhTien.Location = new System.Drawing.Point(70, 437);
            this.rtbTinhTien.Name = "rtbTinhTien";
            this.rtbTinhTien.Size = new System.Drawing.Size(130, 33);
            this.rtbTinhTien.TabIndex = 79;
            this.rtbTinhTien.Text = "";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTinhTien.BackColor = System.Drawing.Color.LightCoral;
            this.btnTinhTien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTinhTien.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.Location = new System.Drawing.Point(206, 439);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(82, 30);
            this.btnTinhTien.TabIndex = 80;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.UseVisualStyleBackColor = false;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReload.Image = global::UserInterface.Properties.Resources.reload;
            this.btnReload.Location = new System.Drawing.Point(741, 50);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(32, 32);
            this.btnReload.TabIndex = 81;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // formTienNha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.rtbTinhTien);
            this.Controls.Add(this.dtTienNha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.label2);
            this.Name = "formTienNha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiền Nhà";
            this.Load += new System.EventHandler(this.formTienNha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtTienNha)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtTienNha;
        private System.Windows.Forms.Label tbThangSau;
        private System.Windows.Forms.TextBox tbTienNha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpkThang;
        private System.Windows.Forms.TextBox tbMNTT;
        private System.Windows.Forms.ComboBox cbHGD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPTT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbTinhTien;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.NumericUpDown numNuoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienNhaCoDinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeSoDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeSoNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhiVSANTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienNha;
        private System.Windows.Forms.Button btnReload;
    }
}