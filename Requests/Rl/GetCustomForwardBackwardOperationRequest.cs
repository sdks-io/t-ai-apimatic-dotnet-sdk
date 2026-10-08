namespace TogetherApIs.Requests.Rl;

/// <summary>
/// The inputs of the GetCustomForwardBackwardOperation operation.
/// </summary>
public sealed record GetCustomForwardBackwardOperationRequest
{
    public required string SessionId { get; init; }

    public required string OperationId { get; init; }
}
