namespace Pepro.Presentation.Controls
{
    partial class TaskProgressCardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            taskIdLabel = new Label();
            taskNameLabel = new Label();
            taskPercentLabel = new Label();
            SuspendLayout();
            // 
            // taskIdLabel
            // 
            taskIdLabel.Dock = DockStyle.Fill;
            taskIdLabel.Location = new Point(108, 0);
            taskIdLabel.Name = "taskIdLabel";
            taskIdLabel.Size = new Size(404, 32);
            taskIdLabel.TabIndex = 0;
            taskIdLabel.Text = "Task id";
            taskIdLabel.TextAlign = ContentAlignment.BottomLeft;
            taskIdLabel.Click += TaskProgressCardControl_Click;
            taskIdLabel.MouseDown += TaskProgressCardControl_MouseDown;
            taskIdLabel.MouseEnter += TaskProgressCardControl_MouseEnter;
            taskIdLabel.MouseLeave += TaskProgressCardControl_MouseLeave;
            taskIdLabel.MouseUp += TaskProgressCardControl_MouseUp;
            // 
            // taskNameLabel
            // 
            taskNameLabel.Dock = DockStyle.Bottom;
            taskNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            taskNameLabel.Location = new Point(108, 32);
            taskNameLabel.Name = "taskNameLabel";
            taskNameLabel.Size = new Size(404, 32);
            taskNameLabel.TabIndex = 0;
            taskNameLabel.Text = "Task name";
            taskNameLabel.Click += TaskProgressCardControl_Click;
            taskNameLabel.MouseDown += TaskProgressCardControl_MouseDown;
            taskNameLabel.MouseEnter += TaskProgressCardControl_MouseEnter;
            taskNameLabel.MouseLeave += TaskProgressCardControl_MouseLeave;
            taskNameLabel.MouseUp += TaskProgressCardControl_MouseUp;
            // 
            // taskPercentLabel
            // 
            taskPercentLabel.Dock = DockStyle.Left;
            taskPercentLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            taskPercentLabel.Location = new Point(0, 0);
            taskPercentLabel.Name = "taskPercentLabel";
            taskPercentLabel.Size = new Size(108, 64);
            taskPercentLabel.TabIndex = 0;
            taskPercentLabel.Text = "0%";
            taskPercentLabel.TextAlign = ContentAlignment.MiddleCenter;
            taskPercentLabel.Click += TaskProgressCardControl_Click;
            taskPercentLabel.MouseDown += TaskProgressCardControl_MouseDown;
            taskPercentLabel.MouseEnter += TaskProgressCardControl_MouseEnter;
            taskPercentLabel.MouseLeave += TaskProgressCardControl_MouseLeave;
            taskPercentLabel.MouseUp += TaskProgressCardControl_MouseUp;
            // 
            // TaskProgressCardControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(taskIdLabel);
            Controls.Add(taskNameLabel);
            Controls.Add(taskPercentLabel);
            Margin = new Padding(0);
            Name = "TaskProgressCardControl";
            Size = new Size(512, 64);
            MouseDown += TaskProgressCardControl_MouseDown;
            MouseEnter += TaskProgressCardControl_MouseEnter;
            MouseLeave += TaskProgressCardControl_MouseLeave;
            MouseUp += TaskProgressCardControl_MouseUp;
            ResumeLayout(false);

        }

        #endregion

        private Label taskIdLabel;
        private Label taskNameLabel;
        private Label taskPercentLabel;
    }
}
