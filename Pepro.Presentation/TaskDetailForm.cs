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

            TaskProgressCardControl taskCard = new() {
                Item = item,
                Margin = i != tasksProgress.Count - 1 ? new Padding(0, 0, 0, 8) : new Padding(0),
                Width = tasksOfProjectFlowLayoutPanel.ClientSize.Width - tasksOfProjectFlowLayoutPanel.Padding.Horizontal,
                ForeColor = ThemeColors.Text,
                BackColor = Color.FromArgb(29, 29, 29),
                MouseOverBackColor = ThemeColors.Accent.Base,
                MouseDownBackColor = ThemeColors.Accent.Dark
            };

            taskCard.Click += (sender, e) => {
                RetrieveInfomation(item.TaskId);
            };

            tasksOfProjectFlowLayoutPanel.Controls.Add(taskCard);
        }
    }

    public void RetrieveInfomation(int taskId) {
        if (taskManagerPanel.Controls.Count > 0) {
            taskManagerPanel.Controls.Clear();
        }

        if (otherTasksOfManagerFlowLayoutLabel.Controls.Count > 0) {
            otherTasksOfManagerFlowLayoutLabel.Controls.Clear();
        }

        Employee employee = TaskBusiness.Instance.GetTaskManager(taskId);

        ManagerItemControl managerCard = new() {
            Id = employee.EmployeeId,
            Name = employee.FirstName + ", " + employee.MiddleName + " " + employee.LastName,
            Width = taskManagerPanel.ClientSize.Width - taskManagerPanel.Padding.Horizontal,
        };

        taskManagerPanel.Controls.Add(managerCard);

        List<ProjectTaskProgress> tasksProgress = TaskBusiness.Instance.GetTasksWithProgressByEmployeeId(employee.EmployeeId);

        for (int i = 0; i < tasksProgress.Count; i++) {
            ProjectTaskProgress item = tasksProgress[i];

            TaskOfEmployeeControl taskOfEmployeeItem = new() {
                ProjectId = item.ProjectId,
                JobId = item.TaskId.ToString(),
                JobName = item.Name,
                JobPercent = item.ProgressPercent.ToString() + "%",
                Margin = i != tasksProgress.Count - 1 ? new Padding(0, 0, 0, 8) : new Padding(0),
                Width = otherTasksOfManagerFlowLayoutLabel.ClientSize.Width - otherTasksOfManagerFlowLayoutLabel.Padding.Horizontal,
            };

            otherTasksOfManagerFlowLayoutLabel.Controls.Add(taskOfEmployeeItem);
        }
    }
}
