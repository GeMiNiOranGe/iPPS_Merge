using Pepro.DTOs;
using Pepro.Presentation.Base;
using Pepro.Presentation.Controls.Pages;
using Pepro.Presentation.Payloads;

namespace Pepro.Presentation.Utilities;

public class ControlUiMediator(Panel workplacePanel) : IMediator
{
    private readonly Panel _workplacePanel = workplacePanel;

    public void Notify(object sender, ControlUiEvent ev, object? data = null)
    {
        switch (ev)
        {
            case ControlUiEvent.NavigateAssignmentControl:
                Navigate<AssignmentControl>();
                break;
            case ControlUiEvent.PushAssignmentEditorControl:
                PushEditor<AssignmentEditorControl, AssignmentDto>(data);
                break;
            case ControlUiEvent.NavigateDocumentControl:
                Navigate<DocumentControl>();
                break;
            case ControlUiEvent.NavigateDepartmentControl:
                Navigate<DepartmentControl>();
                break;
            case ControlUiEvent.PushDepartmentEditorControl:
                PushEditor<DepartmentEditorControl, DepartmentDto>(data);
                break;
            case ControlUiEvent.PushDocumentEditorControl:
                PushEditor<DocumentEditorControl, DocumentDto>(data);
                break;
            case ControlUiEvent.NavigateProgressControl:
                Navigate<ProgressControl>();
                break;
            case ControlUiEvent.NavigateProjectControl:
                Navigate<ProjectControl>();
                break;
            case ControlUiEvent.PushProjectEditorControl:
                PushEditor<ProjectEditorControl, ProjectDto>(data);
                break;
            case ControlUiEvent.NavigateEmployeeControl:
                Navigate<EmployeeControl>();
                break;
            case ControlUiEvent.PushEmployeeEditorControl:
                PushEditor<EmployeeEditorControl, EmployeeDto>(data);
                break;
            case ControlUiEvent.PushAssignmentDetailControl:
                PushAssignmentDetailControl(data);
                break;
            case ControlUiEvent.NavigateEmployeeInformationControl:
                NavigateEmployeeInformationControl(data);
                break;
            case ControlUiEvent.NavigatePayrollControl:
                Navigate<PayrollControl>();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(ev), ev, "This event is not supported.");
        }
    }

    private TControl Create<TControl>()
        where TControl : PeproMediatedUserControl, new()
    {
        return new()
        {
            Mediator = this,
        };
    }

    private void PushEditor<TEditorControl, TDto>(object? data)
        where TEditorControl : PeproEditorControlBase, IEditorUserControl<TDto>, new()
    {
        if (data is not EditorControlPayload<TDto> payload)
        {
            return;
        }

        TEditorControl control = Create<TEditorControl>();
        control.Item = payload.Item;
        control.Mode = payload.Mode;
        control.OnDataChanged = payload.OnDataChanged;

        Push(control);
    }

    private void Navigate(UserControl control)
    {
        _workplacePanel.Controls.Clear();
        control.Dock = DockStyle.Fill;
        _workplacePanel.Controls.Add(control);
        control.BringToFront();
    }

    private void Navigate<TControl>()
        where TControl : PeproMediatedUserControl, new()
    {
        TControl control = Create<TControl>();
        Navigate(control);
    }

    private void Push(UserControl control)
    {
        control.Dock = DockStyle.Fill;
        _workplacePanel.Controls.Add(control);
        control.BringToFront();
    }

    private void PushAssignmentDetailControl(object? data)
    {
        if (data is not AssignmentDetailControlPayload payload)
        {
            return;
        }

        AssignmentDetailControl assignmentDetailControl = new()
        {
            Mediator = this,
            ProjectId = payload.ProjectId,
            ProjectName = payload.ProjectName,
        };
        Push(assignmentDetailControl);
    }

    private void NavigateEmployeeInformationControl(object? data)
    {
        if (data is not EmployeeInformationControlPayload payload)
        {
            return;
        }

        EmployeeInformationControl employeeInformationControl = new()
        {
            Mediator = this,
            EmployeeId = payload.EmployeeId,
        };
        Navigate(employeeInformationControl);
    }
}
