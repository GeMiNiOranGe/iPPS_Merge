using Pepro.DTOs;

namespace Pepro.Presentation;

public sealed record OpenEmployeeEditorControlPayload {
    public required Employee Item { get; init; }
    public required EditorMode Mode { get; init; }
    public Action? OnDataChanged { get; init; }
}