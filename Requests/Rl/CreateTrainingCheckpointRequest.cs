namespace TogetherApIs.Requests.Rl;

/// <summary>
/// The inputs of the CreateTrainingCheckpoint operation.
/// </summary>
public sealed record CreateTrainingCheckpointRequest
{
    public required string SessionId { get; init; }

    public required string IdempotencyKey { get; init; }
}
