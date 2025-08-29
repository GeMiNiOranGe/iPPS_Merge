using Pepro.Business;
using Pepro.DTOs;
using System.ComponentModel;

namespace Pepro.Presentation.Controls;

public partial class AssignmentEditorControl : PeproEditorControlBase, IEditorUserControl<AssignmentDto>
{
    private AssignmentDto _item = null!;
    private EditorMode _mode;

    public AssignmentEditorControl()
    {
        Initialize();
    }

    public AssignmentEditorControl(IMediator mediator) : base(mediator)
    {
        Initialize();
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public AssignmentDto Item
    {
        get => _item;
        set
        {
            _item = value ?? throw new ArgumentNullException(nameof(Item));
            assignmentNameInputField.Text = _item.Name;
            isPublicToProjectCheckBox.Checked = _item.IsPublicToProject;
            isPublicToDepartmentCheckBox.Checked = _item.IsPublicToDepartment;
            managerIdInputField.Text = _item.ManagerId.ToString();
            startDateTimePicker.SetValue(_item.StartDate);
            endDateTimePicker.SetValue(_item.EndDate);
        }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public EditorMode Mode
    {
        get => _mode;
        set
        {
            _mode = value;
            HeaderText = _mode switch
            {
                EditorMode.Create => "Create a new assignment",
                EditorMode.Edit => "Edit assignment",
                _ => throw new InvalidEnumArgumentException(nameof(Mode), (int)_mode, typeof(EditorMode)),
            };
        }
    }

    private void Initialize()
    {
        InitializeComponent();
    }

    private void AssignmentEditorControl_Load(object sender, EventArgs e)
    {
        projectComboBoxField.DisplayMember = nameof(ProjectDto.Name);
        projectComboBoxField.ValueMember = nameof(ProjectDto.ProjectId);

        statusComboBoxField.DisplayMember = nameof(StatusDto.Name);
        statusComboBoxField.ValueMember = nameof(StatusDto.StatusId);

        projectComboBoxField.DataSource = ProjectBusiness.Instance.GetProjects();
        statusComboBoxField.DataSource = StatusBusiness.Instance.GetStatuses();

        switch (_mode)
        {
            case EditorMode.Create:
                SetupCreateMode();
                break;
            case EditorMode.Edit:
                SetupEditMode();
                break;
        }
    }

    private void SetupCreateMode()
    {
        projectComboBoxField.SelectedIndex = -1;
        statusComboBoxField.SelectedIndex = -1;
    }

    private void SetupEditMode()
    {
        projectComboBoxField.SelectedValue = _item.ProjectId;
        statusComboBoxField.SelectedValue = _item.StatusId;
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        if (!ValidateInputs())
        {
            MessageBoxWrapper.ShowInformation("FillInformation");
            return;
        }

        if (
            !int.TryParse(managerIdInputField.Text, out int managerId)
            || !int.TryParse(
                projectComboBoxField.SelectedValue?.ToString(),
                out int projectId
            )
            || !int.TryParse(
                statusComboBoxField.SelectedValue?.ToString(),
                out int statusId
            )
        )
        {
            return;
        }

        AssignmentDto assignment = new()
        {
            AssignmentId = _item.AssignmentId,
            Name = assignmentNameInputField.Text.Trim(),
            IsPublicToProject = isPublicToProjectCheckBox.Checked,
            IsPublicToDepartment = isPublicToDepartmentCheckBox.Checked,
            ManagerId = managerId,
            StartDate = startDateTimePicker.Value,
            EndDate = endDateTimePicker.Value,
            ProjectId = projectId,
            StatusId = statusId,
        };

        int result = _mode switch
        {
            // EditorMode.Create => AssignmentBusiness.Instance.InsertAssignment(assignment),
            // EditorMode.Edit => AssignmentBusiness.Instance.UpdateAssignment(assignment),
        };

        if (result > 0)
        {
            NotifyDataChanged();
            Close();
            MessageBoxWrapper.ShowInformation("SaveSuccess");
        }
        else
        {
            MessageBoxWrapper.ShowError("SaveFailed");
        }
    }

    private bool ValidateInputs()
    {
        return !string.IsNullOrWhiteSpace(managerIdInputField.Text)
            && !string.IsNullOrWhiteSpace(assignmentNameInputField.Text)
            && !string.IsNullOrWhiteSpace(
                projectComboBoxField.SelectedValue?.ToString()
            )
            && !string.IsNullOrWhiteSpace(
                statusComboBoxField.SelectedValue?.ToString()
            );
    }
}
