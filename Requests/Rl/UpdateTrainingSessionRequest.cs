using TogetherApIs.Models;

namespace TogetherApIs.Requests.Rl;

/// <summary>
/// The inputs of the UpdateTrainingSession operation.
/// </summary>
public sealed record UpdateTrainingSessionRequest
{
    public required string SessionId { get; init; }

    public required RlUpdateTrainingSessionRequest Body { get; init; }
}
