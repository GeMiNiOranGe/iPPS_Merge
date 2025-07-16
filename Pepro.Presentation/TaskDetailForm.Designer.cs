
namespace Pepro.Presentation
{
    partial class TaskDetailForm
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
            taskManagerPanel = new Panel();
            otherTasksOfManagerLabel = new Label();
            otherTasksOfManagerFlowLayoutLabel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // projectIdLabel
            // 
            projectIdLabel.AutoSize = true;
            projectIdLabel.ForeColor = Color.White;
            projectIdLabel.Location = new Point(13, 17);
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
            projectNameLabel.Location = new Point(13, 40);
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
            tasksOfProjectLabel.Location = new Point(12, 90);
            tasksOfProjectLabel.Margin = new Padding(0);
            tasksOfProjectLabel.Name = "tasksOfProjectLabel";
            tasksOfProjectLabel.Size = new Size(161, 28);
            tasksOfProjectLabel.TabIndex = 0;
            tasksOfProjectLabel.Text = "Tasks of project";
            // 
            // tasksOfProjectFlowLayoutPanel
            // 
            tasksOfProjectFlowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tasksOfProjectFlowLayoutPanel.AutoScroll = true;
            tasksOfProjectFlowLayoutPanel.Location = new Point(17, 126);
            tasksOfProjectFlowLayoutPanel.Margin = new Padding(8);
            tasksOfProjectFlowLayoutPanel.Name = "tasksOfProjectFlowLayoutPanel";
            tasksOfProjectFlowLayoutPanel.Size = new Size(640, 538);
            tasksOfProjectFlowLayoutPanel.TabIndex = 0;
            // 
            // taskManagerLabel
            // 
            taskManagerLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            taskManagerLabel.AutoSize = true;
            taskManagerLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            taskManagerLabel.ForeColor = Color.White;
            taskManagerLabel.Location = new Point(685, 90);
            taskManagerLabel.Margin = new Padding(0);
            taskManagerLabel.Name = "taskManagerLabel";
            taskManagerLabel.Size = new Size(142, 28);
            taskManagerLabel.TabIndex = 0;
            taskManagerLabel.Text = "Task manager";
            // 
            // taskManagerPanel
            // 
            taskManagerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            taskManagerPanel.Location = new Point(689, 126);
            taskManagerPanel.Margin = new Padding(24, 8, 8, 24);
            taskManagerPanel.Name = "taskManagerPanel";
            taskManagerPanel.Size = new Size(558, 155);
            taskManagerPanel.TabIndex = 0;
            // 
            // otherTasksOfManagerLabel
            // 
            otherTasksOfManagerLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            otherTasksOfManagerLabel.AutoSize = true;
            otherTasksOfManagerLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            otherTasksOfManagerLabel.ForeColor = Color.White;
            otherTasksOfManagerLabel.Location = new Point(685, 305);
            otherTasksOfManagerLabel.Margin = new Padding(0);
            otherTasksOfManagerLabel.Name = "otherTasksOfManagerLabel";
            otherTasksOfManagerLabel.Size = new Size(235, 28);
            otherTasksOfManagerLabel.TabIndex = 0;
            otherTasksOfManagerLabel.Text = "Other tasks of manager";
            // 
            // otherTasksOfManagerFlowLayoutLabel
            // 
            otherTasksOfManagerFlowLayoutLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            otherTasksOfManagerFlowLayoutLabel.AutoScroll = true;
            otherTasksOfManagerFlowLayoutLabel.Location = new Point(689, 341);
            otherTasksOfManagerFlowLayoutLabel.Margin = new Padding(24, 8, 8, 8);
            otherTasksOfManagerFlowLayoutLabel.Name = "otherTasksOfManagerFlowLayoutLabel";
            otherTasksOfManagerFlowLayoutLabel.Size = new Size(558, 323);
            otherTasksOfManagerFlowLayoutLabel.TabIndex = 0;
            // 
            // TaskDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1264, 681);
            Controls.Add(projectIdLabel);
            Controls.Add(projectNameLabel);
            Controls.Add(tasksOfProjectLabel);
            Controls.Add(tasksOfProjectFlowLayoutPanel);
            Controls.Add(taskManagerLabel);
            Controls.Add(taskManagerPanel);
            Controls.Add(otherTasksOfManagerLabel);
            Controls.Add(otherTasksOfManagerFlowLayoutLabel);
            MinimumSize = new Size(960, 540);
            Name = "TaskDetailForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task detail";
            Load += TaskDetailForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label projectIdLabel;
        private Label projectNameLabel;
        private Label tasksOfProjectLabel;
        private Label taskManagerLabel;
        private FlowLayoutPanel tasksOfProjectFlowLayoutPanel;
        private Panel taskManagerPanel;
        private FlowLayoutPanel otherTasksOfManagerFlowLayoutLabel;
        private Label otherTasksOfManagerLabel;
    }
}