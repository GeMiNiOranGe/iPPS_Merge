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
            dateIssused_On = new DateTimePicker();
            dateDate = new DateTimePicker();
            cbNameJob = new ComboBox();
            cbNameProject = new ComboBox();
            txtIDJob = new TextBox();
            txtIDPro = new TextBox();
            btnBroser = new Button();
            label25 = new Label();
            txtLink = new TextBox();
            label24 = new Label();
            cbIssue_Purpose = new ComboBox();
            btnSave = new Button();
            label7 = new Label();
            cbLastest_Revision = new ComboBox();
            cbReference = new ComboBox();
            cbSupport = new ComboBox();
            cbAction = new ComboBox();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            txtChecked_By = new TextBox();
            label19 = new Label();
            txtApproved_By = new TextBox();
            label20 = new Label();
            txtTitle = new TextBox();
            txtTo_Company = new TextBox();
            txtIssused_Via = new TextBox();
            txtPrepared_By = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            cbRevision_Number = new ComboBox();
            label22 = new Label();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbPartner_Code = new ComboBox();
            cbType = new ComboBox();
            cbPackage = new ComboBox();
            txtWork_Item = new TextBox();
            label21 = new Label();
            label23 = new Label();
            txtIDDoc = new TextBox();
            SuspendLayout();
            // 
            // dateIssused_On
            // 
            dateIssused_On.Format = DateTimePickerFormat.Short;
            dateIssused_On.Location = new Point(685, 438);
            dateIssused_On.Margin = new Padding(16, 8, 8, 8);
            dateIssused_On.Name = "dateIssused_On";
            dateIssused_On.Size = new Size(196, 26);
            dateIssused_On.TabIndex = 192;
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
            btnBroser.Location = new Point(897, 512);
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
            label25.Location = new Point(685, 496);
            label25.Margin = new Padding(16, 24, 8, 0);
            label25.Name = "label25";
            label25.Size = new Size(34, 19);
            label25.TabIndex = 183;
            label25.Text = "Link";
            // 
            // txtLink
            // 
            txtLink.Location = new Point(685, 523);
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
            // cbIssue_Purpose
            // 
            cbIssue_Purpose.FormattingEnabled = true;
            cbIssue_Purpose.Items.AddRange(new object[] { "F1", "FA", "FR" });
            cbIssue_Purpose.Location = new Point(685, 266);
            cbIssue_Purpose.Margin = new Padding(16, 8, 8, 8);
            cbIssue_Purpose.Name = "cbIssue_Purpose";
            cbIssue_Purpose.Size = new Size(196, 27);
            cbIssue_Purpose.TabIndex = 181;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(34, 130, 253);
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(402, 575);
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
            // cbReference
            // 
            cbReference.FormattingEnabled = true;
            cbReference.Items.AddRange(new object[] { "BCMP VIETNAM" });
            cbReference.Location = new Point(245, 523);
            cbReference.Margin = new Padding(16, 8, 8, 8);
            cbReference.Name = "cbReference";
            cbReference.Size = new Size(196, 27);
            cbReference.TabIndex = 167;
            // 
            // cbSupport
            // 
            cbSupport.FormattingEnabled = true;
            cbSupport.Items.AddRange(new object[] { "BCMP VIETNAM" });
            cbSupport.Location = new Point(25, 523);
            cbSupport.Margin = new Padding(16, 8, 8, 8);
            cbSupport.Name = "cbSupport";
            cbSupport.Size = new Size(196, 27);
            cbSupport.TabIndex = 165;
            // 
            // cbAction
            // 
            cbAction.FormattingEnabled = true;
            cbAction.Items.AddRange(new object[] { "BCMP KOREA", "BCMP - PASSET" });
            cbAction.Location = new Point(685, 352);
            cbAction.Margin = new Padding(16, 8, 8, 8);
            cbAction.Name = "cbAction";
            cbAction.Size = new Size(196, 27);
            cbAction.TabIndex = 164;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(25, 411);
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
            label12.Location = new Point(245, 411);
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
            label13.Location = new Point(465, 325);
            label13.Margin = new Padding(16, 24, 8, 0);
            label13.Name = "label13";
            label13.Size = new Size(132, 19);
            label13.TabIndex = 150;
            label13.Text = "Được chấp nhận bởi";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.White;
            label14.Location = new Point(685, 325);
            label14.Margin = new Padding(16, 24, 8, 0);
            label14.Name = "label14";
            label14.Size = new Size(75, 19);
            label14.TabIndex = 151;
            label14.Text = "Hoạt động";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.White;
            label15.Location = new Point(25, 496);
            label15.Margin = new Padding(16, 24, 8, 0);
            label15.Name = "label15";
            label15.Size = new Size(49, 19);
            label15.TabIndex = 152;
            label15.Text = "Hỗ trợ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.White;
            label16.Location = new Point(245, 496);
            label16.Margin = new Padding(16, 24, 8, 0);
            label16.Name = "label16";
            label16.Size = new Size(77, 19);
            label16.TabIndex = 153;
            label16.Text = "Tham khảo";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.White;
            label17.Location = new Point(465, 411);
            label17.Margin = new Padding(16, 24, 8, 0);
            label17.Name = "label17";
            label17.Size = new Size(58, 19);
            label17.TabIndex = 154;
            label17.Text = "Công ty";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.White;
            label18.Location = new Point(685, 411);
            label18.Margin = new Padding(16, 24, 8, 0);
            label18.Name = "label18";
            label18.Size = new Size(108, 19);
            label18.TabIndex = 155;
            label18.Text = "Ngày phát hành";
            // 
            // txtChecked_By
            // 
            txtChecked_By.Location = new Point(245, 438);
            txtChecked_By.Margin = new Padding(16, 8, 8, 8);
            txtChecked_By.Name = "txtChecked_By";
            txtChecked_By.Size = new Size(196, 26);
            txtChecked_By.TabIndex = 163;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.White;
            label19.Location = new Point(465, 496);
            label19.Margin = new Padding(16, 24, 8, 0);
            label19.Name = "label19";
            label19.Size = new Size(33, 19);
            label19.TabIndex = 156;
            label19.Text = "Cấp";
            // 
            // txtApproved_By
            // 
            txtApproved_By.Location = new Point(465, 352);
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
            // txtTo_Company
            // 
            txtTo_Company.Location = new Point(465, 438);
            txtTo_Company.Margin = new Padding(16, 8, 8, 8);
            txtTo_Company.Name = "txtTo_Company";
            txtTo_Company.Size = new Size(196, 26);
            txtTo_Company.TabIndex = 158;
            // 
            // txtIssused_Via
            // 
            txtIssused_Via.Location = new Point(465, 523);
            txtIssused_Via.Margin = new Padding(16, 8, 8, 8);
            txtIssused_Via.Name = "txtIssused_Via";
            txtIssused_Via.Size = new Size(196, 26);
            txtIssused_Via.TabIndex = 159;
            // 
            // txtPrepared_By
            // 
            txtPrepared_By.Location = new Point(25, 438);
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
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(685, 239);
            label9.Margin = new Padding(16, 24, 8, 0);
            label9.Name = "label9";
            label9.Size = new Size(132, 19);
            label9.TabIndex = 145;
            label9.Text = "Mục đích phát hành";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(25, 239);
            label3.Margin = new Padding(16, 24, 8, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 19);
            label3.TabIndex = 128;
            label3.Text = "Bưu kiện";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(245, 239);
            label4.Margin = new Padding(16, 24, 8, 0);
            label4.Name = "label4";
            label4.Size = new Size(97, 19);
            label4.TabIndex = 129;
            label4.Text = "Mục công việc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(25, 325);
            label5.Margin = new Padding(16, 24, 8, 0);
            label5.Name = "label5";
            label5.Size = new Size(34, 19);
            label5.TabIndex = 130;
            label5.Text = "Loại";
            // 
            // cbPartner_Code
            // 
            cbPartner_Code.FormattingEnabled = true;
            cbPartner_Code.Location = new Point(245, 352);
            cbPartner_Code.Margin = new Padding(16, 8, 8, 8);
            cbPartner_Code.Name = "cbPartner_Code";
            cbPartner_Code.Size = new Size(196, 27);
            cbPartner_Code.TabIndex = 137;
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "D", "E", "F", "H", "L", "M", "Q", "S" });
            cbType.Location = new Point(25, 352);
            cbType.Margin = new Padding(16, 8, 8, 8);
            cbType.Name = "cbType";
            cbType.Size = new Size(196, 27);
            cbType.TabIndex = 136;
            // 
            // cbPackage
            // 
            cbPackage.FormattingEnabled = true;
            cbPackage.Items.AddRange(new object[] { "Common", "Licence" });
            cbPackage.Location = new Point(25, 266);
            cbPackage.Margin = new Padding(16, 8, 8, 8);
            cbPackage.Name = "cbPackage";
            cbPackage.Size = new Size(196, 27);
            cbPackage.TabIndex = 135;
            // 
            // txtWork_Item
            // 
            txtWork_Item.Location = new Point(245, 266);
            txtWork_Item.Margin = new Padding(16, 8, 8, 8);
            txtWork_Item.Name = "txtWork_Item";
            txtWork_Item.Size = new Size(196, 26);
            txtWork_Item.TabIndex = 132;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = Color.White;
            label21.Location = new Point(245, 325);
            label21.Margin = new Padding(16, 24, 8, 0);
            label21.Name = "label21";
            label21.Size = new Size(74, 19);
            label21.TabIndex = 131;
            label21.Text = "Mã đối tác";
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
            Controls.Add(dateIssused_On);
            Controls.Add(dateDate);
            Controls.Add(label24);
            Controls.Add(cbNameJob);
            Controls.Add(label21);
            Controls.Add(cbNameProject);
            Controls.Add(txtWork_Item);
            Controls.Add(txtIDJob);
            Controls.Add(cbPackage);
            Controls.Add(txtIDPro);
            Controls.Add(cbType);
            Controls.Add(txtIDDoc);
            Controls.Add(cbPartner_Code);
            Controls.Add(btnBroser);
            Controls.Add(label5);
            Controls.Add(label25);
            Controls.Add(label4);
            Controls.Add(txtLink);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbIssue_Purpose);
            Controls.Add(label1);
            Controls.Add(label23);
            Controls.Add(label6);
            Controls.Add(btnSave);
            Controls.Add(label22);
            Controls.Add(label7);
            Controls.Add(cbRevision_Number);
            Controls.Add(cbLastest_Revision);
            Controls.Add(label11);
            Controls.Add(cbReference);
            Controls.Add(label9);
            Controls.Add(cbSupport);
            Controls.Add(label8);
            Controls.Add(cbAction);
            Controls.Add(txtPrepared_By);
            Controls.Add(label10);
            Controls.Add(txtIssused_Via);
            Controls.Add(label12);
            Controls.Add(txtTo_Company);
            Controls.Add(label13);
            Controls.Add(txtTitle);
            Controls.Add(label14);
            Controls.Add(label20);
            Controls.Add(label15);
            Controls.Add(txtApproved_By);
            Controls.Add(label16);
            Controls.Add(label19);
            Controls.Add(label17);
            Controls.Add(txtChecked_By);
            Controls.Add(label18);
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
        private ComboBox cbReference;
        private ComboBox cbSupport;
        private ComboBox cbAction;
        private Label label10;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox txtChecked_By;
        private Label label19;
        private TextBox txtApproved_By;
        private Label label20;
        private TextBox txtTitle;
        private TextBox txtTo_Company;
        private TextBox txtIssused_Via;
        private TextBox txtPrepared_By;
        private Label label8;
        private Label label9;
        private Label label11;
        private ComboBox cbRevision_Number;
        private Label label22;
        private Label label6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbPartner_Code;
        private ComboBox cbType;
        private ComboBox cbPackage;
        private TextBox txtWork_Item;
        private Label label21;
        private Button btnSave;
        private ComboBox cbIssue_Purpose;
        private Label label24;
        private Button btnBroser;
        private Label label25;
        private TextBox txtLink;
        private TextBox txtIDPro;
        private TextBox txtIDJob;
        private ComboBox cbNameJob;
        private ComboBox cbNameProject;
        private DateTimePicker dateDate;
        private DateTimePicker dateIssused_On;
        private TextBox txtIDDoc;
        private Label label23;
    }
}