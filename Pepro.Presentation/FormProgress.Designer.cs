
namespace Pepro.Presentation {
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
            flPnlProjectList = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flPnlProjectList
            // 
            flPnlProjectList.BackColor = Color.FromArgb(15, 15, 15);
            flPnlProjectList.Dock = DockStyle.Fill;
            flPnlProjectList.Location = new Point(0, 0);
            flPnlProjectList.Margin = new Padding(4, 3, 4, 3);
            flPnlProjectList.Name = "flPnlProjectList";
            flPnlProjectList.Padding = new Padding(14, 14, 14, 14);
            flPnlProjectList.Size = new Size(331, 301);
            flPnlProjectList.TabIndex = 0;
            // 
            // FormProgress
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 301);
            Controls.Add(flPnlProjectList);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormProgress";
            Load += FormProgress_Load;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flPnlProjectList;
    }
}

