namespace Pepro.Presentation {
    partial class RolePermission {
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
            txtColumnName = new TextBox();
            lblColumnName = new Label();
            txtName = new TextBox();
            lblName = new Label();
            txtPermissionID = new TextBox();
            txtRoleId = new TextBox();
            lblPermissionID = new Label();
            txtID = new TextBox();
            lblRoleId = new Label();
            lblId = new Label();
            dgvRolePermission = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRolePermission).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtColumnName);
            groupBox1.Controls.Add(lblColumnName);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(lblName);
            groupBox1.Controls.Add(txtPermissionID);
            groupBox1.Controls.Add(txtRoleId);
            groupBox1.Controls.Add(lblPermissionID);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(lblRoleId);
            groupBox1.Controls.Add(lblId);
            groupBox1.Location = new Point(77, 36);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(780, 216);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Function";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Menu;
            btnDelete.Location = new Point(279, 132);
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
            btnUpdate.Location = new Point(177, 132);
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
            btnAdd.Location = new Point(76, 132);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(74, 36);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtColumnName
            // 
            txtColumnName.Location = new Point(525, 128);
            txtColumnName.Margin = new Padding(4, 3, 4, 3);
            txtColumnName.Name = "txtColumnName";
            txtColumnName.Size = new Size(150, 23);
            txtColumnName.TabIndex = 5;
            // 
            // lblColumnName
            // 
            lblColumnName.AutoSize = true;
            lblColumnName.Location = new Point(432, 132);
            lblColumnName.Margin = new Padding(4, 0, 4, 0);
            lblColumnName.Name = "lblColumnName";
            lblColumnName.Size = new Size(86, 15);
            lblColumnName.TabIndex = 4;
            lblColumnName.Text = "Column name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(158, 70);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 23);
            txtName.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(106, 74);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // txtPermissionID
            // 
            txtPermissionID.Location = new Point(525, 74);
            txtPermissionID.Margin = new Padding(4, 3, 4, 3);
            txtPermissionID.Name = "txtPermissionID";
            txtPermissionID.Size = new Size(150, 23);
            txtPermissionID.TabIndex = 1;
            // 
            // txtRoleId
            // 
            txtRoleId.Location = new Point(525, 22);
            txtRoleId.Margin = new Padding(4, 3, 4, 3);
            txtRoleId.Name = "txtRoleId";
            txtRoleId.Size = new Size(150, 23);
            txtRoleId.TabIndex = 1;
            // 
            // lblPermissionID
            // 
            lblPermissionID.AutoSize = true;
            lblPermissionID.Location = new Point(432, 77);
            lblPermissionID.Margin = new Padding(4, 0, 4, 0);
            lblPermissionID.Name = "lblPermissionID";
            lblPermissionID.Size = new Size(82, 15);
            lblPermissionID.TabIndex = 0;
            lblPermissionID.Text = "Permission ID:";
            // 
            // txtID
            // 
            txtID.Location = new Point(158, 22);
            txtID.Margin = new Padding(4, 3, 4, 3);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 23);
            txtID.TabIndex = 1;
            // 
            // lblRoleId
            // 
            lblRoleId.AutoSize = true;
            lblRoleId.Location = new Point(464, 25);
            lblRoleId.Margin = new Padding(4, 0, 4, 0);
            lblRoleId.Name = "lblRoleId";
            lblRoleId.Size = new Size(47, 15);
            lblRoleId.TabIndex = 0;
            lblRoleId.Text = "Role ID:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(126, 25);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // dgvRolePermission
            // 
            dgvRolePermission.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRolePermission.Location = new Point(77, 284);
            dgvRolePermission.Margin = new Padding(4, 3, 4, 3);
            dgvRolePermission.Name = "dgvRolePermission";
            dgvRolePermission.Size = new Size(780, 203);
            dgvRolePermission.TabIndex = 4;
            // 
            // RolePermission
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(dgvRolePermission);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "RolePermission";
            Text = "FormRolePermission";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRolePermission).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtColumnName;
        private Label lblColumnName;
        private TextBox txtName;
        private Label lblName;
        private TextBox txtID;
        private Label lblId;
        private TextBox txtRoleId;
        private Label lblRoleId;
        private TextBox txtPermissionID;
        private Label lblPermissionID;
        private DataGridView dgvRolePermission;
    }
}