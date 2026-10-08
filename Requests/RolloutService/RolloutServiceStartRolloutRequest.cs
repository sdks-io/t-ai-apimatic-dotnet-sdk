namespace TogetherApIs.Requests.RolloutService;

/// <summary>
/// The inputs of the RolloutServiceStartRollout operation.
/// </summary>
public sealed record RolloutServiceStartRolloutRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public required string Id { get; init; }
}
