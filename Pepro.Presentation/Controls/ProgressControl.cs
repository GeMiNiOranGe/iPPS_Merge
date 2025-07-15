using Pepro.Business;
using Pepro.DTOs;

namespace Pepro.Presentation.Controls;

public partial class ProgressControl : PeproUserControl {
    public ProgressControl() {
        InitializeComponent();
    }

    private void ProgressControl_Load(object sender, EventArgs e) {
        ShowProjectsWithProgress();
    }

    private void ShowProjectsWithProgress() {
        if (projectsFlowLayoutPanel.Controls.Count > 0) {
            projectsFlowLayoutPanel.Controls.Clear();
        }

        List<ProjectProgress> projectsProgress = ProjectBusiness.Instance.GetProjectsWithProgress();

        foreach (ProjectProgress item in projectsProgress) {
            ProjectItemControl projectItem = new() {
                Id = item.ProjectId,
                Name = item.Name,
                Percent = item.ProgressPercent.ToString() + "%"
            };

            projectsFlowLayoutPanel.Controls.Add(projectItem);
        }
    }
}
