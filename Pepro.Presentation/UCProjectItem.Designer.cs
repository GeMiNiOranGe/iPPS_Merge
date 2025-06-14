
namespace Pepro.Presentation
{
    partial class UCProjectItem
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
            lbPercent = new Label();
            lbName = new Label();
            lbId = new Label();
            lbDepartmentName = new Label();
            SuspendLayout();
            // 
            // lbPercent
            // 
            lbPercent.BackColor = Color.Transparent;
            lbPercent.Dock = DockStyle.Fill;
            lbPercent.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPercent.ForeColor = Color.FromArgb(34, 130, 253);
            lbPercent.Location = new Point(0, 40);
            lbPercent.Margin = new Padding(4, 0, 4, 0);
            lbPercent.Name = "lbPercent";
            lbPercent.Size = new Size(200, 130);
            lbPercent.TabIndex = 0;
            lbPercent.Text = "0%";
            lbPercent.TextAlign = ContentAlignment.MiddleCenter;
            lbPercent.Click += UCProject_Click;
            lbPercent.MouseEnter += UCProject_MouseEnter;
            lbPercent.MouseLeave += UCProject_MouseLeave;
            // 
            // lbName
            // 
            lbName.BackColor = Color.Transparent;
            lbName.Dock = DockStyle.Bottom;
            lbName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.ForeColor = Color.White;
            lbName.Location = new Point(0, 170);
            lbName.Margin = new Padding(4, 0, 4, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(200, 40);
            lbName.TabIndex = 1;
            lbName.Text = "Tên dự án";
            lbName.TextAlign = ContentAlignment.MiddleCenter;
            lbName.Click += UCProject_Click;
            lbName.MouseEnter += UCProject_MouseEnter;
            lbName.MouseLeave += UCProject_MouseLeave;
            // 
            // lbId
            // 
            lbId.BackColor = Color.Transparent;
            lbId.Dock = DockStyle.Top;
            lbId.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbId.ForeColor = Color.White;
            lbId.Location = new Point(0, 0);
            lbId.Margin = new Padding(4, 0, 4, 0);
            lbId.Name = "lbId";
            lbId.Size = new Size(200, 40);
            lbId.TabIndex = 2;
            lbId.Text = "Mã dự án";
            lbId.TextAlign = ContentAlignment.MiddleCenter;
            lbId.Click += UCProject_Click;
            lbId.MouseEnter += UCProject_MouseEnter;
            lbId.MouseLeave += UCProject_MouseLeave;
            // 
            // lbDepartmentName
            // 
            lbDepartmentName.BackColor = Color.Transparent;
            lbDepartmentName.Dock = DockStyle.Bottom;
            lbDepartmentName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDepartmentName.ForeColor = Color.White;
            lbDepartmentName.Location = new Point(0, 210);
            lbDepartmentName.Margin = new Padding(4, 0, 4, 0);
            lbDepartmentName.Name = "lbDepartmentName";
            lbDepartmentName.Size = new Size(200, 40);
            lbDepartmentName.TabIndex = 3;
            lbDepartmentName.Text = "Tên phòng ban";
            lbDepartmentName.TextAlign = ContentAlignment.TopCenter;
            lbDepartmentName.Click += UCProject_Click;
            lbDepartmentName.MouseEnter += UCProject_MouseEnter;
            lbDepartmentName.MouseLeave += UCProject_MouseLeave;
            // 
            // UCProjectItem
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 29);
            Controls.Add(lbPercent);
            Controls.Add(lbName);
            Controls.Add(lbDepartmentName);
            Controls.Add(lbId);
            Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "UCProjectItem";
            Size = new Size(200, 250);
            Click += UCProject_Click;
            MouseEnter += UCProject_MouseEnter;
            MouseLeave += UCProject_MouseLeave;
            ResumeLayout(false);

        }

        #endregion

        private Label lbPercent;
        private Label lbName;
        private Label lbId;
        private Label lbDepartmentName;
    }
}
