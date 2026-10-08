namespace TogetherApIs.Requests.ShadowExperimentService;

/// <summary>
/// The inputs of the ShadowExperimentServiceGetTarget operation.
/// </summary>
public sealed record ShadowExperimentServiceGetTargetRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public required string ExperimentId { get; init; }

    public required string Id { get; init; }
}
