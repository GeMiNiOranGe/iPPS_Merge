using Pepro.Presentation.Controls;

namespace Pepro.Presentation;

public class ControlUiMediator(Panel workplacePanel) : IMediator {
    private readonly Panel _workplacePanel = workplacePanel;

    public void Notify(object sender, ControlUiEvent ev, object? data = null) {
        switch (ev) {
        case ControlUiEvent.OpenDocumentControl:
            DocumentControl documentControl = new(this);
            OpenControl(documentControl);
            break;
        case ControlUiEvent.OpenDocumentEditorControl:
            if (data is OpenDocumentEditorControlPayload payload) {
                DocumentEditorControl documentEditorControl = new(this) {
                    Item = payload.Item,
                    Mode = payload.Mode,
                };
                PushControl(documentEditorControl); 
            }
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
}
