namespace TogetherApIs.Requests.ShadowExperimentService;

/// <summary>
/// The inputs of the ShadowExperimentServiceListShadowExperiments operation.
/// </summary>
public sealed record ShadowExperimentServiceListShadowExperimentsRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public int? Limit { get; init; }

    public string? After { get; init; }

    public bool? IncludeTargets { get; init; }
}
