namespace Pepro.Presentation;

public sealed record OpenAssignmentDetailControlPayload {
    public required int ProjectId { get; init; }
    public required string ProjectName { get; init; }
}