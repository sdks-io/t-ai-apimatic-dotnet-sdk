namespace TogetherApIs.Requests.Rl;

/// <summary>
/// The inputs of the GetForwardBackwardOperation operation.
/// </summary>
public sealed record GetForwardBackwardOperationRequest
{
    public required string SessionId { get; init; }

    public required string OperationId { get; init; }
}
