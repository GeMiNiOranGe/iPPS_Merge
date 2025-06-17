namespace Pepro.Presentation
{
    partial class ElectricityPaymentForm
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
            label2 = new Label();
            btnXoa = new Button();
            btnCapnhat = new Button();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            numThangSau = new NumericUpDown();
            numThangTruoc = new NumericUpDown();
            tbDonVi = new TextBox();
            DonVi = new Label();
            tbThangSau = new Label();
            label5 = new Label();
            label4 = new Label();
            dtpkThang = new DateTimePicker();
            tbMaDien = new TextBox();
            cbHGD = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            dtDien = new DataGridView();
            MaDien = new DataGridViewTextBoxColumn();
            MaHGD = new DataGridViewTextBoxColumn();
            Thang = new DataGridViewTextBoxColumn();
            HeSoDienThangTruoc = new DataGridViewTextBoxColumn();
            HeSoDienHienTai = new DataGridViewTextBoxColumn();
            btnReload = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numThangSau).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numThangTruoc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtDien).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(424, 8);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 56;
            label2.Text = "Điện";
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom;
            btnXoa.BackColor = Color.FromArgb(255, 96, 0);
            btnXoa.FlatStyle = FlatStyle.Popup;
            btnXoa.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(550, 504);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(109, 35);
            btnXoa.TabIndex = 63;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapnhat
            // 
            btnCapnhat.Anchor = AnchorStyles.Bottom;
            btnCapnhat.BackColor = Color.FromArgb(255, 96, 0);
            btnCapnhat.FlatStyle = FlatStyle.Popup;
            btnCapnhat.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapnhat.Location = new Point(412, 504);
            btnCapnhat.Margin = new Padding(4);
            btnCapnhat.Name = "btnCapnhat";
            btnCapnhat.Size = new Size(109, 35);
            btnCapnhat.TabIndex = 62;
            btnCapnhat.Text = "Cập nhật";
            btnCapnhat.UseVisualStyleBackColor = false;
            btnCapnhat.Click += btnCapnhat_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom;
            btnThem.BackColor = Color.FromArgb(255, 96, 0);
            btnThem.FlatStyle = FlatStyle.Popup;
            btnThem.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(275, 504);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(109, 35);
            btnThem.TabIndex = 61;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.BackColor = Color.FromArgb(255, 165, 89);
            groupBox1.Controls.Add(numThangSau);
            groupBox1.Controls.Add(numThangTruoc);
            groupBox1.Controls.Add(tbDonVi);
            groupBox1.Controls.Add(DonVi);
            groupBox1.Controls.Add(tbThangSau);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpkThang);
            groupBox1.Controls.Add(tbMaDien);
            groupBox1.Controls.Add(cbHGD);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(76, 54);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(780, 155);
            groupBox1.TabIndex = 65;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // numThangSau
            // 
            numThangSau.Location = new Point(569, 68);
            numThangSau.Margin = new Padding(4);
            numThangSau.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numThangSau.Name = "numThangSau";
            numThangSau.Size = new Size(122, 24);
            numThangSau.TabIndex = 14;
            // 
            // numThangTruoc
            // 
            numThangTruoc.Location = new Point(569, 26);
            numThangTruoc.Margin = new Padding(4);
            numThangTruoc.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numThangTruoc.Name = "numThangTruoc";
            numThangTruoc.Size = new Size(122, 24);
            numThangTruoc.TabIndex = 13;
            // 
            // tbDonVi
            // 
            tbDonVi.Location = new Point(569, 109);
            tbDonVi.Margin = new Padding(4);
            tbDonVi.Name = "tbDonVi";
            tbDonVi.Size = new Size(120, 24);
            tbDonVi.TabIndex = 12;
            // 
            // DonVi
            // 
            DonVi.Anchor = AnchorStyles.Top;
            DonVi.AutoSize = true;
            DonVi.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DonVi.Location = new Point(492, 114);
            DonVi.Margin = new Padding(4, 0, 4, 0);
            DonVi.Name = "DonVi";
            DonVi.Size = new Size(53, 17);
            DonVi.TabIndex = 11;
            DonVi.Text = "Đơn Vị:";
            // 
            // tbThangSau
            // 
            tbThangSau.Anchor = AnchorStyles.Top;
            tbThangSau.AutoSize = true;
            tbThangSau.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbThangSau.Location = new Point(424, 72);
            tbThangSau.Margin = new Padding(4, 0, 4, 0);
            tbThangSau.Name = "tbThangSau";
            tbThangSau.Size = new Size(119, 17);
            tbThangSau.TabIndex = 9;
            tbThangSau.Text = "Hệ Số Tháng Sau:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(410, 30);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(133, 17);
            label5.TabIndex = 7;
            label5.Text = "Hệ Số Tháng Trước:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(151, 115);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(52, 17);
            label4.TabIndex = 6;
            label4.Text = "Tháng:";
            // 
            // dtpkThang
            // 
            dtpkThang.Format = DateTimePickerFormat.Short;
            dtpkThang.Location = new Point(228, 110);
            dtpkThang.Margin = new Padding(4);
            dtpkThang.Name = "dtpkThang";
            dtpkThang.Size = new Size(125, 24);
            dtpkThang.TabIndex = 5;
            dtpkThang.ValueChanged += dtpkThang_ValueChanged;
            // 
            // tbMaDien
            // 
            tbMaDien.Location = new Point(229, 26);
            tbMaDien.Margin = new Padding(4);
            tbMaDien.Name = "tbMaDien";
            tbMaDien.Size = new Size(120, 24);
            tbMaDien.TabIndex = 4;
            // 
            // cbHGD
            // 
            cbHGD.Anchor = AnchorStyles.Top;
            cbHGD.FormattingEnabled = true;
            cbHGD.Location = new Point(228, 68);
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
            label3.Location = new Point(91, 73);
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
            label1.Location = new Point(138, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 17);
            label1.TabIndex = 0;
            label1.Text = "Mã Điện:";
            // 
            // dtDien
            // 
            dtDien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtDien.Columns.AddRange(new DataGridViewColumn[] { MaDien, MaHGD, Thang, HeSoDienThangTruoc, HeSoDienHienTai });
            dtDien.Location = new Point(76, 227);
            dtDien.Margin = new Padding(4);
            dtDien.Name = "dtDien";
            dtDien.RowHeadersWidth = 51;
            dtDien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtDien.Size = new Size(780, 255);
            dtDien.TabIndex = 66;
            dtDien.CellContentClick += dtDien_CellContentClick;
            // 
            // MaDien
            // 
            MaDien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaDien.DataPropertyName = "MaDien";
            MaDien.HeaderText = "Mã Điện";
            MaDien.MinimumWidth = 6;
            MaDien.Name = "MaDien";
            MaDien.ReadOnly = true;
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
            // HeSoDienThangTruoc
            // 
            HeSoDienThangTruoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HeSoDienThangTruoc.DataPropertyName = "HeSoDienThangTruoc";
            HeSoDienThangTruoc.HeaderText = "Hệ Số Tháng Trước";
            HeSoDienThangTruoc.MinimumWidth = 6;
            HeSoDienThangTruoc.Name = "HeSoDienThangTruoc";
            HeSoDienThangTruoc.ReadOnly = true;
            // 
            // HeSoDienHienTai
            // 
            HeSoDienHienTai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HeSoDienHienTai.DataPropertyName = "HeSoDienHienTai";
            HeSoDienHienTai.HeaderText = "Hệ Số Hiện Tại";
            HeSoDienHienTai.MinimumWidth = 6;
            HeSoDienHienTai.Name = "HeSoDienHienTai";
            HeSoDienHienTai.ReadOnly = true;
            // 
            // btnReload
            // 
            btnReload.BackColor = Color.FromArgb(255, 96, 0);
            btnReload.ForeColor = SystemColors.ButtonHighlight;
            btnReload.Image = Properties.Resources.reload;
            btnReload.Location = new Point(864, 54);
            btnReload.Margin = new Padding(4);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(38, 37);
            btnReload.TabIndex = 15;
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
            btnExit.TabIndex = 67;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // formTienDien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 230, 199);
            ClientSize = new Size(934, 553);
            Controls.Add(btnExit);
            Controls.Add(btnReload);
            Controls.Add(dtDien);
            Controls.Add(groupBox1);
            Controls.Add(btnXoa);
            Controls.Add(btnCapnhat);
            Controls.Add(btnThem);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "formTienDien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Điện";
            Load += formTienDien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numThangSau).EndInit();
            ((System.ComponentModel.ISupportInitialize)numThangTruoc).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtDien).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label2;
        private Button btnXoa;
        private Button btnCapnhat;
        private Button btnThem;
        private GroupBox groupBox1;
        private Label label4;
        private DateTimePicker dtpkThang;
        private TextBox tbMaDien;
        private ComboBox cbHGD;
        private Label label3;
        private Label label1;
        private TextBox tbDonVi;
        private Label DonVi;
        private Label tbThangSau;
        private Label label5;
        private DataGridView dtDien;
        private DataGridViewTextBoxColumn MaDien;
        private DataGridViewTextBoxColumn MaHGD;
        private DataGridViewTextBoxColumn Thang;
        private DataGridViewTextBoxColumn HeSoDienThangTruoc;
        private DataGridViewTextBoxColumn HeSoDienHienTai;
        private NumericUpDown numThangSau;
        private NumericUpDown numThangTruoc;
        private Button btnReload;
        private Button btnExit;
    }
}