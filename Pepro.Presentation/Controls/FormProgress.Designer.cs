
namespace Pepro.Presentation.Controls {
    partial class FormProgress {
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
            projectListFlowLayoutPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // projectListFlowLayoutPanel
            // 
            projectListFlowLayoutPanel.BackColor = Color.FromArgb(15, 15, 15);
            projectListFlowLayoutPanel.Dock = DockStyle.Fill;
            projectListFlowLayoutPanel.Location = new Point(0, 0);
            projectListFlowLayoutPanel.Margin = new Padding(4, 3, 4, 3);
            projectListFlowLayoutPanel.Name = "projectListFlowLayoutPanel";
            projectListFlowLayoutPanel.Padding = new Padding(14);
            projectListFlowLayoutPanel.Size = new Size(331, 301);
            projectListFlowLayoutPanel.TabIndex = 0;
            // 
            // FormProgress
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(projectListFlowLayoutPanel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormProgress";
            Size = new Size(331, 301);
            Load += FormProgress_Load;
            ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel projectListFlowLayoutPanel;
    }
}

