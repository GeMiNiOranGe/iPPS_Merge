namespace Pepro.Presentation.Controls
{
    partial class AdminTaskControl
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
            taskIdTextBox = new TextBox();
            taskIdLabel = new Label();
            addButton = new Button();
            projectIdTextBox = new TextBox();
            projectIdLabel = new Label();
            Delete = new DataGridViewImageColumn();
            Edit = new DataGridViewImageColumn();
            ProjectID = new DataGridViewTextBoxColumn();
            DepPublic = new DataGridViewTextBoxColumn();
            PrjPublic = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            AccessRight = new DataGridViewTextBoxColumn();
            WorkName = new DataGridViewTextBoxColumn();
            idMng = new DataGridViewTextBoxColumn();
            idJob = new DataGridViewTextBoxColumn();
            taskDataGridView = new DataGridView();
            actionPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)taskDataGridView).BeginInit();
            actionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // taskIdTextBox
            // 
            taskIdTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            taskIdTextBox.Location = new Point(792, 54);
            taskIdTextBox.Margin = new Padding(2, 5, 2, 5);
            taskIdTextBox.Name = "taskIdTextBox";
            taskIdTextBox.Size = new Size(112, 31);
            taskIdTextBox.TabIndex = 4;
            taskIdTextBox.KeyPress += TaskTextBox_KeyPress;
            // 
            // taskIdLabel
            // 
            taskIdLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            taskIdLabel.AutoSize = true;
            taskIdLabel.Font = new Font("Segoe UI", 12F);
            taskIdLabel.ForeColor = Color.White;
            taskIdLabel.Location = new Point(645, 58);
            taskIdLabel.Margin = new Padding(2, 0, 2, 0);
            taskIdLabel.Name = "taskIdLabel";
            taskIdLabel.Size = new Size(143, 21);
            taskIdLabel.TabIndex = 3;
            taskIdLabel.Text = "Nhập mã công việc";
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addButton.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addButton.Location = new Point(916, 22);
            addButton.Margin = new Padding(2, 5, 2, 5);
            addButton.Name = "addButton";
            addButton.Size = new Size(56, 57);
            addButton.TabIndex = 2;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // projectIdTextBox
            // 
            projectIdTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            projectIdTextBox.Location = new Point(792, 15);
            projectIdTextBox.Margin = new Padding(2, 5, 2, 5);
            projectIdTextBox.Name = "projectIdTextBox";
            projectIdTextBox.Size = new Size(112, 31);
            projectIdTextBox.TabIndex = 1;
            projectIdTextBox.KeyPress += ProjectIdTextBox_KeyPress;
            // 
            // projectIdLabel
            // 
            projectIdLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            projectIdLabel.AutoSize = true;
            projectIdLabel.Font = new Font("Segoe UI", 12F);
            projectIdLabel.ForeColor = Color.White;
            projectIdLabel.Location = new Point(671, 19);
            projectIdLabel.Margin = new Padding(2, 0, 2, 0);
            projectIdLabel.Name = "projectIdLabel";
            projectIdLabel.Size = new Size(117, 21);
            projectIdLabel.TabIndex = 0;
            projectIdLabel.Text = "Nhập mã dự án";
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Width = 6;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "";
            Edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Width = 6;
            // 
            // ProjectID
            // 
            ProjectID.HeaderText = "ID dự án";
            ProjectID.MinimumWidth = 6;
            ProjectID.Name = "ProjectID";
            ProjectID.Width = 125;
            // 
            // DepPublic
            // 
            DepPublic.HeaderText = "Công khai phòng ban";
            DepPublic.MinimumWidth = 6;
            DepPublic.Name = "DepPublic";
            DepPublic.Width = 220;
            // 
            // PrjPublic
            // 
            PrjPublic.HeaderText = "Công khai dự án";
            PrjPublic.MinimumWidth = 6;
            PrjPublic.Name = "PrjPublic";
            PrjPublic.Width = 175;
            // 
            // Status
            // 
            Status.HeaderText = "Tình trạng";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // AccessRight
            // 
            AccessRight.HeaderText = "Quyền truy cập";
            AccessRight.MinimumWidth = 6;
            AccessRight.Name = "AccessRight";
            AccessRight.Width = 160;
            // 
            // WorkName
            // 
            WorkName.HeaderText = "Tên công việc";
            WorkName.MinimumWidth = 6;
            WorkName.Name = "WorkName";
            WorkName.Width = 145;
            // 
            // idMng
            // 
            idMng.HeaderText = "ID quản lý";
            idMng.MinimumWidth = 6;
            idMng.Name = "idMng";
            idMng.Width = 125;
            // 
            // idJob
            // 
            idJob.HeaderText = "ID công việc";
            idJob.MinimumWidth = 6;
            idJob.Name = "idJob";
            idJob.Width = 135;
            // 
            // taskDataGridView
            // 
            taskDataGridView.AllowUserToAddRows = false;
            taskDataGridView.BackgroundColor = Color.FromArgb(15, 15, 15);
            taskDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            taskDataGridView.Columns.AddRange(new DataGridViewColumn[] { idJob, idMng, WorkName, AccessRight, Status, PrjPublic, DepPublic, ProjectID, Edit, Delete });
            taskDataGridView.Dock = DockStyle.Fill;
            taskDataGridView.Location = new Point(0, 0);
            taskDataGridView.Margin = new Padding(2, 5, 2, 5);
            taskDataGridView.Name = "taskDataGridView";
            taskDataGridView.RowHeadersWidth = 51;
            taskDataGridView.RowTemplate.Height = 24;
            taskDataGridView.Size = new Size(984, 462);
            taskDataGridView.TabIndex = 0;
            taskDataGridView.CellContentClick += TaskDataGridView_CellContentClick;
            // 
            // actionPanel
            // 
            actionPanel.BackColor = Color.FromArgb(22, 22, 22);
            actionPanel.Controls.Add(projectIdTextBox);
            actionPanel.Controls.Add(taskIdTextBox);
            actionPanel.Controls.Add(projectIdLabel);
            actionPanel.Controls.Add(taskIdLabel);
            actionPanel.Controls.Add(addButton);
            actionPanel.Dock = DockStyle.Bottom;
            actionPanel.Location = new Point(0, 462);
            actionPanel.Margin = new Padding(2, 5, 2, 5);
            actionPanel.Name = "actionPanel";
            actionPanel.Size = new Size(984, 99);
            actionPanel.TabIndex = 2;
            // 
            // AdminTasks
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(taskDataGridView);
            Controls.Add(actionPanel);
            Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2, 5, 2, 5);
            Name = "AdminTasks";
            Size = new Size(984, 561);
            Load += AdminTasks_Load;
            ((System.ComponentModel.ISupportInitialize)taskDataGridView).EndInit();
            actionPanel.ResumeLayout(false);
            actionPanel.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private Button addButton;
        private TextBox projectIdTextBox;
        private Label projectIdLabel;
        private TextBox taskIdTextBox;
        private Label taskIdLabel;
        private DataGridViewImageColumn Delete;
        private DataGridViewImageColumn Edit;
        private DataGridViewTextBoxColumn ProjectID;
        private DataGridViewTextBoxColumn DepPublic;
        private DataGridViewTextBoxColumn PrjPublic;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn AccessRight;
        private DataGridViewTextBoxColumn WorkName;
        private DataGridViewTextBoxColumn idMng;
        private DataGridViewTextBoxColumn idJob;
        private DataGridView taskDataGridView;
        private Panel actionPanel;
    }
}