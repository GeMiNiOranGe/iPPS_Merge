namespace Pepro.Presentation
{
    partial class FormDocument
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvDocument = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Column17 = new DataGridViewTextBoxColumn();
            Column18 = new DataGridViewTextBoxColumn();
            Column19 = new DataGridViewTextBoxColumn();
            Column20 = new DataGridViewTextBoxColumn();
            Column21 = new DataGridViewTextBoxColumn();
            Column22 = new DataGridViewTextBoxColumn();
            btnInsert = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            radioIDDoc = new RadioButton();
            radioISSUSED_ON = new RadioButton();
            radioIDJob = new RadioButton();
            btnOpenFile = new Button();
            btnDownload = new Button();
            txtIDDoc = new TextBox();
            txtSearch = new TextBox();
            txtTypeFile = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNameProject = new TextBox();
            label4 = new Label();
            txtNameJob = new TextBox();
            label5 = new Label();
            txtIDJob = new TextBox();
            label6 = new Label();
            txtIDPro = new TextBox();
            panel1 = new Panel();
            label7 = new Label();
            panel2 = new Panel();
            btnReload = new Button();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDocument).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDocument
            // 
            dgvDocument.AllowUserToAddRows = false;
            dgvDocument.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(70, 70, 70);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dgvDocument.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDocument.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDocument.BackgroundColor = Color.FromArgb(15, 15, 15);
            dgvDocument.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(34, 130, 253);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(34, 130, 253);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDocument.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDocument.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocument.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13, Column14, Column15, Column16, Column17, Column18, Column19, Column20, Column21, Column22 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(25, 25, 25);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(34, 130, 253);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDocument.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDocument.EnableHeadersVisualStyles = false;
            dgvDocument.Location = new Point(10, 100);
            dgvDocument.Margin = new Padding(2);
            dgvDocument.Name = "dgvDocument";
            dgvDocument.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvDocument.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvDocument.RowHeadersVisible = false;
            dgvDocument.RowHeadersWidth = 51;
            dgvDocument.RowTemplate.Height = 24;
            dgvDocument.Size = new Size(1181, 502);
            dgvDocument.TabIndex = 0;
            dgvDocument.CellContentClick += dgvDocument_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ID";
            Column1.HeaderText = "Mã tài liệu";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "JOB_ID";
            Column2.HeaderText = "Mã công việc";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "PACKAGE";
            Column3.HeaderText = "Bưu kiện";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "WORK_ITEM";
            Column4.HeaderText = "Mục công việc";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "TYPE";
            Column5.HeaderText = "Loại";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "PARTNER_CODE";
            Column6.HeaderText = "Mã đối tác";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "REVISION_NUMBER";
            Column7.HeaderText = "Số sửa đổi";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "LASTEST_REVISION";
            Column8.HeaderText = "Sửa đổi mới nhất";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "DATE";
            Column9.HeaderText = "Ngày";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "ISSUE_PURPOSE";
            Column10.HeaderText = "Mục đích phát hành";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 155;
            // 
            // Column11
            // 
            Column11.DataPropertyName = "PREPARED_BY";
            Column11.HeaderText = "Được soạn bởi";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            Column11.Width = 300;
            // 
            // Column12
            // 
            Column12.DataPropertyName = "CHECKED_BY";
            Column12.HeaderText = "Kiểm tra bằng";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            Column12.Width = 300;
            // 
            // Column13
            // 
            Column13.DataPropertyName = "APPROVED_BY";
            Column13.HeaderText = "Được chấp nhận bởi";
            Column13.MinimumWidth = 6;
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            Column13.Width = 300;
            // 
            // Column14
            // 
            Column14.DataPropertyName = "ACTION";
            Column14.HeaderText = "Hoạt động";
            Column14.MinimumWidth = 6;
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            Column14.Width = 125;
            // 
            // Column15
            // 
            Column15.DataPropertyName = "SUPPORT";
            Column15.HeaderText = "Hỗ trợ";
            Column15.MinimumWidth = 6;
            Column15.Name = "Column15";
            Column15.ReadOnly = true;
            Column15.Width = 125;
            // 
            // Column16
            // 
            Column16.DataPropertyName = "REFERRENCE";
            Column16.HeaderText = "Tham khảo";
            Column16.MinimumWidth = 6;
            Column16.Name = "Column16";
            Column16.ReadOnly = true;
            Column16.Width = 125;
            // 
            // Column17
            // 
            Column17.DataPropertyName = "TO_COMPANY";
            Column17.HeaderText = "Công ty";
            Column17.MinimumWidth = 6;
            Column17.Name = "Column17";
            Column17.ReadOnly = true;
            Column17.Width = 400;
            // 
            // Column18
            // 
            Column18.DataPropertyName = "ISSUSED_ON";
            Column18.HeaderText = "Ban hành ngày";
            Column18.MinimumWidth = 6;
            Column18.Name = "Column18";
            Column18.ReadOnly = true;
            Column18.Width = 125;
            // 
            // Column19
            // 
            Column19.DataPropertyName = "ISSUSED_VIA";
            Column19.HeaderText = "Cấp";
            Column19.MinimumWidth = 6;
            Column19.Name = "Column19";
            Column19.ReadOnly = true;
            Column19.Width = 300;
            // 
            // Column20
            // 
            Column20.DataPropertyName = "TITLE";
            Column20.HeaderText = "Tựa đề";
            Column20.MinimumWidth = 6;
            Column20.Name = "Column20";
            Column20.ReadOnly = true;
            Column20.Width = 1000;
            // 
            // Column21
            // 
            Column21.DataPropertyName = "NAME";
            Column21.HeaderText = "Tên tệp";
            Column21.MinimumWidth = 6;
            Column21.Name = "Column21";
            Column21.ReadOnly = true;
            Column21.Width = 125;
            // 
            // Column22
            // 
            Column22.DataPropertyName = "NATIVE_FILE_FORMAT";
            Column22.HeaderText = "Kiểu tệp";
            Column22.MinimumWidth = 6;
            Column22.Name = "Column22";
            Column22.ReadOnly = true;
            Column22.Width = 125;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(34, 130, 253);
            btnInsert.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(686, 38);
            btnInsert.Margin = new Padding(2);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(65, 47);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "Thêm";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(34, 130, 253);
            btnDelete.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(861, 38);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(65, 47);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xoá";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(34, 130, 253);
            btnEdit.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(774, 38);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(65, 47);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // radioIDDoc
            // 
            radioIDDoc.AutoSize = true;
            radioIDDoc.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioIDDoc.ForeColor = Color.FromArgb(34, 130, 253);
            radioIDDoc.Location = new Point(329, 52);
            radioIDDoc.Margin = new Padding(2);
            radioIDDoc.Name = "radioIDDoc";
            radioIDDoc.Size = new Size(79, 17);
            radioIDDoc.TabIndex = 7;
            radioIDDoc.TabStop = true;
            radioIDDoc.Text = "Mã tài liệu";
            radioIDDoc.UseVisualStyleBackColor = true;
            // 
            // radioISSUSED_ON
            // 
            radioISSUSED_ON.AutoSize = true;
            radioISSUSED_ON.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioISSUSED_ON.ForeColor = Color.FromArgb(34, 130, 253);
            radioISSUSED_ON.Location = new Point(434, 52);
            radioISSUSED_ON.Margin = new Padding(2);
            radioISSUSED_ON.Name = "radioISSUSED_ON";
            radioISSUSED_ON.Size = new Size(108, 17);
            radioISSUSED_ON.TabIndex = 8;
            radioISSUSED_ON.TabStop = true;
            radioISSUSED_ON.Text = "Ngày phát hành";
            radioISSUSED_ON.UseVisualStyleBackColor = true;
            // 
            // radioIDJob
            // 
            radioIDJob.AutoSize = true;
            radioIDJob.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioIDJob.ForeColor = Color.FromArgb(34, 130, 253);
            radioIDJob.Location = new Point(573, 52);
            radioIDJob.Margin = new Padding(2);
            radioIDJob.Name = "radioIDJob";
            radioIDJob.Size = new Size(92, 17);
            radioIDJob.TabIndex = 9;
            radioIDJob.TabStop = true;
            radioIDJob.Text = "Mã công việc";
            radioIDJob.UseVisualStyleBackColor = true;
            // 
            // btnOpenFile
            // 
            btnOpenFile.BackColor = Color.FromArgb(34, 130, 253);
            btnOpenFile.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpenFile.Location = new Point(948, 38);
            btnOpenFile.Margin = new Padding(2);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(65, 47);
            btnOpenFile.TabIndex = 11;
            btnOpenFile.Text = "Mở tệp";
            btnOpenFile.UseVisualStyleBackColor = false;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.FromArgb(34, 130, 253);
            btnDownload.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDownload.Location = new Point(1036, 38);
            btnDownload.Margin = new Padding(2);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(153, 47);
            btnDownload.TabIndex = 12;
            btnDownload.Text = "DownLoad";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            // 
            // txtIDDoc
            // 
            txtIDDoc.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtIDDoc.BackColor = Color.FromArgb(15, 15, 15);
            txtIDDoc.Enabled = false;
            txtIDDoc.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIDDoc.ForeColor = Color.White;
            txtIDDoc.Location = new Point(97, 622);
            txtIDDoc.Margin = new Padding(2);
            txtIDDoc.Name = "txtIDDoc";
            txtIDDoc.Size = new Size(88, 21);
            txtIDDoc.TabIndex = 14;
            txtIDDoc.TextChanged += txtIDDoc_TextChanged;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(29, 29, 29);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(4, 3);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(177, 19);
            txtSearch.TabIndex = 15;
            txtSearch.Text = "Search";
            // 
            // txtTypeFile
            // 
            txtTypeFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtTypeFile.BackColor = Color.FromArgb(15, 15, 15);
            txtTypeFile.Enabled = false;
            txtTypeFile.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTypeFile.ForeColor = Color.White;
            txtTypeFile.Location = new Point(97, 668);
            txtTypeFile.Margin = new Padding(2);
            txtTypeFile.Name = "txtTypeFile";
            txtTypeFile.Size = new Size(88, 21);
            txtTypeFile.TabIndex = 16;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 627);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 13);
            label1.TabIndex = 17;
            label1.Text = "Mã tài liệu";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 673);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 13);
            label2.TabIndex = 18;
            label2.Text = "Kiểu tệp";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(246, 673);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 13);
            label3.TabIndex = 20;
            label3.Text = "Tên dự án";
            // 
            // txtNameProject
            // 
            txtNameProject.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtNameProject.BackColor = Color.FromArgb(15, 15, 15);
            txtNameProject.Enabled = false;
            txtNameProject.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNameProject.ForeColor = Color.White;
            txtNameProject.Location = new Point(332, 668);
            txtNameProject.Margin = new Padding(2);
            txtNameProject.Name = "txtNameProject";
            txtNameProject.Size = new Size(88, 21);
            txtNameProject.TabIndex = 19;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(485, 673);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 13);
            label4.TabIndex = 22;
            label4.Text = "Tên công việc";
            // 
            // txtNameJob
            // 
            txtNameJob.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtNameJob.BackColor = Color.FromArgb(15, 15, 15);
            txtNameJob.Enabled = false;
            txtNameJob.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNameJob.ForeColor = Color.White;
            txtNameJob.Location = new Point(593, 668);
            txtNameJob.Margin = new Padding(2);
            txtNameJob.Name = "txtNameJob";
            txtNameJob.Size = new Size(88, 21);
            txtNameJob.TabIndex = 21;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(485, 627);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 13);
            label5.TabIndex = 24;
            label5.Text = "Mã công việc";
            // 
            // txtIDJob
            // 
            txtIDJob.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtIDJob.BackColor = Color.FromArgb(15, 15, 15);
            txtIDJob.Enabled = false;
            txtIDJob.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIDJob.ForeColor = Color.White;
            txtIDJob.Location = new Point(593, 622);
            txtIDJob.Margin = new Padding(2);
            txtIDJob.Name = "txtIDJob";
            txtIDJob.Size = new Size(88, 21);
            txtIDJob.TabIndex = 23;
            txtIDJob.TextChanged += txtIDJob_TextChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(246, 627);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(56, 13);
            label6.TabIndex = 26;
            label6.Text = "Mã dự án";
            // 
            // txtIDPro
            // 
            txtIDPro.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtIDPro.BackColor = Color.FromArgb(15, 15, 15);
            txtIDPro.Enabled = false;
            txtIDPro.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIDPro.ForeColor = Color.White;
            txtIDPro.Location = new Point(332, 622);
            txtIDPro.Margin = new Padding(2);
            txtIDPro.Name = "txtIDPro";
            txtIDPro.Size = new Size(88, 21);
            txtIDPro.TabIndex = 25;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 130, 253);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1202, 29);
            panel1.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(35, 0);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(65, 21);
            label7.TabIndex = 28;
            label7.Text = "Tài liệu";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(34, 130, 253);
            panel2.Controls.Add(txtSearch);
            panel2.Location = new Point(74, 47);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 28);
            panel2.TabIndex = 28;
            // 
            // btnReload
            // 
            btnReload.BackColor = Color.FromArgb(34, 130, 253);
            btnReload.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReload.Image = Properties.Resources.reload;
            btnReload.Location = new Point(10, 39);
            btnReload.Margin = new Padding(2);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(43, 44);
            btnReload.TabIndex = 10;
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += btnReload_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(34, 130, 253);
            btnSearch.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Image = Properties.Resources.search;
            btnSearch.Location = new Point(271, 39);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(43, 44);
            btnSearch.TabIndex = 6;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // FormDocument
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            ClientSize = new Size(1202, 711);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(txtIDPro);
            Controls.Add(label5);
            Controls.Add(txtIDJob);
            Controls.Add(label4);
            Controls.Add(txtNameJob);
            Controls.Add(label3);
            Controls.Add(txtNameProject);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTypeFile);
            Controls.Add(txtIDDoc);
            Controls.Add(btnDownload);
            Controls.Add(btnOpenFile);
            Controls.Add(btnReload);
            Controls.Add(radioIDJob);
            Controls.Add(radioISSUSED_ON);
            Controls.Add(radioIDDoc);
            Controls.Add(btnSearch);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(dgvDocument);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FormDocument";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDocument";
            Load += FormDocument_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDocument).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private DataGridView dgvDocument;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSearch;
        private RadioButton radioIDDoc;
        private RadioButton radioISSUSED_ON;
        private RadioButton radioIDJob;
        private Button btnReload;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewTextBoxColumn Column19;
        private DataGridViewTextBoxColumn Column20;
        private DataGridViewTextBoxColumn Column21;
        private DataGridViewTextBoxColumn Column22;
        private Button btnOpenFile;
        private Button btnDownload;
        private TextBox txtIDDoc;
        private TextBox txtSearch;
        private TextBox txtTypeFile;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNameProject;
        private Label label4;
        private TextBox txtNameJob;
        private Label label5;
        private TextBox txtIDJob;
        private Label label6;
        private TextBox txtIDPro;
        private Panel panel1;
        private Label label7;
        private Panel panel2;
    }
}