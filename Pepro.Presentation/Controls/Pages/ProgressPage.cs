using Pepro.Business;
using Pepro.DTOs;
using Pepro.Presentation.Controls.Molecules;
using Pepro.Presentation.Controls.Templates;
using Pepro.Presentation.Enums;
using Pepro.Presentation.Payloads;

namespace Pepro.Presentation.Controls.Pages;

public partial class ProgressPage : MediatedTemplate
{
    public ProgressPage()
    {
        InitializeComponent();
    }

    private void ProgressPage_Load(object sender, EventArgs e)
    {
        ShowProjectsWithProgress();
    }

    private void ShowProjectsWithProgress()
    {
        if (projectsFlowLayoutPanel.Controls.Count > 0)
        {
            projectsFlowLayoutPanel.Controls.Clear();
        }

        List<ProjectProgressView> projectsProgress =
        [
            .. ProjectBusiness.Instance.GetProjectProgressViews()
        ];

        for (int i = 0; i < projectsProgress.Count; i++)
        {
            ProjectProgressView item = projectsProgress[i];

            ProjectProgressCard projectCard = new()
            {
                Item = item,
                Margin = i != projectsProgress.Count - 1 ? new Padding(0, 0, 0, 8) : new Padding(0),
                Width = projectsFlowLayoutPanel.ClientSize.Width - projectsFlowLayoutPanel.Padding.Horizontal,
                Cursor = Cursors.Hand,
                ForeColor = ThemeColors.Text,
                BackColor = Color.FromArgb(29, 29, 29),
                MouseOverBackColor = ThemeColors.Accent.Base,
                MouseDownBackColor = ThemeColors.Accent.Dark
            };

            projectCard.Click += (sender, e) =>
            {
                Mediator?.Notify(this, ControlUiEvent.PushAssignmentDetailPage, new AssignmentDetailPagePayload()
                {
                    ProjectId = item.ProjectId,
                    ProjectName = item.Name
                });
            };

            projectsFlowLayoutPanel.Controls.Add(projectCard);
        }
    }

    private void ProjectsFlowLayoutPanel_SizeChanged(object sender, EventArgs e)
    {
        foreach (Control control in projectsFlowLayoutPanel.Controls)
        {
            control.Width = projectsFlowLayoutPanel.ClientSize.Width - projectsFlowLayoutPanel.Padding.Horizontal;
        }
    }
}
