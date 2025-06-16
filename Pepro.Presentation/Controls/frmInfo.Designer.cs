namespace Pepro.Presentation.Controls
{
    partial class frmInfo
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
            label22 = new Label();
            panel2 = new Panel();
            cbSDT = new ComboBox();
            label6 = new Label();
            rdoFemale = new RadioButton();
            rdoMale = new RadioButton();
            txtCCCD = new TextBox();
            dtpEmployeeBirthday = new DateTimePicker();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label10 = new Label();
            label11 = new Label();
            cbProject = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            txtEmpoyeeID = new TextBox();
            txtDepartment = new TextBox();
            txtEmployeeName = new TextBox();
            label21 = new Label();
            txtRole = new TextBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label22
            // 
            label22.BackColor = Color.FromArgb(22, 22, 22);
            label22.Dock = DockStyle.Top;
            label22.Font = new Font("Tahoma", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.White;
            label22.Location = new Point(0, 0);
            label22.Margin = new Padding(2, 0, 2, 0);
            label22.Name = "label22";
            label22.Size = new Size(681, 87);
            label22.TabIndex = 42;
            label22.Text = "Thông tin cơ bản";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(15, 15, 15);
            panel2.Controls.Add(cbSDT);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(rdoFemale);
            panel2.Controls.Add(rdoMale);
            panel2.Controls.Add(txtCCCD);
            panel2.Controls.Add(dtpEmployeeBirthday);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(cbProject);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(txtEmpoyeeID);
            panel2.Controls.Add(txtDepartment);
            panel2.Controls.Add(txtEmployeeName);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(txtRole);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 87);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(681, 560);
            panel2.TabIndex = 43;
            // 
            // cbSDT
            // 
            cbSDT.Anchor = AnchorStyles.None;
            cbSDT.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSDT.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSDT.FormattingEnabled = true;
            cbSDT.Location = new Point(282, 445);
            cbSDT.Margin = new Padding(2);
            cbSDT.Name = "cbSDT";
            cbSDT.Size = new Size(264, 27);
            cbSDT.TabIndex = 51;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(227, 448);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(39, 19);
            label6.TabIndex = 50;
            label6.Text = "SĐT";
            // 
            // rdoFemale
            // 
            rdoFemale.Anchor = AnchorStyles.None;
            rdoFemale.AutoSize = true;
            rdoFemale.Enabled = false;
            rdoFemale.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoFemale.ForeColor = Color.White;
            rdoFemale.Location = new Point(422, 175);
            rdoFemale.Margin = new Padding(4, 3, 4, 3);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(48, 23);
            rdoFemale.TabIndex = 49;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Nữ";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            rdoMale.Anchor = AnchorStyles.None;
            rdoMale.AutoSize = true;
            rdoMale.Enabled = false;
            rdoMale.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoMale.ForeColor = Color.White;
            rdoMale.Location = new Point(282, 175);
            rdoMale.Margin = new Padding(4, 3, 4, 3);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(60, 23);
            rdoMale.TabIndex = 48;
            rdoMale.TabStop = true;
            rdoMale.Text = "Nam";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // txtCCCD
            // 
            txtCCCD.Anchor = AnchorStyles.None;
            txtCCCD.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCCCD.Location = new Point(282, 265);
            txtCCCD.Margin = new Padding(2);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.ReadOnly = true;
            txtCCCD.Size = new Size(264, 27);
            txtCCCD.TabIndex = 47;
            // 
            // dtpEmployeeBirthday
            // 
            dtpEmployeeBirthday.Anchor = AnchorStyles.None;
            dtpEmployeeBirthday.Checked = false;
            dtpEmployeeBirthday.CustomFormat = "yyyy-mm-dd";
            dtpEmployeeBirthday.Enabled = false;
            dtpEmployeeBirthday.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEmployeeBirthday.Format = DateTimePickerFormat.Short;
            dtpEmployeeBirthday.Location = new Point(282, 220);
            dtpEmployeeBirthday.Margin = new Padding(2);
            dtpEmployeeBirthday.Name = "dtpEmployeeBirthday";
            dtpEmployeeBirthday.Size = new Size(264, 27);
            dtpEmployeeBirthday.TabIndex = 46;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(153, 88);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 19);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(183, 133);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 19);
            label4.TabIndex = 3;
            label4.Text = "Họ và tên";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(192, 178);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 19);
            label5.TabIndex = 4;
            label5.Text = "Giới tính";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(195, 313);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(67, 19);
            label10.TabIndex = 9;
            label10.Text = "Chức vụ";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(215, 268);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(50, 19);
            label11.TabIndex = 10;
            label11.Text = "CCCD";
            // 
            // cbProject
            // 
            cbProject.Anchor = AnchorStyles.None;
            cbProject.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProject.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbProject.FormattingEnabled = true;
            cbProject.Location = new Point(282, 400);
            cbProject.Margin = new Padding(2);
            cbProject.Name = "cbProject";
            cbProject.Size = new Size(264, 27);
            cbProject.TabIndex = 36;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(174, 358);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(85, 19);
            label12.TabIndex = 11;
            label12.Text = "Phòng ban";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(134, 403);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(119, 19);
            label13.TabIndex = 12;
            label13.Text = "Dự án tham gia";
            // 
            // txtEmpoyeeID
            // 
            txtEmpoyeeID.Anchor = AnchorStyles.None;
            txtEmpoyeeID.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmpoyeeID.Location = new Point(282, 85);
            txtEmpoyeeID.Margin = new Padding(2);
            txtEmpoyeeID.Name = "txtEmpoyeeID";
            txtEmpoyeeID.ReadOnly = true;
            txtEmpoyeeID.Size = new Size(264, 27);
            txtEmpoyeeID.TabIndex = 30;
            // 
            // txtDepartment
            // 
            txtDepartment.Anchor = AnchorStyles.None;
            txtDepartment.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDepartment.Location = new Point(282, 355);
            txtDepartment.Margin = new Padding(2);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.ReadOnly = true;
            txtDepartment.Size = new Size(264, 27);
            txtDepartment.TabIndex = 29;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Anchor = AnchorStyles.None;
            txtEmployeeName.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmployeeName.Location = new Point(282, 130);
            txtEmployeeName.Margin = new Padding(2);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.ReadOnly = true;
            txtEmployeeName.Size = new Size(264, 27);
            txtEmployeeName.TabIndex = 27;
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.None;
            label21.AutoSize = true;
            label21.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.White;
            label21.Location = new Point(181, 223);
            label21.Margin = new Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new Size(79, 19);
            label21.TabIndex = 20;
            label21.Text = "Ngày sinh";
            // 
            // txtRole
            // 
            txtRole.Anchor = AnchorStyles.None;
            txtRole.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRole.Location = new Point(282, 310);
            txtRole.Margin = new Padding(2);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(264, 27);
            txtRole.TabIndex = 23;
            // 
            // frmInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 647);
            Controls.Add(panel2);
            Controls.Add(label22);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmInfo";
            Text = "frmInfo";
            Load += frmInfo_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Label label22;
        private Panel panel2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label10;
        private Label label11;
        private ComboBox cbProject;
        private Label label12;
        private Label label13;
        private TextBox txtEmpoyeeID;
        private TextBox txtDepartment;
        private TextBox txtEmployeeName;
        private Label label21;
        private TextBox txtRole;
        private TextBox txtCCCD;
        private DateTimePicker dtpEmployeeBirthday;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;
        private Label label6;
        private ComboBox cbSDT;
    }
}