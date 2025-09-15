using Pepro.Presentation.Enums;
using Pepro.Presentation.Payloads;
using Pepro.Presentation.Utilities;

namespace Pepro.Presentation.Controls.Templates;

public class CrudTemplate : MediatedTemplate
{
    public CrudTemplate() { }

    protected static void BindDataGridViewCellClick<ItemType>(
        DataGridView dataGridView,
        DataGridViewCellEventArgs e,
        Action<ItemType>? onCellClicked = null
    )
    {
        // Ignore clicks on the column header or invalid row indices
        if (e.RowIndex < 0 || e.RowIndex >= dataGridView.Rows.Count)
        {
            return;
        }

        DataGridViewRow row = dataGridView.Rows[e.RowIndex];

        if (row.DataBoundItem is ItemType item)
        {
            onCellClicked?.Invoke(item);
        }
    }

    protected static void BindSearchButtonClick<ItemType>(
        string keyword,
        DataGridView dataGridView,
        Func<string, IEnumerable<ItemType>> onSearch,
        Action<IEnumerable<ItemType>>? onSearchCompleted = null
    )
    {
        if (string.IsNullOrEmpty(keyword))
        {
            return;
        }
        IEnumerable<ItemType> items = onSearch(keyword);
        dataGridView.DataSource = items.ToList();
        onSearchCompleted?.Invoke(items);
    }

    protected void BindInsertButtonClick<ItemType>(
        ItemType item,
        ControlUiEvent uiEvent,
        Action? onDataChanged
    )
    {
        Mediator?.Notify(
            this,
            uiEvent,
            new EditorControlPayload<ItemType>
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

        Mediator?.Notify(
            this,
            uiEvent,
            new EditorControlPayload<ItemType>
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
