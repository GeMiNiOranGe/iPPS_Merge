namespace Pepro.Presentation {
    partial class FormRole {
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
            txtRoleId = new TextBox();
            txtID = new TextBox();
            lblRoleName = new Label();
            lblId = new Label();
            dgvRole = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRole).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtRoleId);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(lblRoleName);
            groupBox1.Controls.Add(lblId);
            groupBox1.Location = new Point(77, 35);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(780, 216);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Function";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Menu;
            btnDelete.Location = new Point(432, 122);
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
            btnUpdate.Location = new Point(330, 122);
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
            btnAdd.Location = new Point(229, 122);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(74, 36);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtRoleId
            // 
            txtRoleId.Location = new Point(514, 52);
            txtRoleId.Margin = new Padding(4, 3, 4, 3);
            txtRoleId.Name = "txtRoleId";
            txtRoleId.Size = new Size(150, 23);
            txtRoleId.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Location = new Point(147, 52);
            txtID.Margin = new Padding(4, 3, 4, 3);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 23);
            txtID.TabIndex = 1;
            // 
            // lblRoleName
            // 
            lblRoleName.AutoSize = true;
            lblRoleName.Location = new Point(436, 55);
            lblRoleName.Margin = new Padding(4, 0, 4, 0);
            lblRoleName.Name = "lblRoleName";
            lblRoleName.Size = new Size(66, 15);
            lblRoleName.TabIndex = 0;
            lblRoleName.Text = "Role name:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(115, 55);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // dgvRole
            // 
            dgvRole.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRole.Location = new Point(77, 283);
            dgvRole.Margin = new Padding(4, 3, 4, 3);
            dgvRole.Name = "dgvRole";
            dgvRole.Size = new Size(780, 203);
            dgvRole.TabIndex = 6;
            // 
            // FormRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(groupBox1);
            Controls.Add(dgvRole);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormRole";
            Text = "FormRole";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRole).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtRoleId;
        private TextBox txtID;
        private Label lblRoleName;
        private Label lblId;
        private DataGridView dgvRole;
    }
}