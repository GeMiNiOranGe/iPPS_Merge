namespace Pepro.Presentation
{
    partial class formChamCong
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
            informationGroupBox = new GroupBox();
            statusComboBox = new ComboBox();
            statusLabel = new Label();
            attendanceIdTextBox = new TextBox();
            attendanceIdLabel = new Label();
            numberOfAttendanceLabel = new Label();
            numberOfAttendanceNumericUpDown = new NumericUpDown();
            label5 = new Label();
            numngaynghiBHXH = new NumericUpDown();
            label4 = new Label();
            numngaynghi = new NumericUpDown();
            attendanceDateTimePicker = new DateTimePicker();
            employeeIdTextBox = new ComboBox();
            attendanceDateLabel = new Label();
            employeeIdLabel = new Label();
            addButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            attendanceDataGridView = new DataGridView();
            MACC = new DataGridViewTextBoxColumn();
            THANG = new DataGridViewTextBoxColumn();
            SONGAYTRONGTHANG = new DataGridViewTextBoxColumn();
            SONGAYNGHIBHXH = new DataGridViewTextBoxColumn();
            SONGAYNGHIKHONGLYDO = new DataGridViewTextBoxColumn();
            MANV = new DataGridViewTextBoxColumn();
            label2 = new Label();
            attendanceButton = new Button();
            exportReportButton = new Button();
            informationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numberOfAttendanceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numngaynghiBHXH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numngaynghi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)attendanceDataGridView).BeginInit();
            SuspendLayout();
            // 
            // informationGroupBox
            // 
            informationGroupBox.Anchor = AnchorStyles.Top;
            informationGroupBox.AutoSize = true;
            informationGroupBox.BackColor = Color.FromArgb(255, 165, 89);
            informationGroupBox.Controls.Add(statusComboBox);
            informationGroupBox.Controls.Add(statusLabel);
            informationGroupBox.Controls.Add(attendanceIdTextBox);
            informationGroupBox.Controls.Add(attendanceIdLabel);
            informationGroupBox.Controls.Add(numberOfAttendanceLabel);
            informationGroupBox.Controls.Add(numberOfAttendanceNumericUpDown);
            informationGroupBox.Controls.Add(label5);
            informationGroupBox.Controls.Add(numngaynghiBHXH);
            informationGroupBox.Controls.Add(label4);
            informationGroupBox.Controls.Add(numngaynghi);
            informationGroupBox.Controls.Add(attendanceDateTimePicker);
            informationGroupBox.Controls.Add(employeeIdTextBox);
            informationGroupBox.Controls.Add(attendanceDateLabel);
            informationGroupBox.Controls.Add(employeeIdLabel);
            informationGroupBox.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            informationGroupBox.Location = new Point(10, 70);
            informationGroupBox.Margin = new Padding(4);
            informationGroupBox.Name = "informationGroupBox";
            informationGroupBox.Padding = new Padding(4);
            informationGroupBox.Size = new Size(988, 163);
            informationGroupBox.TabIndex = 46;
            informationGroupBox.TabStop = false;
            informationGroupBox.Text = "Thông Tin Chấm Công";
            // 
            // statusComboBox
            // 
            statusComboBox.BackColor = SystemColors.Info;
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Items.AddRange(new object[] { "Đi làm", "Nghỉ có phép", "Nghỉ không phép" });
            statusComboBox.Location = new Point(162, 78);
            statusComboBox.Margin = new Padding(4, 2, 4, 2);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(154, 25);
            statusComboBox.TabIndex = 26;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusLabel.Location = new Point(65, 81);
            statusLabel.Margin = new Padding(4, 0, 4, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(85, 18);
            statusLabel.TabIndex = 25;
            statusLabel.Text = "Tình Trạng:";
            // 
            // attendanceIdTextBox
            // 
            attendanceIdTextBox.Location = new Point(162, 37);
            attendanceIdTextBox.Margin = new Padding(4);
            attendanceIdTextBox.Name = "attendanceIdTextBox";
            attendanceIdTextBox.Size = new Size(154, 24);
            attendanceIdTextBox.TabIndex = 24;
            // 
            // attendanceIdLabel
            // 
            attendanceIdLabel.AutoSize = true;
            attendanceIdLabel.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            attendanceIdLabel.Location = new Point(35, 38);
            attendanceIdLabel.Margin = new Padding(4, 0, 4, 0);
            attendanceIdLabel.Name = "attendanceIdLabel";
            attendanceIdLabel.Size = new Size(114, 18);
            attendanceIdLabel.TabIndex = 23;
            attendanceIdLabel.Text = "Mã Chấm Công:";
            // 
            // numberOfAttendanceLabel
            // 
            numberOfAttendanceLabel.AutoSize = true;
            numberOfAttendanceLabel.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numberOfAttendanceLabel.Location = new Point(760, 29);
            numberOfAttendanceLabel.Margin = new Padding(4, 0, 4, 0);
            numberOfAttendanceLabel.Name = "numberOfAttendanceLabel";
            numberOfAttendanceLabel.Size = new Size(110, 18);
            numberOfAttendanceLabel.TabIndex = 22;
            numberOfAttendanceLabel.Text = "Số ngày đi làm:";
            // 
            // numberOfAttendanceNumericUpDown
            // 
            numberOfAttendanceNumericUpDown.Location = new Point(893, 27);
            numberOfAttendanceNumericUpDown.Margin = new Padding(4);
            numberOfAttendanceNumericUpDown.Name = "numberOfAttendanceNumericUpDown";
            numberOfAttendanceNumericUpDown.Size = new Size(80, 24);
            numberOfAttendanceNumericUpDown.TabIndex = 21;
            numberOfAttendanceNumericUpDown.ValueChanged += NumberOfAttendanceNumericUpDown_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(727, 115);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(140, 18);
            label5.TabIndex = 20;
            label5.Text = "Số ngày nghỉ BHXH:";
            // 
            // numngaynghiBHXH
            // 
            numngaynghiBHXH.Location = new Point(893, 110);
            numngaynghiBHXH.Margin = new Padding(4);
            numngaynghiBHXH.Name = "numngaynghiBHXH";
            numngaynghiBHXH.Size = new Size(80, 24);
            numngaynghiBHXH.TabIndex = 19;
            numngaynghiBHXH.ValueChanged += NumngaynghiBHXH_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(684, 72);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(178, 18);
            label4.TabIndex = 18;
            label4.Text = "Số ngày nghỉ không phép:";
            // 
            // numngaynghi
            // 
            numngaynghi.Location = new Point(893, 68);
            numngaynghi.Margin = new Padding(4);
            numngaynghi.Name = "numngaynghi";
            numngaynghi.Size = new Size(80, 24);
            numngaynghi.TabIndex = 17;
            numngaynghi.ValueChanged += Numngaynghi_ValueChanged;
            // 
            // attendanceDateTimePicker
            // 
            attendanceDateTimePicker.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            attendanceDateTimePicker.Format = DateTimePickerFormat.Short;
            attendanceDateTimePicker.Location = new Point(462, 79);
            attendanceDateTimePicker.Margin = new Padding(4, 2, 4, 2);
            attendanceDateTimePicker.Name = "attendanceDateTimePicker";
            attendanceDateTimePicker.Size = new Size(200, 25);
            attendanceDateTimePicker.TabIndex = 16;
            attendanceDateTimePicker.ValueChanged += AttendanceDateTimePicker_ValueChanged;
            // 
            // employeeIdTextBox
            // 
            employeeIdTextBox.BackColor = SystemColors.Info;
            employeeIdTextBox.DropDownStyle = ComboBoxStyle.DropDownList;
            employeeIdTextBox.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeeIdTextBox.FormattingEnabled = true;
            employeeIdTextBox.Location = new Point(462, 36);
            employeeIdTextBox.Margin = new Padding(4, 2, 4, 2);
            employeeIdTextBox.Name = "employeeIdTextBox";
            employeeIdTextBox.Size = new Size(200, 25);
            employeeIdTextBox.TabIndex = 15;
            // 
            // attendanceDateLabel
            // 
            attendanceDateLabel.AutoSize = true;
            attendanceDateLabel.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            attendanceDateLabel.Location = new Point(345, 83);
            attendanceDateLabel.Margin = new Padding(4, 0, 4, 0);
            attendanceDateLabel.Name = "attendanceDateLabel";
            attendanceDateLabel.Size = new Size(105, 18);
            attendanceDateLabel.TabIndex = 12;
            attendanceDateLabel.Text = "Ngày làm việc:";
            // 
            // employeeIdLabel
            // 
            employeeIdLabel.AutoSize = true;
            employeeIdLabel.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeeIdLabel.Location = new Point(348, 40);
            employeeIdLabel.Margin = new Padding(4, 0, 4, 0);
            employeeIdLabel.Name = "employeeIdLabel";
            employeeIdLabel.Size = new Size(101, 18);
            employeeIdLabel.TabIndex = 10;
            employeeIdLabel.Text = "Mã nhân viên:";
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addButton.BackColor = Color.FromArgb(255, 96, 0);
            addButton.FlatStyle = FlatStyle.Popup;
            addButton.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addButton.Location = new Point(380, 572);
            addButton.Margin = new Padding(4);
            addButton.Name = "addButton";
            addButton.Size = new Size(109, 35);
            addButton.TabIndex = 50;
            addButton.Text = "Thêm mới";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += AddButton_Click;
            // 
            // updateButton
            // 
            updateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            updateButton.BackColor = Color.FromArgb(255, 96, 0);
            updateButton.FlatStyle = FlatStyle.Popup;
            updateButton.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateButton.Location = new Point(517, 572);
            updateButton.Margin = new Padding(4);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(109, 35);
            updateButton.TabIndex = 51;
            updateButton.Text = "Cập nhật";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += UpdateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteButton.BackColor = Color.FromArgb(255, 96, 0);
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteButton.Location = new Point(654, 572);
            deleteButton.Margin = new Padding(4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(109, 35);
            deleteButton.TabIndex = 52;
            deleteButton.Text = "Xóa";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += DeleteButton_Click;
            // 
            // attendanceDataGridView
            // 
            attendanceDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            attendanceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            attendanceDataGridView.Columns.AddRange(new DataGridViewColumn[] { MACC, THANG, SONGAYTRONGTHANG, SONGAYNGHIBHXH, SONGAYNGHIKHONGLYDO, MANV });
            attendanceDataGridView.Location = new Point(2, 231);
            attendanceDataGridView.Margin = new Padding(4);
            attendanceDataGridView.Name = "attendanceDataGridView";
            attendanceDataGridView.RowHeadersWidth = 51;
            attendanceDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            attendanceDataGridView.Size = new Size(1004, 314);
            attendanceDataGridView.TabIndex = 54;
            attendanceDataGridView.SelectionChanged += AttendanceDataGridView_SelectionChanged;
            // 
            // MACC
            // 
            MACC.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MACC.DataPropertyName = "MACC";
            MACC.HeaderText = "Mã Chấm Công";
            MACC.MinimumWidth = 6;
            MACC.Name = "MACC";
            MACC.ReadOnly = true;
            // 
            // THANG
            // 
            THANG.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            THANG.DataPropertyName = "THANG";
            THANG.HeaderText = "Tháng";
            THANG.MinimumWidth = 6;
            THANG.Name = "THANG";
            THANG.ReadOnly = true;
            // 
            // SONGAYTRONGTHANG
            // 
            SONGAYTRONGTHANG.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SONGAYTRONGTHANG.DataPropertyName = "SONGAYTRONGTHANG";
            SONGAYTRONGTHANG.HeaderText = "Số ngày trong tháng";
            SONGAYTRONGTHANG.MinimumWidth = 6;
            SONGAYTRONGTHANG.Name = "SONGAYTRONGTHANG";
            SONGAYTRONGTHANG.ReadOnly = true;
            // 
            // SONGAYNGHIBHXH
            // 
            SONGAYNGHIBHXH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SONGAYNGHIBHXH.DataPropertyName = "SONGAYNGHIBHXH";
            SONGAYNGHIBHXH.HeaderText = "Số ngày nghỉ BHXH";
            SONGAYNGHIBHXH.MinimumWidth = 6;
            SONGAYNGHIBHXH.Name = "SONGAYNGHIBHXH";
            SONGAYNGHIBHXH.ReadOnly = true;
            // 
            // SONGAYNGHIKHONGLYDO
            // 
            SONGAYNGHIKHONGLYDO.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SONGAYNGHIKHONGLYDO.DataPropertyName = "SONGAYNGHIKHONGLYDO";
            SONGAYNGHIKHONGLYDO.HeaderText = "Số ngày nghỉ không lý do";
            SONGAYNGHIKHONGLYDO.MinimumWidth = 6;
            SONGAYNGHIKHONGLYDO.Name = "SONGAYNGHIKHONGLYDO";
            // 
            // MANV
            // 
            MANV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MANV.DataPropertyName = "MANV";
            MANV.HeaderText = "Mã Nhân Viên";
            MANV.MinimumWidth = 6;
            MANV.Name = "MANV";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(430, 23);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(138, 27);
            label2.TabIndex = 55;
            label2.Text = "Chấm Công";
            // 
            // attendanceButton
            // 
            attendanceButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            attendanceButton.BackColor = Color.FromArgb(255, 96, 0);
            attendanceButton.FlatStyle = FlatStyle.Popup;
            attendanceButton.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            attendanceButton.Location = new Point(242, 572);
            attendanceButton.Margin = new Padding(4);
            attendanceButton.Name = "attendanceButton";
            attendanceButton.Size = new Size(109, 35);
            attendanceButton.TabIndex = 56;
            attendanceButton.Text = "Chấm công";
            attendanceButton.UseVisualStyleBackColor = false;
            attendanceButton.Click += AttendanceButton_Click;
            // 
            // exportReportButton
            // 
            exportReportButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            exportReportButton.BackColor = Color.FromArgb(255, 96, 0);
            exportReportButton.FlatStyle = FlatStyle.Popup;
            exportReportButton.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exportReportButton.Location = new Point(105, 572);
            exportReportButton.Margin = new Padding(4);
            exportReportButton.Name = "exportReportButton";
            exportReportButton.Size = new Size(109, 35);
            exportReportButton.TabIndex = 57;
            exportReportButton.Text = "Xuất báo cáo";
            exportReportButton.UseVisualStyleBackColor = false;
            exportReportButton.Click += ExportReportButton_Click;
            // 
            // formChamCong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(255, 230, 199);
            Controls.Add(exportReportButton);
            Controls.Add(attendanceButton);
            Controls.Add(label2);
            Controls.Add(attendanceDataGridView);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(addButton);
            Controls.Add(informationGroupBox);
            Margin = new Padding(4);
            Name = "formChamCong";
            Size = new Size(1006, 619);
            Load += FromChamCong_Load;
            informationGroupBox.ResumeLayout(false);
            informationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numberOfAttendanceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)numngaynghiBHXH).EndInit();
            ((System.ComponentModel.ISupportInitialize)numngaynghi).EndInit();
            ((System.ComponentModel.ISupportInitialize)attendanceDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private GroupBox informationGroupBox;
        private Label employeeIdLabel;
        private Button addButton;
        private Button updateButton;
        private Button deleteButton;
        private DataGridView attendanceDataGridView;
        private DataGridViewTextBoxColumn MACC;
        private DataGridViewTextBoxColumn THANG;
        private DataGridViewTextBoxColumn SONGAYTRONGTHANG;
        private DataGridViewTextBoxColumn SONGAYNGHIBHXH;
        private DataGridViewTextBoxColumn SONGAYNGHIKHONGLYDO;
        private DataGridViewTextBoxColumn MANV;
        private ComboBox employeeIdTextBox;
        private Label label2;
        private Label label4;
        private NumericUpDown numngaynghi;
        private DateTimePicker attendanceDateTimePicker;
        private Label attendanceDateLabel;
        private Label numberOfAttendanceLabel;
        private NumericUpDown numberOfAttendanceNumericUpDown;
        private Label label5;
        private NumericUpDown numngaynghiBHXH;
        private TextBox attendanceIdTextBox;
        private Label attendanceIdLabel;
        private ComboBox statusComboBox;
        private Label statusLabel;
        private Button attendanceButton;
        private Button exportReportButton;
    }
}