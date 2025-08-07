namespace Pepro.Presentation.Controls;

public class PeproCrudControlBase : PeproMediatedUserControl
{
    public PeproCrudControlBase() { }

    public PeproCrudControlBase(IMediator mediator) : base(mediator) { }

    protected void BindInsertButtonClick<ItemType>(
        ItemType item,
        ControlUiEvent uiEvent,
        Action? onDataChanged
    )
    {
        _mediator.Notify(
            this,
            uiEvent,
            new OpenEditorControlPayload<ItemType>
            {
                Item = item,
                Mode = EditorMode.Create,
                OnDataChanged = onDataChanged,
            }
        );
    }

    protected void BindUpdateButtonClick<ItemType>(
        DataGridView dataGridView,
        ControlUiEvent uiEvent,
        Action? onDataChanged
    )
    {
        if (dataGridView.CurrentRow == null)
        {
            MessageBoxWrapper.ShowInformation("SelectData");
            return;
        }

        DataGridViewRow row = dataGridView.CurrentRow;
        if (row.DataBoundItem is not ItemType item)
        {
            MessageBoxWrapper.ShowError("DataReadError");
            return;
        }

        _mediator.Notify(
            this,
            uiEvent,
            new OpenEditorControlPayload<ItemType>
            {
                Item = item,
                Mode = EditorMode.Edit,
                OnDataChanged = onDataChanged
            }
        );
    }
}
