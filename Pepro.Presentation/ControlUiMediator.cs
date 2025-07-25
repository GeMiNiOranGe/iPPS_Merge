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
        case ControlUiEvent.OpenDocumentEditorForm:
            if (data is OpenDocumentEditorFormPayload payload) {
                DocumentEditorForm documentEditorForm = new(this) {
                    Item = payload.Item,
                    HeaderText = payload.HeaderText,
                };
                PushControl(documentEditorForm); 
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
