namespace TogetherApIs.Requests.Rl;

/// <summary>
/// The inputs of the GetWeightsSyncOperation operation.
/// </summary>
public sealed record GetWeightsSyncOperationRequest
{
    public required string SessionId { get; init; }

    public required string OperationId { get; init; }
}
