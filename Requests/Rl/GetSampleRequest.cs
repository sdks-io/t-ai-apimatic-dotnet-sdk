namespace TogetherApIs.Requests.Rl;

/// <summary>
/// The inputs of the GetSample operation.
/// </summary>
public sealed record GetSampleRequest
{
    public required string SessionId { get; init; }

    public required string OperationId { get; init; }
}
