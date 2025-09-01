using Pepro.DTOs;
using Pepro.Presentation.Controls;

namespace Pepro.Presentation;

public class ControlUiMediator(Panel workplacePanel) : IMediator {
    private readonly Panel _workplacePanel = workplacePanel;

    public void Notify(object sender, ControlUiEvent ev, object? data = null) {
        switch (ev) {
        case ControlUiEvent.OpenAssignmentControl:
            OpenAssignmentControl();
            break;
        case ControlUiEvent.OpenAssignmentEditorControl:
            OpenAssignmentEditorControl(data);
            break;
        case ControlUiEvent.OpenDocumentControl:
            OpenDocumentControl();
            break;
        case ControlUiEvent.OpenDepartmentControl:
            OpenDepartmentControl();
            break;
        case ControlUiEvent.OpenDocumentEditorControl:
            OpenDocumentEditorControl(data);
            break;
        case ControlUiEvent.OpenProgressControl:
            OpenProgressControl();
            break;
        case ControlUiEvent.OpenProjectControl:
            OpenProjectControl();
            break;
        case ControlUiEvent.OpenProjectEditorControl:
            OpenProjectEditorControl(data);
            break;
        case ControlUiEvent.OpenEmployeeControl:
            OpenEmployeeControl();
            break;
        case ControlUiEvent.OpenEmployeeEditorControl:
            OpenEmployeeEditorControl(data);
            break;
        case ControlUiEvent.OpenAssignmentDetailControl:
            OpenAssignmentDetailControl(data);
            break;
        case ControlUiEvent.OpenEmployeeInformationControl:
            OpenEmployeeInformationControl(data);
            break;
        }
    }

    private void OpenControl(UserControl control) {
        _workplacePanel.Controls.Clear();
        control.Dock = DockStyle.Fill;
        _workplacePanel.Controls.Add(control);
        control.BringToFront();
    }

    private void PushControl(UserControl control) {
        control.Dock = DockStyle.Fill;
        _workplacePanel.Controls.Add(control);
        control.BringToFront();
    }

    private void OpenAssignmentControl() {
        AssignmentControl assignmentControl = new(this);
        OpenControl(assignmentControl);
    }

    private void OpenAssignmentEditorControl(object? data) {
        if (data is not OpenEditorControlPayload<AssignmentDto> payload) {
            return;
        }

        AssignmentEditorControl assignmentEditorControl = new(this) {
            Item = payload.Item,
            Mode = payload.Mode,
            OnDataChanged = payload.OnDataChanged,
        };
        PushControl(assignmentEditorControl);
    }

    private void OpenDepartmentControl() {
        DepartmentControl departmentControl = new(this);
        OpenControl(departmentControl);
    }

    private void OpenDocumentControl() {
        DocumentControl documentControl = new(this);
        OpenControl(documentControl);
    }

    private void OpenDocumentEditorControl(object? data) {
        if (data is not OpenEditorControlPayload<DocumentDto> payload) {
            return;
        }

        DocumentEditorControl documentEditorControl = new(this) {
            Item = payload.Item,
            Mode = payload.Mode,
            OnDataChanged = payload.OnDataChanged,
        };
        PushControl(documentEditorControl);
    }

    private void OpenProgressControl() {
        ProgressControl progressControl = new(this);
        OpenControl(progressControl);
    }

    private void OpenProjectControl() {
        ProjectControl projectControl = new(this);
        OpenControl(projectControl);
    }

    private void OpenProjectEditorControl(object? data) {
        if (data is not OpenEditorControlPayload<ProjectDto> payload) {
            return;
        }

        ProjectEditorControl employeeEditorControl = new(this) {
            Item = payload.Item,
            Mode = payload.Mode,
            OnDataChanged = payload.OnDataChanged,
        };
        PushControl(employeeEditorControl);
    }

    private void OpenEmployeeControl() {
        EmployeeControl employeeControl = new(this);
        OpenControl(employeeControl);
    }

    private void OpenEmployeeEditorControl(object? data) {
        if (data is not OpenEditorControlPayload<EmployeeDto> payload) {
            return;
        }

        EmployeeEditorControl employeeEditorControl = new(this) {
            Item = payload.Item,
            Mode = payload.Mode,
            OnDataChanged = payload.OnDataChanged,
        };
        PushControl(employeeEditorControl);
    }

    private void OpenAssignmentDetailControl(object? data) {
        if (data is not OpenAssignmentDetailControlPayload payload) {
            return;
        }

        AssignmentDetailControl assignmentDetailControl = new(this) {
            ProjectId = payload.ProjectId,
            ProjectName = payload.ProjectName,
        };
        PushControl(assignmentDetailControl);
    }

    private void OpenEmployeeInformationControl(object? data) {
        if (data is not OpenEmployeeInformationControlPayload payload) {
            return;
        }

        EmployeeInformationControl employeeInformationControl = new(this) {
            EmployeeId = payload.EmployeeId,
        };
        OpenControl(employeeInformationControl);
    }
}
