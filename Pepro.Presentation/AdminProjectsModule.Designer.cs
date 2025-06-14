namespace Pepro.Presentation
{
    partial class AdminProjectsModule
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
            pnlHead = new Panel();
            ptbClose = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtIDPrj = new TextBox();
            txtName = new TextBox();
            txtAccess = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            txtCustomer = new TextBox();
            txtIDManager = new TextBox();
            txtStatus = new TextBox();
            txtIDDep = new TextBox();
            label8 = new Label();
            dtpStart = new DateTimePicker();
            label9 = new Label();
            label10 = new Label();
            dtpEnd = new DateTimePicker();
            pnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbClose).BeginInit();
            SuspendLayout();
            // 
            // pnlHead
            // 
            pnlHead.BackColor = Color.FromArgb(34, 130, 253);
            pnlHead.Controls.Add(ptbClose);
            pnlHead.Controls.Add(label1);
            pnlHead.Dock = DockStyle.Top;
            pnlHead.Location = new Point(0, 0);
            pnlHead.Margin = new Padding(2);
            pnlHead.Name = "pnlHead";
            pnlHead.Size = new Size(525, 75);
            pnlHead.TabIndex = 0;
            pnlHead.MouseDown += pnlHead_MouseDown;
            // 
            // ptbClose
            // 
            ptbClose.Cursor = Cursors.Hand;
            ptbClose.Location = new Point(492, 12);
            ptbClose.Margin = new Padding(2);
            ptbClose.Name = "ptbClose";
            ptbClose.Size = new Size(22, 23);
            ptbClose.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbClose.TabIndex = 1;
            ptbClose.TabStop = false;
            ptbClose.Click += ptbClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 26);
            label1.TabIndex = 0;
            label1.Text = "Thêm dự án";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(31, 99);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "ID dự án";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(31, 142);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên dự án";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(31, 183);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 3;
            label4.Text = "Quyền truy cập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(30, 226);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 4;
            label5.Text = "Trạng thái";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(30, 268);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 5;
            label6.Text = "Tên khách hàng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(31, 310);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 6;
            label7.Text = "ID quản lý";
            // 
            // txtIDPrj
            // 
            txtIDPrj.Location = new Point(181, 103);
            txtIDPrj.Margin = new Padding(2);
            txtIDPrj.Name = "txtIDPrj";
            txtIDPrj.Size = new Size(308, 23);
            txtIDPrj.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(181, 144);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(308, 23);
            txtName.TabIndex = 2;
            // 
            // txtAccess
            // 
            txtAccess.Location = new Point(181, 187);
            txtAccess.Margin = new Padding(2);
            txtAccess.Name = "txtAccess";
            txtAccess.Size = new Size(308, 23);
            txtAccess.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(181, 486);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 45);
            btnSave.TabIndex = 10;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(292, 486);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(88, 45);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(401, 486);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 45);
            btnClear.TabIndex = 12;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(181, 271);
            txtCustomer.Margin = new Padding(2);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(308, 23);
            txtCustomer.TabIndex = 5;
            // 
            // txtIDManager
            // 
            txtIDManager.Location = new Point(181, 313);
            txtIDManager.Margin = new Padding(2);
            txtIDManager.Name = "txtIDManager";
            txtIDManager.Size = new Size(308, 23);
            txtIDManager.TabIndex = 6;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(181, 230);
            txtStatus.Margin = new Padding(2);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(308, 23);
            txtStatus.TabIndex = 4;
            // 
            // txtIDDep
            // 
            txtIDDep.Location = new Point(181, 355);
            txtIDDep.Margin = new Padding(2);
            txtIDDep.Name = "txtIDDep";
            txtIDDep.Size = new Size(308, 23);
            txtIDDep.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(31, 353);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(106, 20);
            label8.TabIndex = 13;
            label8.Text = "ID phòng ban";
            // 
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(181, 396);
            dtpStart.Margin = new Padding(2);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(308, 23);
            dtpStart.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(30, 392);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(103, 20);
            label9.TabIndex = 16;
            label9.Text = "Ngày bắt đầu";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(30, 433);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(106, 20);
            label10.TabIndex = 18;
            label10.Text = "Ngày kết thúc";
            // 
            // dtpEnd
            // 
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(181, 436);
            dtpEnd.Margin = new Padding(2);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(308, 23);
            dtpEnd.TabIndex = 9;
            // 
            // AdminProjectsModule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 29);
            ClientSize = new Size(525, 563);
            Controls.Add(label10);
            Controls.Add(dtpEnd);
            Controls.Add(label9);
            Controls.Add(dtpStart);
            Controls.Add(txtIDDep);
            Controls.Add(label8);
            Controls.Add(txtStatus);
            Controls.Add(txtIDManager);
            Controls.Add(txtCustomer);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(txtAccess);
            Controls.Add(txtName);
            Controls.Add(txtIDPrj);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pnlHead);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "AdminProjectsModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminProjectsModule";
            pnlHead.ResumeLayout(false);
            pnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbClose).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Panel pnlHead;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        public System.Windows.Forms.TextBox txtIDPrj;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtAccess;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnClear;
        private PictureBox ptbClose;
        public System.Windows.Forms.TextBox txtCustomer;
        public System.Windows.Forms.TextBox txtIDManager;
        public System.Windows.Forms.TextBox txtStatus;
        public System.Windows.Forms.TextBox txtIDDep;
        private Label label8;
        public System.Windows.Forms.DateTimePicker dtpStart;
        private Label label9;
        private Label label10;
        public System.Windows.Forms.DateTimePicker dtpEnd;
    }
}