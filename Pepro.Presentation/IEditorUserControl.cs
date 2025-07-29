namespace Pepro.Presentation;

public interface IEditorUserControl<ItemType> {
    ItemType Item {
        get;
        set;
    }

    EditorMode Mode {
        get;
        set;
    }
}
