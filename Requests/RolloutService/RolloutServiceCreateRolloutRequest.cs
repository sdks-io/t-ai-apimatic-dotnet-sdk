using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Requests.RolloutService;

/// <summary>
/// The inputs of the RolloutServiceCreateRollout operation.
/// </summary>
public sealed record RolloutServiceCreateRolloutRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public required DeCreateRolloutRequest3 Body { get; init; }
}
