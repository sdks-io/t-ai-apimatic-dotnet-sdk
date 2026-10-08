using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Requests.RolloutService;

/// <summary>
/// The inputs of the RolloutServicePreviewRolloutDefaults operation.
/// </summary>
public sealed record RolloutServicePreviewRolloutDefaultsRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public required DeCreateRolloutRequest3 Body { get; init; }
}
