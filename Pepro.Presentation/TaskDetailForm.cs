using Pepro.Business;
using Pepro.DTOs;
using Pepro.Presentation.Controls;
using System.ComponentModel;

namespace Pepro.Presentation;

public partial class TaskDetailForm : PeproForm {
    public TaskDetailForm() {
        InitializeComponent();
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public required string ProjectId {
        get => projectIdLabel.Text;
        set => projectIdLabel.Text = value;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public required string ProjectName {
        get => projectNameLabel.Text;
        set => projectNameLabel.Text = value;
    }

    private void TaskDetailForm_Load(object sender, EventArgs e) {
        ShowTasksByProject();
    }

    private void ShowTasksByProject() {
        if (tasksOfProjectFlowLayoutPanel.Controls.Count > 0) {
            tasksOfProjectFlowLayoutPanel.Controls.Clear();
        }

        List<ProjectTaskProgress> tasksProgress = TaskBusiness.Instance.GetTasksWithProgressByProjectId(ProjectId);

        for (int i = 0; i < tasksProgress.Count; i++) {
            ProjectTaskProgress item = tasksProgress[i];

            TaskItemControl taskCard = new() {
                Id = item.TaskId.ToString(),
                Name = item.Name,
                Percent = item.ProgressPercent.ToString() + "%",
                PanelManager = taskManagerPanel,
                PanelJobOfEmployee = otherTasksOfManagerFlowLayoutLabel,
            };

            tasksOfProjectFlowLayoutPanel.Controls.Add(taskCard);
        }
    }
}
