namespace Pepro.Presentation.Controls.Molecules
{
    partial class EmployeeCardControl
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
            employeeIdLabel = new Label();
            employeeNameLabel = new Label();
            SuspendLayout();
            // 
            // employeeIdLabel
            // 
            employeeIdLabel.Dock = DockStyle.Fill;
            employeeIdLabel.Location = new Point(0, 0);
            employeeIdLabel.Margin = new Padding(8, 8, 8, 5);
            employeeIdLabel.Name = "employeeIdLabel";
            employeeIdLabel.Padding = new Padding(8, 0, 0, 0);
            employeeIdLabel.Size = new Size(512, 29);
            employeeIdLabel.TabIndex = 0;
            employeeIdLabel.Text = "Employee id";
            employeeIdLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // employeeNameLabel
            // 
            employeeNameLabel.Dock = DockStyle.Bottom;
            employeeNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            employeeNameLabel.Location = new Point(0, 29);
            employeeNameLabel.Margin = new Padding(4, 0, 4, 0);
            employeeNameLabel.Name = "employeeNameLabel";
            employeeNameLabel.Padding = new Padding(8, 0, 0, 0);
            employeeNameLabel.Size = new Size(512, 32);
            employeeNameLabel.TabIndex = 1;
            employeeNameLabel.Text = "Employee name";
            // 
            // EmployeeCardControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(employeeIdLabel);
            Controls.Add(employeeNameLabel);
            Margin = new Padding(0);
            Name = "EmployeeCardControl";
            Size = new Size(512, 61);
            ResumeLayout(false);

        }

        #endregion

        private Label employeeIdLabel;
        private Label employeeNameLabel;
    }
}
