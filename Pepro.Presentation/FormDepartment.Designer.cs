namespace Pepro.Presentation
{
    partial class FormDepartment
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
            dtgvDepartment = new DataGridView();
            DepartmentID = new DataGridViewTextBoxColumn();
            DepartmentName = new DataGridViewTextBoxColumn();
            ManagerID = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvDepartment).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvDepartment
            // 
            dtgvDepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDepartment.Columns.AddRange(new DataGridViewColumn[] { DepartmentID, DepartmentName, ManagerID });
            dtgvDepartment.Location = new Point(121, 270);
            dtgvDepartment.Margin = new Padding(4, 3, 4, 3);
            dtgvDepartment.Name = "dtgvDepartment";
            dtgvDepartment.ReadOnly = true;
            dtgvDepartment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvDepartment.Size = new Size(780, 210);
            dtgvDepartment.TabIndex = 0;
            dtgvDepartment.CellContentClick += dtgvDepartment_CellContentClick;
            // 
            // DepartmentID
            // 
            DepartmentID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DepartmentID.DataPropertyName = "DepartmentID";
            DepartmentID.HeaderText = "ID";
            DepartmentID.Name = "DepartmentID";
            DepartmentID.ReadOnly = true;
            // 
            // DepartmentName
            // 
            DepartmentName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DepartmentName.DataPropertyName = "DepartmentName";
            DepartmentName.HeaderText = "Name";
            DepartmentName.Name = "DepartmentName";
            DepartmentName.ReadOnly = true;
            // 
            // ManagerID
            // 
            ManagerID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ManagerID.DataPropertyName = "ManagerID";
            ManagerID.HeaderText = "Manager";
            ManagerID.Name = "ManagerID";
            ManagerID.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(247, 32);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(519, 216);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Function";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Menu;
            btnDelete.Location = new Point(343, 165);
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
            btnUpdate.Location = new Point(246, 165);
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
            btnAdd.Location = new Point(140, 165);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(74, 36);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(203, 117);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 23);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 121);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Manager:";
            // 
            // txtName
            // 
            txtName.Location = new Point(203, 70);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 23);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 74);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // txtID
            // 
            txtID.Location = new Point(203, 22);
            txtID.Margin = new Padding(4, 3, 4, 3);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 23);
            txtID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // FormDepartment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 537);
            Controls.Add(groupBox1);
            Controls.Add(dtgvDepartment);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormDepartment";
            Text = "Department";
            Load += FormDepartment_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvDepartment).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private DataGridView dtgvDepartment;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridViewTextBoxColumn DepartmentID;
        private DataGridViewTextBoxColumn DepartmentName;
        private DataGridViewTextBoxColumn ManagerID;
    }
}