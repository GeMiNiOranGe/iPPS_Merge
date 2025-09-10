using Pepro.Presentation.Controls.Molecules;

namespace Pepro.Presentation.Controls.Pages
{
    partial class AssignmentDetailControl
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
            assignmentsOfProjectLabel = new Label();
            assignmentsOfProjectFlowLayoutPanel = new FlowLayoutPanel();
            assignmentManagerLabel = new Label();
            assignmentManagerCard = new EmployeeCardControl();
            otherAssignmentsOfManagerLabel = new Label();
            otherAssignmentsOfManagerFlowLayoutLabel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // projectIdLabel
            // 
            projectIdLabel.AutoSize = true;
            projectIdLabel.ForeColor = Color.White;
            projectIdLabel.Location = new Point(13, 59);
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
            projectNameLabel.Location = new Point(13, 82);
            projectNameLabel.Margin = new Padding(8, 0, 0, 4);
            projectNameLabel.Name = "projectNameLabel";
            projectNameLabel.Size = new Size(89, 19);
            projectNameLabel.TabIndex = 0;
            projectNameLabel.Text = "Project name";
            // 
            // assignmentsOfProjectLabel
            // 
            assignmentsOfProjectLabel.AutoSize = true;
            assignmentsOfProjectLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            assignmentsOfProjectLabel.ForeColor = Color.White;
            assignmentsOfProjectLabel.Location = new Point(13, 108);
            assignmentsOfProjectLabel.Margin = new Padding(0);
            assignmentsOfProjectLabel.Name = "assignmentsOfProjectLabel";
            assignmentsOfProjectLabel.Size = new Size(231, 28);
            assignmentsOfProjectLabel.TabIndex = 0;
            assignmentsOfProjectLabel.Text = "Assignments of project";
            // 
            // assignmentsOfProjectFlowLayoutPanel
            // 
            assignmentsOfProjectFlowLayoutPanel.AutoScroll = true;
            assignmentsOfProjectFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            assignmentsOfProjectFlowLayoutPanel.Location = new Point(17, 144);
            assignmentsOfProjectFlowLayoutPanel.Margin = new Padding(8);
            assignmentsOfProjectFlowLayoutPanel.Name = "assignmentsOfProjectFlowLayoutPanel";
            assignmentsOfProjectFlowLayoutPanel.Size = new Size(504, 520);
            assignmentsOfProjectFlowLayoutPanel.TabIndex = 0;
            // 
            // assignmentManagerLabel
            // 
            assignmentManagerLabel.AutoSize = true;
            assignmentManagerLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            assignmentManagerLabel.ForeColor = Color.White;
            assignmentManagerLabel.Location = new Point(549, 108);
            assignmentManagerLabel.Margin = new Padding(0);
            assignmentManagerLabel.Name = "assignmentManagerLabel";
            assignmentManagerLabel.Size = new Size(212, 28);
            assignmentManagerLabel.TabIndex = 0;
            assignmentManagerLabel.Text = "Assignment manager";
            // 
            // assignmentManagerCard
            // 
            assignmentManagerCard.BackColor = Color.FromArgb(29, 29, 29);
            assignmentManagerCard.ForeColor = Color.White;
            assignmentManagerCard.Location = new Point(553, 144);
            assignmentManagerCard.Margin = new Padding(0, 0, 0, 24);
            assignmentManagerCard.Name = "assignmentManagerCard";
            assignmentManagerCard.Size = new Size(495, 61);
            assignmentManagerCard.TabIndex = 0;
            // 
            // otherAssignmentsOfManagerLabel
            // 
            otherAssignmentsOfManagerLabel.AutoSize = true;
            otherAssignmentsOfManagerLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            otherAssignmentsOfManagerLabel.ForeColor = Color.White;
            otherAssignmentsOfManagerLabel.Location = new Point(549, 229);
            otherAssignmentsOfManagerLabel.Margin = new Padding(0);
            otherAssignmentsOfManagerLabel.Name = "otherAssignmentsOfManagerLabel";
            otherAssignmentsOfManagerLabel.Size = new Size(304, 28);
            otherAssignmentsOfManagerLabel.TabIndex = 0;
            otherAssignmentsOfManagerLabel.Text = "Other assignments of manager";
            // 
            // otherAssignmentsOfManagerFlowLayoutLabel
            // 
            otherAssignmentsOfManagerFlowLayoutLabel.AutoScroll = true;
            otherAssignmentsOfManagerFlowLayoutLabel.FlowDirection = FlowDirection.TopDown;
            otherAssignmentsOfManagerFlowLayoutLabel.Location = new Point(553, 265);
            otherAssignmentsOfManagerFlowLayoutLabel.Margin = new Padding(24, 8, 16, 8);
            otherAssignmentsOfManagerFlowLayoutLabel.Name = "otherAssignmentsOfManagerFlowLayoutLabel";
            otherAssignmentsOfManagerFlowLayoutLabel.Size = new Size(495, 399);
            otherAssignmentsOfManagerFlowLayoutLabel.TabIndex = 0;
            // 
            // AssignmentDetailControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            Controls.Add(projectIdLabel);
            Controls.Add(projectNameLabel);
            Controls.Add(assignmentsOfProjectLabel);
            Controls.Add(assignmentsOfProjectFlowLayoutPanel);
            Controls.Add(assignmentManagerLabel);
            Controls.Add(assignmentManagerCard);
            Controls.Add(otherAssignmentsOfManagerLabel);
            Controls.Add(otherAssignmentsOfManagerFlowLayoutLabel);
            HeaderText = "Assignment Detail";
            Name = "AssignmentDetailControl";
            Load += AssignmentDetailControl_Load;
            Controls.SetChildIndex(otherAssignmentsOfManagerFlowLayoutLabel, 0);
            Controls.SetChildIndex(otherAssignmentsOfManagerLabel, 0);
            Controls.SetChildIndex(assignmentManagerCard, 0);
            Controls.SetChildIndex(assignmentManagerLabel, 0);
            Controls.SetChildIndex(assignmentsOfProjectFlowLayoutPanel, 0);
            Controls.SetChildIndex(assignmentsOfProjectLabel, 0);
            Controls.SetChildIndex(projectNameLabel, 0);
            Controls.SetChildIndex(projectIdLabel, 0);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label projectIdLabel;
        private Label projectNameLabel;
        private Label assignmentsOfProjectLabel;
        private Label assignmentManagerLabel;
        private FlowLayoutPanel assignmentsOfProjectFlowLayoutPanel;
        private EmployeeCardControl assignmentManagerCard;
        private FlowLayoutPanel otherAssignmentsOfManagerFlowLayoutLabel;
        private Label otherAssignmentsOfManagerLabel;
    }
}