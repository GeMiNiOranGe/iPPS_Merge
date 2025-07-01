namespace Pepro.Presentation
{
    partial class AdminTaskEditorForm
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
            headerPanel = new Panel();
            closePictureBox = new PictureBox();
            headerLabel = new Label();
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
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closePictureBox).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(34, 130, 253);
            headerPanel.Controls.Add(closePictureBox);
            headerPanel.Controls.Add(headerLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(2);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(569, 75);
            headerPanel.TabIndex = 0;
            headerPanel.MouseDown += HeaderPanel_MouseDown;
            // 
            // closePictureBox
            // 
            closePictureBox.Cursor = Cursors.Hand;
            closePictureBox.Location = new Point(537, 12);
            closePictureBox.Margin = new Padding(2);
            closePictureBox.Name = "closePictureBox";
            closePictureBox.Size = new Size(22, 23);
            closePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            closePictureBox.TabIndex = 1;
            closePictureBox.TabStop = false;
            closePictureBox.Click += ClosePictureBox_Click;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.White;
            headerLabel.Location = new Point(35, 23);
            headerLabel.Margin = new Padding(2, 0, 2, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(165, 26);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Thêm công việc";
            // 
            // projectIdLabel
            // 
            projectIdLabel.AutoSize = true;
            projectIdLabel.BackColor = Color.Transparent;
            projectIdLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectIdLabel.ForeColor = Color.White;
            projectIdLabel.Location = new Point(13, 100);
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
            taskIdLabel.Location = new Point(13, 141);
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
            managerIdLabel.Location = new Point(13, 181);
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
            taskNameLabel.Location = new Point(13, 222);
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
            accessLabel.Location = new Point(13, 262);
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
            statusLabel.Location = new Point(13, 302);
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
            publicProjectLabel.Location = new Point(13, 343);
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
            publicDepartmentLabel.Location = new Point(13, 383);
            publicDepartmentLabel.Margin = new Padding(2, 0, 2, 0);
            publicDepartmentLabel.Name = "publicDepartmentLabel";
            publicDepartmentLabel.Size = new Size(160, 20);
            publicDepartmentLabel.TabIndex = 9;
            publicDepartmentLabel.Text = "Công khai phòng ban";
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton.Location = new Point(216, 427);
            saveButton.Margin = new Padding(2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(88, 45);
            saveButton.TabIndex = 9;
            saveButton.Text = "Lưu";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // updateButton
            // 
            updateButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateButton.Location = new Point(327, 427);
            updateButton.Margin = new Padding(2);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(88, 45);
            updateButton.TabIndex = 10;
            updateButton.Text = "Cập nhật";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += UpdateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearButton.Location = new Point(436, 427);
            clearButton.Margin = new Padding(2);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(88, 45);
            clearButton.TabIndex = 11;
            clearButton.Text = "Làm mới";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButton_Click;
            // 
            // projectIdTextBox
            // 
            projectIdTextBox.Location = new Point(216, 103);
            projectIdTextBox.Margin = new Padding(2);
            projectIdTextBox.Name = "projectIdTextBox";
            projectIdTextBox.Size = new Size(308, 23);
            projectIdTextBox.TabIndex = 1;
            // 
            // taskIdTextBox
            // 
            taskIdTextBox.Location = new Point(216, 143);
            taskIdTextBox.Margin = new Padding(2);
            taskIdTextBox.Name = "taskIdTextBox";
            taskIdTextBox.Size = new Size(308, 23);
            taskIdTextBox.TabIndex = 2;
            // 
            // managerIdTextBox
            // 
            managerIdTextBox.Location = new Point(216, 182);
            managerIdTextBox.Margin = new Padding(2);
            managerIdTextBox.Name = "managerIdTextBox";
            managerIdTextBox.Size = new Size(308, 23);
            managerIdTextBox.TabIndex = 3;
            // 
            // taskNameTextBox
            // 
            taskNameTextBox.Location = new Point(216, 223);
            taskNameTextBox.Margin = new Padding(2);
            taskNameTextBox.Name = "taskNameTextBox";
            taskNameTextBox.Size = new Size(308, 23);
            taskNameTextBox.TabIndex = 4;
            // 
            // accessTextBox
            // 
            accessTextBox.Location = new Point(216, 263);
            accessTextBox.Margin = new Padding(2);
            accessTextBox.Name = "accessTextBox";
            accessTextBox.Size = new Size(308, 23);
            accessTextBox.TabIndex = 5;
            // 
            // publicDepartmentTextBox
            // 
            publicDepartmentTextBox.Location = new Point(216, 384);
            publicDepartmentTextBox.Margin = new Padding(2);
            publicDepartmentTextBox.Name = "publicDepartmentTextBox";
            publicDepartmentTextBox.Size = new Size(308, 23);
            publicDepartmentTextBox.TabIndex = 8;
            // 
            // publicProjectTextBox
            // 
            publicProjectTextBox.Location = new Point(216, 344);
            publicProjectTextBox.Margin = new Padding(2);
            publicProjectTextBox.Name = "publicProjectTextBox";
            publicProjectTextBox.Size = new Size(308, 23);
            publicProjectTextBox.TabIndex = 7;
            // 
            // statusTextBox
            // 
            statusTextBox.Location = new Point(216, 303);
            statusTextBox.Margin = new Padding(2);
            statusTextBox.Name = "statusTextBox";
            statusTextBox.Size = new Size(308, 23);
            statusTextBox.TabIndex = 6;
            // 
            // AdminTaskEditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 29);
            ClientSize = new Size(569, 516);
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
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "AdminTaskEditorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminTasksModule";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)closePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Panel headerPanel;
        private Label headerLabel;
        private PictureBox closePictureBox;
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