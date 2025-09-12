namespace Pepro.Presentation.Controls.Molecules {
    partial class ComboBoxField {
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
            inputFieldComboBox = new ComboBox();
            SuspendLayout();
            // 
            // inputFieldComboBox
            // 
            inputFieldComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputFieldComboBox.Cursor = Cursors.Hand;
            inputFieldComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            inputFieldComboBox.FlatStyle = FlatStyle.Flat;
            inputFieldComboBox.FormattingEnabled = true;
            inputFieldComboBox.Location = new Point(0, 21);
            inputFieldComboBox.Margin = new Padding(0);
            inputFieldComboBox.Name = "inputFieldComboBox";
            inputFieldComboBox.Size = new Size(240, 27);
            inputFieldComboBox.TabIndex = 1;
            inputFieldComboBox.SelectedIndexChanged += InputFieldComboBox_SelectedIndexChanged;
            // 
            // PeproComboBoxField
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(inputFieldComboBox);
            Name = "PeproComboBoxField";
            Size = new Size(240, 48);
            Controls.SetChildIndex(inputFieldComboBox, 0);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox inputFieldComboBox;
    }
}
