namespace TogetherApIs.Requests.Rl;

/// <summary>
/// The inputs of the StopTrainingSession operation.
/// </summary>
public sealed record StopTrainingSessionRequest
{
    public required string SessionId { get; init; }
}
