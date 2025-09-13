using Pepro.Presentation.Enums;

namespace Pepro.Presentation.Interfaces;

public interface IMediator
{
    void Notify(object sender, ControlUiEvent ev, object? data = null);
}
