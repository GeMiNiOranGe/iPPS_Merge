
namespace Pepro.Presentation
{
    partial class UCManagerItem
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
            managerIdLabel = new Label();
            managerNameLabel = new Label();
            SuspendLayout();
            // 
            // managerIdLabel
            // 
            managerIdLabel.AutoSize = true;
            managerIdLabel.ForeColor = Color.White;
            managerIdLabel.Location = new Point(8, 8);
            managerIdLabel.Margin = new Padding(8, 8, 8, 5);
            managerIdLabel.Name = "managerIdLabel";
            managerIdLabel.Size = new Size(125, 20);
            managerIdLabel.TabIndex = 0;
            managerIdLabel.Text = "Mã người quản lý";
            // 
            // managerNameLabel
            // 
            managerNameLabel.AutoSize = true;
            managerNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            managerNameLabel.ForeColor = Color.White;
            managerNameLabel.Location = new Point(8, 33);
            managerNameLabel.Margin = new Padding(4, 0, 4, 0);
            managerNameLabel.Name = "managerNameLabel";
            managerNameLabel.Size = new Size(191, 30);
            managerNameLabel.TabIndex = 1;
            managerNameLabel.Text = "Tên người quản lý";
            // 
            // UCManagerItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 29);
            Controls.Add(managerNameLabel);
            Controls.Add(managerIdLabel);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UCManagerItem";
            Size = new Size(471, 85);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label managerIdLabel;
        private Label managerNameLabel;
    }
}
