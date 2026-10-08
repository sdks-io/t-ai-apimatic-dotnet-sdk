using TogetherApIs.Models;

namespace TogetherApIs.Requests.RolloutService;

/// <summary>
/// The inputs of the RolloutServiceResumeRollout operation.
/// </summary>
public sealed record RolloutServiceResumeRolloutRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public required string Id { get; init; }

    public required DeResumeRolloutRequest Body { get; init; }
}
