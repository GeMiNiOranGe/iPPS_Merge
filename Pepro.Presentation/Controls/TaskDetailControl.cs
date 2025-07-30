using Pepro.Business;
using Pepro.DTOs;
using System.ComponentModel;

namespace Pepro.Presentation.Controls;

public partial class TaskDetailControl : PeproMediatedUserControl {
    public TaskDetailControl() {
        Initialize();
    }

    public TaskDetailControl(IMediator mediator) : base(mediator) {
        Initialize();
    }

    private void Initialize() {
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

    private void TaskDetailControl_Load(object sender, EventArgs e) {
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
                Cursor = Cursors.Hand,
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
        if (otherTasksOfManagerFlowLayoutLabel.Controls.Count > 0) {
            otherTasksOfManagerFlowLayoutLabel.Controls.Clear();
        }

        Employee employee = TaskBusiness.Instance.GetTaskManager(taskId);

        taskManagerCard.Item = employee;

        List<ProjectTaskProgress> tasksProgress = TaskBusiness.Instance.GetTasksWithProgressByEmployeeId(employee.EmployeeId);

        for (int i = 0; i < tasksProgress.Count; i++) {
            ProjectTaskProgress item = tasksProgress[i];

            TaskProgressCardControl taskCard = new() {
                Item = item,
                Margin = i != tasksProgress.Count - 1 ? new Padding(0, 0, 0, 8) : new Padding(0),
                Width = otherTasksOfManagerFlowLayoutLabel.ClientSize.Width - otherTasksOfManagerFlowLayoutLabel.Padding.Horizontal,
                ForeColor = ThemeColors.Text,
                BackColor = Color.FromArgb(29, 29, 29),
                MouseOverBackColor = ThemeColors.Accent.Base,
                MouseDownBackColor = ThemeColors.Accent.Dark
            };

            otherTasksOfManagerFlowLayoutLabel.Controls.Add(taskCard);
        }
    }
}
