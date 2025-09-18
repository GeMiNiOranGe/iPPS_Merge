using Pepro.Presentation.Controls.Organisms;

namespace Pepro.Presentation.Controls.Pages;

partial class ProgressPage
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        projectProgressList = new ProjectProgressList();
        SuspendLayout();
        // 
        // projectProgressList
        // 
        projectProgressList.Dock = DockStyle.Fill;
        projectProgressList.Location = new Point(0, 48);
        projectProgressList.Name = "projectProgressList";
        projectProgressList.Size = new Size(1064, 633);
        projectProgressList.TabIndex = 0;
        projectProgressList.OnItemClick += ProjectsFlowLayoutPanel_OnItemClick;
        // 
        // ProgressPage
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(15, 15, 15);
        Controls.Add(projectProgressList);
        HeaderText = "Progress";
        Name = "ProgressPage";
        ReturnButtonVisible = false;
        Load += ProgressPage_Load;
        Controls.SetChildIndex(projectProgressList, 0);
        ResumeLayout(false);

    }

    #endregion

    private ProjectProgressList projectProgressList;
}
