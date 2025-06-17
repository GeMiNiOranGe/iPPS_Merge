
namespace Pepro.Presentation.Controls
{
    partial class ProjectItemControl
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
            percentLabel = new Label();
            projectNameLabel = new Label();
            projectIdLabel = new Label();
            departmentNameLabel = new Label();
            SuspendLayout();
            // 
            // percentLabel
            // 
            percentLabel.BackColor = Color.Transparent;
            percentLabel.Dock = DockStyle.Fill;
            percentLabel.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point, 0);
            percentLabel.ForeColor = Color.FromArgb(34, 130, 253);
            percentLabel.Location = new Point(0, 40);
            percentLabel.Margin = new Padding(4, 0, 4, 0);
            percentLabel.Name = "percentLabel";
            percentLabel.Size = new Size(200, 130);
            percentLabel.TabIndex = 0;
            percentLabel.Text = "0%";
            percentLabel.TextAlign = ContentAlignment.MiddleCenter;
            percentLabel.Click += UCProject_Click;
            percentLabel.MouseEnter += UCProject_MouseEnter;
            percentLabel.MouseLeave += UCProject_MouseLeave;
            // 
            // projectNameLabel
            // 
            projectNameLabel.BackColor = Color.Transparent;
            projectNameLabel.Dock = DockStyle.Bottom;
            projectNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            projectNameLabel.ForeColor = Color.White;
            projectNameLabel.Location = new Point(0, 170);
            projectNameLabel.Margin = new Padding(4, 0, 4, 0);
            projectNameLabel.Name = "projectNameLabel";
            projectNameLabel.Size = new Size(200, 40);
            projectNameLabel.TabIndex = 1;
            projectNameLabel.Text = "Tên dự án";
            projectNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            projectNameLabel.Click += UCProject_Click;
            projectNameLabel.MouseEnter += UCProject_MouseEnter;
            projectNameLabel.MouseLeave += UCProject_MouseLeave;
            // 
            // projectIdLabel
            // 
            projectIdLabel.BackColor = Color.Transparent;
            projectIdLabel.Dock = DockStyle.Top;
            projectIdLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            projectIdLabel.ForeColor = Color.White;
            projectIdLabel.Location = new Point(0, 0);
            projectIdLabel.Margin = new Padding(4, 0, 4, 0);
            projectIdLabel.Name = "projectIdLabel";
            projectIdLabel.Size = new Size(200, 40);
            projectIdLabel.TabIndex = 2;
            projectIdLabel.Text = "Mã dự án";
            projectIdLabel.TextAlign = ContentAlignment.MiddleCenter;
            projectIdLabel.Click += UCProject_Click;
            projectIdLabel.MouseEnter += UCProject_MouseEnter;
            projectIdLabel.MouseLeave += UCProject_MouseLeave;
            // 
            // departmentNameLabel
            // 
            departmentNameLabel.BackColor = Color.Transparent;
            departmentNameLabel.Dock = DockStyle.Bottom;
            departmentNameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            departmentNameLabel.ForeColor = Color.White;
            departmentNameLabel.Location = new Point(0, 210);
            departmentNameLabel.Margin = new Padding(4, 0, 4, 0);
            departmentNameLabel.Name = "departmentNameLabel";
            departmentNameLabel.Size = new Size(200, 40);
            departmentNameLabel.TabIndex = 3;
            departmentNameLabel.Text = "Tên phòng ban";
            departmentNameLabel.TextAlign = ContentAlignment.TopCenter;
            departmentNameLabel.Click += UCProject_Click;
            departmentNameLabel.MouseEnter += UCProject_MouseEnter;
            departmentNameLabel.MouseLeave += UCProject_MouseLeave;
            // 
            // UCProjectItem
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 29);
            Controls.Add(percentLabel);
            Controls.Add(projectNameLabel);
            Controls.Add(departmentNameLabel);
            Controls.Add(projectIdLabel);
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

        private Label percentLabel;
        private Label projectNameLabel;
        private Label projectIdLabel;
        private Label departmentNameLabel;
    }
}
