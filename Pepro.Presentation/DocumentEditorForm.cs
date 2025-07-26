using Pepro.Business;
using Pepro.DTOs;
using Pepro.Presentation.Controls;
using System.ComponentModel;

namespace Pepro.Presentation;

public partial class DocumentEditorForm : PeproMediatedUserControl {
    private TaskDocument _item = null!;

    public DocumentEditorForm() {
        Initialize();
    }

    public DocumentEditorForm(IMediator mediator) : base(mediator) {
        Initialize();
    }

    private void Initialize() {
        InitializeComponent();
    }

    private void FormInsert_Load(object sender, EventArgs e) {
        projectIdInputField.DataBindings.Add(
            nameof(projectIdInputField.Text),
            projectNameComboBoxField.InnerComboBox,
            nameof(projectNameComboBoxField.InnerComboBox.SelectedValue)
        );
        taskIdInputField.DataBindings.Add(
            nameof(taskIdInputField.Text),
            taskNameComboBoxField.InnerComboBox,
            nameof(taskNameComboBoxField.InnerComboBox.SelectedValue)
        );

        List<Project> projects = ProjectBusiness.Instance.GetProjects();
        projectNameComboBoxField.InnerComboBox.DataSource = projects;
        projectNameComboBoxField.InnerComboBox.DisplayMember = nameof(Project.Name);
        projectNameComboBoxField.InnerComboBox.ValueMember = nameof(Project.ProjectId);
        projectNameComboBoxField.InnerComboBox.SelectedIndex = -1;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public required TaskDocument Item {
        get => _item;
        set {
            _item = value ?? throw new ArgumentNullException(nameof(Item));
            documentIdInputField.Text = _item.DocumentId.ToString();
            titleInputField.Text = _item.Title;
            createdAtDateTimePicker.Value = _item.CreateAt <= createdAtDateTimePicker.MinDate ? createdAtDateTimePicker.MinDate : _item.CreateAt;
            revisionNumberInputField.Text = _item.RevisionNumber.ToString();
            revisionStatusInputField.Text = _item.RevisionStatus;
            filePathInputField.Text = _item.DocumentUrl;
            fileTypeInputField.Text = _item.NativeFileFormat;
            preparedByInputField.Text = _item.PreparedBy;
            checkedByInputField.Text = _item.CheckedBy;
            approvedByInputField.Text = _item.ApprovedBy;
            taskIdInputField.Text = _item.TaskId.ToString();
        }
    }

    private void ProjectNameComboBoxField_SelectedIndexChanged(object sender, EventArgs e) {
        string projectId = projectNameComboBoxField.InnerComboBox.SelectedValue?.ToString() ?? "";
        List<ProjectTask> tasks = TaskBusiness.Instance.GetTasksByProjectId(projectId);
        taskNameComboBoxField.InnerComboBox.DataSource = tasks;
        taskNameComboBoxField.InnerComboBox.DisplayMember = nameof(ProjectTask.Name);
        taskNameComboBoxField.InnerComboBox.ValueMember = nameof(ProjectTask.TaskId);
    }

    private void SaveButton_Click(object sender, EventArgs e) {
        MessageBoxWrapper.ShowInformation("TreasureFoundPremiumUnlock2");
    }

    private void BrowseButton_Click(object sender, EventArgs e) {
        MessageBoxWrapper.ShowInformation("TreasureFoundPremiumUnlock1");
    }
}
