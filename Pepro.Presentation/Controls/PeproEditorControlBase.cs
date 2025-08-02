namespace Pepro.Presentation.Controls;

public abstract class PeproEditorControlBase : PeproMediatedUserControl {
    public PeproEditorControlBase() { }

    public PeproEditorControlBase(IMediator mediator) : base(mediator) { }
}
