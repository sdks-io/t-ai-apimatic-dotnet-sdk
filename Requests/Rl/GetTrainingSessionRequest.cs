namespace TogetherApIs.Requests.Rl;

/// <summary>
/// The inputs of the GetTrainingSession operation.
/// </summary>
public sealed record GetTrainingSessionRequest
{
    public required string SessionId { get; init; }
}
