namespace TogetherApIs.Requests.Rl;

/// <summary>
/// The inputs of the CreateInferenceCheckpoint operation.
/// </summary>
public sealed record CreateInferenceCheckpointRequest
{
    public required string SessionId { get; init; }

    public required string IdempotencyKey { get; init; }
}
