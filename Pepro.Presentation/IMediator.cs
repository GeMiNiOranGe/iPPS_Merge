namespace Pepro.Presentation;

public interface IMediator {
    void Notify(object sender, ControlUiEvent ev, object? data = null);
}
