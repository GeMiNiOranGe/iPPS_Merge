namespace Pepro.Presentation.Payloads;

public sealed record AssignmentDetailControlPayload {
    public required int ProjectId { get; init; }
    public required string ProjectName { get; init; }
}