using Pepro.Business;
using Pepro.DTOs;
using System.ComponentModel;

namespace Pepro.Presentation.Controls;

public partial class DocumentEditorControl : PeproEditorControlBase, IEditorUserControl<DocumentDto> {
    private DocumentDto _item = null!;
    private EditorMode _mode;

    public DocumentEditorControl() {
        InitializeComponent();

        saveButton.ApplyFlatStyle();
        browseButton.ApplyFlatStyle();

        projectIdInputField.FocusColor = ThemeColors.Accent.Base;
        assignmentIdInputField.FocusColor = ThemeColors.Accent.Base;
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

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public DocumentDto Item {
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
            assignmentIdInputField.Text = _item.AssignmentId.ToString();
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public EditorMode Mode {
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

    private void DocumentEditorControl_Load(object sender, EventArgs e) {
        projectIdInputField.BindTextToValue(projectNameComboBoxField);
        assignmentIdInputField.BindTextToValue(assignmentNameComboBoxField);

        projectNameComboBoxField.DisplayMember = nameof(ProjectDto.Name);
        projectNameComboBoxField.ValueMember = nameof(ProjectDto.ProjectId);

        assignmentNameComboBoxField.DisplayMember = nameof(AssignmentDto.Name);
        assignmentNameComboBoxField.ValueMember = nameof(AssignmentDto.AssignmentId);

        switch (_mode) {
        case EditorMode.Create:
            SetupCreateMode();
            break;
        case EditorMode.Edit:
            SetupEditMode();
            break;
        }
    }

    private void SetupCreateMode() {
        List<ProjectDto> projects = ProjectBusiness.Instance.GetProjects();
        projectNameComboBoxField.DataSource = projects;
        projectNameComboBoxField.SelectedIndex = -1;
    }

    private void SetupEditMode() {
        assignmentNameComboBoxField.Enabled = false;
        projectNameComboBoxField.Enabled = false;

        if (!int.TryParse(documentIdInputField.Text, out int documentId))
        {
            return;
        }

        AssignmentDto? assignment = AssignmentBusiness.Instance.GetAssignmentByDocumentId(documentId);
        if (assignment == null)
        {
            return;
        }

        assignmentNameComboBoxField.DataSource = (List<AssignmentDto>)[assignment];

        ProjectDto? project = ProjectBusiness.Instance.GetProjectByAssignmentId(assignment.AssignmentId);
        if (project == null)
        {
            return;
        }

        projectNameComboBoxField.ExecuteWithoutEvent(
            nameof(PeproComboBoxField.SelectedIndexChanged),
            ProjectNameComboBoxField_SelectedIndexChanged,
            () => projectNameComboBoxField.DataSource = (List<ProjectDto>)[project]
        );
    }

    private void ProjectNameComboBoxField_SelectedIndexChanged(object? sender, EventArgs e) {
        if (!int.TryParse(projectNameComboBoxField.SelectedValue?.ToString(), out int projectId)){
            return;
        }

        List<AssignmentDto> assignments = AssignmentBusiness.Instance.GetAssignmentsByProjectId(projectId);
        assignmentNameComboBoxField.DataSource = assignments;
        assignmentNameComboBoxField.SelectedIndex = -1;
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
