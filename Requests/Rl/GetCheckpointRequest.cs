namespace TogetherApIs.Requests.Rl;

/// <summary>
/// The inputs of the GetCheckpoint operation.
/// </summary>
public sealed record GetCheckpointRequest
{
    public required string Id { get; init; }
}
