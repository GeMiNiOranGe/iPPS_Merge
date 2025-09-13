namespace Pepro.Presentation.Controls.Molecules;

partial class AssignmentProgressCard
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
    private void InitializeComponent()
    {
        assignmentIdLabel = new Label();
        assignmentNameLabel = new Label();
        assignmentPercentLabel = new Label();
        SuspendLayout();
        // 
        // assignmentIdLabel
        // 
        assignmentIdLabel.Dock = DockStyle.Fill;
        assignmentIdLabel.Location = new Point(108, 0);
        assignmentIdLabel.Name = "assignmentIdLabel";
        assignmentIdLabel.Size = new Size(404, 32);
        assignmentIdLabel.TabIndex = 0;
        assignmentIdLabel.Text = "Assignment id";
        assignmentIdLabel.TextAlign = ContentAlignment.BottomLeft;
        assignmentIdLabel.Click += AssignmentProgressCardControl_Click;
        assignmentIdLabel.MouseDown += AssignmentProgressCardControl_MouseDown;
        assignmentIdLabel.MouseEnter += AssignmentProgressCardControl_MouseEnter;
        assignmentIdLabel.MouseLeave += AssignmentProgressCardControl_MouseLeave;
        assignmentIdLabel.MouseUp += AssignmentProgressCardControl_MouseUp;
        // 
        // assignmentNameLabel
        // 
        assignmentNameLabel.Dock = DockStyle.Bottom;
        assignmentNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
        assignmentNameLabel.Location = new Point(108, 32);
        assignmentNameLabel.Name = "assignmentNameLabel";
        assignmentNameLabel.Size = new Size(404, 32);
        assignmentNameLabel.TabIndex = 0;
        assignmentNameLabel.Text = "Assignment name";
        assignmentNameLabel.Click += AssignmentProgressCardControl_Click;
        assignmentNameLabel.MouseDown += AssignmentProgressCardControl_MouseDown;
        assignmentNameLabel.MouseEnter += AssignmentProgressCardControl_MouseEnter;
        assignmentNameLabel.MouseLeave += AssignmentProgressCardControl_MouseLeave;
        assignmentNameLabel.MouseUp += AssignmentProgressCardControl_MouseUp;
        // 
        // assignmentPercentLabel
        // 
        assignmentPercentLabel.Dock = DockStyle.Left;
        assignmentPercentLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
        assignmentPercentLabel.Location = new Point(0, 0);
        assignmentPercentLabel.Name = "assignmentPercentLabel";
        assignmentPercentLabel.Size = new Size(108, 64);
        assignmentPercentLabel.TabIndex = 0;
        assignmentPercentLabel.Text = "0%";
        assignmentPercentLabel.TextAlign = ContentAlignment.MiddleCenter;
        assignmentPercentLabel.Click += AssignmentProgressCardControl_Click;
        assignmentPercentLabel.MouseDown += AssignmentProgressCardControl_MouseDown;
        assignmentPercentLabel.MouseEnter += AssignmentProgressCardControl_MouseEnter;
        assignmentPercentLabel.MouseLeave += AssignmentProgressCardControl_MouseLeave;
        assignmentPercentLabel.MouseUp += AssignmentProgressCardControl_MouseUp;
        // 
        // AssignmentProgressCardControl
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(assignmentIdLabel);
        Controls.Add(assignmentNameLabel);
        Controls.Add(assignmentPercentLabel);
        Margin = new Padding(0);
        Name = "AssignmentProgressCardControl";
        Size = new Size(512, 64);
        MouseDown += AssignmentProgressCardControl_MouseDown;
        MouseEnter += AssignmentProgressCardControl_MouseEnter;
        MouseLeave += AssignmentProgressCardControl_MouseLeave;
        MouseUp += AssignmentProgressCardControl_MouseUp;
        ResumeLayout(false);

    }

    #endregion

    private Label assignmentIdLabel;
    private Label assignmentNameLabel;
    private Label assignmentPercentLabel;
}
