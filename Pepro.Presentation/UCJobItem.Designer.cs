
namespace Pepro.Presentation
{
    partial class UCJobItem
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
            taskIdLabel.AutoSize = true;
            taskIdLabel.ForeColor = Color.White;
            taskIdLabel.Location = new Point(8, 8);
            taskIdLabel.Margin = new Padding(8, 8, 8, 5);
            taskIdLabel.Name = "taskIdLabel";
            taskIdLabel.Size = new Size(97, 20);
            taskIdLabel.TabIndex = 0;
            taskIdLabel.Text = "Mã công việc";
            taskIdLabel.Click += UCJobItem_Click;
            taskIdLabel.MouseEnter += UCJobItem_MouseEnter;
            taskIdLabel.MouseLeave += UCJobItem_MouseLeave;
            // 
            // taskNameLabel
            // 
            taskNameLabel.AutoSize = true;
            taskNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            taskNameLabel.ForeColor = Color.White;
            taskNameLabel.Location = new Point(7, 33);
            taskNameLabel.Margin = new Padding(4, 0, 4, 0);
            taskNameLabel.Name = "taskNameLabel";
            taskNameLabel.Size = new Size(146, 30);
            taskNameLabel.TabIndex = 1;
            taskNameLabel.Text = "Tên công việc";
            taskNameLabel.Click += UCJobItem_Click;
            taskNameLabel.MouseEnter += UCJobItem_MouseEnter;
            taskNameLabel.MouseLeave += UCJobItem_MouseLeave;
            // 
            // taskPercentLabel
            // 
            taskPercentLabel.Dock = DockStyle.Right;
            taskPercentLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskPercentLabel.ForeColor = Color.FromArgb(34, 130, 253);
            taskPercentLabel.Location = new Point(415, 0);
            taskPercentLabel.Margin = new Padding(4, 0, 4, 0);
            taskPercentLabel.Name = "taskPercentLabel";
            taskPercentLabel.Size = new Size(85, 85);
            taskPercentLabel.TabIndex = 2;
            taskPercentLabel.Text = "100%";
            taskPercentLabel.TextAlign = ContentAlignment.MiddleCenter;
            taskPercentLabel.Click += UCJobItem_Click;
            taskPercentLabel.MouseEnter += UCJobItem_MouseEnter;
            taskPercentLabel.MouseLeave += UCJobItem_MouseLeave;
            // 
            // UCJobItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 29);
            Controls.Add(taskPercentLabel);
            Controls.Add(taskNameLabel);
            Controls.Add(taskIdLabel);
            Font = new Font("Segoe UI", 11.25F);
            Margin = new Padding(0, 0, 0, 8);
            Name = "UCJobItem";
            Size = new Size(500, 85);
            Click += UCJobItem_Click;
            MouseEnter += UCJobItem_MouseEnter;
            MouseLeave += UCJobItem_MouseLeave;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label taskIdLabel;
        private Label taskNameLabel;
        private Label taskPercentLabel;
    }
}
