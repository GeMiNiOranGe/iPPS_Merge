using Pepro.Business;
using Pepro.DTOs;

namespace Pepro.Presentation.Controls;

public partial class ProgressControl : UserControl {
    public ProgressControl() {
        InitializeComponent();
    }

    private void FormProgress_Load(object sender, EventArgs e) {
        ShowAllProject();
    }

    private void ShowAllProject() {
        if (projectListFlowLayoutPanel.Controls.Count > 0) {
            projectListFlowLayoutPanel.Controls.Clear();
        }

        List<ProjectProgress> projectsProgress = ProjectBusiness.Instance.GetProjectsWithProgress();

        foreach (ProjectProgress item in projectsProgress) {
            ProjectItemControl projectItem = new() {
                Id = item.ProjectId,
                Name = item.Name,
                Percent = item.ProgressPercent.ToString() + "%"
            };

            projectListFlowLayoutPanel.Controls.Add(projectItem);
        }
    }
}
