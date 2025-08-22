namespace Pepro.Presentation.Controls
{
    partial class ProjectEditorControl
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
            projectNameLabel = new Label();
            accessLabel = new Label();
            statusLabel = new Label();
            customerLabel = new Label();
            managerIdLabel = new Label();
            projectIdTextBox = new TextBox();
            projectNameTextBox = new TextBox();
            accessTextBox = new TextBox();
            saveButton = new Button();
            customerTextBox = new TextBox();
            managerIdTextBox = new TextBox();
            statusTextBox = new TextBox();
            departmentTextBox = new TextBox();
            departmentLabel = new Label();
            startDateTimePicker = new DateTimePicker();
            startDateLabel = new Label();
            endDateLabel = new Label();
            endDateTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // projectIdLabel
            // 
            projectIdLabel.AutoSize = true;
            projectIdLabel.BackColor = Color.Transparent;
            projectIdLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectIdLabel.ForeColor = Color.White;
            projectIdLabel.Location = new Point(35, 125);
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
            projectNameLabel.Location = new Point(35, 180);
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
            accessLabel.Location = new Point(35, 232);
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
            statusLabel.Location = new Point(34, 286);
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
            customerLabel.Location = new Point(34, 339);
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
            managerIdLabel.Location = new Point(35, 393);
            managerIdLabel.Margin = new Padding(2, 0, 2, 0);
            managerIdLabel.Name = "managerIdLabel";
            managerIdLabel.Size = new Size(80, 20);
            managerIdLabel.TabIndex = 6;
            managerIdLabel.Text = "ID quản lý";
            // 
            // projectIdTextBox
            // 
            projectIdTextBox.Location = new Point(207, 130);
            projectIdTextBox.Margin = new Padding(2, 3, 2, 3);
            projectIdTextBox.Name = "projectIdTextBox";
            projectIdTextBox.Size = new Size(351, 26);
            projectIdTextBox.TabIndex = 1;
            // 
            // projectNameTextBox
            // 
            projectNameTextBox.Location = new Point(207, 182);
            projectNameTextBox.Margin = new Padding(2, 3, 2, 3);
            projectNameTextBox.Name = "projectNameTextBox";
            projectNameTextBox.Size = new Size(351, 26);
            projectNameTextBox.TabIndex = 2;
            // 
            // accessTextBox
            // 
            accessTextBox.Location = new Point(207, 237);
            accessTextBox.Margin = new Padding(2, 3, 2, 3);
            accessTextBox.Name = "accessTextBox";
            accessTextBox.Size = new Size(351, 26);
            accessTextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveButton.Location = new Point(207, 616);
            saveButton.Margin = new Padding(2, 3, 2, 3);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(101, 57);
            saveButton.TabIndex = 10;
            saveButton.Text = "Lưu";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // customerTextBox
            // 
            customerTextBox.Location = new Point(207, 343);
            customerTextBox.Margin = new Padding(2, 3, 2, 3);
            customerTextBox.Name = "customerTextBox";
            customerTextBox.Size = new Size(351, 26);
            customerTextBox.TabIndex = 5;
            // 
            // managerIdTextBox
            // 
            managerIdTextBox.Location = new Point(207, 396);
            managerIdTextBox.Margin = new Padding(2, 3, 2, 3);
            managerIdTextBox.Name = "managerIdTextBox";
            managerIdTextBox.Size = new Size(351, 26);
            managerIdTextBox.TabIndex = 6;
            // 
            // statusTextBox
            // 
            statusTextBox.Location = new Point(207, 291);
            statusTextBox.Margin = new Padding(2, 3, 2, 3);
            statusTextBox.Name = "statusTextBox";
            statusTextBox.Size = new Size(351, 26);
            statusTextBox.TabIndex = 4;
            // 
            // departmentTextBox
            // 
            departmentTextBox.Location = new Point(207, 450);
            departmentTextBox.Margin = new Padding(2, 3, 2, 3);
            departmentTextBox.Name = "departmentTextBox";
            departmentTextBox.Size = new Size(351, 26);
            departmentTextBox.TabIndex = 7;
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.BackColor = Color.Transparent;
            departmentLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departmentLabel.ForeColor = Color.White;
            departmentLabel.Location = new Point(35, 447);
            departmentLabel.Margin = new Padding(2, 0, 2, 0);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new Size(106, 20);
            departmentLabel.TabIndex = 13;
            departmentLabel.Text = "ID phòng ban";
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.Format = DateTimePickerFormat.Short;
            startDateTimePicker.Location = new Point(207, 502);
            startDateTimePicker.Margin = new Padding(2, 3, 2, 3);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(351, 26);
            startDateTimePicker.TabIndex = 8;
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.BackColor = Color.Transparent;
            startDateLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startDateLabel.ForeColor = Color.White;
            startDateLabel.Location = new Point(34, 497);
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
            endDateLabel.Location = new Point(34, 548);
            endDateLabel.Margin = new Padding(2, 0, 2, 0);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(106, 20);
            endDateLabel.TabIndex = 18;
            endDateLabel.Text = "Ngày kết thúc";
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Format = DateTimePickerFormat.Short;
            endDateTimePicker.Location = new Point(207, 552);
            endDateTimePicker.Margin = new Padding(2, 3, 2, 3);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(351, 26);
            endDateTimePicker.TabIndex = 9;
            // 
            // ProjectEditorControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 29);
            Controls.Add(endDateLabel);
            Controls.Add(endDateTimePicker);
            Controls.Add(startDateLabel);
            Controls.Add(startDateTimePicker);
            Controls.Add(departmentTextBox);
            Controls.Add(departmentLabel);
            Controls.Add(statusTextBox);
            Controls.Add(managerIdTextBox);
            Controls.Add(customerTextBox);
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
            HeaderText = "Project Editor";
            Margin = new Padding(2, 3, 2, 3);
            Name = "ProjectEditorControl";
            Controls.SetChildIndex(projectIdLabel, 0);
            Controls.SetChildIndex(projectNameLabel, 0);
            Controls.SetChildIndex(accessLabel, 0);
            Controls.SetChildIndex(statusLabel, 0);
            Controls.SetChildIndex(customerLabel, 0);
            Controls.SetChildIndex(managerIdLabel, 0);
            Controls.SetChildIndex(projectIdTextBox, 0);
            Controls.SetChildIndex(projectNameTextBox, 0);
            Controls.SetChildIndex(accessTextBox, 0);
            Controls.SetChildIndex(saveButton, 0);
            Controls.SetChildIndex(customerTextBox, 0);
            Controls.SetChildIndex(managerIdTextBox, 0);
            Controls.SetChildIndex(statusTextBox, 0);
            Controls.SetChildIndex(departmentLabel, 0);
            Controls.SetChildIndex(departmentTextBox, 0);
            Controls.SetChildIndex(startDateTimePicker, 0);
            Controls.SetChildIndex(startDateLabel, 0);
            Controls.SetChildIndex(endDateTimePicker, 0);
            Controls.SetChildIndex(endDateLabel, 0);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

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