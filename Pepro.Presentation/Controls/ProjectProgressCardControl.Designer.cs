
namespace Pepro.Presentation.Controls
{
    partial class ProjectProgressCardControl
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
            projectIdLabel = new Label();
            projectNameLabel = new Label();
            projectPercentLabel = new Label();
            SuspendLayout();
            // 
            // projectIdLabel
            // 
            projectIdLabel.Dock = DockStyle.Fill;
            projectIdLabel.Location = new Point(108, 0);
            projectIdLabel.Name = "projectIdLabel";
            projectIdLabel.Size = new Size(404, 32);
            projectIdLabel.TabIndex = 0;
            projectIdLabel.Text = "Project id";
            projectIdLabel.TextAlign = ContentAlignment.BottomLeft;
            projectIdLabel.Click += ProjectProgressCardControl_Click;
            projectIdLabel.MouseDown += ProjectProgressCardControl_MouseDown;
            projectIdLabel.MouseEnter += ProjectProgressCardControl_MouseEnter;
            projectIdLabel.MouseLeave += ProjectProgressCardControl_MouseLeave;
            // 
            // projectNameLabel
            // 
            projectNameLabel.Dock = DockStyle.Bottom;
            projectNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            projectNameLabel.Location = new Point(108, 32);
            projectNameLabel.Name = "projectNameLabel";
            projectNameLabel.Size = new Size(404, 32);
            projectNameLabel.TabIndex = 0;
            projectNameLabel.Text = "Project name";
            projectNameLabel.Click += ProjectProgressCardControl_Click;
            projectNameLabel.MouseDown += ProjectProgressCardControl_MouseDown;
            projectNameLabel.MouseEnter += ProjectProgressCardControl_MouseEnter;
            projectNameLabel.MouseLeave += ProjectProgressCardControl_MouseLeave;
            // 
            // projectPercentLabel
            // 
            projectPercentLabel.Dock = DockStyle.Left;
            projectPercentLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            projectPercentLabel.Location = new Point(0, 0);
            projectPercentLabel.Name = "projectPercentLabel";
            projectPercentLabel.Size = new Size(108, 64);
            projectPercentLabel.TabIndex = 0;
            projectPercentLabel.Text = "0%";
            projectPercentLabel.TextAlign = ContentAlignment.MiddleCenter;
            projectPercentLabel.Click += ProjectProgressCardControl_Click;
            projectPercentLabel.MouseDown += ProjectProgressCardControl_MouseDown;
            projectPercentLabel.MouseEnter += ProjectProgressCardControl_MouseEnter;
            projectPercentLabel.MouseLeave += ProjectProgressCardControl_MouseLeave;
            // 
            // ProjectProgressCardControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(projectIdLabel);
            Controls.Add(projectNameLabel);
            Controls.Add(projectPercentLabel);
            Cursor = Cursors.Hand;
            Margin = new Padding(0);
            Name = "ProjectProgressCardControl";
            Size = new Size(512, 64);
            MouseDown += ProjectProgressCardControl_MouseDown;
            MouseEnter += ProjectProgressCardControl_MouseEnter;
            MouseLeave += ProjectProgressCardControl_MouseLeave;
            ResumeLayout(false);

        }

        #endregion

        private Label projectPercentLabel;
        private Label projectNameLabel;
        private Label projectIdLabel;
    }
}
