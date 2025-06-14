namespace Pepro.Presentation {
    partial class FormAccountRole {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            textBox1 = new TextBox();
            txtAccountId = new TextBox();
            lblRoleId = new Label();
            txtID = new TextBox();
            lblAccountId = new Label();
            lblId = new Label();
            dgvAccountRole = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccountRole).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(txtAccountId);
            groupBox1.Controls.Add(lblRoleId);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(lblAccountId);
            groupBox1.Controls.Add(lblId);
            groupBox1.Location = new Point(77, 35);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(780, 216);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Function";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Menu;
            btnDelete.Location = new Point(602, 130);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(74, 36);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Menu;
            btnUpdate.Location = new Point(500, 130);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(74, 36);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Menu;
            btnAdd.Location = new Point(399, 130);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(74, 36);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 127);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 1;
            // 
            // txtAccountId
            // 
            txtAccountId.Location = new Point(510, 36);
            txtAccountId.Margin = new Padding(4, 3, 4, 3);
            txtAccountId.Name = "txtAccountId";
            txtAccountId.Size = new Size(150, 23);
            txtAccountId.TabIndex = 1;
            // 
            // lblRoleId
            // 
            lblRoleId.AutoSize = true;
            lblRoleId.Location = new Point(64, 130);
            lblRoleId.Margin = new Padding(4, 0, 4, 0);
            lblRoleId.Name = "lblRoleId";
            lblRoleId.Size = new Size(47, 15);
            lblRoleId.TabIndex = 0;
            lblRoleId.Text = "Role ID:";
            // 
            // txtID
            // 
            txtID.Location = new Point(142, 36);
            txtID.Margin = new Padding(4, 3, 4, 3);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 23);
            txtID.TabIndex = 1;
            // 
            // lblAccountId
            // 
            lblAccountId.AutoSize = true;
            lblAccountId.Location = new Point(432, 39);
            lblAccountId.Margin = new Padding(4, 0, 4, 0);
            lblAccountId.Name = "lblAccountId";
            lblAccountId.Size = new Size(69, 15);
            lblAccountId.TabIndex = 0;
            lblAccountId.Text = "Account ID:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(111, 39);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // dgvAccountRole
            // 
            dgvAccountRole.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccountRole.Location = new Point(77, 283);
            dgvAccountRole.Margin = new Padding(4, 3, 4, 3);
            dgvAccountRole.Name = "dgvAccountRole";
            dgvAccountRole.Size = new Size(780, 203);
            dgvAccountRole.TabIndex = 8;
            // 
            // FormAccountRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(groupBox1);
            Controls.Add(dgvAccountRole);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormAccountRole";
            Text = "FormAccountRole";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccountRole).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtAccountId;
        private TextBox txtID;
        private Label lblAccountId;
        private Label lblId;
        private DataGridView dgvAccountRole;
        private TextBox textBox1;
        private Label lblRoleId;
    }
}