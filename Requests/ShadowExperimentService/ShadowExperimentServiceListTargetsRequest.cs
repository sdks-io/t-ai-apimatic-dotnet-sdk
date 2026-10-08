namespace TogetherApIs.Requests.ShadowExperimentService;

/// <summary>
/// The inputs of the ShadowExperimentServiceListTargets operation.
/// </summary>
public sealed record ShadowExperimentServiceListTargetsRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public required string ExperimentId { get; init; }

    public int? Limit { get; init; }

    public string? After { get; init; }
}
