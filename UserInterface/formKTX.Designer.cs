﻿namespace UserInterface
{
    partial class formKTX
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.điệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nướcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiềnNhàToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.dtHoGiaDinh = new System.Windows.Forms.DataGridView();
            this.MaHoGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMaNV2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMaNV1 = new System.Windows.Forms.ComboBox();
            this.tbHoGiaDinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.rtbTimKiem = new System.Windows.Forms.RichTextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHoGiaDinh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.điệnToolStripMenuItem,
            this.nướcToolStripMenuItem,
            this.tiềnNhàToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // điệnToolStripMenuItem
            // 
            this.điệnToolStripMenuItem.Name = "điệnToolStripMenuItem";
            this.điệnToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.điệnToolStripMenuItem.Text = "Điện ";
            this.điệnToolStripMenuItem.Click += new System.EventHandler(this.điệnToolStripMenuItem_Click);
            // 
            // nướcToolStripMenuItem
            // 
            this.nướcToolStripMenuItem.Name = "nướcToolStripMenuItem";
            this.nướcToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.nướcToolStripMenuItem.Text = "Nước";
            this.nướcToolStripMenuItem.Click += new System.EventHandler(this.nướcToolStripMenuItem_Click);
            // 
            // tiềnNhàToolStripMenuItem
            // 
            this.tiềnNhàToolStripMenuItem.Name = "tiềnNhàToolStripMenuItem";
            this.tiềnNhàToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.tiềnNhàToolStripMenuItem.Text = "Tiền Nhà";
            this.tiềnNhàToolStripMenuItem.Click += new System.EventHandler(this.tiềnNhàToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 56;
            this.label2.Text = "Kí Túc Xá";
            // 
            // dtHoGiaDinh
            // 
            this.dtHoGiaDinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtHoGiaDinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHoGiaDinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHoGD,
            this.MaNV1,
            this.MaNV2});
            this.dtHoGiaDinh.Location = new System.Drawing.Point(102, 180);
            this.dtHoGiaDinh.Name = "dtHoGiaDinh";
            this.dtHoGiaDinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtHoGiaDinh.Size = new System.Drawing.Size(759, 229);
            this.dtHoGiaDinh.TabIndex = 57;
            this.dtHoGiaDinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtHoGiaDinh_CellContentClick);
            // 
            // MaHoGD
            // 
            this.MaHoGD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHoGD.DataPropertyName = "MaHoGD";
            this.MaHoGD.HeaderText = "Mã Hộ";
            this.MaHoGD.Name = "MaHoGD";
            this.MaHoGD.ReadOnly = true;
            // 
            // MaNV1
            // 
            this.MaNV1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNV1.DataPropertyName = "MaNV1";
            this.MaNV1.HeaderText = "Mã Nhân Viên";
            this.MaNV1.Name = "MaNV1";
            this.MaNV1.ReadOnly = true;
            // 
            // MaNV2
            // 
            this.MaNV2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNV2.DataPropertyName = "MaNV2";
            this.MaNV2.HeaderText = "Mã Nhân Viên";
            this.MaNV2.Name = "MaNV2";
            this.MaNV2.ReadOnly = true;
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapnhat.BackColor = System.Drawing.Color.LightCoral;
            this.btnCapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapnhat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.Location = new System.Drawing.Point(757, 422);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(94, 30);
            this.btnCapnhat.TabIndex = 59;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.UseVisualStyleBackColor = false;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.LightCoral;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(643, 421);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 30);
            this.btnThem.TabIndex = 58;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.cbMaNV2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbMaNV1);
            this.groupBox1.Controls.Add(this.tbHoGiaDinh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(186, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 104);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // cbMaNV2
            // 
            this.cbMaNV2.FormattingEnabled = true;
            this.cbMaNV2.Location = new System.Drawing.Point(262, 48);
            this.cbMaNV2.Name = "cbMaNV2";
            this.cbMaNV2.Size = new System.Drawing.Size(105, 21);
            this.cbMaNV2.TabIndex = 6;
            this.cbMaNV2.SelectedIndexChanged += new System.EventHandler(this.cbMaNV2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã Nhân Viên:";
            // 
            // cbMaNV1
            // 
            this.cbMaNV1.FormattingEnabled = true;
            this.cbMaNV1.Location = new System.Drawing.Point(262, 19);
            this.cbMaNV1.Name = "cbMaNV1";
            this.cbMaNV1.Size = new System.Drawing.Size(105, 21);
            this.cbMaNV1.TabIndex = 4;
            this.cbMaNV1.SelectedIndexChanged += new System.EventHandler(this.cbMaNV1_SelectedIndexChanged);
            // 
            // tbHoGiaDinh
            // 
            this.tbHoGiaDinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbHoGiaDinh.Location = new System.Drawing.Point(262, 76);
            this.tbHoGiaDinh.Name = "tbHoGiaDinh";
            this.tbHoGiaDinh.Size = new System.Drawing.Size(105, 20);
            this.tbHoGiaDinh.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Hộ Gia Đình:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân Viên:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTimKiem.BackColor = System.Drawing.Color.LightCoral;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimKiem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(276, 422);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(77, 30);
            this.btnTimKiem.TabIndex = 62;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // rtbTimKiem
            // 
            this.rtbTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbTimKiem.Location = new System.Drawing.Point(108, 422);
            this.rtbTimKiem.Name = "rtbTimKiem";
            this.rtbTimKiem.Size = new System.Drawing.Size(162, 30);
            this.rtbTimKiem.TabIndex = 63;
            this.rtbTimKiem.Text = "";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuy.BackColor = System.Drawing.Color.LightCoral;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(276, 462);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(77, 30);
            this.btnHuy.TabIndex = 64;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // formKTX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 503);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.rtbTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtHoGiaDinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formKTX";
            this.Text = "Kí Túc Xá";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formKTX_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHoGiaDinh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem điệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nướcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiềnNhàToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtHoGiaDinh;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHoGiaDinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMaNV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.RichTextBox rtbTimKiem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ComboBox cbMaNV2;
        private System.Windows.Forms.Label label4;
    }
}