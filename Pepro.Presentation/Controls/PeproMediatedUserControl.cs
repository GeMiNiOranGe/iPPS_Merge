namespace Pepro.Presentation.Controls;

public class PeproMediatedUserControl : PeproUserControlBase {
    protected readonly IMediator _mediator = null!;

    public PeproMediatedUserControl() : base() { }

    public PeproMediatedUserControl(IMediator mediator) : base() {
        _mediator = mediator;
    }
}
