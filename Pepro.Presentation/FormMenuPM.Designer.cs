namespace Pepro.Presentation
{
    partial class FormMenuPM
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
            groupBox1 = new GroupBox();
            picLogout = new PictureBox();
            btnAR = new Button();
            btnGrant = new Button();
            btnDepartment = new Button();
            btnEmployee = new Button();
            pnMenu = new Panel();
            label1 = new Label();
            lbRole = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(picLogout);
            groupBox1.Controls.Add(btnAR);
            groupBox1.Controls.Add(btnGrant);
            groupBox1.Controls.Add(btnDepartment);
            groupBox1.Controls.Add(btnEmployee);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(14, 92);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(203, 481);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Function";
            // 
            // picLogout
            // 
            picLogout.BackgroundImage = Properties.Resources.Logout;
            picLogout.BackgroundImageLayout = ImageLayout.Center;
            picLogout.Location = new Point(4, 399);
            picLogout.Margin = new Padding(4, 3, 4, 3);
            picLogout.Name = "picLogout";
            picLogout.Size = new Size(89, 75);
            picLogout.TabIndex = 3;
            picLogout.TabStop = false;
            picLogout.Click += picLogout_Click;
            // 
            // btnAR
            // 
            btnAR.BackColor = Color.LightSkyBlue;
            btnAR.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAR.ForeColor = SystemColors.ControlLightLight;
            btnAR.Location = new Point(12, 317);
            btnAR.Margin = new Padding(4, 3, 4, 3);
            btnAR.Name = "btnAR";
            btnAR.Size = new Size(184, 57);
            btnAR.TabIndex = 3;
            btnAR.Text = "AccountRole";
            btnAR.UseVisualStyleBackColor = false;
            btnAR.Click += btnAR_Click;
            // 
            // btnGrant
            // 
            btnGrant.BackColor = Color.LightSkyBlue;
            btnGrant.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGrant.ForeColor = SystemColors.ControlLightLight;
            btnGrant.Location = new Point(12, 130);
            btnGrant.Margin = new Padding(4, 3, 4, 3);
            btnGrant.Name = "btnGrant";
            btnGrant.Size = new Size(184, 57);
            btnGrant.TabIndex = 2;
            btnGrant.Text = "Grant Permissions";
            btnGrant.UseVisualStyleBackColor = false;
            btnGrant.Click += btnGrant_Click;
            // 
            // btnDepartment
            // 
            btnDepartment.BackColor = Color.LightSkyBlue;
            btnDepartment.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDepartment.ForeColor = SystemColors.ControlLightLight;
            btnDepartment.Location = new Point(13, 226);
            btnDepartment.Margin = new Padding(4, 3, 4, 3);
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Size = new Size(184, 57);
            btnDepartment.TabIndex = 1;
            btnDepartment.Text = "Department";
            btnDepartment.UseVisualStyleBackColor = false;
            btnDepartment.Click += btnDepartment_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.LightSkyBlue;
            btnEmployee.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployee.ForeColor = SystemColors.ControlLightLight;
            btnEmployee.Location = new Point(12, 32);
            btnEmployee.Margin = new Padding(4, 3, 4, 3);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(184, 57);
            btnEmployee.TabIndex = 0;
            btnEmployee.Text = "Employee";
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // pnMenu
            // 
            pnMenu.BackColor = SystemColors.ButtonFace;
            pnMenu.ForeColor = SystemColors.ActiveCaptionText;
            pnMenu.Location = new Point(224, 97);
            pnMenu.Margin = new Padding(4, 3, 4, 3);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(1097, 477);
            pnMenu.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(21, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(232, 24);
            label1.TabIndex = 2;
            label1.Text = "Personnel Management";
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRole.ForeColor = Color.Coral;
            lbRole.Location = new Point(1098, 42);
            lbRole.Margin = new Padding(4, 0, 4, 0);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(50, 16);
            lbRole.TabIndex = 3;
            lbRole.Text = "Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.iconUser;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(1198, 10);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 80);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FormMenuPM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(1335, 648);
            Controls.Add(pictureBox1);
            Controls.Add(lbRole);
            Controls.Add(label1);
            Controls.Add(pnMenu);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormMenuPM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += FormMenu_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGrant;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.Button btnAR;
    }
}