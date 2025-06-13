namespace Pepro.Presentation
{
    partial class FormStaff
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
            txtSearch = new TextBox();
            radioSearchMa = new RadioButton();
            radioSearchTen = new RadioButton();
            lbSLNV = new Label();
            lbMaNV = new Label();
            listViewDataNV = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            btnReload = new Button();
            btnExport = new Button();
            btnDel = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            btnSearch = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(17, 92);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(211, 26);
            txtSearch.TabIndex = 1;
            // 
            // radioSearchMa
            // 
            radioSearchMa.AutoSize = true;
            radioSearchMa.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioSearchMa.Location = new Point(314, 97);
            radioSearchMa.Margin = new Padding(3, 2, 3, 2);
            radioSearchMa.Name = "radioSearchMa";
            radioSearchMa.Size = new Size(108, 23);
            radioSearchMa.TabIndex = 8;
            radioSearchMa.TabStop = true;
            radioSearchMa.Text = "Mã nhân viên";
            radioSearchMa.UseVisualStyleBackColor = true;
            // 
            // radioSearchTen
            // 
            radioSearchTen.AutoSize = true;
            radioSearchTen.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioSearchTen.Location = new Point(455, 97);
            radioSearchTen.Margin = new Padding(3, 2, 3, 2);
            radioSearchTen.Name = "radioSearchTen";
            radioSearchTen.Size = new Size(110, 23);
            radioSearchTen.TabIndex = 9;
            radioSearchTen.TabStop = true;
            radioSearchTen.Text = "Tên nhân viên";
            radioSearchTen.UseVisualStyleBackColor = true;
            // 
            // lbSLNV
            // 
            lbSLNV.AutoSize = true;
            lbSLNV.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSLNV.Location = new Point(945, 98);
            lbSLNV.Name = "lbSLNV";
            lbSLNV.Size = new Size(33, 22);
            lbSLNV.TabIndex = 10;
            lbSLNV.Text = "SL";
            // 
            // lbMaNV
            // 
            lbMaNV.AutoSize = true;
            lbMaNV.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMaNV.Location = new Point(737, 98);
            lbMaNV.Name = "lbMaNV";
            lbMaNV.Size = new Size(40, 22);
            lbMaNV.TabIndex = 11;
            lbMaNV.Text = "null";
            // 
            // listViewDataNV
            // 
            listViewDataNV.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13 });
            listViewDataNV.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewDataNV.FullRowSelect = true;
            listViewDataNV.GridLines = true;
            listViewDataNV.Location = new Point(3, 144);
            listViewDataNV.Margin = new Padding(3, 2, 3, 2);
            listViewDataNV.Name = "listViewDataNV";
            listViewDataNV.Size = new Size(1002, 474);
            listViewDataNV.TabIndex = 12;
            listViewDataNV.UseCompatibleStateImageBehavior = false;
            listViewDataNV.View = View.Details;
            listViewDataNV.SelectedIndexChanged += listViewDataNV_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Mã nhân viên";
            columnHeader2.Width = 118;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Họ và tên";
            columnHeader3.Width = 177;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Giới tính";
            columnHeader4.Width = 117;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Ngày sinh";
            columnHeader5.Width = 117;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Nơi sinh";
            columnHeader6.Width = 117;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Quê quán";
            columnHeader7.Width = 116;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Trình độ văn hoá";
            columnHeader8.Width = 175;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Dân tộc";
            columnHeader9.Width = 121;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Tôn giáo";
            columnHeader10.Width = 119;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Đoàn viên ";
            columnHeader11.Width = 116;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Đảng viên";
            columnHeader12.Width = 121;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Công đoàn viên";
            columnHeader13.Width = 145;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(840, 98);
            label1.Name = "label1";
            label1.Size = new Size(88, 22);
            label1.TabIndex = 14;
            label1.Text = "Số lượng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(593, 98);
            label2.Name = "label2";
            label2.Size = new Size(126, 22);
            label2.TabIndex = 15;
            label2.Text = "Mã nhân viên:";
            // 
            // btnReload
            // 
            btnReload.BackColor = Color.FromArgb(255, 96, 0);
            btnReload.BackgroundImage = Properties.Resources.reload;
            btnReload.BackgroundImageLayout = ImageLayout.Center;
            btnReload.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReload.Location = new Point(649, 14);
            btnReload.Margin = new Padding(3, 2, 3, 2);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(46, 47);
            btnReload.TabIndex = 13;
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += btnReload_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(255, 96, 0);
            btnExport.BackgroundImageLayout = ImageLayout.Center;
            btnExport.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExport.Location = new Point(942, 14);
            btnExport.Margin = new Padding(3, 2, 3, 2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(42, 47);
            btnExport.TabIndex = 7;
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.FromArgb(255, 96, 0);
            btnDel.BackgroundImageLayout = ImageLayout.Center;
            btnDel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDel.Location = new Point(869, 14);
            btnDel.Margin = new Padding(3, 2, 3, 2);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(45, 47);
            btnDel.TabIndex = 5;
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(255, 96, 0);
            btnEdit.BackgroundImageLayout = ImageLayout.Center;
            btnEdit.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(796, 14);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(45, 47);
            btnEdit.TabIndex = 4;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 96, 0);
            btnAdd.BackgroundImageLayout = ImageLayout.Center;
            btnAdd.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(724, 14);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(45, 47);
            btnAdd.TabIndex = 3;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 96, 0);
            btnSearch.BackgroundImage = Properties.Resources.search;
            btnSearch.BackgroundImageLayout = ImageLayout.Center;
            btnSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(248, 82);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(45, 47);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 18);
            label3.Name = "label3";
            label3.Size = new Size(123, 27);
            label3.TabIndex = 16;
            label3.Text = "Nhân viên";
            // 
            // FormStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 230, 199);
            ClientSize = new Size(1006, 619);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnReload);
            Controls.Add(listViewDataNV);
            Controls.Add(lbMaNV);
            Controls.Add(lbSLNV);
            Controls.Add(radioSearchTen);
            Controls.Add(radioSearchMa);
            Controls.Add(btnExport);
            Controls.Add(btnDel);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormStaff";
            Text = "NhanVien";
            Load += FormStaff_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.RadioButton radioSearchMa;
        private System.Windows.Forms.RadioButton radioSearchTen;
        private System.Windows.Forms.Label lbSLNV;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.ListView listViewDataNV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}