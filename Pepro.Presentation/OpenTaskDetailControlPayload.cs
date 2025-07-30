namespace Pepro.Presentation;

public sealed record OpenTaskDetailControlPayload {
    public required string ProjectId { get; init; }
    public required string ProjectName { get; init; }
}