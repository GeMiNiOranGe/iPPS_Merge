namespace Pepro.Presentation.Controls {
    partial class PeproMediatedUserControl {
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
            headerLabel = new Label();
            headerReturnButton = new Button();
            headerPanel = new Panel();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.Dock = DockStyle.Fill;
            headerLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            headerLabel.Location = new Point(48, 0);
            headerLabel.Margin = new Padding(0);
            headerLabel.Name = "headerLabel";
            headerLabel.Padding = new Padding(16, 0, 0, 0);
            headerLabel.Size = new Size(1016, 48);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Header Text";
            headerLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // headerReturnButton
            // 
            headerReturnButton.Dock = DockStyle.Left;
            headerReturnButton.Location = new Point(0, 0);
            headerReturnButton.Name = "headerReturnButton";
            headerReturnButton.Size = new Size(48, 48);
            headerReturnButton.TabIndex = 1;
            headerReturnButton.UseVisualStyleBackColor = true;
            headerReturnButton.Click += HeaderReturnButton_Click;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(22, 22, 22);
            headerPanel.Controls.Add(headerLabel);
            headerPanel.Controls.Add(headerReturnButton);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1064, 48);
            headerPanel.TabIndex = 0;
            // 
            // PeproMediatedUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            Controls.Add(headerPanel);
            ForeColor = Color.White;
            Name = "PeproMediatedUserControl";
            Size = new Size(1064, 681);
            headerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label headerLabel;
        private Button headerReturnButton;
        private Panel headerPanel;
    }
}
