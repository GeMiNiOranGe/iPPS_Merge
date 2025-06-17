namespace Pepro.Presentation
{
    partial class WaterPaymentForm
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
            numThangSau = new NumericUpDown();
            numThangtruoc = new NumericUpDown();
            tbDonVi = new TextBox();
            DonVi = new Label();
            tbThangSau = new Label();
            label5 = new Label();
            label4 = new Label();
            dtpkThang = new DateTimePicker();
            tbMaN = new TextBox();
            cbMaho = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            btnXoa = new Button();
            btnCapnhat = new Button();
            btnThem = new Button();
            label2 = new Label();
            btnReload = new Button();
            dtNuoc = new DataGridView();
            MaNUOC = new DataGridViewTextBoxColumn();
            MaHGD = new DataGridViewTextBoxColumn();
            Thang = new DataGridViewTextBoxColumn();
            HESONUOCTHANGTRUOC = new DataGridViewTextBoxColumn();
            HESONUOCHIENTAI = new DataGridViewTextBoxColumn();
            DVN = new DataGridViewTextBoxColumn();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numThangSau).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numThangtruoc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtNuoc).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.BackColor = Color.FromArgb(255, 165, 89);
            groupBox1.Controls.Add(numThangSau);
            groupBox1.Controls.Add(numThangtruoc);
            groupBox1.Controls.Add(tbDonVi);
            groupBox1.Controls.Add(DonVi);
            groupBox1.Controls.Add(tbThangSau);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpkThang);
            groupBox1.Controls.Add(tbMaN);
            groupBox1.Controls.Add(cbMaho);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(60, 51);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(780, 142);
            groupBox1.TabIndex = 72;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // numThangSau
            // 
            numThangSau.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numThangSau.Location = new Point(600, 61);
            numThangSau.Margin = new Padding(4);
            numThangSau.Name = "numThangSau";
            numThangSau.Size = new Size(122, 24);
            numThangSau.TabIndex = 14;
            // 
            // numThangtruoc
            // 
            numThangtruoc.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numThangtruoc.Location = new Point(600, 21);
            numThangtruoc.Margin = new Padding(4);
            numThangtruoc.Name = "numThangtruoc";
            numThangtruoc.Size = new Size(122, 24);
            numThangtruoc.TabIndex = 13;
            // 
            // tbDonVi
            // 
            tbDonVi.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDonVi.Location = new Point(600, 103);
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
            DonVi.Location = new Point(528, 110);
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
            tbThangSau.Location = new Point(460, 68);
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
            label5.Location = new Point(446, 25);
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
            label4.Location = new Point(150, 110);
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
            dtpkThang.Location = new Point(219, 103);
            dtpkThang.Margin = new Padding(4);
            dtpkThang.Name = "dtpkThang";
            dtpkThang.Size = new Size(121, 24);
            dtpkThang.TabIndex = 5;
            dtpkThang.ValueChanged += dtpkThang_ValueChanged;
            // 
            // tbMaN
            // 
            tbMaN.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbMaN.Location = new Point(220, 20);
            tbMaN.Margin = new Padding(4);
            tbMaN.Name = "tbMaN";
            tbMaN.Size = new Size(120, 24);
            tbMaN.TabIndex = 4;
            // 
            // cbMaho
            // 
            cbMaho.Anchor = AnchorStyles.Top;
            cbMaho.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbMaho.FormattingEnabled = true;
            cbMaho.Location = new Point(219, 61);
            cbMaho.Margin = new Padding(4);
            cbMaho.Name = "cbMaho";
            cbMaho.Size = new Size(122, 25);
            cbMaho.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(89, 68);
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
            label1.Location = new Point(133, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 0;
            label1.Text = "Mã Nước:";
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom;
            btnXoa.BackColor = Color.FromArgb(255, 96, 0);
            btnXoa.FlatStyle = FlatStyle.Popup;
            btnXoa.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(536, 467);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(109, 35);
            btnXoa.TabIndex = 70;
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
            btnCapnhat.Location = new Point(388, 467);
            btnCapnhat.Margin = new Padding(4);
            btnCapnhat.Name = "btnCapnhat";
            btnCapnhat.Size = new Size(109, 35);
            btnCapnhat.TabIndex = 69;
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
            btnThem.Location = new Point(245, 467);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(109, 35);
            btnThem.TabIndex = 68;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(409, 19);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 66;
            label2.Text = "Nước";
            // 
            // btnReload
            // 
            btnReload.BackColor = Color.FromArgb(255, 96, 0);
            btnReload.ForeColor = SystemColors.ButtonHighlight;
            btnReload.Image = Properties.Resources.reload;
            btnReload.Location = new Point(844, 61);
            btnReload.Margin = new Padding(4);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(38, 37);
            btnReload.TabIndex = 73;
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += btnReload_Click;
            // 
            // dtNuoc
            // 
            dtNuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtNuoc.Columns.AddRange(new DataGridViewColumn[] { MaNUOC, MaHGD, Thang, HESONUOCTHANGTRUOC, HESONUOCHIENTAI, DVN });
            dtNuoc.Location = new Point(60, 214);
            dtNuoc.Margin = new Padding(4);
            dtNuoc.Name = "dtNuoc";
            dtNuoc.RowHeadersWidth = 51;
            dtNuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtNuoc.Size = new Size(780, 230);
            dtNuoc.TabIndex = 74;
            dtNuoc.CellContentClick += dtNuoc_CellContentClick;
            // 
            // MaNUOC
            // 
            MaNUOC.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaNUOC.DataPropertyName = "MaNUOC";
            MaNUOC.HeaderText = "Mã Nước";
            MaNUOC.MinimumWidth = 6;
            MaNUOC.Name = "MaNUOC";
            MaNUOC.ReadOnly = true;
            // 
            // MaHGD
            // 
            MaHGD.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaHGD.DataPropertyName = "MAHGD";
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
            // HESONUOCTHANGTRUOC
            // 
            HESONUOCTHANGTRUOC.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HESONUOCTHANGTRUOC.DataPropertyName = "HESONUOCTHANGTRUOC";
            HESONUOCTHANGTRUOC.HeaderText = "Hệ Số Tháng Trước";
            HESONUOCTHANGTRUOC.MinimumWidth = 6;
            HESONUOCTHANGTRUOC.Name = "HESONUOCTHANGTRUOC";
            HESONUOCTHANGTRUOC.ReadOnly = true;
            // 
            // HESONUOCHIENTAI
            // 
            HESONUOCHIENTAI.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HESONUOCHIENTAI.DataPropertyName = "HESONUOCHIENTAI";
            HESONUOCHIENTAI.HeaderText = "Hệ Số Tháng Sau";
            HESONUOCHIENTAI.MinimumWidth = 6;
            HESONUOCHIENTAI.Name = "HESONUOCHIENTAI";
            HESONUOCHIENTAI.ReadOnly = true;
            // 
            // DVN
            // 
            DVN.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DVN.DataPropertyName = "DVN";
            DVN.HeaderText = "Đơn Vị";
            DVN.MinimumWidth = 6;
            DVN.Name = "DVN";
            DVN.ReadOnly = true;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 230, 199);
            btnExit.BackgroundImageLayout = ImageLayout.Center;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(911, -1);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(32, 32);
            btnExit.TabIndex = 75;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // formTienNuoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 230, 199);
            ClientSize = new Size(942, 519);
            Controls.Add(btnExit);
            Controls.Add(dtNuoc);
            Controls.Add(btnReload);
            Controls.Add(groupBox1);
            Controls.Add(btnXoa);
            Controls.Add(btnCapnhat);
            Controls.Add(btnThem);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "formTienNuoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nước";
            Load += formTienNuoc_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numThangSau).EndInit();
            ((System.ComponentModel.ISupportInitialize)numThangtruoc).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtNuoc).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbDonVi;
        private Label DonVi;
        private Label tbThangSau;
        private Label label5;
        private Label label4;
        private DateTimePicker dtpkThang;
        private TextBox tbMaN;
        private ComboBox cbMaho;
        private Label label3;
        private Label label1;
        private Button btnXoa;
        private Button btnCapnhat;
        private Button btnThem;
        private Label label2;
        private NumericUpDown numThangSau;
        private NumericUpDown numThangtruoc;
        private Button btnReload;
        private DataGridView dtNuoc;
        private DataGridViewTextBoxColumn MaNUOC;
        private DataGridViewTextBoxColumn MaHGD;
        private DataGridViewTextBoxColumn Thang;
        private DataGridViewTextBoxColumn HESONUOCTHANGTRUOC;
        private DataGridViewTextBoxColumn HESONUOCHIENTAI;
        private DataGridViewTextBoxColumn DVN;
        private Button btnExit;
    }
}