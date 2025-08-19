namespace Pepro.Presentation.Controls;

public class PeproCrudControlBase : PeproMediatedUserControl
{
    public PeproCrudControlBase() { }

    public PeproCrudControlBase(IMediator mediator) : base(mediator) { }

    protected static void BindSearchButtonClick<ItemType>(
        string keyword,
        DataGridView dataGridView,
        Func<string, List<ItemType>> onSearch,
        Action<List<ItemType>>? onSearchCompleted = null
    )
    {
        if (string.IsNullOrEmpty(keyword))
        {
            return;
        }
        List<ItemType> items = onSearch(keyword);
        dataGridView.DataSource = items;
        onSearchCompleted?.Invoke(items);
    }

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

    protected static void BindDeleteButtonClick<ItemType>(
        DataGridView dataGridView,
        Func<ItemType, int> onDelete,
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

        if (MessageBoxWrapper.ConfirmDelete() == DialogResult.Yes)
        {
            int numberOfRowsAffected = onDelete(item);
            MessageBoxWrapper.ShowInformation(
                "DeleteSuccess",
                numberOfRowsAffected
            );
            onDataChanged?.Invoke();
        }
    }
}
