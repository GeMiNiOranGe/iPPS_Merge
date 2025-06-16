namespace Pepro.Presentation
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
        private void InitializeComponent() {
            groupBox1 = new GroupBox();
            cbTinhTrang = new ComboBox();
            label6 = new Label();
            tbMaCC = new TextBox();
            label10 = new Label();
            label9 = new Label();
            numDiLam = new NumericUpDown();
            label5 = new Label();
            numngaynghiBHXH = new NumericUpDown();
            label4 = new Label();
            numngaynghi = new NumericUpDown();
            dtpNgayLV = new DateTimePicker();
            cboManv = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            btnThem = new Button();
            btnCapnhat = new Button();
            btnXoa = new Button();
            dataChamCong = new DataGridView();
            MACC = new DataGridViewTextBoxColumn();
            THANG = new DataGridViewTextBoxColumn();
            SONGAYTRONGTHANG = new DataGridViewTextBoxColumn();
            SONGAYNGHIBHXH = new DataGridViewTextBoxColumn();
            SONGAYNGHIKHONGLYDO = new DataGridViewTextBoxColumn();
            MANV = new DataGridViewTextBoxColumn();
            label2 = new Label();
            btnChamCong = new Button();
            btnBaoCao = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDiLam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numngaynghiBHXH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numngaynghi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataChamCong).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.AutoSize = true;
            groupBox1.BackColor = Color.FromArgb(255, 165, 89);
            groupBox1.Controls.Add(cbTinhTrang);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbMaCC);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(numDiLam);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(numngaynghiBHXH);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numngaynghi);
            groupBox1.Controls.Add(dtpNgayLV);
            groupBox1.Controls.Add(cboManv);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(10, 70);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(988, 163);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Chấm Công";
            // 
            // cbTinhTrang
            // 
            cbTinhTrang.BackColor = SystemColors.Info;
            cbTinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTinhTrang.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbTinhTrang.FormattingEnabled = true;
            cbTinhTrang.Items.AddRange(new object[] { "Đi làm", "Nghỉ có phép", "Nghỉ không phép" });
            cbTinhTrang.Location = new Point(162, 78);
            cbTinhTrang.Margin = new Padding(4, 2, 4, 2);
            cbTinhTrang.Name = "cbTinhTrang";
            cbTinhTrang.Size = new Size(154, 25);
            cbTinhTrang.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(65, 81);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(85, 18);
            label6.TabIndex = 25;
            label6.Text = "Tình Trạng:";
            // 
            // tbMaCC
            // 
            tbMaCC.Location = new Point(162, 37);
            tbMaCC.Margin = new Padding(4);
            tbMaCC.Name = "tbMaCC";
            tbMaCC.Size = new Size(154, 24);
            tbMaCC.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(35, 38);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(114, 18);
            label10.TabIndex = 23;
            label10.Text = "Mã Chấm Công:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(760, 29);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(110, 18);
            label9.TabIndex = 22;
            label9.Text = "Số ngày đi làm:";
            // 
            // numDiLam
            // 
            numDiLam.Location = new Point(893, 27);
            numDiLam.Margin = new Padding(4);
            numDiLam.Name = "numDiLam";
            numDiLam.Size = new Size(80, 24);
            numDiLam.TabIndex = 21;
            numDiLam.ValueChanged += numDiLam_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(727, 115);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(140, 18);
            label5.TabIndex = 20;
            label5.Text = "Số ngày nghỉ BHXH:";
            // 
            // numngaynghiBHXH
            // 
            numngaynghiBHXH.Location = new Point(893, 110);
            numngaynghiBHXH.Margin = new Padding(4);
            numngaynghiBHXH.Name = "numngaynghiBHXH";
            numngaynghiBHXH.Size = new Size(80, 24);
            numngaynghiBHXH.TabIndex = 19;
            numngaynghiBHXH.ValueChanged += numngaynghiBHXH_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(684, 72);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(178, 18);
            label4.TabIndex = 18;
            label4.Text = "Số ngày nghỉ không phép:";
            // 
            // numngaynghi
            // 
            numngaynghi.Location = new Point(893, 68);
            numngaynghi.Margin = new Padding(4);
            numngaynghi.Name = "numngaynghi";
            numngaynghi.Size = new Size(80, 24);
            numngaynghi.TabIndex = 17;
            numngaynghi.ValueChanged += numngaynghi_ValueChanged;
            // 
            // dtpNgayLV
            // 
            dtpNgayLV.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayLV.Format = DateTimePickerFormat.Short;
            dtpNgayLV.Location = new Point(462, 79);
            dtpNgayLV.Margin = new Padding(4, 2, 4, 2);
            dtpNgayLV.Name = "dtpNgayLV";
            dtpNgayLV.Size = new Size(200, 25);
            dtpNgayLV.TabIndex = 16;
            dtpNgayLV.ValueChanged += dtpNgayLV_ValueChanged;
            // 
            // cboManv
            // 
            cboManv.BackColor = SystemColors.Info;
            cboManv.DropDownStyle = ComboBoxStyle.DropDownList;
            cboManv.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboManv.FormattingEnabled = true;
            cboManv.Location = new Point(462, 36);
            cboManv.Margin = new Padding(4, 2, 4, 2);
            cboManv.Name = "cboManv";
            cboManv.Size = new Size(200, 25);
            cboManv.TabIndex = 15;
            cboManv.SelectedIndexChanged += cboManv_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(345, 83);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 18);
            label3.TabIndex = 12;
            label3.Text = "Ngày làm việc:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(348, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 18);
            label1.TabIndex = 10;
            label1.Text = "Mã nhân viên:";
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnThem.BackColor = Color.FromArgb(255, 96, 0);
            btnThem.FlatStyle = FlatStyle.Popup;
            btnThem.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(380, 572);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(109, 35);
            btnThem.TabIndex = 50;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnCapnhat
            // 
            btnCapnhat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCapnhat.BackColor = Color.FromArgb(255, 96, 0);
            btnCapnhat.FlatStyle = FlatStyle.Popup;
            btnCapnhat.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapnhat.Location = new Point(517, 572);
            btnCapnhat.Margin = new Padding(4);
            btnCapnhat.Name = "btnCapnhat";
            btnCapnhat.Size = new Size(109, 35);
            btnCapnhat.TabIndex = 51;
            btnCapnhat.Text = "Cập nhật";
            btnCapnhat.UseVisualStyleBackColor = false;
            btnCapnhat.Click += btnCapnhat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXoa.BackColor = Color.FromArgb(255, 96, 0);
            btnXoa.FlatStyle = FlatStyle.Popup;
            btnXoa.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(654, 572);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(109, 35);
            btnXoa.TabIndex = 52;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // dataChamCong
            // 
            dataChamCong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataChamCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataChamCong.Columns.AddRange(new DataGridViewColumn[] { MACC, THANG, SONGAYTRONGTHANG, SONGAYNGHIBHXH, SONGAYNGHIKHONGLYDO, MANV });
            dataChamCong.Location = new Point(2, 231);
            dataChamCong.Margin = new Padding(4);
            dataChamCong.Name = "dataChamCong";
            dataChamCong.RowHeadersWidth = 51;
            dataChamCong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataChamCong.Size = new Size(1004, 314);
            dataChamCong.TabIndex = 54;
            dataChamCong.SelectionChanged += dataChamCong_SelectionChanged;
            // 
            // MACC
            // 
            MACC.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MACC.DataPropertyName = "MACC";
            MACC.HeaderText = "Mã Chấm Công";
            MACC.MinimumWidth = 6;
            MACC.Name = "MACC";
            MACC.ReadOnly = true;
            // 
            // THANG
            // 
            THANG.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            THANG.DataPropertyName = "THANG";
            THANG.HeaderText = "Tháng";
            THANG.MinimumWidth = 6;
            THANG.Name = "THANG";
            THANG.ReadOnly = true;
            // 
            // SONGAYTRONGTHANG
            // 
            SONGAYTRONGTHANG.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SONGAYTRONGTHANG.DataPropertyName = "SONGAYTRONGTHANG";
            SONGAYTRONGTHANG.HeaderText = "Số ngày trong tháng";
            SONGAYTRONGTHANG.MinimumWidth = 6;
            SONGAYTRONGTHANG.Name = "SONGAYTRONGTHANG";
            SONGAYTRONGTHANG.ReadOnly = true;
            // 
            // SONGAYNGHIBHXH
            // 
            SONGAYNGHIBHXH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SONGAYNGHIBHXH.DataPropertyName = "SONGAYNGHIBHXH";
            SONGAYNGHIBHXH.HeaderText = "Số ngày nghỉ BHXH";
            SONGAYNGHIBHXH.MinimumWidth = 6;
            SONGAYNGHIBHXH.Name = "SONGAYNGHIBHXH";
            SONGAYNGHIBHXH.ReadOnly = true;
            // 
            // SONGAYNGHIKHONGLYDO
            // 
            SONGAYNGHIKHONGLYDO.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SONGAYNGHIKHONGLYDO.DataPropertyName = "SONGAYNGHIKHONGLYDO";
            SONGAYNGHIKHONGLYDO.HeaderText = "Số ngày nghỉ không lý do";
            SONGAYNGHIKHONGLYDO.MinimumWidth = 6;
            SONGAYNGHIKHONGLYDO.Name = "SONGAYNGHIKHONGLYDO";
            // 
            // MANV
            // 
            MANV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MANV.DataPropertyName = "MANV";
            MANV.HeaderText = "Mã Nhân Viên";
            MANV.MinimumWidth = 6;
            MANV.Name = "MANV";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(430, 23);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(138, 27);
            label2.TabIndex = 55;
            label2.Text = "Chấm Công";
            // 
            // btnChamCong
            // 
            btnChamCong.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnChamCong.BackColor = Color.FromArgb(255, 96, 0);
            btnChamCong.FlatStyle = FlatStyle.Popup;
            btnChamCong.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChamCong.Location = new Point(242, 572);
            btnChamCong.Margin = new Padding(4);
            btnChamCong.Name = "btnChamCong";
            btnChamCong.Size = new Size(109, 35);
            btnChamCong.TabIndex = 56;
            btnChamCong.Text = "Chấm công";
            btnChamCong.UseVisualStyleBackColor = false;
            btnChamCong.Click += btnChamCong_Click_1;
            // 
            // btnBaoCao
            // 
            btnBaoCao.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBaoCao.BackColor = Color.FromArgb(255, 96, 0);
            btnBaoCao.FlatStyle = FlatStyle.Popup;
            btnBaoCao.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBaoCao.Location = new Point(105, 572);
            btnBaoCao.Margin = new Padding(4);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Size = new Size(109, 35);
            btnBaoCao.TabIndex = 57;
            btnBaoCao.Text = "Xuất báo cáo";
            btnBaoCao.UseVisualStyleBackColor = false;
            btnBaoCao.Click += btnBaoCao_Click;
            // 
            // formChamCong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(255, 230, 199);
            Controls.Add(btnBaoCao);
            Controls.Add(btnChamCong);
            Controls.Add(label2);
            Controls.Add(dataChamCong);
            Controls.Add(btnXoa);
            Controls.Add(btnCapnhat);
            Controls.Add(btnThem);
            Controls.Add(groupBox1);
            Margin = new Padding(4);
            Name = "formChamCong";
            Size = new Size(1006, 619);
            Load += fromChamCong_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDiLam).EndInit();
            ((System.ComponentModel.ISupportInitialize)numngaynghiBHXH).EndInit();
            ((System.ComponentModel.ISupportInitialize)numngaynghi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataChamCong).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private Label label1;
        private Button btnThem;
        private Button btnCapnhat;
        private Button btnXoa;
        private DataGridView dataChamCong;
        private DataGridViewTextBoxColumn MACC;
        private DataGridViewTextBoxColumn THANG;
        private DataGridViewTextBoxColumn SONGAYTRONGTHANG;
        private DataGridViewTextBoxColumn SONGAYNGHIBHXH;
        private DataGridViewTextBoxColumn SONGAYNGHIKHONGLYDO;
        private DataGridViewTextBoxColumn MANV;
        private ComboBox cboManv;
        private Label label2;
        private Label label4;
        private NumericUpDown numngaynghi;
        private DateTimePicker dtpNgayLV;
        private Label label3;
        private Label label9;
        private NumericUpDown numDiLam;
        private Label label5;
        private NumericUpDown numngaynghiBHXH;
        private TextBox tbMaCC;
        private Label label10;
        private ComboBox cbTinhTrang;
        private Label label6;
        private Button btnChamCong;
        private Button btnBaoCao;
    }
}