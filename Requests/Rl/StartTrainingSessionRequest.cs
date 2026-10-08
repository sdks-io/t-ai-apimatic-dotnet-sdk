using TogetherApIs.Models;

namespace TogetherApIs.Requests.Rl;

/// <summary>
/// The inputs of the StartTrainingSession operation.
/// </summary>
public sealed record StartTrainingSessionRequest
{
    public required RlStartTrainingSessionRequest Body { get; init; }
}
