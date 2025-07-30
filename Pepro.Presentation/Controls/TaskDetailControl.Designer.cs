namespace Pepro.Presentation.Controls
{
    partial class TaskDetailControl
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
            tasksOfProjectLabel = new Label();
            tasksOfProjectFlowLayoutPanel = new FlowLayoutPanel();
            taskManagerLabel = new Label();
            taskManagerCard = new EmployeeCardControl();
            otherTasksOfManagerLabel = new Label();
            otherTasksOfManagerFlowLayoutLabel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // projectIdLabel
            // 
            projectIdLabel.AutoSize = true;
            projectIdLabel.ForeColor = Color.White;
            projectIdLabel.Location = new Point(13, 59);
            projectIdLabel.Margin = new Padding(8, 8, 0, 4);
            projectIdLabel.Name = "projectIdLabel";
            projectIdLabel.Size = new Size(66, 19);
            projectIdLabel.TabIndex = 0;
            projectIdLabel.Text = "Project id";
            // 
            // projectNameLabel
            // 
            projectNameLabel.AutoSize = true;
            projectNameLabel.ForeColor = Color.White;
            projectNameLabel.Location = new Point(13, 82);
            projectNameLabel.Margin = new Padding(8, 0, 0, 4);
            projectNameLabel.Name = "projectNameLabel";
            projectNameLabel.Size = new Size(89, 19);
            projectNameLabel.TabIndex = 0;
            projectNameLabel.Text = "Project name";
            // 
            // tasksOfProjectLabel
            // 
            tasksOfProjectLabel.AutoSize = true;
            tasksOfProjectLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            tasksOfProjectLabel.ForeColor = Color.White;
            tasksOfProjectLabel.Location = new Point(13, 108);
            tasksOfProjectLabel.Margin = new Padding(0);
            tasksOfProjectLabel.Name = "tasksOfProjectLabel";
            tasksOfProjectLabel.Size = new Size(161, 28);
            tasksOfProjectLabel.TabIndex = 0;
            tasksOfProjectLabel.Text = "Tasks of project";
            // 
            // tasksOfProjectFlowLayoutPanel
            // 
            tasksOfProjectFlowLayoutPanel.AutoScroll = true;
            tasksOfProjectFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            tasksOfProjectFlowLayoutPanel.Location = new Point(17, 144);
            tasksOfProjectFlowLayoutPanel.Margin = new Padding(8);
            tasksOfProjectFlowLayoutPanel.Name = "tasksOfProjectFlowLayoutPanel";
            tasksOfProjectFlowLayoutPanel.Size = new Size(504, 520);
            tasksOfProjectFlowLayoutPanel.TabIndex = 0;
            // 
            // taskManagerLabel
            // 
            taskManagerLabel.AutoSize = true;
            taskManagerLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            taskManagerLabel.ForeColor = Color.White;
            taskManagerLabel.Location = new Point(549, 108);
            taskManagerLabel.Margin = new Padding(0);
            taskManagerLabel.Name = "taskManagerLabel";
            taskManagerLabel.Size = new Size(142, 28);
            taskManagerLabel.TabIndex = 0;
            taskManagerLabel.Text = "Task manager";
            // 
            // taskManagerCard
            // 
            taskManagerCard.BackColor = Color.FromArgb(29, 29, 29);
            taskManagerCard.ForeColor = Color.White;
            taskManagerCard.Location = new Point(553, 144);
            taskManagerCard.Margin = new Padding(0, 0, 0, 24);
            taskManagerCard.Name = "taskManagerCard";
            taskManagerCard.Size = new Size(495, 61);
            taskManagerCard.TabIndex = 0;
            // 
            // otherTasksOfManagerLabel
            // 
            otherTasksOfManagerLabel.AutoSize = true;
            otherTasksOfManagerLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            otherTasksOfManagerLabel.ForeColor = Color.White;
            otherTasksOfManagerLabel.Location = new Point(549, 229);
            otherTasksOfManagerLabel.Margin = new Padding(0);
            otherTasksOfManagerLabel.Name = "otherTasksOfManagerLabel";
            otherTasksOfManagerLabel.Size = new Size(235, 28);
            otherTasksOfManagerLabel.TabIndex = 0;
            otherTasksOfManagerLabel.Text = "Other tasks of manager";
            // 
            // otherTasksOfManagerFlowLayoutLabel
            // 
            otherTasksOfManagerFlowLayoutLabel.AutoScroll = true;
            otherTasksOfManagerFlowLayoutLabel.FlowDirection = FlowDirection.TopDown;
            otherTasksOfManagerFlowLayoutLabel.Location = new Point(553, 265);
            otherTasksOfManagerFlowLayoutLabel.Margin = new Padding(24, 8, 16, 8);
            otherTasksOfManagerFlowLayoutLabel.Name = "otherTasksOfManagerFlowLayoutLabel";
            otherTasksOfManagerFlowLayoutLabel.Size = new Size(495, 399);
            otherTasksOfManagerFlowLayoutLabel.TabIndex = 0;
            // 
            // TaskDetailControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            Controls.Add(projectIdLabel);
            Controls.Add(projectNameLabel);
            Controls.Add(tasksOfProjectLabel);
            Controls.Add(tasksOfProjectFlowLayoutPanel);
            Controls.Add(taskManagerLabel);
            Controls.Add(taskManagerCard);
            Controls.Add(otherTasksOfManagerLabel);
            Controls.Add(otherTasksOfManagerFlowLayoutLabel);
            HeaderText = "Task Detail";
            Name = "TaskDetailControl";
            Load += TaskDetailControl_Load;
            Controls.SetChildIndex(otherTasksOfManagerFlowLayoutLabel, 0);
            Controls.SetChildIndex(otherTasksOfManagerLabel, 0);
            Controls.SetChildIndex(taskManagerCard, 0);
            Controls.SetChildIndex(taskManagerLabel, 0);
            Controls.SetChildIndex(tasksOfProjectFlowLayoutPanel, 0);
            Controls.SetChildIndex(tasksOfProjectLabel, 0);
            Controls.SetChildIndex(projectNameLabel, 0);
            Controls.SetChildIndex(projectIdLabel, 0);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label projectIdLabel;
        private Label projectNameLabel;
        private Label tasksOfProjectLabel;
        private Label taskManagerLabel;
        private FlowLayoutPanel tasksOfProjectFlowLayoutPanel;
        private EmployeeCardControl taskManagerCard;
        private FlowLayoutPanel otherTasksOfManagerFlowLayoutLabel;
        private Label otherTasksOfManagerLabel;
    }
}