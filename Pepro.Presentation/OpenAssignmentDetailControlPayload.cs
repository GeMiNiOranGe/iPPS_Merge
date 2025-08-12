namespace Pepro.Presentation;

public sealed record OpenAssignmentDetailControlPayload {
    public required string ProjectId { get; init; }
    public required string ProjectName { get; init; }
}