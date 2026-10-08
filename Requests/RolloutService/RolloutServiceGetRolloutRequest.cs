namespace TogetherApIs.Requests.RolloutService;

/// <summary>
/// The inputs of the RolloutServiceGetRollout operation.
/// </summary>
public sealed record RolloutServiceGetRolloutRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public required string Id { get; init; }
}
