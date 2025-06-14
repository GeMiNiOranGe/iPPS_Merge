
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
            lbJobId = new Label();
            lbJobName = new Label();
            lbJobPercent = new Label();
            SuspendLayout();
            // 
            // lbJobId
            // 
            lbJobId.AutoSize = true;
            lbJobId.ForeColor = Color.White;
            lbJobId.Location = new Point(8, 8);
            lbJobId.Margin = new Padding(8, 8, 8, 5);
            lbJobId.Name = "lbJobId";
            lbJobId.Size = new Size(97, 20);
            lbJobId.TabIndex = 0;
            lbJobId.Text = "Mã công việc";
            lbJobId.Click += UCJobItem_Click;
            lbJobId.MouseEnter += UCJobItem_MouseEnter;
            lbJobId.MouseLeave += UCJobItem_MouseLeave;
            // 
            // lbJobName
            // 
            lbJobName.AutoSize = true;
            lbJobName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbJobName.ForeColor = Color.White;
            lbJobName.Location = new Point(7, 33);
            lbJobName.Margin = new Padding(4, 0, 4, 0);
            lbJobName.Name = "lbJobName";
            lbJobName.Size = new Size(146, 30);
            lbJobName.TabIndex = 1;
            lbJobName.Text = "Tên công việc";
            lbJobName.Click += UCJobItem_Click;
            lbJobName.MouseEnter += UCJobItem_MouseEnter;
            lbJobName.MouseLeave += UCJobItem_MouseLeave;
            // 
            // lbJobPercent
            // 
            lbJobPercent.Dock = DockStyle.Right;
            lbJobPercent.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbJobPercent.ForeColor = Color.FromArgb(34, 130, 253);
            lbJobPercent.Location = new Point(415, 0);
            lbJobPercent.Margin = new Padding(4, 0, 4, 0);
            lbJobPercent.Name = "lbJobPercent";
            lbJobPercent.Size = new Size(85, 85);
            lbJobPercent.TabIndex = 2;
            lbJobPercent.Text = "100%";
            lbJobPercent.TextAlign = ContentAlignment.MiddleCenter;
            lbJobPercent.Click += UCJobItem_Click;
            lbJobPercent.MouseEnter += UCJobItem_MouseEnter;
            lbJobPercent.MouseLeave += UCJobItem_MouseLeave;
            // 
            // UCJobItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 29);
            Controls.Add(lbJobPercent);
            Controls.Add(lbJobName);
            Controls.Add(lbJobId);
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

        private Label lbJobId;
        private Label lbJobName;
        private Label lbJobPercent;
    }
}
