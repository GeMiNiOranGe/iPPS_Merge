namespace Pepro.Presentation
{
    partial class DormitoryForm
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
            menuStrip1 = new MenuStrip();
            điệnToolStripMenuItem = new ToolStripMenuItem();
            nướcToolStripMenuItem = new ToolStripMenuItem();
            tiềnNhàToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            dtHoGiaDinh = new DataGridView();
            MaHoGD = new DataGridViewTextBoxColumn();
            MaNV1 = new DataGridViewTextBoxColumn();
            MaNV2 = new DataGridViewTextBoxColumn();
            btnCapnhat = new Button();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            cbMaNV2 = new ComboBox();
            label4 = new Label();
            cbMaNV1 = new ComboBox();
            tbHoGiaDinh = new TextBox();
            label3 = new Label();
            label1 = new Label();
            btnTimKiem = new Button();
            rtbTimKiem = new RichTextBox();
            btnHuy = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtHoGiaDinh).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { điệnToolStripMenuItem, nướcToolStripMenuItem, tiềnNhàToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1006, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // điệnToolStripMenuItem
            // 
            điệnToolStripMenuItem.Name = "điệnToolStripMenuItem";
            điệnToolStripMenuItem.Size = new Size(55, 21);
            điệnToolStripMenuItem.Text = "Điện ";
            điệnToolStripMenuItem.Click += điệnToolStripMenuItem_Click;
            // 
            // nướcToolStripMenuItem
            // 
            nướcToolStripMenuItem.Name = "nướcToolStripMenuItem";
            nướcToolStripMenuItem.Size = new Size(57, 21);
            nướcToolStripMenuItem.Text = "Nước";
            nướcToolStripMenuItem.Click += nướcToolStripMenuItem_Click;
            // 
            // tiềnNhàToolStripMenuItem
            // 
            tiềnNhàToolStripMenuItem.Name = "tiềnNhàToolStripMenuItem";
            tiềnNhàToolStripMenuItem.Size = new Size(81, 21);
            tiềnNhàToolStripMenuItem.Text = "Tiền Nhà";
            tiềnNhàToolStripMenuItem.Click += tiềnNhàToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(421, 38);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 56;
            label2.Text = "Kí Túc Xá";
            // 
            // dtHoGiaDinh
            // 
            dtHoGiaDinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtHoGiaDinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtHoGiaDinh.Columns.AddRange(new DataGridViewColumn[] { MaHoGD, MaNV1, MaNV2 });
            dtHoGiaDinh.Location = new Point(158, 218);
            dtHoGiaDinh.Margin = new Padding(4);
            dtHoGiaDinh.Name = "dtHoGiaDinh";
            dtHoGiaDinh.RowHeadersWidth = 51;
            dtHoGiaDinh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtHoGiaDinh.Size = new Size(692, 315);
            dtHoGiaDinh.TabIndex = 57;
            dtHoGiaDinh.CellContentClick += dtHoGiaDinh_CellContentClick;
            // 
            // MaHoGD
            // 
            MaHoGD.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaHoGD.DataPropertyName = "MaHoGD";
            MaHoGD.HeaderText = "Mã Hộ";
            MaHoGD.MinimumWidth = 6;
            MaHoGD.Name = "MaHoGD";
            MaHoGD.ReadOnly = true;
            // 
            // MaNV1
            // 
            MaNV1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaNV1.DataPropertyName = "MaNV1";
            MaNV1.HeaderText = "Mã Nhân Viên";
            MaNV1.MinimumWidth = 6;
            MaNV1.Name = "MaNV1";
            MaNV1.ReadOnly = true;
            // 
            // MaNV2
            // 
            MaNV2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaNV2.DataPropertyName = "MaNV2";
            MaNV2.HeaderText = "Mã Nhân Viên";
            MaNV2.MinimumWidth = 6;
            MaNV2.Name = "MaNV2";
            MaNV2.ReadOnly = true;
            // 
            // btnCapnhat
            // 
            btnCapnhat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCapnhat.BackColor = Color.FromArgb(255, 96, 0);
            btnCapnhat.FlatStyle = FlatStyle.Popup;
            btnCapnhat.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCapnhat.Location = new Point(731, 562);
            btnCapnhat.Margin = new Padding(4);
            btnCapnhat.Name = "btnCapnhat";
            btnCapnhat.Size = new Size(109, 35);
            btnCapnhat.TabIndex = 59;
            btnCapnhat.Text = "Cập nhật";
            btnCapnhat.UseVisualStyleBackColor = false;
            btnCapnhat.Click += btnCapnhat_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnThem.BackColor = Color.FromArgb(255, 96, 0);
            btnThem.FlatStyle = FlatStyle.Popup;
            btnThem.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(600, 561);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(109, 35);
            btnThem.TabIndex = 58;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.BackColor = Color.FromArgb(255, 165, 89);
            groupBox1.Controls.Add(cbMaNV2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbMaNV1);
            groupBox1.Controls.Add(tbHoGiaDinh);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(159, 81);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(690, 130);
            groupBox1.TabIndex = 61;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            // 
            // cbMaNV2
            // 
            cbMaNV2.FormattingEnabled = true;
            cbMaNV2.Location = new Point(350, 53);
            cbMaNV2.Margin = new Padding(4);
            cbMaNV2.Name = "cbMaNV2";
            cbMaNV2.Size = new Size(122, 25);
            cbMaNV2.TabIndex = 6;
            cbMaNV2.SelectedIndexChanged += cbMaNV2_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(230, 56);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 17);
            label4.TabIndex = 5;
            label4.Text = "Mã Nhân Viên:";
            // 
            // cbMaNV1
            // 
            cbMaNV1.FormattingEnabled = true;
            cbMaNV1.Location = new Point(350, 19);
            cbMaNV1.Margin = new Padding(4);
            cbMaNV1.Name = "cbMaNV1";
            cbMaNV1.Size = new Size(122, 25);
            cbMaNV1.TabIndex = 4;
            cbMaNV1.SelectedIndexChanged += cbMaNV1_SelectedIndexChanged;
            // 
            // tbHoGiaDinh
            // 
            tbHoGiaDinh.Anchor = AnchorStyles.Top;
            tbHoGiaDinh.Location = new Point(350, 88);
            tbHoGiaDinh.Margin = new Padding(4);
            tbHoGiaDinh.Name = "tbHoGiaDinh";
            tbHoGiaDinh.Size = new Size(122, 24);
            tbHoGiaDinh.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(219, 91);
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
            label1.Location = new Point(230, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 17);
            label1.TabIndex = 0;
            label1.Text = "Mã Nhân Viên:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTimKiem.BackColor = Color.FromArgb(255, 96, 0);
            btnTimKiem.FlatStyle = FlatStyle.Popup;
            btnTimKiem.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimKiem.Location = new Point(378, 562);
            btnTimKiem.Margin = new Padding(4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(90, 35);
            btnTimKiem.TabIndex = 62;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // rtbTimKiem
            // 
            rtbTimKiem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            rtbTimKiem.Location = new Point(169, 562);
            rtbTimKiem.Margin = new Padding(4);
            rtbTimKiem.Name = "rtbTimKiem";
            rtbTimKiem.Size = new Size(189, 34);
            rtbTimKiem.TabIndex = 63;
            rtbTimKiem.Text = "";
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnHuy.BackColor = Color.FromArgb(255, 96, 0);
            btnHuy.FlatStyle = FlatStyle.Popup;
            btnHuy.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHuy.Location = new Point(489, 562);
            btnHuy.Margin = new Padding(4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(90, 35);
            btnHuy.TabIndex = 64;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // formKTX
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 230, 199);
            ClientSize = new Size(1006, 619);
            Controls.Add(btnHuy);
            Controls.Add(rtbTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(groupBox1);
            Controls.Add(btnCapnhat);
            Controls.Add(btnThem);
            Controls.Add(dtHoGiaDinh);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "formKTX";
            Text = "Kí Túc Xá";
            Load += formKTX_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtHoGiaDinh).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem điệnToolStripMenuItem;
        private ToolStripMenuItem nướcToolStripMenuItem;
        private ToolStripMenuItem tiềnNhàToolStripMenuItem;
        private Label label2;
        private DataGridView dtHoGiaDinh;
        private Button btnCapnhat;
        private Button btnThem;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox tbHoGiaDinh;
        private Label label3;
        private ComboBox cbMaNV1;
        private DataGridViewTextBoxColumn MaHoGD;
        private DataGridViewTextBoxColumn MaNV1;
        private DataGridViewTextBoxColumn MaNV2;
        private Button btnTimKiem;
        private RichTextBox rtbTimKiem;
        private Button btnHuy;
        private ComboBox cbMaNV2;
        private Label label4;
    }
}