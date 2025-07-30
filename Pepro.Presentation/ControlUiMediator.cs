using Pepro.Presentation.Controls;

namespace Pepro.Presentation;

public class ControlUiMediator(Panel workplacePanel) : IMediator {
    private readonly Panel _workplacePanel = workplacePanel;

    public void Notify(object sender, ControlUiEvent ev, object? data = null) {
        switch (ev) {
        case ControlUiEvent.OpenDocumentControl:
            OpenDocumentControl();
            break;
        case ControlUiEvent.OpenDocumentEditorControl:
            OpenDocumentEditorControl(data);
            break;
        case ControlUiEvent.OpenProgressControl:
            OpenProgressControl();
            break;
        case ControlUiEvent.OpenEmployeeControl:
            OpenEmployeeControl();
            break;
        case ControlUiEvent.OpenTaskDetailControl:
            OpenTaskDetailControl(data);
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

    private void OpenDocumentControl() {
        DocumentControl documentControl = new(this);
        OpenControl(documentControl);
    }

    private void OpenDocumentEditorControl(object? data) {
        if (data is not OpenDocumentEditorControlPayload payload) {
            return;
        }

        DocumentEditorControl documentEditorControl = new(this) {
            Item = payload.Item,
            Mode = payload.Mode,
        };
        PushControl(documentEditorControl);
    }

    private void OpenProgressControl() {
        ProgressControl progressControl = new(this);
        OpenControl(progressControl);
    }

    private void OpenEmployeeControl() {
        EmployeeControl employeeControl = new(this);
        OpenControl(employeeControl);
    }

    private void OpenTaskDetailControl(object? data) {
        if (data is not OpenTaskDetailControlPayload payload) {
            return;
        }

        TaskDetailControl taskDetailControl = new(this) {
            ProjectId = payload.ProjectId,
            ProjectName = payload.ProjectName,
        };
        PushControl(taskDetailControl);
    }
}
