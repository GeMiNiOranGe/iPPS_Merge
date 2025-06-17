namespace Pepro.Presentation
{
    partial class AdminProjectEditorForm
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
            projectNameLabel = new Label();
            accessLabel = new Label();
            statusLabel = new Label();
            customerLabel = new Label();
            managerIdLabel = new Label();
            projectIdTextBox = new TextBox();
            projectNameTextBox = new TextBox();
            accessTextBox = new TextBox();
            saveButton = new Button();
            updateButton = new Button();
            clearButton = new Button();
            customerTextBox = new TextBox();
            managerIdTextBox = new TextBox();
            statusTextBox = new TextBox();
            departmentTextBox = new TextBox();
            departmentLabel = new Label();
            startDateTimePicker = new DateTimePicker();
            startDateLabel = new Label();
            endDateLabel = new Label();
            endDateTimePicker = new DateTimePicker();
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
            headerPanel.Size = new Size(525, 75);
            headerPanel.TabIndex = 0;
            headerPanel.MouseDown += HeaderPanel_MouseDown;
            // 
            // closePictureBox
            // 
            closePictureBox.Cursor = Cursors.Hand;
            closePictureBox.Image = Properties.Resources.CloseCircleFill;
            closePictureBox.Location = new Point(492, 12);
            closePictureBox.Margin = new Padding(2);
            closePictureBox.Name = "closePictureBox";
            closePictureBox.Size = new Size(22, 23);
            closePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            closePictureBox.TabIndex = 1;
            closePictureBox.TabStop = false;
            closePictureBox.Click += ClosePictureBox_Click;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.White;
            headerLabel.Location = new Point(30, 21);
            headerLabel.Margin = new Padding(2, 0, 2, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(127, 26);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Thêm dự án";
            // 
            // projectIdLabel
            // 
            projectIdLabel.AutoSize = true;
            projectIdLabel.BackColor = Color.Transparent;
            projectIdLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectIdLabel.ForeColor = Color.White;
            projectIdLabel.Location = new Point(31, 99);
            projectIdLabel.Margin = new Padding(2, 0, 2, 0);
            projectIdLabel.Name = "projectIdLabel";
            projectIdLabel.Size = new Size(70, 20);
            projectIdLabel.TabIndex = 1;
            projectIdLabel.Text = "ID dự án";
            // 
            // projectNameLabel
            // 
            projectNameLabel.AutoSize = true;
            projectNameLabel.BackColor = Color.Transparent;
            projectNameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectNameLabel.ForeColor = Color.White;
            projectNameLabel.Location = new Point(31, 142);
            projectNameLabel.Margin = new Padding(2, 0, 2, 0);
            projectNameLabel.Name = "projectNameLabel";
            projectNameLabel.Size = new Size(80, 20);
            projectNameLabel.TabIndex = 2;
            projectNameLabel.Text = "Tên dự án";
            // 
            // accessLabel
            // 
            accessLabel.AutoSize = true;
            accessLabel.BackColor = Color.Transparent;
            accessLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accessLabel.ForeColor = Color.White;
            accessLabel.Location = new Point(31, 183);
            accessLabel.Margin = new Padding(2, 0, 2, 0);
            accessLabel.Name = "accessLabel";
            accessLabel.Size = new Size(115, 20);
            accessLabel.TabIndex = 3;
            accessLabel.Text = "Quyền truy cập";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.BackColor = Color.Transparent;
            statusLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusLabel.ForeColor = Color.White;
            statusLabel.Location = new Point(30, 226);
            statusLabel.Margin = new Padding(2, 0, 2, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(80, 20);
            statusLabel.TabIndex = 4;
            statusLabel.Text = "Trạng thái";
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.BackColor = Color.Transparent;
            customerLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerLabel.ForeColor = Color.White;
            customerLabel.Location = new Point(30, 268);
            customerLabel.Margin = new Padding(2, 0, 2, 0);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new Size(123, 20);
            customerLabel.TabIndex = 5;
            customerLabel.Text = "Tên khách hàng";
            // 
            // managerIdLabel
            // 
            managerIdLabel.AutoSize = true;
            managerIdLabel.BackColor = Color.Transparent;
            managerIdLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            managerIdLabel.ForeColor = Color.White;
            managerIdLabel.Location = new Point(31, 310);
            managerIdLabel.Margin = new Padding(2, 0, 2, 0);
            managerIdLabel.Name = "managerIdLabel";
            managerIdLabel.Size = new Size(80, 20);
            managerIdLabel.TabIndex = 6;
            managerIdLabel.Text = "ID quản lý";
            // 
            // projectIdTextBox
            // 
            projectIdTextBox.Location = new Point(181, 103);
            projectIdTextBox.Margin = new Padding(2);
            projectIdTextBox.Name = "projectIdTextBox";
            projectIdTextBox.Size = new Size(308, 23);
            projectIdTextBox.TabIndex = 1;
            // 
            // projectNameTextBox
            // 
            projectNameTextBox.Location = new Point(181, 144);
            projectNameTextBox.Margin = new Padding(2);
            projectNameTextBox.Name = "projectNameTextBox";
            projectNameTextBox.Size = new Size(308, 23);
            projectNameTextBox.TabIndex = 2;
            // 
            // accessTextBox
            // 
            accessTextBox.Location = new Point(181, 187);
            accessTextBox.Margin = new Padding(2);
            accessTextBox.Name = "accessTextBox";
            accessTextBox.Size = new Size(308, 23);
            accessTextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton.Location = new Point(181, 486);
            saveButton.Margin = new Padding(2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(88, 45);
            saveButton.TabIndex = 10;
            saveButton.Text = "Lưu";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // updateButton
            // 
            updateButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateButton.Location = new Point(292, 486);
            updateButton.Margin = new Padding(2);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(88, 45);
            updateButton.TabIndex = 11;
            updateButton.Text = "Cập nhật";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += UpdateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearButton.Location = new Point(401, 486);
            clearButton.Margin = new Padding(2);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(88, 45);
            clearButton.TabIndex = 12;
            clearButton.Text = "Làm mới";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButton_Click;
            // 
            // customerTextBox
            // 
            customerTextBox.Location = new Point(181, 271);
            customerTextBox.Margin = new Padding(2);
            customerTextBox.Name = "customerTextBox";
            customerTextBox.Size = new Size(308, 23);
            customerTextBox.TabIndex = 5;
            // 
            // managerIdTextBox
            // 
            managerIdTextBox.Location = new Point(181, 313);
            managerIdTextBox.Margin = new Padding(2);
            managerIdTextBox.Name = "managerIdTextBox";
            managerIdTextBox.Size = new Size(308, 23);
            managerIdTextBox.TabIndex = 6;
            // 
            // statusTextBox
            // 
            statusTextBox.Location = new Point(181, 230);
            statusTextBox.Margin = new Padding(2);
            statusTextBox.Name = "statusTextBox";
            statusTextBox.Size = new Size(308, 23);
            statusTextBox.TabIndex = 4;
            // 
            // departmentTextBox
            // 
            departmentTextBox.Location = new Point(181, 355);
            departmentTextBox.Margin = new Padding(2);
            departmentTextBox.Name = "departmentTextBox";
            departmentTextBox.Size = new Size(308, 23);
            departmentTextBox.TabIndex = 7;
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.BackColor = Color.Transparent;
            departmentLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departmentLabel.ForeColor = Color.White;
            departmentLabel.Location = new Point(31, 353);
            departmentLabel.Margin = new Padding(2, 0, 2, 0);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new Size(106, 20);
            departmentLabel.TabIndex = 13;
            departmentLabel.Text = "ID phòng ban";
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.Format = DateTimePickerFormat.Short;
            startDateTimePicker.Location = new Point(181, 396);
            startDateTimePicker.Margin = new Padding(2);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(308, 23);
            startDateTimePicker.TabIndex = 8;
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.BackColor = Color.Transparent;
            startDateLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startDateLabel.ForeColor = Color.White;
            startDateLabel.Location = new Point(30, 392);
            startDateLabel.Margin = new Padding(2, 0, 2, 0);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(103, 20);
            startDateLabel.TabIndex = 16;
            startDateLabel.Text = "Ngày bắt đầu";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.BackColor = Color.Transparent;
            endDateLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endDateLabel.ForeColor = Color.White;
            endDateLabel.Location = new Point(30, 433);
            endDateLabel.Margin = new Padding(2, 0, 2, 0);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(106, 20);
            endDateLabel.TabIndex = 18;
            endDateLabel.Text = "Ngày kết thúc";
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Format = DateTimePickerFormat.Short;
            endDateTimePicker.Location = new Point(181, 436);
            endDateTimePicker.Margin = new Padding(2);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(308, 23);
            endDateTimePicker.TabIndex = 9;
            // 
            // AdminProjectsModule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 29);
            ClientSize = new Size(525, 563);
            Controls.Add(endDateLabel);
            Controls.Add(endDateTimePicker);
            Controls.Add(startDateLabel);
            Controls.Add(startDateTimePicker);
            Controls.Add(departmentTextBox);
            Controls.Add(departmentLabel);
            Controls.Add(statusTextBox);
            Controls.Add(managerIdTextBox);
            Controls.Add(customerTextBox);
            Controls.Add(clearButton);
            Controls.Add(updateButton);
            Controls.Add(saveButton);
            Controls.Add(accessTextBox);
            Controls.Add(projectNameTextBox);
            Controls.Add(projectIdTextBox);
            Controls.Add(managerIdLabel);
            Controls.Add(customerLabel);
            Controls.Add(statusLabel);
            Controls.Add(accessLabel);
            Controls.Add(projectNameLabel);
            Controls.Add(projectIdLabel);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "AdminProjectsModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminProjectsModule";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)closePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Panel headerPanel;
        private Label headerLabel;
        private Label projectIdLabel;
        private Label projectNameLabel;
        private Label accessLabel;
        private Label statusLabel;
        private Label customerLabel;
        private Label managerIdLabel;
        public TextBox projectIdTextBox;
        public TextBox projectNameTextBox;
        public TextBox accessTextBox;
        public Button saveButton;
        public Button updateButton;
        public Button clearButton;
        private PictureBox closePictureBox;
        public TextBox customerTextBox;
        public TextBox managerIdTextBox;
        public TextBox statusTextBox;
        public TextBox departmentTextBox;
        private Label departmentLabel;
        public DateTimePicker startDateTimePicker;
        private Label startDateLabel;
        private Label endDateLabel;
        public DateTimePicker endDateTimePicker;
    }
}