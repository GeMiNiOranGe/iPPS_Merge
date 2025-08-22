using System.ComponentModel;

namespace Pepro.Presentation.Controls;

public class PeproEditorControlBase : PeproMediatedUserControl {
    private Action? _onDataChanged;

    public PeproEditorControlBase() { }

    public PeproEditorControlBase(IMediator mediator) : base(mediator) { }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Action? OnDataChanged {
        get => _onDataChanged;
        set => _onDataChanged = value;
    }
    
    protected void NotifyDataChanged() {
        if (_onDataChanged == null)
        {
            throw new InvalidOperationException($"{nameof(OnDataChanged)} must be assigned before calling {nameof(NotifyDataChanged)}.");
        }

        _onDataChanged.Invoke();
    }
}
