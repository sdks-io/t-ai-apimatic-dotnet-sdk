using TogetherApIs.Models.Enums;

namespace TogetherApIs.Requests.RolloutService;

/// <summary>
/// The inputs of the RolloutServiceListRollouts operation.
/// </summary>
public sealed record RolloutServiceListRolloutsRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public int? Limit { get; init; }

    public string? After { get; init; }

    public Filter? Filter { get; init; }
}
