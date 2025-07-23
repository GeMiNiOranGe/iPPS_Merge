using System.ComponentModel;
using Pepro.Business;
using Pepro.DTOs;
using Pepro.Presentation.Controls;

namespace Pepro.Presentation;

public partial class DocumentEditorForm : PeproForm
{
    private TaskDocument _item = null!;

    public DocumentEditorForm()
    {
        InitializeComponent();
    }

    public DocumentEditorForm(string name)
    {
        InitializeComponent();
        label24.Text = name;
    }

    private void FormInsert_Load(object sender, EventArgs e)
    {
        txtIDPro.DataBindings.Add(
            nameof(txtIDPro.Text),
            cbNameProject,
            nameof(cbNameProject.SelectedValue)
        );
        txtIDJob.DataBindings.Add(
            nameof(txtIDJob.Text),
            cbNameJob,
            nameof(cbNameJob.SelectedValue)
        );

        List<Project> projects = ProjectBusiness.Instance.GetProjects();
        cbNameProject.DataSource = projects;
        cbNameProject.DisplayMember = nameof(Project.Name);
        cbNameProject.ValueMember = nameof(Project.ProjectId);
        cbNameProject.SelectedIndex = -1;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public required TaskDocument Item
    {
        get => _item;
        set
        {
            _item = value ?? throw new ArgumentNullException(nameof(Item));
            txtIDDoc.Text = _item.DocumentId.ToString();
            txtTitle.Text = _item.Title;
            dateDate.Value = _item.CreateAt <= dateDate.MinDate ? dateDate.MinDate : _item.CreateAt;
            cbRevision_Number.Text = _item.RevisionNumber.ToString();
            cbLastest_Revision.Text = _item.RevisionStatus;
            txtLink.Text = _item.DocumentUrl;

            txtPrepared_By.Text = _item.PreparedBy;
            txtChecked_By.Text = _item.CheckedBy;
            txtApproved_By.Text = _item.ApprovedBy;
            txtIDJob.Text = _item.TaskId.ToString();
        }
    }

    private void cbNameProject_SelectedIndexChanged(object sender, EventArgs e)
    {
        string projectId = cbNameProject.SelectedValue?.ToString() ?? "";
        List<ProjectTask> tasks = TaskBusiness.Instance.GetTasksByProjectId(projectId);
        cbNameJob.DataSource = tasks;
        cbNameJob.DisplayMember = nameof(ProjectTask.Name);
        cbNameJob.ValueMember = nameof(ProjectTask.TaskId);
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        MessageBoxWrapper.ShowInformation("TreasureFoundPremiumUnlock2");
    }

    private void btnBroser_Click(object sender, EventArgs e)
    {
        MessageBoxWrapper.ShowInformation("TreasureFoundPremiumUnlock1");
    }
}
