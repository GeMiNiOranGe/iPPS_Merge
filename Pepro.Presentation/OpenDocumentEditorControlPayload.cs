using Pepro.DTOs;

namespace Pepro.Presentation;

public sealed record OpenDocumentEditorControlPayload {
    public required TaskDocument Item { get; init; }
    public required EditorMode Mode { get; init; }
}
