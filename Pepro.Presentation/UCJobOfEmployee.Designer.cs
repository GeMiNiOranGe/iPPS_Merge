
namespace Pepro.Presentation
{
    partial class UCJobOfEmployee
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
            taskIdLabel = new Label();
            taskNameLabel = new Label();
            taskPercentLabel = new Label();
            SuspendLayout();
            // 
            // projectIdLabel
            // 
            projectIdLabel.AutoSize = true;
            projectIdLabel.ForeColor = Color.White;
            projectIdLabel.Location = new Point(207, 8);
            projectIdLabel.Margin = new Padding(8, 8, 8, 5);
            projectIdLabel.Name = "projectIdLabel";
            projectIdLabel.Size = new Size(72, 20);
            projectIdLabel.TabIndex = 0;
            projectIdLabel.Text = "Mã dự án";
            // 
            // taskIdLabel
            // 
            taskIdLabel.AutoSize = true;
            taskIdLabel.ForeColor = Color.FromArgb(246, 58, 156);
            taskIdLabel.Location = new Point(9, 37);
            taskIdLabel.Margin = new Padding(8, 8, 8, 5);
            taskIdLabel.Name = "taskIdLabel";
            taskIdLabel.Size = new Size(97, 20);
            taskIdLabel.TabIndex = 1;
            taskIdLabel.Text = "Mã công việc";
            // 
            // taskNameLabel
            // 
            taskNameLabel.AutoSize = true;
            taskNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            taskNameLabel.ForeColor = Color.White;
            taskNameLabel.Location = new Point(8, 62);
            taskNameLabel.Margin = new Padding(8, 0, 8, 8);
            taskNameLabel.Name = "taskNameLabel";
            taskNameLabel.Size = new Size(146, 30);
            taskNameLabel.TabIndex = 2;
            taskNameLabel.Text = "Tên công việc";
            // 
            // taskPercentLabel
            // 
            taskPercentLabel.Dock = DockStyle.Right;
            taskPercentLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskPercentLabel.ForeColor = Color.FromArgb(34, 130, 253);
            taskPercentLabel.Location = new Point(381, 0);
            taskPercentLabel.Margin = new Padding(4, 0, 4, 0);
            taskPercentLabel.Name = "taskPercentLabel";
            taskPercentLabel.Size = new Size(100, 100);
            taskPercentLabel.TabIndex = 3;
            taskPercentLabel.Text = "100%";
            taskPercentLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UCJobOfEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 29);
            Controls.Add(taskPercentLabel);
            Controls.Add(taskNameLabel);
            Controls.Add(taskIdLabel);
            Controls.Add(projectIdLabel);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UCJobOfEmployee";
            Size = new Size(481, 100);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label projectIdLabel;
        private Label taskIdLabel;
        private Label taskNameLabel;
        private Label taskPercentLabel;
    }
}
