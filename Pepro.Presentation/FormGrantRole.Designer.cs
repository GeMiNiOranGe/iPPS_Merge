namespace Pepro.Presentation
{
    partial class FormGrantRole
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
            dtgvGrant = new DataGridView();
            groupBox1 = new GroupBox();
            btnForbid = new PictureBox();
            btnPermiss = new PictureBox();
            cbColumnName = new ComboBox();
            tbName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cbPermission = new ComboBox();
            label2 = new Label();
            cbRoleID = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvGrant).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnForbid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPermiss).BeginInit();
            SuspendLayout();
            // 
            // dtgvGrant
            // 
            dtgvGrant.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvGrant.Location = new Point(158, 299);
            dtgvGrant.Margin = new Padding(4, 3, 4, 3);
            dtgvGrant.Name = "dtgvGrant";
            dtgvGrant.ReadOnly = true;
            dtgvGrant.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvGrant.Size = new Size(656, 235);
            dtgvGrant.TabIndex = 0;
            dtgvGrant.CellContentClick += dtgvGrant_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(btnForbid);
            groupBox1.Controls.Add(btnPermiss);
            groupBox1.Controls.Add(cbColumnName);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cbPermission);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbRoleID);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(164, 58);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(642, 234);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Function";
            // 
            // btnForbid
            // 
            btnForbid.BackgroundImage = Properties.Resources.IconForbid;
            btnForbid.BackgroundImageLayout = ImageLayout.Center;
            btnForbid.Location = new Point(343, 156);
            btnForbid.Margin = new Padding(4, 3, 4, 3);
            btnForbid.Name = "btnForbid";
            btnForbid.Size = new Size(74, 54);
            btnForbid.TabIndex = 14;
            btnForbid.TabStop = false;
            btnForbid.Click += btnForbid_Click;
            // 
            // btnPermiss
            // 
            btnPermiss.BackgroundImage = Properties.Resources.IconPermiss;
            btnPermiss.BackgroundImageLayout = ImageLayout.Center;
            btnPermiss.Location = new Point(198, 156);
            btnPermiss.Margin = new Padding(4, 3, 4, 3);
            btnPermiss.Name = "btnPermiss";
            btnPermiss.Size = new Size(72, 51);
            btnPermiss.TabIndex = 13;
            btnPermiss.TabStop = false;
            btnPermiss.Click += btnPermiss_Click;
            // 
            // cbColumnName
            // 
            cbColumnName.FormattingEnabled = true;
            cbColumnName.Location = new Point(451, 93);
            cbColumnName.Margin = new Padding(4, 3, 4, 3);
            cbColumnName.Name = "cbColumnName";
            cbColumnName.Size = new Size(166, 23);
            cbColumnName.TabIndex = 12;
            cbColumnName.SelectedIndexChanged += cbColumnName_SelectedIndexChanged;
            // 
            // tbName
            // 
            tbName.Location = new Point(451, 40);
            tbName.Margin = new Padding(4, 3, 4, 3);
            tbName.Name = "tbName";
            tbName.Size = new Size(166, 23);
            tbName.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 98);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 7;
            label3.Text = "ColumnName:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 45);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 5;
            label4.Text = "Name:";
            // 
            // cbPermission
            // 
            cbPermission.FormattingEnabled = true;
            cbPermission.Location = new Point(93, 89);
            cbPermission.Margin = new Padding(4, 3, 4, 3);
            cbPermission.Name = "cbPermission";
            cbPermission.Size = new Size(140, 23);
            cbPermission.TabIndex = 4;
            cbPermission.SelectedIndexChanged += cbPermission_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 96);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 3;
            label2.Text = "PermissionID:";
            // 
            // cbRoleID
            // 
            cbRoleID.FormattingEnabled = true;
            cbRoleID.Location = new Point(93, 42);
            cbRoleID.Margin = new Padding(4, 3, 4, 3);
            cbRoleID.Name = "cbRoleID";
            cbRoleID.Size = new Size(140, 23);
            cbRoleID.TabIndex = 2;
            cbRoleID.SelectedIndexChanged += cbRoleID_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "RoleID:";
            // 
            // FormGrantRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(933, 532);
            Controls.Add(groupBox1);
            Controls.Add(dtgvGrant);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormGrantRole";
            Text = "Grant Role";
            Load += FormGrantRole_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvGrant).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnForbid).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPermiss).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private DataGridView dtgvGrant;
        private GroupBox groupBox1;
        private TextBox tbName;
        private Label label3;
        private Label label4;
        private ComboBox cbPermission;
        private Label label2;
        private ComboBox cbRoleID;
        private Label label1;
        private ComboBox cbColumnName;
        private PictureBox btnForbid;
        private PictureBox btnPermiss;
    }
}