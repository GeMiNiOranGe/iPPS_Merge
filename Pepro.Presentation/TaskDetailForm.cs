using Pepro.Business;
using Pepro.DTOs;
using Pepro.Presentation.Controls;
using System.ComponentModel;
using System.Data;

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
                RetrieveInfomation(item.TaskId.ToString());
            };

            tasksOfProjectFlowLayoutPanel.Controls.Add(taskCard);
        }
    }

    public void RetrieveInfomation(string taskId) {
        if (taskManagerPanel.Controls.Count > 0) {
            taskManagerPanel.Controls.Clear();
        }

        if (otherTasksOfManagerFlowLayoutLabel.Controls.Count > 0) {
            otherTasksOfManagerFlowLayoutLabel.Controls.Clear();
        }

        string managerTempId = null;

        var dtManager = TaskBusiness.Instance.GetManager(taskId);

        if (dtManager != null && dtManager.Rows.Count > 0) {
            foreach (DataRow row in dtManager.Rows) {
                var managerItem = new ManagerItemControl {
                    Id = row["EMPLOYEE_ID"].ToString(),
                    Name = row["EMPLOYEE_FULLNAME"].ToString()
                };

                managerTempId = managerItem.Id;

                managerItem.Size = new Size() {
                    Width = taskManagerPanel.Size.Width,
                    Height = managerItem.Size.Height
                };
                taskManagerPanel.Controls.Add(managerItem);
            }
        }

        var dtJobsByProject = TaskBusiness.Instance.GetAllByEmployee(managerTempId);
        double total;
        double total1;
        if (dtJobsByProject != null && dtJobsByProject.Rows.Count > 0) {
            foreach (DataRow row in dtJobsByProject.Rows) {
                var jobOfEmployeeItem = new TaskOfEmployeeControl {
                    ProjectId = row["PROJECT_ID"].ToString(),
                    JobId = row["JOB_ID"].ToString(),
                    JobName = row["JOB_NAME"].ToString()
                };
                total = Convert.ToDouble(CProgressBLL.getTotalDocumentbyJobID(jobOfEmployeeItem.JobId));
                total1 = Convert.ToDouble(CProgressBLL.getNumberofDocumentbyJobID(jobOfEmployeeItem.JobId));
                jobOfEmployeeItem.JobPercent = Math.Round((total / total1) * 100, 2).ToString() + "%";
                otherTasksOfManagerFlowLayoutLabel.Controls.Add(jobOfEmployeeItem);
            }
        }
    }
}
