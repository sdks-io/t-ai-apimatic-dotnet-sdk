using TogetherApIs.Models;

namespace TogetherApIs.Requests.RolloutService;

/// <summary>
/// The inputs of the RolloutServicePauseRollout operation.
/// </summary>
public sealed record RolloutServicePauseRolloutRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public required string Id { get; init; }

    public required DePauseRolloutRequest Body { get; init; }
}
