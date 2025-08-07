namespace Pepro.Presentation;

public record OpenEditorControlPayload<ItemType> {
    public required ItemType Item { get; init; }
    public required EditorMode Mode { get; init; }
    public Action? OnDataChanged { get; init; }
}
