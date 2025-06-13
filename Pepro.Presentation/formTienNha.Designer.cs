namespace Pepro.Presentation
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
        private void InitializeComponent() {
            dtTienNha = new DataGridView();
            MANTT = new DataGridViewTextBoxColumn();
            MaHGD = new DataGridViewTextBoxColumn();
            Thang = new DataGridViewTextBoxColumn();
            TienNhaCoDinh = new DataGridViewTextBoxColumn();
            HeSoDien = new DataGridViewTextBoxColumn();
            HeSoNuoc = new DataGridViewTextBoxColumn();
            PhiVSANTT = new DataGridViewTextBoxColumn();
            TongTienNha = new DataGridViewTextBoxColumn();
            tbThangSau = new Label();
            tbTienNha = new TextBox();
            label5 = new Label();
            label4 = new Label();
            dtpkThang = new DateTimePicker();
            tbMNTT = new TextBox();
            cbHGD = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            numNuoc = new NumericUpDown();
            label7 = new Label();
            numDien = new NumericUpDown();
            tbPTT = new TextBox();
            label6 = new Label();
            btnCapnhat = new Button();
            label2 = new Label();
            rtbTinhTien = new RichTextBox();
            btnTinhTien = new Button();
            btnReload = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dtTienNha).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numNuoc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDien).BeginInit();
            SuspendLayout();
            // 
            // dtTienNha
            // 
            dtTienNha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtTienNha.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtTienNha.Columns.AddRange(new DataGridViewColumn[] { MANTT, MaHGD, Thang, TienNhaCoDinh, HeSoDien, HeSoNuoc, PhiVSANTT, TongTienNha });
            dtTienNha.Location = new Point(39, 219);
            dtTienNha.Margin = new Padding(4);
            dtTienNha.Name = "dtTienNha";
            dtTienNha.RowHeadersWidth = 51;
            dtTienNha.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtTienNha.Size = new Size(854, 274);
            dtTienNha.TabIndex = 74;
            dtTienNha.CellContentClick += dtTienNha_CellContentClick;
            // 
            // MANTT
            // 
            MANTT.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MANTT.DataPropertyName = "MANTT";
            MANTT.HeaderText = "Mã Nhà Tập Thể";
            MANTT.MinimumWidth = 6;
            MANTT.Name = "MANTT";
            MANTT.ReadOnly = true;
            // 
            // MaHGD
            // 
            MaHGD.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaHGD.DataPropertyName = "MaHGD";
            MaHGD.HeaderText = "Mã Hộ";
            MaHGD.MinimumWidth = 6;
            MaHGD.Name = "MaHGD";
            MaHGD.ReadOnly = true;
            // 
            // Thang
            // 
            Thang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Thang.DataPropertyName = "Thang";
            Thang.HeaderText = "Tháng";
            Thang.MinimumWidth = 6;
            Thang.Name = "Thang";
            Thang.ReadOnly = true;
            // 
            // TienNhaCoDinh
            // 
            TienNhaCoDinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TienNhaCoDinh.DataPropertyName = "TienNhaCoDinh";
            TienNhaCoDinh.HeaderText = "Tiền Nhà";
            TienNhaCoDinh.MinimumWidth = 6;
            TienNhaCoDinh.Name = "TienNhaCoDinh";
            TienNhaCoDinh.ReadOnly = true;
            // 
            // HeSoDien
            // 
            HeSoDien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HeSoDien.DataPropertyName = "HeSoDien";
            HeSoDien.HeaderText = "Hệ Số Điện";
            HeSoDien.MinimumWidth = 6;
            HeSoDien.Name = "HeSoDien";
            HeSoDien.ReadOnly = true;
            // 
            // HeSoNuoc
            // 
            HeSoNuoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HeSoNuoc.DataPropertyName = "HeSoNuoc";
            HeSoNuoc.HeaderText = "Hệ Số Nước";
            HeSoNuoc.MinimumWidth = 6;
            HeSoNuoc.Name = "HeSoNuoc";
            HeSoNuoc.ReadOnly = true;
            // 
            // PhiVSANTT
            // 
            PhiVSANTT.DataPropertyName = "PhiVSANTT";
            PhiVSANTT.HeaderText = "Phí Vệ Sinh và An Ninh";
            PhiVSANTT.MinimumWidth = 6;
            PhiVSANTT.Name = "PhiVSANTT";
            PhiVSANTT.ReadOnly = true;
            PhiVSANTT.Width = 125;
            // 
            // TongTienNha
            // 
            TongTienNha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TongTienNha.DataPropertyName = "TongTienNha";
            TongTienNha.HeaderText = "Tổng Tiền";
            TongTienNha.MinimumWidth = 6;
            TongTienNha.Name = "TongTienNha";
            TongTienNha.ReadOnly = true;
            // 
            // tbThangSau
            // 
            tbThangSau.Anchor = AnchorStyles.Top;
            tbThangSau.AutoSize = true;
            tbThangSau.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbThangSau.Location = new Point(522, 58);
            tbThangSau.Margin = new Padding(4, 0, 4, 0);
            tbThangSau.Name = "tbThangSau";
            tbThangSau.Size = new Size(76, 17);
            tbThangSau.TabIndex = 9;
            tbThangSau.Text = "Hệ số điện:";
            // 
            // tbTienNha
            // 
            tbTienNha.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTienNha.Location = new Point(614, 23);
            tbTienNha.Margin = new Padding(4);
            tbTienNha.Name = "tbTienNha";
            tbTienNha.Size = new Size(120, 24);
            tbTienNha.TabIndex = 8;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(534, 23);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 17);
            label5.TabIndex = 7;
            label5.Text = "Tiền Nhà:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(184, 117);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(52, 17);
            label4.TabIndex = 6;
            label4.Text = "Tháng:";
            // 
            // dtpkThang
            // 
            dtpkThang.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpkThang.Format = DateTimePickerFormat.Short;
            dtpkThang.Location = new Point(256, 114);
            dtpkThang.Margin = new Padding(4);
            dtpkThang.Name = "dtpkThang";
            dtpkThang.Size = new Size(125, 24);
            dtpkThang.TabIndex = 5;
            // 
            // tbMNTT
            // 
            tbMNTT.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbMNTT.Location = new Point(256, 31);
            tbMNTT.Margin = new Padding(4);
            tbMNTT.Name = "tbMNTT";
            tbMNTT.Size = new Size(120, 24);
            tbMNTT.TabIndex = 4;
            // 
            // cbHGD
            // 
            cbHGD.Anchor = AnchorStyles.Top;
            cbHGD.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbHGD.FormattingEnabled = true;
            cbHGD.Location = new Point(256, 72);
            cbHGD.Margin = new Padding(4);
            cbHGD.Name = "cbHGD";
            cbHGD.Size = new Size(122, 25);
            cbHGD.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(123, 75);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 17);
            label3.TabIndex = 2;
            label3.Text = "Mã Hộ Gia Đình:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(102, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 17);
            label1.TabIndex = 0;
            label1.Text = "Mã Người Thu Tiền:";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.BackColor = Color.FromArgb(255, 165, 89);
            groupBox1.Controls.Add(numNuoc);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(numDien);
            groupBox1.Controls.Add(tbPTT);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbThangSau);
            groupBox1.Controls.Add(tbTienNha);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpkThang);
            groupBox1.Controls.Add(tbMNTT);
            groupBox1.Controls.Add(cbHGD);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(39, 53);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(808, 161);
            groupBox1.TabIndex = 78;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // numNuoc
            // 
            numNuoc.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numNuoc.Location = new Point(614, 91);
            numNuoc.Margin = new Padding(4);
            numNuoc.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numNuoc.Name = "numNuoc";
            numNuoc.Size = new Size(122, 24);
            numNuoc.TabIndex = 17;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(519, 93);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(83, 17);
            label7.TabIndex = 16;
            label7.Text = "Hệ số nước:";
            // 
            // numDien
            // 
            numDien.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numDien.Location = new Point(614, 57);
            numDien.Margin = new Padding(4);
            numDien.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numDien.Name = "numDien";
            numDien.Size = new Size(122, 24);
            numDien.TabIndex = 15;
            // 
            // tbPTT
            // 
            tbPTT.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPTT.Location = new Point(614, 125);
            tbPTT.Margin = new Padding(4);
            tbPTT.Name = "tbPTT";
            tbPTT.Size = new Size(120, 24);
            tbPTT.TabIndex = 14;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(438, 128);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(156, 17);
            label6.TabIndex = 13;
            label6.Text = "Tiền Vệ Sinh và Trật Tự:";
            // 
            // btnCapnhat
            // 
            btnCapnhat.Anchor = AnchorStyles.Bottom;
            btnCapnhat.BackColor = Color.FromArgb(255, 96, 0);
            btnCapnhat.FlatStyle = FlatStyle.Popup;
            btnCapnhat.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCapnhat.Location = new Point(783, 521);
            btnCapnhat.Margin = new Padding(4);
            btnCapnhat.Name = "btnCapnhat";
            btnCapnhat.Size = new Size(109, 35);
            btnCapnhat.TabIndex = 76;
            btnCapnhat.Text = "Cập nhật";
            btnCapnhat.UseVisualStyleBackColor = false;
            btnCapnhat.Click += btnCapnhat_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(405, 19);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 73;
            label2.Text = "Tiền Nhà";
            // 
            // rtbTinhTien
            // 
            rtbTinhTien.BackColor = Color.White;
            rtbTinhTien.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbTinhTien.Location = new Point(39, 514);
            rtbTinhTien.Margin = new Padding(4);
            rtbTinhTien.Name = "rtbTinhTien";
            rtbTinhTien.Size = new Size(151, 38);
            rtbTinhTien.TabIndex = 79;
            rtbTinhTien.Text = "";
            // 
            // btnTinhTien
            // 
            btnTinhTien.Anchor = AnchorStyles.Bottom;
            btnTinhTien.BackColor = Color.FromArgb(255, 96, 0);
            btnTinhTien.FlatStyle = FlatStyle.Popup;
            btnTinhTien.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTinhTien.Location = new Point(200, 521);
            btnTinhTien.Margin = new Padding(4);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(95, 35);
            btnTinhTien.TabIndex = 80;
            btnTinhTien.Text = "Tính Tiền";
            btnTinhTien.UseVisualStyleBackColor = false;
            btnTinhTien.Click += btnTinhTien_Click;
            // 
            // btnReload
            // 
            btnReload.BackColor = Color.FromArgb(255, 96, 0);
            btnReload.ForeColor = SystemColors.ButtonHighlight;
            btnReload.Image = Properties.Resources.reload;
            btnReload.Location = new Point(855, 60);
            btnReload.Margin = new Padding(4);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(38, 37);
            btnReload.TabIndex = 81;
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += btnReload_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 230, 199);
            btnExit.BackgroundImageLayout = ImageLayout.Center;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(903, -1);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(32, 32);
            btnExit.TabIndex = 82;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // formTienNha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 230, 199);
            ClientSize = new Size(934, 566);
            Controls.Add(btnExit);
            Controls.Add(btnReload);
            Controls.Add(btnTinhTien);
            Controls.Add(rtbTinhTien);
            Controls.Add(dtTienNha);
            Controls.Add(groupBox1);
            Controls.Add(btnCapnhat);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "formTienNha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tiền Nhà";
            Load += formTienNha_Load;
            ((System.ComponentModel.ISupportInitialize)dtTienNha).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numNuoc).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDien).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
        private System.Windows.Forms.Button btnExit;
    }
}