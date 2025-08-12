using Pepro.Business;
using Pepro.DTOs;

namespace Pepro.Presentation.Controls;

public partial class ProgressControl : PeproMediatedUserControl {
    public ProgressControl() {
        Initialize();
    }

    public ProgressControl(IMediator mediator) : base(mediator) {
        Initialize();
    }

    private void Initialize() {
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

        for (int i = 0; i < projectsProgress.Count; i++) {
            ProjectProgress item = projectsProgress[i];

            ProjectProgressCardControl projectCard = new() {
                Item = item,
                Margin = i != projectsProgress.Count - 1 ? new Padding(0, 0, 0, 8) : new Padding(0),
                Width = projectsFlowLayoutPanel.ClientSize.Width - projectsFlowLayoutPanel.Padding.Horizontal,
                Cursor = Cursors.Hand,
                ForeColor = ThemeColors.Text,
                BackColor = Color.FromArgb(29, 29, 29),
                MouseOverBackColor = ThemeColors.Accent.Base,
                MouseDownBackColor = ThemeColors.Accent.Dark
            };

            projectCard.Click += (sender, e) => {
                _mediator.Notify(this, ControlUiEvent.OpenAssignmentDetailControl, new OpenAssignmentDetailControlPayload() {
                    ProjectId = item.ProjectId,
                    ProjectName = item.Name
                });
            };

            projectsFlowLayoutPanel.Controls.Add(projectCard);
        }
    }

    private void ProjectsFlowLayoutPanel_SizeChanged(object sender, EventArgs e) {
        foreach (Control control in projectsFlowLayoutPanel.Controls) {
            control.Width = projectsFlowLayoutPanel.ClientSize.Width - projectsFlowLayoutPanel.Padding.Horizontal;
        }
    }
}
