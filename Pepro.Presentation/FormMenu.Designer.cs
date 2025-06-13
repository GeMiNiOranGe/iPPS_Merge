namespace Pepro.Presentation
{
    partial class FormMenu
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
            panelSidebar = new Panel();
            btnDormitory = new Button();
            btnLuong = new Button();
            btnChamCong = new Button();
            lbMaPB = new Label();
            panelSide = new Panel();
            btnNhanVien = new Button();
            panel2 = new Panel();
            btnExit = new Button();
            panelChinh = new Panel();
            panelSidebar.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(69, 69, 69);
            panelSidebar.Controls.Add(btnDormitory);
            panelSidebar.Controls.Add(btnLuong);
            panelSidebar.Controls.Add(btnChamCong);
            panelSidebar.Controls.Add(lbMaPB);
            panelSidebar.Controls.Add(panelSide);
            panelSidebar.Controls.Add(btnNhanVien);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Margin = new Padding(3, 2, 3, 2);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(220, 656);
            panelSidebar.TabIndex = 0;
            // 
            // btnDormitory
            // 
            btnDormitory.BackColor = Color.FromArgb(69, 69, 69);
            btnDormitory.FlatAppearance.BorderSize = 0;
            btnDormitory.FlatStyle = FlatStyle.Flat;
            btnDormitory.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDormitory.ForeColor = Color.White;
            btnDormitory.Image = Properties.Resources.Dormitory;
            btnDormitory.ImageAlign = ContentAlignment.MiddleLeft;
            btnDormitory.Location = new Point(21, 397);
            btnDormitory.Margin = new Padding(3, 2, 3, 2);
            btnDormitory.Name = "btnDormitory";
            btnDormitory.Size = new Size(196, 62);
            btnDormitory.TabIndex = 10;
            btnDormitory.Text = " Ký Túc Xá";
            btnDormitory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDormitory.UseVisualStyleBackColor = false;
            btnDormitory.Click += btnDormitory_Click;
            // 
            // btnLuong
            // 
            btnLuong.BackColor = Color.FromArgb(69, 69, 69);
            btnLuong.FlatAppearance.BorderSize = 0;
            btnLuong.FlatStyle = FlatStyle.Flat;
            btnLuong.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuong.ForeColor = Color.White;
            btnLuong.Image = Properties.Resources.salary;
            btnLuong.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuong.Location = new Point(21, 305);
            btnLuong.Margin = new Padding(3, 2, 3, 2);
            btnLuong.Name = "btnLuong";
            btnLuong.Size = new Size(196, 62);
            btnLuong.TabIndex = 8;
            btnLuong.Text = " Lương";
            btnLuong.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLuong.UseVisualStyleBackColor = false;
            btnLuong.Click += btnLuong_Click;
            // 
            // btnChamCong
            // 
            btnChamCong.BackColor = Color.FromArgb(69, 69, 69);
            btnChamCong.FlatAppearance.BorderSize = 0;
            btnChamCong.FlatStyle = FlatStyle.Flat;
            btnChamCong.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChamCong.ForeColor = Color.White;
            btnChamCong.Image = Properties.Resources.Chamcong;
            btnChamCong.ImageAlign = ContentAlignment.MiddleLeft;
            btnChamCong.Location = new Point(21, 213);
            btnChamCong.Margin = new Padding(3, 2, 3, 2);
            btnChamCong.Name = "btnChamCong";
            btnChamCong.Size = new Size(196, 62);
            btnChamCong.TabIndex = 6;
            btnChamCong.Text = " Chấm Công";
            btnChamCong.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnChamCong.UseVisualStyleBackColor = false;
            btnChamCong.Click += btnChamCong_Click;
            // 
            // lbMaPB
            // 
            lbMaPB.AutoSize = true;
            lbMaPB.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMaPB.ForeColor = Color.White;
            lbMaPB.Location = new Point(64, 37);
            lbMaPB.Name = "lbMaPB";
            lbMaPB.Size = new Size(83, 27);
            lbMaPB.TabIndex = 4;
            lbMaPB.Text = "Admin";
            // 
            // panelSide
            // 
            panelSide.BackColor = Color.White;
            panelSide.Location = new Point(4, 121);
            panelSide.Margin = new Padding(3, 2, 3, 2);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(13, 62);
            panelSide.TabIndex = 0;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.FromArgb(69, 69, 69);
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhanVien.ForeColor = Color.White;
            btnNhanVien.Image = Properties.Resources.employee;
            btnNhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.Location = new Point(21, 121);
            btnNhanVien.Margin = new Padding(3, 2, 3, 2);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(196, 62);
            btnNhanVien.TabIndex = 2;
            btnNhanVien.Text = "  Nhân Viên";
            btnNhanVien.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 230, 199);
            panel2.Controls.Add(btnExit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(220, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(994, 37);
            panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 230, 199);
            btnExit.BackgroundImageLayout = ImageLayout.Center;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(962, 2);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(32, 32);
            btnExit.TabIndex = 0;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panelChinh
            // 
            panelChinh.BackColor = Color.FromArgb(255, 230, 199);
            panelChinh.Dock = DockStyle.Fill;
            panelChinh.Location = new Point(220, 37);
            panelChinh.Margin = new Padding(3, 2, 3, 2);
            panelChinh.Name = "panelChinh";
            panelChinh.Size = new Size(994, 619);
            panelChinh.TabIndex = 2;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1214, 656);
            Controls.Add(panelChinh);
            Controls.Add(panel2);
            Controls.Add(panelSidebar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenu";
            Load += FormMenu_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Panel panelChinh;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Label lbMaPB;
        private System.Windows.Forms.Button btnChamCong;
        private System.Windows.Forms.Button btnLuong;
        private System.Windows.Forms.Button btnDormitory;
    }
}