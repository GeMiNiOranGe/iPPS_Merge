using Pepro.Presentation.Controls.Atoms;

namespace Pepro.Presentation.Base {
    partial class PeproInputFieldBase {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            inputFieldLabel = new PeproLabel();
            SuspendLayout();
            // 
            // inputFieldLabel
            // 
            inputFieldLabel.Dock = DockStyle.Top;
            inputFieldLabel.Location = new Point(0, 0);
            inputFieldLabel.Margin = new Padding(0, 0, 0, 8);
            inputFieldLabel.Name = "inputFieldLabel";
            inputFieldLabel.Size = new Size(240, 14);
            inputFieldLabel.TabIndex = 0;
            inputFieldLabel.Text = "inputFieldLabel";
            // 
            // PeproInputFieldBase
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(inputFieldLabel);
            Margin = new Padding(0);
            Name = "PeproInputFieldBase";
            Size = new Size(240, 128);
            ResumeLayout(false);
        }

        #endregion

        private PeproLabel inputFieldLabel;
    }
}
