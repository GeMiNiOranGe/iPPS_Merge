
namespace Pepro.Presentation.Controls {
    partial class ProgressControl {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            projectsFlowLayoutPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // projectsFlowLayoutPanel
            // 
            projectsFlowLayoutPanel.Dock = DockStyle.Fill;
            projectsFlowLayoutPanel.Location = new Point(0, 0);
            projectsFlowLayoutPanel.Name = "projectsFlowLayoutPanel";
            projectsFlowLayoutPanel.Padding = new Padding(16);
            projectsFlowLayoutPanel.Size = new Size(150, 150);
            projectsFlowLayoutPanel.TabIndex = 0;
            // 
            // ProgressControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            Controls.Add(projectsFlowLayoutPanel);
            Name = "ProgressControl";
            Load += ProgressControl_Load;
            ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel projectsFlowLayoutPanel;
    }
}

