namespace TogetherApIs.Requests.Rl;

/// <summary>
/// The inputs of the GetOptimStepOperation operation.
/// </summary>
public sealed record GetOptimStepOperationRequest
{
    public required string SessionId { get; init; }

    public required string OperationId { get; init; }
}
