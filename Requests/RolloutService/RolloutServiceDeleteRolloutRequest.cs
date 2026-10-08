namespace TogetherApIs.Requests.RolloutService;

/// <summary>
/// The inputs of the RolloutServiceDeleteRollout operation.
/// </summary>
public sealed record RolloutServiceDeleteRolloutRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public required string Id { get; init; }

    public string? Etag { get; init; }
}
