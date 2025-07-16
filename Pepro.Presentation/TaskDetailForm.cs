using Pepro.Business;
using Pepro.Presentation.Controls;
using System.ComponentModel;
using System.Data;

namespace Pepro.Presentation;

public partial class TaskDetailForm : PeproForm {
    public TaskDetailForm() {
        InitializeComponent();
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string ProjectId {
        get => projectIdLabel.Text;
        set => projectIdLabel.Text = value;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string ProjectName {
        get => projectNameLabel.Text;
        set => projectNameLabel.Text = value;
    }

    private void TaskDetailForm_Load(object sender, EventArgs e) {
        ShowJobsFromProject();
    }

    private void ShowJobsFromProject() {
        tasksOfProjectFlowLayoutPanel.Controls.Clear();
        var dataTable = TaskBusiness.Instance.GetAllFromProject(ProjectId);
        double total;
        double total1;
        if (dataTable != null && dataTable.Rows.Count > 0) {
            foreach (DataRow row in dataTable.Rows) {
                var jobItem = new TaskItemControl {
                    Id = row["JOB_ID"].ToString(),
                    Name = row["JOB_NAME"].ToString(),
                    PanelManager = taskManagerPanel,
                    PanelJobOfEmployee = otherTasksOfManagerFlowLayoutLabel
                };
                total = Convert.ToDouble(CProgressBLL.getTotalDocumentbyJobID(jobItem.Id));
                total1 = Convert.ToDouble(CProgressBLL.getNumberofDocumentbyJobID(jobItem.Id));
                jobItem.Percent = Math.Round((total / total1) * 100, 2).ToString() + "%";

                jobItem.Size = new Size() {
                    Width = tasksOfProjectFlowLayoutPanel.Size.Width,
                    Height = jobItem.Size.Height
                };
                tasksOfProjectFlowLayoutPanel.Controls.Add(jobItem);
            }
        }
    }
}
