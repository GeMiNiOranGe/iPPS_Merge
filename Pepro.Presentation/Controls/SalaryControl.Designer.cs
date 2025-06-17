namespace Pepro.Presentation.Controls
{
    partial class SalaryControl
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
            informationGroupBox = new GroupBox();
            cbBacLuong = new ComboBox();
            tbPhuCap = new TextBox();
            label5 = new Label();
            tbTienLuong = new TextBox();
            label3 = new Label();
            tbTienNha = new TextBox();
            label10 = new Label();
            dtpkThoiDiem = new DateTimePicker();
            label9 = new Label();
            tbSoNgayCong = new TextBox();
            label7 = new Label();
            label6 = new Label();
            tbLCB = new TextBox();
            label4 = new Label();
            employeeIdComboBox = new ComboBox();
            employeeIdLabel = new Label();
            employeeSalaryDataGridView = new DataGridView();
            MaNhanVien = new DataGridViewTextBoxColumn();
            LuongCoBan = new DataGridViewTextBoxColumn();
            HeSoBacLuong = new DataGridViewTextBoxColumn();
            Hesophucapchucvu = new DataGridViewTextBoxColumn();
            Songaydilam = new DataGridViewTextBoxColumn();
            Songaynghibhxh = new DataGridViewTextBoxColumn();
            Songaynghikhonglydo = new DataGridViewTextBoxColumn();
            TienNha = new DataGridViewTextBoxColumn();
            TongLuong = new DataGridViewTextBoxColumn();
            Thoidiem = new DataGridViewTextBoxColumn();
            computeSalaryButton = new Button();
            salaryRichTextBox = new RichTextBox();
            updateButton = new Button();
            employeeIdRichTextBox = new RichTextBox();
            searchButton = new Button();
            cancelButton = new Button();
            headerLabel = new Label();
            exportReportButton = new Button();
            informationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeSalaryDataGridView).BeginInit();
            SuspendLayout();
            // 
            // informationGroupBox
            // 
            informationGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            informationGroupBox.BackColor = Color.FromArgb(255, 165, 89);
            informationGroupBox.Controls.Add(cbBacLuong);
            informationGroupBox.Controls.Add(tbPhuCap);
            informationGroupBox.Controls.Add(label5);
            informationGroupBox.Controls.Add(tbTienLuong);
            informationGroupBox.Controls.Add(label3);
            informationGroupBox.Controls.Add(tbTienNha);
            informationGroupBox.Controls.Add(label10);
            informationGroupBox.Controls.Add(dtpkThoiDiem);
            informationGroupBox.Controls.Add(label9);
            informationGroupBox.Controls.Add(tbSoNgayCong);
            informationGroupBox.Controls.Add(label7);
            informationGroupBox.Controls.Add(label6);
            informationGroupBox.Controls.Add(tbLCB);
            informationGroupBox.Controls.Add(label4);
            informationGroupBox.Controls.Add(employeeIdComboBox);
            informationGroupBox.Controls.Add(employeeIdLabel);
            informationGroupBox.FlatStyle = FlatStyle.Popup;
            informationGroupBox.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            informationGroupBox.Location = new Point(64, 88);
            informationGroupBox.Margin = new Padding(4);
            informationGroupBox.Name = "informationGroupBox";
            informationGroupBox.Padding = new Padding(4);
            informationGroupBox.Size = new Size(906, 150);
            informationGroupBox.TabIndex = 0;
            informationGroupBox.TabStop = false;
            informationGroupBox.Text = "Thông tin lương";
            // 
            // cbBacLuong
            // 
            cbBacLuong.Anchor = AnchorStyles.Top;
            cbBacLuong.FormattingEnabled = true;
            cbBacLuong.Location = new Point(433, 30);
            cbBacLuong.Margin = new Padding(4);
            cbBacLuong.Name = "cbBacLuong";
            cbBacLuong.Size = new Size(117, 25);
            cbBacLuong.TabIndex = 23;
            // 
            // tbPhuCap
            // 
            tbPhuCap.Anchor = AnchorStyles.Top;
            tbPhuCap.Location = new Point(433, 114);
            tbPhuCap.Margin = new Padding(4);
            tbPhuCap.Name = "tbPhuCap";
            tbPhuCap.Size = new Size(117, 24);
            tbPhuCap.TabIndex = 22;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(321, 116);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 16);
            label5.TabIndex = 21;
            label5.Text = "Hệ Số Phụ Cấp:";
            // 
            // tbTienLuong
            // 
            tbTienLuong.Anchor = AnchorStyles.Top;
            tbTienLuong.Enabled = false;
            tbTienLuong.Location = new Point(117, 113);
            tbTienLuong.Margin = new Padding(4);
            tbTienLuong.Name = "tbTienLuong";
            tbTienLuong.Size = new Size(140, 24);
            tbTienLuong.TabIndex = 20;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 115);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 16);
            label3.TabIndex = 19;
            label3.Text = "Tiền Lương:";
            // 
            // tbTienNha
            // 
            tbTienNha.Anchor = AnchorStyles.Top;
            tbTienNha.Location = new Point(689, 36);
            tbTienNha.Margin = new Padding(4);
            tbTienNha.Name = "tbTienNha";
            tbTienNha.Size = new Size(122, 24);
            tbTienNha.TabIndex = 18;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(586, 81);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(71, 16);
            label10.TabIndex = 17;
            label10.Text = "Thời Điểm:";
            // 
            // dtpkThoiDiem
            // 
            dtpkThoiDiem.Anchor = AnchorStyles.Top;
            dtpkThoiDiem.Format = DateTimePickerFormat.Short;
            dtpkThoiDiem.Location = new Point(689, 73);
            dtpkThoiDiem.Margin = new Padding(4);
            dtpkThoiDiem.Name = "dtpkThoiDiem";
            dtpkThoiDiem.Size = new Size(123, 24);
            dtpkThoiDiem.TabIndex = 16;
            dtpkThoiDiem.ValueChanged += dtpkThoiDiem_ValueChanged;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(595, 38);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(63, 16);
            label9.TabIndex = 14;
            label9.Text = "Tiền Nhà:";
            // 
            // tbSoNgayCong
            // 
            tbSoNgayCong.Anchor = AnchorStyles.Top;
            tbSoNgayCong.Location = new Point(433, 70);
            tbSoNgayCong.Margin = new Padding(4);
            tbSoNgayCong.Name = "tbSoNgayCong";
            tbSoNgayCong.Size = new Size(117, 24);
            tbSoNgayCong.TabIndex = 11;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(326, 73);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(92, 16);
            label7.TabIndex = 10;
            label7.Text = "Số Ngày Công:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(334, 30);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(85, 16);
            label6.TabIndex = 8;
            label6.Text = "Hệ Số Lương:";
            // 
            // tbLCB
            // 
            tbLCB.Anchor = AnchorStyles.Top;
            tbLCB.Location = new Point(117, 71);
            tbLCB.Margin = new Padding(4);
            tbLCB.Name = "tbLCB";
            tbLCB.Size = new Size(140, 24);
            tbLCB.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 74);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 16);
            label4.TabIndex = 4;
            label4.Text = "Lương Cơ Bản:";
            // 
            // employeeIdComboBox
            // 
            employeeIdComboBox.Anchor = AnchorStyles.Top;
            employeeIdComboBox.FormattingEnabled = true;
            employeeIdComboBox.Location = new Point(117, 31);
            employeeIdComboBox.Margin = new Padding(4);
            employeeIdComboBox.Name = "employeeIdComboBox";
            employeeIdComboBox.Size = new Size(140, 25);
            employeeIdComboBox.TabIndex = 1;
            employeeIdComboBox.SelectedIndexChanged += cbMaNV_SelectedIndexChanged;
            // 
            // employeeIdLabel
            // 
            employeeIdLabel.Anchor = AnchorStyles.Top;
            employeeIdLabel.AutoSize = true;
            employeeIdLabel.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeeIdLabel.Location = new Point(3, 34);
            employeeIdLabel.Margin = new Padding(4, 0, 4, 0);
            employeeIdLabel.Name = "employeeIdLabel";
            employeeIdLabel.Size = new Size(91, 16);
            employeeIdLabel.TabIndex = 0;
            employeeIdLabel.Text = "Mã Nhân Viên:";
            // 
            // employeeSalaryDataGridView
            // 
            employeeSalaryDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            employeeSalaryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeSalaryDataGridView.Columns.AddRange(new DataGridViewColumn[] { MaNhanVien, LuongCoBan, HeSoBacLuong, Hesophucapchucvu, Songaydilam, Songaynghibhxh, Songaynghikhonglydo, TienNha, TongLuong, Thoidiem });
            employeeSalaryDataGridView.Location = new Point(64, 268);
            employeeSalaryDataGridView.Margin = new Padding(4);
            employeeSalaryDataGridView.Name = "employeeSalaryDataGridView";
            employeeSalaryDataGridView.RowHeadersWidth = 51;
            employeeSalaryDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            employeeSalaryDataGridView.Size = new Size(906, 243);
            employeeSalaryDataGridView.TabIndex = 57;
            employeeSalaryDataGridView.CellContentClick += dtgvLuongNV_CellContentClick;
            // 
            // MaNhanVien
            // 
            MaNhanVien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaNhanVien.DataPropertyName = "MaNhanVien";
            MaNhanVien.HeaderText = "Mã Nhân Viên";
            MaNhanVien.MinimumWidth = 6;
            MaNhanVien.Name = "MaNhanVien";
            MaNhanVien.ReadOnly = true;
            // 
            // LuongCoBan
            // 
            LuongCoBan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LuongCoBan.DataPropertyName = "LuongCoBan";
            LuongCoBan.HeaderText = "Lương Cơ Bản";
            LuongCoBan.MinimumWidth = 6;
            LuongCoBan.Name = "LuongCoBan";
            LuongCoBan.ReadOnly = true;
            // 
            // HeSoBacLuong
            // 
            HeSoBacLuong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HeSoBacLuong.DataPropertyName = "HeSoBacLuong";
            HeSoBacLuong.HeaderText = "Hệ Số Lương";
            HeSoBacLuong.MinimumWidth = 6;
            HeSoBacLuong.Name = "HeSoBacLuong";
            HeSoBacLuong.ReadOnly = true;
            // 
            // Hesophucapchucvu
            // 
            Hesophucapchucvu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Hesophucapchucvu.DataPropertyName = "Hesophucapchucvu";
            Hesophucapchucvu.HeaderText = "Hệ Số Phụ Cấp Chức Vụ";
            Hesophucapchucvu.MinimumWidth = 6;
            Hesophucapchucvu.Name = "Hesophucapchucvu";
            Hesophucapchucvu.ReadOnly = true;
            // 
            // Songaydilam
            // 
            Songaydilam.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Songaydilam.DataPropertyName = "Songaydilam";
            Songaydilam.HeaderText = "Số Ngày Đi Làm";
            Songaydilam.MinimumWidth = 6;
            Songaydilam.Name = "Songaydilam";
            Songaydilam.ReadOnly = true;
            // 
            // Songaynghibhxh
            // 
            Songaynghibhxh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Songaynghibhxh.DataPropertyName = "Songaynghibhxh";
            Songaynghibhxh.HeaderText = "Số Ngày Nghỉ BHXH";
            Songaynghibhxh.MinimumWidth = 6;
            Songaynghibhxh.Name = "Songaynghibhxh";
            Songaynghibhxh.ReadOnly = true;
            // 
            // Songaynghikhonglydo
            // 
            Songaynghikhonglydo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Songaynghikhonglydo.DataPropertyName = "Songaynghikhonglydo";
            Songaynghikhonglydo.HeaderText = "Số Ngày Nghỉ Không  Lý Do";
            Songaynghikhonglydo.MinimumWidth = 6;
            Songaynghikhonglydo.Name = "Songaynghikhonglydo";
            Songaynghikhonglydo.ReadOnly = true;
            // 
            // TienNha
            // 
            TienNha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TienNha.DataPropertyName = "TienNha";
            TienNha.HeaderText = "Tiền Nhà";
            TienNha.MinimumWidth = 6;
            TienNha.Name = "TienNha";
            TienNha.ReadOnly = true;
            // 
            // TongLuong
            // 
            TongLuong.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TongLuong.DataPropertyName = "TongLuong";
            TongLuong.HeaderText = "Tổng Lương";
            TongLuong.MinimumWidth = 6;
            TongLuong.Name = "TongLuong";
            TongLuong.ReadOnly = true;
            // 
            // Thoidiem
            // 
            Thoidiem.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Thoidiem.DataPropertyName = "Thoidiem";
            Thoidiem.HeaderText = "Thời Điểm";
            Thoidiem.MinimumWidth = 6;
            Thoidiem.Name = "Thoidiem";
            Thoidiem.ReadOnly = true;
            // 
            // computeSalaryButton
            // 
            computeSalaryButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            computeSalaryButton.BackColor = Color.FromArgb(255, 96, 0);
            computeSalaryButton.FlatStyle = FlatStyle.Popup;
            computeSalaryButton.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            computeSalaryButton.Location = new Point(662, 31);
            computeSalaryButton.Margin = new Padding(4);
            computeSalaryButton.Name = "computeSalaryButton";
            computeSalaryButton.Size = new Size(116, 32);
            computeSalaryButton.TabIndex = 58;
            computeSalaryButton.Text = "Tính Lương";
            computeSalaryButton.UseVisualStyleBackColor = false;
            computeSalaryButton.Click += btnTinhLuong_Click;
            // 
            // salaryRichTextBox
            // 
            salaryRichTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            salaryRichTextBox.Location = new Point(798, 31);
            salaryRichTextBox.Margin = new Padding(4);
            salaryRichTextBox.Name = "salaryRichTextBox";
            salaryRichTextBox.Size = new Size(172, 32);
            salaryRichTextBox.TabIndex = 59;
            salaryRichTextBox.Text = "";
            // 
            // updateButton
            // 
            updateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            updateButton.BackColor = Color.FromArgb(255, 96, 0);
            updateButton.FlatStyle = FlatStyle.Popup;
            updateButton.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateButton.Location = new Point(732, 524);
            updateButton.Margin = new Padding(4);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(98, 32);
            updateButton.TabIndex = 60;
            updateButton.Text = "Cập Nhật";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += btnCapNhat_Click;
            // 
            // employeeIdRichTextBox
            // 
            employeeIdRichTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            employeeIdRichTextBox.Location = new Point(64, 526);
            employeeIdRichTextBox.Margin = new Padding(4);
            employeeIdRichTextBox.Name = "employeeIdRichTextBox";
            employeeIdRichTextBox.Size = new Size(274, 32);
            employeeIdRichTextBox.TabIndex = 63;
            employeeIdRichTextBox.Text = "";
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            searchButton.BackColor = Color.FromArgb(255, 96, 0);
            searchButton.FlatStyle = FlatStyle.Popup;
            searchButton.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchButton.Location = new Point(358, 526);
            searchButton.Margin = new Padding(4);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(122, 32);
            searchButton.TabIndex = 64;
            searchButton.Text = "Tìm kiếm";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += btnTimKiem_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cancelButton.BackColor = Color.FromArgb(255, 96, 0);
            cancelButton.FlatStyle = FlatStyle.Popup;
            cancelButton.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelButton.Location = new Point(358, 575);
            cancelButton.Margin = new Padding(4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(122, 32);
            cancelButton.TabIndex = 65;
            cancelButton.Text = "Hủy";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += btnHuy_Click;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            headerLabel.Location = new Point(69, 31);
            headerLabel.Margin = new Padding(4, 0, 4, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(237, 31);
            headerLabel.TabIndex = 66;
            headerLabel.Text = "Lương Nhân Viên";
            // 
            // exportReportButton
            // 
            exportReportButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exportReportButton.BackColor = Color.FromArgb(255, 96, 0);
            exportReportButton.FlatStyle = FlatStyle.Popup;
            exportReportButton.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exportReportButton.Location = new Point(530, 31);
            exportReportButton.Margin = new Padding(4);
            exportReportButton.Name = "exportReportButton";
            exportReportButton.Size = new Size(112, 32);
            exportReportButton.TabIndex = 67;
            exportReportButton.Text = "Xuất báo cáo";
            exportReportButton.UseVisualStyleBackColor = false;
            exportReportButton.Click += btnBaoCao_Click;
            // 
            // formTinhLuong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 230, 199);
            Controls.Add(exportReportButton);
            Controls.Add(headerLabel);
            Controls.Add(cancelButton);
            Controls.Add(searchButton);
            Controls.Add(employeeIdRichTextBox);
            Controls.Add(updateButton);
            Controls.Add(computeSalaryButton);
            Controls.Add(employeeSalaryDataGridView);
            Controls.Add(salaryRichTextBox);
            Controls.Add(informationGroupBox);
            Margin = new Padding(4);
            Name = "formTinhLuong";
            Size = new Size(1006, 619);
            Load += formTinhLuong_Load;
            informationGroupBox.ResumeLayout(false);
            informationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeeSalaryDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private GroupBox informationGroupBox;
        private ComboBox employeeIdComboBox;
        private Label employeeIdLabel;
        private Label label6;
        private TextBox tbLCB;
        private Label label4;
        private TextBox tbSoNgayCong;
        private Label label7;
        private DateTimePicker dtpkThoiDiem;
        private Label label9;
        private Label label10;
        private DataGridView employeeSalaryDataGridView;
        private Button computeSalaryButton;
        private RichTextBox salaryRichTextBox;
        private Button updateButton;
        private TextBox tbTienNha;
        private TextBox tbTienLuong;
        private Label label3;
        private TextBox tbPhuCap;
        private Label label5;
        private RichTextBox employeeIdRichTextBox;
        private Button searchButton;
        private Button cancelButton;
        private Label headerLabel;
        private ComboBox cbBacLuong;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn LuongCoBan;
        private DataGridViewTextBoxColumn HeSoBacLuong;
        private DataGridViewTextBoxColumn Hesophucapchucvu;
        private DataGridViewTextBoxColumn Songaydilam;
        private DataGridViewTextBoxColumn Songaynghibhxh;
        private DataGridViewTextBoxColumn Songaynghikhonglydo;
        private DataGridViewTextBoxColumn TienNha;
        private DataGridViewTextBoxColumn TongLuong;
        private DataGridViewTextBoxColumn Thoidiem;
        private Button exportReportButton;
    }
}