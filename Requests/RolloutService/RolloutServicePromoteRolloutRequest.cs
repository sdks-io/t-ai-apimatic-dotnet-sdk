using TogetherApIs.Models;

namespace TogetherApIs.Requests.RolloutService;

/// <summary>
/// The inputs of the RolloutServicePromoteRollout operation.
/// </summary>
public sealed record RolloutServicePromoteRolloutRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public required string Id { get; init; }

    public required DePromoteRolloutRequest Body { get; init; }
}
