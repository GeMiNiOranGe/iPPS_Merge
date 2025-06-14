
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
            lbManagerId = new Label();
            lbManagerName = new Label();
            SuspendLayout();
            // 
            // lbManagerId
            // 
            lbManagerId.AutoSize = true;
            lbManagerId.ForeColor = Color.White;
            lbManagerId.Location = new Point(8, 8);
            lbManagerId.Margin = new Padding(8, 8, 8, 5);
            lbManagerId.Name = "lbManagerId";
            lbManagerId.Size = new Size(125, 20);
            lbManagerId.TabIndex = 0;
            lbManagerId.Text = "Mã người quản lý";
            // 
            // lbManagerName
            // 
            lbManagerName.AutoSize = true;
            lbManagerName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbManagerName.ForeColor = Color.White;
            lbManagerName.Location = new Point(8, 33);
            lbManagerName.Margin = new Padding(4, 0, 4, 0);
            lbManagerName.Name = "lbManagerName";
            lbManagerName.Size = new Size(191, 30);
            lbManagerName.TabIndex = 1;
            lbManagerName.Text = "Tên người quản lý";
            // 
            // UCManagerItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 29);
            Controls.Add(lbManagerName);
            Controls.Add(lbManagerId);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UCManagerItem";
            Size = new Size(471, 85);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label lbManagerId;
        private Label lbManagerName;
    }
}
