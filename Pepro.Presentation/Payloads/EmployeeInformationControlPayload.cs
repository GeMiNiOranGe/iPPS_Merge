namespace Pepro.Presentation.Payloads;

public sealed record EmployeeInformationControlPayload {
    public required int EmployeeId { get; init; }
}
