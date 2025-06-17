
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
            lblIdProject = new Label();
            lblNameProject = new Label();
            lblListWorkOfProject = new Label();
            lbManagerOfJob = new Label();
            flPnlListJob = new FlowLayoutPanel();
            pnlManager = new Panel();
            flPnlJobOfEmployee = new FlowLayoutPanel();
            lbOtherJobOfManager = new Label();
            SuspendLayout();
            // 
            // lblIdProject
            // 
            lblIdProject.AutoSize = true;
            lblIdProject.ForeColor = Color.White;
            lblIdProject.Location = new Point(12, 9);
            lblIdProject.Name = "lblIdProject";
            lblIdProject.Size = new Size(72, 20);
            lblIdProject.TabIndex = 0;
            lblIdProject.Text = "Mã dự án";
            // 
            // lblNameProject
            // 
            lblNameProject.AutoSize = true;
            lblNameProject.ForeColor = Color.White;
            lblNameProject.Location = new Point(12, 39);
            lblNameProject.Name = "lblNameProject";
            lblNameProject.Size = new Size(74, 20);
            lblNameProject.TabIndex = 1;
            lblNameProject.Text = "Tên dự án";
            // 
            // lblListWorkOfProject
            // 
            lblListWorkOfProject.AutoSize = true;
            lblListWorkOfProject.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListWorkOfProject.ForeColor = Color.White;
            lblListWorkOfProject.Location = new Point(12, 89);
            lblListWorkOfProject.Margin = new Padding(6, 0, 6, 0);
            lblListWorkOfProject.Name = "lblListWorkOfProject";
            lblListWorkOfProject.Size = new Size(304, 25);
            lblListWorkOfProject.TabIndex = 2;
            lblListWorkOfProject.Text = "Danh sách công việc trong dự án";
            // 
            // lbManagerOfJob
            // 
            lbManagerOfJob.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbManagerOfJob.AutoSize = true;
            lbManagerOfJob.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbManagerOfJob.ForeColor = Color.White;
            lbManagerOfJob.Location = new Point(693, 89);
            lbManagerOfJob.Margin = new Padding(6, 0, 6, 0);
            lbManagerOfJob.Name = "lbManagerOfJob";
            lbManagerOfJob.Size = new Size(263, 25);
            lbManagerOfJob.TabIndex = 3;
            lbManagerOfJob.Text = "Nhân viên phụ trách quản lý";
            // 
            // flPnlListJob
            // 
            flPnlListJob.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flPnlListJob.AutoScroll = true;
            flPnlListJob.Location = new Point(15, 126);
            flPnlListJob.Margin = new Padding(6);
            flPnlListJob.Name = "flPnlListJob";
            flPnlListJob.Size = new Size(643, 540);
            flPnlListJob.TabIndex = 4;
            // 
            // pnlManager
            // 
            pnlManager.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlManager.Location = new Point(698, 126);
            pnlManager.Margin = new Padding(6);
            pnlManager.Name = "pnlManager";
            pnlManager.Size = new Size(551, 150);
            pnlManager.TabIndex = 5;
            // 
            // flPnlJobOfEmployee
            // 
            flPnlJobOfEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flPnlJobOfEmployee.AutoScroll = true;
            flPnlJobOfEmployee.Location = new Point(698, 341);
            flPnlJobOfEmployee.Margin = new Padding(6);
            flPnlJobOfEmployee.Name = "flPnlJobOfEmployee";
            flPnlJobOfEmployee.Size = new Size(551, 325);
            flPnlJobOfEmployee.TabIndex = 5;
            // 
            // lbOtherJobOfManager
            // 
            lbOtherJobOfManager.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbOtherJobOfManager.AutoSize = true;
            lbOtherJobOfManager.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbOtherJobOfManager.ForeColor = Color.White;
            lbOtherJobOfManager.Location = new Point(693, 310);
            lbOtherJobOfManager.Margin = new Padding(6, 0, 6, 0);
            lbOtherJobOfManager.Name = "lbOtherJobOfManager";
            lbOtherJobOfManager.Size = new Size(463, 25);
            lbOtherJobOfManager.TabIndex = 7;
            lbOtherJobOfManager.Text = "Những công việc đang tham gia của người quản lý";
            // 
            // FormJobDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(1264, 681);
            Controls.Add(lbOtherJobOfManager);
            Controls.Add(flPnlJobOfEmployee);
            Controls.Add(pnlManager);
            Controls.Add(flPnlListJob);
            Controls.Add(lbManagerOfJob);
            Controls.Add(lblListWorkOfProject);
            Controls.Add(lblNameProject);
            Controls.Add(lblIdProject);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "FormJobDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết công việc";
            Load += FormWorkOfProject_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label lblIdProject;
        private Label lblNameProject;
        private Label lblListWorkOfProject;
        private Label lbManagerOfJob;
        private FlowLayoutPanel flPnlListJob;
        private Panel pnlManager;
        private FlowLayoutPanel flPnlJobOfEmployee;
        private Label lbOtherJobOfManager;
    }
}