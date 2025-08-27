namespace Pepro.Presentation.Controls
{
    partial class AssignmentEditorControl
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
            projectIdLabel = new Label();
            taskIdLabel = new Label();
            managerIdLabel = new Label();
            taskNameLabel = new Label();
            accessLabel = new Label();
            statusLabel = new Label();
            publicProjectLabel = new Label();
            publicDepartmentLabel = new Label();
            saveButton = new Button();
            updateButton = new Button();
            clearButton = new Button();
            projectIdTextBox = new TextBox();
            taskIdTextBox = new TextBox();
            managerIdTextBox = new TextBox();
            taskNameTextBox = new TextBox();
            accessTextBox = new TextBox();
            publicDepartmentTextBox = new TextBox();
            publicProjectTextBox = new TextBox();
            statusTextBox = new TextBox();
            SuspendLayout();
            // 
            // projectIdLabel
            // 
            projectIdLabel.AutoSize = true;
            projectIdLabel.BackColor = Color.Transparent;
            projectIdLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectIdLabel.ForeColor = Color.White;
            projectIdLabel.Location = new Point(15, 127);
            projectIdLabel.Margin = new Padding(2, 0, 2, 0);
            projectIdLabel.Name = "projectIdLabel";
            projectIdLabel.Size = new Size(70, 20);
            projectIdLabel.TabIndex = 2;
            projectIdLabel.Text = "ID dự án";
            // 
            // taskIdLabel
            // 
            taskIdLabel.AutoSize = true;
            taskIdLabel.BackColor = Color.Transparent;
            taskIdLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskIdLabel.ForeColor = Color.White;
            taskIdLabel.Location = new Point(15, 179);
            taskIdLabel.Margin = new Padding(2, 0, 2, 0);
            taskIdLabel.Name = "taskIdLabel";
            taskIdLabel.Size = new Size(96, 20);
            taskIdLabel.TabIndex = 3;
            taskIdLabel.Text = "ID công việc";
            // 
            // managerIdLabel
            // 
            managerIdLabel.AutoSize = true;
            managerIdLabel.BackColor = Color.Transparent;
            managerIdLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            managerIdLabel.ForeColor = Color.White;
            managerIdLabel.Location = new Point(15, 229);
            managerIdLabel.Margin = new Padding(2, 0, 2, 0);
            managerIdLabel.Name = "managerIdLabel";
            managerIdLabel.Size = new Size(80, 20);
            managerIdLabel.TabIndex = 4;
            managerIdLabel.Text = "ID quản lý";
            // 
            // taskNameLabel
            // 
            taskNameLabel.AutoSize = true;
            taskNameLabel.BackColor = Color.Transparent;
            taskNameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskNameLabel.ForeColor = Color.White;
            taskNameLabel.Location = new Point(15, 281);
            taskNameLabel.Margin = new Padding(2, 0, 2, 0);
            taskNameLabel.Name = "taskNameLabel";
            taskNameLabel.Size = new Size(106, 20);
            taskNameLabel.TabIndex = 5;
            taskNameLabel.Text = "Tên công việc";
            // 
            // accessLabel
            // 
            accessLabel.AutoSize = true;
            accessLabel.BackColor = Color.Transparent;
            accessLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accessLabel.ForeColor = Color.White;
            accessLabel.Location = new Point(15, 332);
            accessLabel.Margin = new Padding(2, 0, 2, 0);
            accessLabel.Name = "accessLabel";
            accessLabel.Size = new Size(115, 20);
            accessLabel.TabIndex = 6;
            accessLabel.Text = "Quyền truy cập";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.BackColor = Color.Transparent;
            statusLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusLabel.ForeColor = Color.White;
            statusLabel.Location = new Point(15, 383);
            statusLabel.Margin = new Padding(2, 0, 2, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(80, 20);
            statusLabel.TabIndex = 7;
            statusLabel.Text = "Trạng thái";
            // 
            // publicProjectLabel
            // 
            publicProjectLabel.AutoSize = true;
            publicProjectLabel.BackColor = Color.Transparent;
            publicProjectLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            publicProjectLabel.ForeColor = Color.White;
            publicProjectLabel.Location = new Point(15, 434);
            publicProjectLabel.Margin = new Padding(2, 0, 2, 0);
            publicProjectLabel.Name = "publicProjectLabel";
            publicProjectLabel.Size = new Size(124, 20);
            publicProjectLabel.TabIndex = 8;
            publicProjectLabel.Text = "Công khai dự án";
            // 
            // publicDepartmentLabel
            // 
            publicDepartmentLabel.AutoSize = true;
            publicDepartmentLabel.BackColor = Color.Transparent;
            publicDepartmentLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            publicDepartmentLabel.ForeColor = Color.White;
            publicDepartmentLabel.Location = new Point(15, 485);
            publicDepartmentLabel.Margin = new Padding(2, 0, 2, 0);
            publicDepartmentLabel.Name = "publicDepartmentLabel";
            publicDepartmentLabel.Size = new Size(160, 20);
            publicDepartmentLabel.TabIndex = 9;
            publicDepartmentLabel.Text = "Công khai phòng ban";
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton.Location = new Point(247, 541);
            saveButton.Margin = new Padding(2, 3, 2, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(101, 57);
            saveButton.TabIndex = 9;
            saveButton.Text = "Lưu";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // updateButton
            // 
            updateButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateButton.Location = new Point(374, 541);
            updateButton.Margin = new Padding(2, 3, 2, 3);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(101, 57);
            updateButton.TabIndex = 10;
            updateButton.Text = "Cập nhật";
            updateButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearButton.Location = new Point(498, 541);
            clearButton.Margin = new Padding(2, 3, 2, 3);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(101, 57);
            clearButton.TabIndex = 11;
            clearButton.Text = "Làm mới";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // projectIdTextBox
            // 
            projectIdTextBox.Location = new Point(247, 130);
            projectIdTextBox.Margin = new Padding(2, 3, 2, 3);
            projectIdTextBox.Name = "projectIdTextBox";
            projectIdTextBox.Size = new Size(351, 26);
            projectIdTextBox.TabIndex = 1;
            // 
            // taskIdTextBox
            // 
            taskIdTextBox.Location = new Point(247, 181);
            taskIdTextBox.Margin = new Padding(2, 3, 2, 3);
            taskIdTextBox.Name = "taskIdTextBox";
            taskIdTextBox.Size = new Size(351, 26);
            taskIdTextBox.TabIndex = 2;
            // 
            // managerIdTextBox
            // 
            managerIdTextBox.Location = new Point(247, 231);
            managerIdTextBox.Margin = new Padding(2, 3, 2, 3);
            managerIdTextBox.Name = "managerIdTextBox";
            managerIdTextBox.Size = new Size(351, 26);
            managerIdTextBox.TabIndex = 3;
            // 
            // taskNameTextBox
            // 
            taskNameTextBox.Location = new Point(247, 282);
            taskNameTextBox.Margin = new Padding(2, 3, 2, 3);
            taskNameTextBox.Name = "taskNameTextBox";
            taskNameTextBox.Size = new Size(351, 26);
            taskNameTextBox.TabIndex = 4;
            // 
            // accessTextBox
            // 
            accessTextBox.Location = new Point(247, 333);
            accessTextBox.Margin = new Padding(2, 3, 2, 3);
            accessTextBox.Name = "accessTextBox";
            accessTextBox.Size = new Size(351, 26);
            accessTextBox.TabIndex = 5;
            // 
            // publicDepartmentTextBox
            // 
            publicDepartmentTextBox.Location = new Point(247, 486);
            publicDepartmentTextBox.Margin = new Padding(2, 3, 2, 3);
            publicDepartmentTextBox.Name = "publicDepartmentTextBox";
            publicDepartmentTextBox.Size = new Size(351, 26);
            publicDepartmentTextBox.TabIndex = 8;
            // 
            // publicProjectTextBox
            // 
            publicProjectTextBox.Location = new Point(247, 436);
            publicProjectTextBox.Margin = new Padding(2, 3, 2, 3);
            publicProjectTextBox.Name = "publicProjectTextBox";
            publicProjectTextBox.Size = new Size(351, 26);
            publicProjectTextBox.TabIndex = 7;
            // 
            // statusTextBox
            // 
            statusTextBox.Location = new Point(247, 384);
            statusTextBox.Margin = new Padding(2, 3, 2, 3);
            statusTextBox.Name = "statusTextBox";
            statusTextBox.Size = new Size(351, 26);
            statusTextBox.TabIndex = 6;
            // 
            // AssignmentEditorControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(publicDepartmentTextBox);
            Controls.Add(publicProjectTextBox);
            Controls.Add(statusTextBox);
            Controls.Add(accessTextBox);
            Controls.Add(taskNameTextBox);
            Controls.Add(managerIdTextBox);
            Controls.Add(taskIdTextBox);
            Controls.Add(projectIdTextBox);
            Controls.Add(clearButton);
            Controls.Add(updateButton);
            Controls.Add(saveButton);
            Controls.Add(publicDepartmentLabel);
            Controls.Add(publicProjectLabel);
            Controls.Add(statusLabel);
            Controls.Add(accessLabel);
            Controls.Add(taskNameLabel);
            Controls.Add(managerIdLabel);
            Controls.Add(taskIdLabel);
            Controls.Add(projectIdLabel);
            HeaderText = "Assignment Editor";
            Name = "AssignmentEditorControl";
            Controls.SetChildIndex(projectIdLabel, 0);
            Controls.SetChildIndex(taskIdLabel, 0);
            Controls.SetChildIndex(managerIdLabel, 0);
            Controls.SetChildIndex(taskNameLabel, 0);
            Controls.SetChildIndex(accessLabel, 0);
            Controls.SetChildIndex(statusLabel, 0);
            Controls.SetChildIndex(publicProjectLabel, 0);
            Controls.SetChildIndex(publicDepartmentLabel, 0);
            Controls.SetChildIndex(saveButton, 0);
            Controls.SetChildIndex(updateButton, 0);
            Controls.SetChildIndex(clearButton, 0);
            Controls.SetChildIndex(projectIdTextBox, 0);
            Controls.SetChildIndex(taskIdTextBox, 0);
            Controls.SetChildIndex(managerIdTextBox, 0);
            Controls.SetChildIndex(taskNameTextBox, 0);
            Controls.SetChildIndex(accessTextBox, 0);
            Controls.SetChildIndex(statusTextBox, 0);
            Controls.SetChildIndex(publicProjectTextBox, 0);
            Controls.SetChildIndex(publicDepartmentTextBox, 0);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label projectIdLabel;
        private Label taskIdLabel;
        private Label managerIdLabel;
        private Label taskNameLabel;
        private Label accessLabel;
        private Label statusLabel;
        private Label publicProjectLabel;
        private Label publicDepartmentLabel;
        public Button saveButton;
        public Button updateButton;
        public Button clearButton;
        public TextBox projectIdTextBox;
        public TextBox taskIdTextBox;
        public TextBox managerIdTextBox;
        public TextBox taskNameTextBox;
        public TextBox accessTextBox;
        public TextBox publicDepartmentTextBox;
        public TextBox publicProjectTextBox;
        public TextBox statusTextBox;
    }
}