namespace Pepro.Presentation
{
    partial class AdminTasksModule
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnSave = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            txtPrjID = new TextBox();
            txtJobID = new TextBox();
            txtMngID = new TextBox();
            txtName = new TextBox();
            txtAccessR = new TextBox();
            txtDepPub = new TextBox();
            txtPrjPub = new TextBox();
            txtStatus = new TextBox();
            pnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlHead
            // 
            pnlHead.BackColor = Color.FromArgb(34, 130, 253);
            pnlHead.Controls.Add(pictureBox1);
            pnlHead.Controls.Add(label1);
            pnlHead.Dock = DockStyle.Top;
            pnlHead.Location = new Point(0, 0);
            pnlHead.Margin = new Padding(2);
            pnlHead.Name = "pnlHead";
            pnlHead.Size = new Size(569, 75);
            pnlHead.TabIndex = 0;
            pnlHead.MouseDown += pnlHead_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(537, 12);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(35, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(165, 26);
            label1.TabIndex = 0;
            label1.Text = "Thêm công việc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(13, 100);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "ID dự án";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 141);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 3;
            label2.Text = "ID công việc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 181);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 4;
            label4.Text = "ID quản lý";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(13, 222);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 5;
            label5.Text = "Tên công việc";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(13, 262);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 6;
            label6.Text = "Quyền truy cập";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(13, 302);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 7;
            label7.Text = "Trạng thái";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(13, 343);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(124, 20);
            label8.TabIndex = 8;
            label8.Text = "Công khai dự án";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(13, 383);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(160, 20);
            label9.TabIndex = 9;
            label9.Text = "Công khai phòng ban";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(216, 427);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 45);
            btnSave.TabIndex = 9;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(327, 427);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(88, 45);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(436, 427);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 45);
            btnClear.TabIndex = 11;
            btnClear.Text = "Làm mới";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtPrjID
            // 
            txtPrjID.Location = new Point(216, 103);
            txtPrjID.Margin = new Padding(2);
            txtPrjID.Name = "txtPrjID";
            txtPrjID.Size = new Size(308, 23);
            txtPrjID.TabIndex = 1;
            // 
            // txtJobID
            // 
            txtJobID.Location = new Point(216, 143);
            txtJobID.Margin = new Padding(2);
            txtJobID.Name = "txtJobID";
            txtJobID.Size = new Size(308, 23);
            txtJobID.TabIndex = 2;
            // 
            // txtMngID
            // 
            txtMngID.Location = new Point(216, 182);
            txtMngID.Margin = new Padding(2);
            txtMngID.Name = "txtMngID";
            txtMngID.Size = new Size(308, 23);
            txtMngID.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(216, 223);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(308, 23);
            txtName.TabIndex = 4;
            // 
            // txtAccessR
            // 
            txtAccessR.Location = new Point(216, 263);
            txtAccessR.Margin = new Padding(2);
            txtAccessR.Name = "txtAccessR";
            txtAccessR.Size = new Size(308, 23);
            txtAccessR.TabIndex = 5;
            // 
            // txtDepPub
            // 
            txtDepPub.Location = new Point(216, 384);
            txtDepPub.Margin = new Padding(2);
            txtDepPub.Name = "txtDepPub";
            txtDepPub.Size = new Size(308, 23);
            txtDepPub.TabIndex = 8;
            // 
            // txtPrjPub
            // 
            txtPrjPub.Location = new Point(216, 344);
            txtPrjPub.Margin = new Padding(2);
            txtPrjPub.Name = "txtPrjPub";
            txtPrjPub.Size = new Size(308, 23);
            txtPrjPub.TabIndex = 7;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(216, 303);
            txtStatus.Margin = new Padding(2);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(308, 23);
            txtStatus.TabIndex = 6;
            // 
            // AdminTasksModule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 29);
            ClientSize = new Size(569, 516);
            Controls.Add(txtDepPub);
            Controls.Add(txtPrjPub);
            Controls.Add(txtStatus);
            Controls.Add(txtAccessR);
            Controls.Add(txtName);
            Controls.Add(txtMngID);
            Controls.Add(txtJobID);
            Controls.Add(txtPrjID);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(pnlHead);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "AdminTasksModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminTasksModule";
            pnlHead.ResumeLayout(false);
            pnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Panel pnlHead;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.TextBox txtPrjID;
        public System.Windows.Forms.TextBox txtJobID;
        public System.Windows.Forms.TextBox txtMngID;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtAccessR;
        public System.Windows.Forms.TextBox txtDepPub;
        public System.Windows.Forms.TextBox txtPrjPub;
        public System.Windows.Forms.TextBox txtStatus;
    }
}