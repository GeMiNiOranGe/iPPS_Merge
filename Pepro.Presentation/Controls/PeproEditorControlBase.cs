using System.ComponentModel;

namespace Pepro.Presentation.Controls;

public abstract class PeproEditorControlBase<ItemType> : PeproMediatedUserControl {
    public PeproEditorControlBase() { }

    public PeproEditorControlBase(IMediator mediator) : base(mediator) { }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public abstract required ItemType Item {
        get;
        set;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public abstract required EditorMode Mode {
        get;
        set;
    }
}
