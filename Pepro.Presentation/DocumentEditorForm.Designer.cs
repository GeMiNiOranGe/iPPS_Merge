namespace Pepro.Presentation
{
    partial class DocumentEditorForm
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
            dateDate = new DateTimePicker();
            cbNameJob = new ComboBox();
            cbNameProject = new ComboBox();
            txtIDJob = new TextBox();
            txtIDPro = new TextBox();
            btnBroser = new Button();
            label25 = new Label();
            txtLink = new TextBox();
            label24 = new Label();
            btnSave = new Button();
            label7 = new Label();
            cbLastest_Revision = new ComboBox();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtChecked_By = new TextBox();
            txtApproved_By = new TextBox();
            label20 = new Label();
            txtTitle = new TextBox();
            txtPrepared_By = new TextBox();
            label8 = new Label();
            label11 = new Label();
            cbRevision_Number = new ComboBox();
            label22 = new Label();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            label23 = new Label();
            txtIDDoc = new TextBox();
            SuspendLayout();
            // 
            // dateDate
            // 
            dateDate.Format = DateTimePickerFormat.Short;
            dateDate.Location = new Point(685, 181);
            dateDate.Margin = new Padding(16, 8, 8, 8);
            dateDate.Name = "dateDate";
            dateDate.Size = new Size(196, 26);
            dateDate.TabIndex = 191;
            // 
            // cbNameJob
            // 
            cbNameJob.FormattingEnabled = true;
            cbNameJob.Location = new Point(245, 96);
            cbNameJob.Margin = new Padding(16, 8, 8, 8);
            cbNameJob.Name = "cbNameJob";
            cbNameJob.Size = new Size(196, 27);
            cbNameJob.TabIndex = 190;
            // 
            // cbNameProject
            // 
            cbNameProject.FormattingEnabled = true;
            cbNameProject.Location = new Point(685, 96);
            cbNameProject.Margin = new Padding(16, 8, 8, 8);
            cbNameProject.Name = "cbNameProject";
            cbNameProject.Size = new Size(196, 27);
            cbNameProject.TabIndex = 189;
            cbNameProject.SelectedIndexChanged += cbNameProject_SelectedIndexChanged;
            // 
            // txtIDJob
            // 
            txtIDJob.Location = new Point(25, 96);
            txtIDJob.Margin = new Padding(16, 8, 8, 8);
            txtIDJob.Name = "txtIDJob";
            txtIDJob.Size = new Size(196, 26);
            txtIDJob.TabIndex = 188;
            // 
            // txtIDPro
            // 
            txtIDPro.Location = new Point(465, 96);
            txtIDPro.Margin = new Padding(16, 8, 8, 8);
            txtIDPro.Name = "txtIDPro";
            txtIDPro.Size = new Size(196, 26);
            txtIDPro.TabIndex = 187;
            // 
            // btnBroser
            // 
            btnBroser.BackColor = Color.FromArgb(34, 130, 253);
            btnBroser.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBroser.ForeColor = Color.Black;
            btnBroser.Location = new Point(897, 255);
            btnBroser.Margin = new Padding(8);
            btnBroser.Name = "btnBroser";
            btnBroser.Size = new Size(89, 47);
            btnBroser.TabIndex = 185;
            btnBroser.Text = "Broser";
            btnBroser.UseVisualStyleBackColor = false;
            btnBroser.Click += btnBroser_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.ForeColor = Color.White;
            label25.Location = new Point(685, 239);
            label25.Margin = new Padding(16, 24, 8, 0);
            label25.Name = "label25";
            label25.Size = new Size(34, 19);
            label25.TabIndex = 183;
            label25.Text = "Link";
            // 
            // txtLink
            // 
            txtLink.Location = new Point(685, 266);
            txtLink.Margin = new Padding(16, 8, 8, 8);
            txtLink.Name = "txtLink";
            txtLink.Size = new Size(196, 26);
            txtLink.TabIndex = 184;
            // 
            // label24
            // 
            label24.Dock = DockStyle.Top;
            label24.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            label24.ForeColor = Color.White;
            label24.Location = new Point(0, 0);
            label24.Margin = new Padding(2, 0, 2, 0);
            label24.Name = "label24";
            label24.Size = new Size(1064, 32);
            label24.TabIndex = 182;
            label24.Text = "label24";
            label24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(34, 130, 253);
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(407, 341);
            btnSave.Margin = new Padding(8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(96, 47);
            btnSave.TabIndex = 172;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(465, 239);
            label7.Margin = new Padding(16, 24, 8, 0);
            label7.Name = "label7";
            label7.Size = new Size(113, 19);
            label7.TabIndex = 168;
            label7.Text = "Sửa đổi mới nhất";
            // 
            // cbLastest_Revision
            // 
            cbLastest_Revision.FormattingEnabled = true;
            cbLastest_Revision.Items.AddRange(new object[] { "Latest" });
            cbLastest_Revision.Location = new Point(465, 266);
            cbLastest_Revision.Margin = new Padding(16, 8, 8, 8);
            cbLastest_Revision.Name = "cbLastest_Revision";
            cbLastest_Revision.Size = new Size(196, 27);
            cbLastest_Revision.TabIndex = 169;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(25, 239);
            label10.Margin = new Padding(16, 24, 8, 0);
            label10.Name = "label10";
            label10.Size = new Size(97, 19);
            label10.TabIndex = 148;
            label10.Text = "Được soạn bởi";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(245, 239);
            label12.Margin = new Padding(16, 24, 8, 0);
            label12.Name = "label12";
            label12.Size = new Size(96, 19);
            label12.TabIndex = 149;
            label12.Text = "KIểm tra bằng";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.White;
            label13.Location = new Point(25, 325);
            label13.Margin = new Padding(16, 24, 8, 0);
            label13.Name = "label13";
            label13.Size = new Size(132, 19);
            label13.TabIndex = 150;
            label13.Text = "Được chấp nhận bởi";
            // 
            // txtChecked_By
            // 
            txtChecked_By.Location = new Point(245, 266);
            txtChecked_By.Margin = new Padding(16, 8, 8, 8);
            txtChecked_By.Name = "txtChecked_By";
            txtChecked_By.Size = new Size(196, 26);
            txtChecked_By.TabIndex = 163;
            // 
            // txtApproved_By
            // 
            txtApproved_By.Location = new Point(25, 352);
            txtApproved_By.Margin = new Padding(16, 8, 8, 8);
            txtApproved_By.Name = "txtApproved_By";
            txtApproved_By.Size = new Size(196, 26);
            txtApproved_By.TabIndex = 162;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = Color.White;
            label20.Location = new Point(245, 154);
            label20.Margin = new Padding(16, 24, 8, 0);
            label20.Name = "label20";
            label20.Size = new Size(50, 19);
            label20.TabIndex = 157;
            label20.Text = "Tựa đề";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(245, 181);
            txtTitle.Margin = new Padding(16, 8, 8, 8);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(196, 26);
            txtTitle.TabIndex = 161;
            // 
            // txtPrepared_By
            // 
            txtPrepared_By.Location = new Point(25, 266);
            txtPrepared_By.Margin = new Padding(16, 8, 8, 8);
            txtPrepared_By.Name = "txtPrepared_By";
            txtPrepared_By.Size = new Size(196, 26);
            txtPrepared_By.TabIndex = 160;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(685, 154);
            label8.Margin = new Padding(16, 24, 8, 0);
            label8.Name = "label8";
            label8.Size = new Size(41, 19);
            label8.TabIndex = 144;
            label8.Text = "Ngày";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(465, 154);
            label11.Margin = new Padding(16, 24, 8, 0);
            label11.Name = "label11";
            label11.Size = new Size(72, 19);
            label11.TabIndex = 142;
            label11.Text = "Số sửa đổi";
            // 
            // cbRevision_Number
            // 
            cbRevision_Number.FormattingEnabled = true;
            cbRevision_Number.Items.AddRange(new object[] { "A", "B" });
            cbRevision_Number.Location = new Point(465, 181);
            cbRevision_Number.Margin = new Padding(16, 8, 8, 8);
            cbRevision_Number.Name = "cbRevision_Number";
            cbRevision_Number.Size = new Size(196, 27);
            cbRevision_Number.TabIndex = 143;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = Color.White;
            label22.Location = new Point(25, 69);
            label22.Margin = new Padding(16, 0, 8, 0);
            label22.Name = "label22";
            label22.Size = new Size(90, 19);
            label22.TabIndex = 141;
            label22.Text = "Mã công việc";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(465, 69);
            label6.Margin = new Padding(16, 0, 8, 0);
            label6.Name = "label6";
            label6.Size = new Size(68, 19);
            label6.TabIndex = 140;
            label6.Text = "Mã dự án";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(685, 69);
            label1.Margin = new Padding(16, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 19);
            label1.TabIndex = 126;
            label1.Text = "Tên dự án";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(245, 69);
            label2.Margin = new Padding(16, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 127;
            label2.Text = "Tên công việc";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.ForeColor = Color.White;
            label23.Location = new Point(25, 154);
            label23.Margin = new Padding(16, 24, 8, 0);
            label23.Name = "label23";
            label23.Size = new Size(73, 19);
            label23.TabIndex = 174;
            label23.Text = "Mã tài liệu";
            // 
            // txtIDDoc
            // 
            txtIDDoc.Enabled = false;
            txtIDDoc.Location = new Point(25, 181);
            txtIDDoc.Margin = new Padding(16, 8, 8, 8);
            txtIDDoc.Name = "txtIDDoc";
            txtIDDoc.Size = new Size(196, 26);
            txtIDDoc.TabIndex = 186;
            // 
            // DocumentEditorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 22, 22);
            ClientSize = new Size(1064, 681);
            Controls.Add(dateDate);
            Controls.Add(label24);
            Controls.Add(cbNameJob);
            Controls.Add(cbNameProject);
            Controls.Add(txtIDJob);
            Controls.Add(txtIDPro);
            Controls.Add(txtIDDoc);
            Controls.Add(btnBroser);
            Controls.Add(label25);
            Controls.Add(txtLink);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label23);
            Controls.Add(label6);
            Controls.Add(btnSave);
            Controls.Add(label22);
            Controls.Add(label7);
            Controls.Add(cbRevision_Number);
            Controls.Add(cbLastest_Revision);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(txtPrepared_By);
            Controls.Add(label10);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(txtTitle);
            Controls.Add(label20);
            Controls.Add(txtApproved_By);
            Controls.Add(txtChecked_By);
            Margin = new Padding(2);
            Name = "DocumentEditorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInsert";
            Load += FormInsert_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Label label7;
        private ComboBox cbLastest_Revision;
        private Label label10;
        private Label label12;
        private Label label13;
        private TextBox txtChecked_By;
        private TextBox txtApproved_By;
        private Label label20;
        private TextBox txtTitle;
        private TextBox txtPrepared_By;
        private Label label8;
        private Label label11;
        private ComboBox cbRevision_Number;
        private Label label22;
        private Label label6;
        private Label label1;
        private Label label2;
        private Button btnSave;
        private Label label24;
        private Button btnBroser;
        private Label label25;
        private TextBox txtLink;
        private TextBox txtIDPro;
        private TextBox txtIDJob;
        private ComboBox cbNameJob;
        private ComboBox cbNameProject;
        private DateTimePicker dateDate;
        private TextBox txtIDDoc;
        private Label label23;
    }
}