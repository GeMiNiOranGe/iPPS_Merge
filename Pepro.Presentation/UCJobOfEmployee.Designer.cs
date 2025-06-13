
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
            lbProjectId = new Label();
            lbJobId = new Label();
            lbJobName = new Label();
            lbJobPercent = new Label();
            SuspendLayout();
            // 
            // lbProjectId
            // 
            lbProjectId.AutoSize = true;
            lbProjectId.ForeColor = Color.White;
            lbProjectId.Location = new Point(207, 8);
            lbProjectId.Margin = new Padding(8, 8, 8, 5);
            lbProjectId.Name = "lbProjectId";
            lbProjectId.Size = new Size(72, 20);
            lbProjectId.TabIndex = 0;
            lbProjectId.Text = "Mã dự án";
            // 
            // lbJobId
            // 
            lbJobId.AutoSize = true;
            lbJobId.ForeColor = Color.FromArgb(246, 58, 156);
            lbJobId.Location = new Point(9, 37);
            lbJobId.Margin = new Padding(8, 8, 8, 5);
            lbJobId.Name = "lbJobId";
            lbJobId.Size = new Size(97, 20);
            lbJobId.TabIndex = 1;
            lbJobId.Text = "Mã công việc";
            // 
            // lbJobName
            // 
            lbJobName.AutoSize = true;
            lbJobName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbJobName.ForeColor = Color.White;
            lbJobName.Location = new Point(8, 62);
            lbJobName.Margin = new Padding(8, 0, 8, 8);
            lbJobName.Name = "lbJobName";
            lbJobName.Size = new Size(146, 30);
            lbJobName.TabIndex = 2;
            lbJobName.Text = "Tên công việc";
            // 
            // lbJobPercent
            // 
            lbJobPercent.Dock = DockStyle.Right;
            lbJobPercent.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbJobPercent.ForeColor = Color.FromArgb(34, 130, 253);
            lbJobPercent.Location = new Point(381, 0);
            lbJobPercent.Margin = new Padding(4, 0, 4, 0);
            lbJobPercent.Name = "lbJobPercent";
            lbJobPercent.Size = new Size(100, 100);
            lbJobPercent.TabIndex = 3;
            lbJobPercent.Text = "100%";
            lbJobPercent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UCJobOfEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 29);
            Controls.Add(lbJobPercent);
            Controls.Add(lbJobName);
            Controls.Add(lbJobId);
            Controls.Add(lbProjectId);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UCJobOfEmployee";
            Size = new Size(481, 100);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbProjectId;
        private System.Windows.Forms.Label lbJobId;
        private System.Windows.Forms.Label lbJobName;
        private System.Windows.Forms.Label lbJobPercent;
    }
}
