namespace Pepro.Presentation.Controls.Molecules {
    partial class TextBoxField {
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
            inputFieldTextBox = new TextBox();
            inputFieldPanel = new Panel();
            SuspendLayout();
            // 
            // inputFieldTextBox
            // 
            inputFieldTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputFieldTextBox.BorderStyle = BorderStyle.None;
            inputFieldTextBox.Cursor = Cursors.IBeam;
            inputFieldTextBox.Location = new Point(0, 22);
            inputFieldTextBox.Margin = new Padding(0);
            inputFieldTextBox.Name = "inputFieldTextBox";
            inputFieldTextBox.Size = new Size(240, 19);
            inputFieldTextBox.TabIndex = 1;
            inputFieldTextBox.TextChanged += InputFieldTextBox_TextChanged;
            // 
            // inputFieldPanel
            // 
            inputFieldPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputFieldPanel.BackColor = SystemColors.ControlText;
            inputFieldPanel.Location = new Point(0, 46);
            inputFieldPanel.Margin = new Padding(0);
            inputFieldPanel.Name = "inputFieldPanel";
            inputFieldPanel.Size = new Size(240, 2);
            inputFieldPanel.TabIndex = 0;
            // 
            // PeproInputField
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(inputFieldPanel);
            Controls.Add(inputFieldTextBox);
            Name = "PeproInputField";
            Size = new Size(240, 48);
            Controls.SetChildIndex(inputFieldTextBox, 0);
            Controls.SetChildIndex(inputFieldPanel, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputFieldTextBox;
        private Panel inputFieldPanel;
    }
}
