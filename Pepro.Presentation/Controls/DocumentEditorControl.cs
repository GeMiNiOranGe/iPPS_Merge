using Pepro.Business;
using Pepro.DTOs;
using System.ComponentModel;

namespace Pepro.Presentation.Controls;

public partial class DocumentEditorControl : PeproEditorControlBase, IEditorUserControl<DocumentDto> {
    private DocumentDto _item = null!;
    private EditorMode _mode;
    private bool _suppressTaskReload = false;

    public DocumentEditorControl() {
        Initialize();
    }

    public DocumentEditorControl(IMediator mediator) : base(mediator) {
        Initialize();
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public required DocumentDto Item {
        get => _item;
        set {
            _item = value ?? throw new ArgumentNullException(nameof(Item));
            documentIdInputField.Text = _item.DocumentId.ToString();
            titleInputField.Text = _item.Title;
            createdAtDateTimePicker.SetValue(_item.CreateAt);
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

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public required EditorMode Mode {
        get => _mode;
        set {
            _mode = value;
            HeaderText = _mode switch {
                EditorMode.Create => "Create a new document",
                EditorMode.Edit => "Edit document",
                _ => throw new InvalidEnumArgumentException(nameof(Mode), (int)_mode, typeof(EditorMode)),
            };
        }
    }

    private void Initialize() {
        InitializeComponent();

        saveButton.SetupRuntimeFlatStyle();
        browseButton.SetupRuntimeFlatStyle();

        projectIdInputField.FocusColor = ThemeColors.Accent.Base;
        taskIdInputField.FocusColor = ThemeColors.Accent.Base;
        documentIdInputField.FocusColor = ThemeColors.Accent.Base;
        titleInputField.FocusColor = ThemeColors.Accent.Base;
        preparedByInputField.FocusColor = ThemeColors.Accent.Base;
        checkedByInputField.FocusColor = ThemeColors.Accent.Base;
        approvedByInputField.FocusColor = ThemeColors.Accent.Base;
        fileTypeInputField.FocusColor = ThemeColors.Accent.Base;
        revisionNumberInputField.FocusColor = ThemeColors.Accent.Base;
        revisionStatusInputField.FocusColor = ThemeColors.Accent.Base;
        filePathInputField.FocusColor = ThemeColors.Accent.Base;
    }

    private void DocumentEditorControl_Load(object sender, EventArgs e) {
        projectIdInputField.DataBindings.Add(
            nameof(projectIdInputField.Text),
            projectNameComboBoxField,
            nameof(projectNameComboBoxField.SelectedValue)
        );
        taskIdInputField.DataBindings.Add(
            nameof(taskIdInputField.Text),
            taskNameComboBoxField,
            nameof(taskNameComboBoxField.SelectedValue)
        );

        projectNameComboBoxField.DisplayMember = nameof(ProjectDto.Name);
        projectNameComboBoxField.ValueMember = nameof(ProjectDto.ProjectId);

        taskNameComboBoxField.DisplayMember = nameof(ProjectTask.Name);
        taskNameComboBoxField.ValueMember = nameof(ProjectTask.TaskId);

        if (_mode == EditorMode.Create) {
            List<ProjectDto> projects = ProjectBusiness.Instance.GetProjects();
            projectNameComboBoxField.DataSource = projects;
            projectNameComboBoxField.SelectedIndex = -1;
        }
        if (_mode == EditorMode.Edit) {
            taskNameComboBoxField.Enabled = false;
            projectNameComboBoxField.Enabled = false;

            _suppressTaskReload = true;
            ProjectTask task = TaskBusiness.Instance.GetTaskByDocumentId(documentIdInputField.Text);
            taskNameComboBoxField.DataSource = (List<ProjectTask>)[task];

            ProjectDto? project = ProjectBusiness.Instance.GetProjectByTaskId(task.TaskId);
            if (project != null)
            {
                projectNameComboBoxField.DataSource = (List<ProjectDto>)[project];
            }
            _suppressTaskReload = false;
        }
    }

    private void ProjectNameComboBoxField_SelectedIndexChanged(object sender, EventArgs e) {
        if (_suppressTaskReload) {
            return;
        }

        string projectId = projectNameComboBoxField.SelectedValue?.ToString() ?? "";
        List<ProjectTask> tasks = TaskBusiness.Instance.GetTasksByProjectId(projectId);
        taskNameComboBoxField.DataSource = tasks;
        taskNameComboBoxField.SelectedIndex = -1;
    }

    private void SaveButton_Click(object sender, EventArgs e) {
        MessageBoxWrapper.ShowInformation("TreasureFoundPremiumUnlock2");
        NotifyDataChanged();
        Close();
    }

    private void BrowseButton_Click(object sender, EventArgs e) {
        MessageBoxWrapper.ShowInformation("TreasureFoundPremiumUnlock1");
    }
}
