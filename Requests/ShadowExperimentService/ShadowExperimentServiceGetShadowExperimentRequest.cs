namespace TogetherApIs.Requests.ShadowExperimentService;

/// <summary>
/// The inputs of the ShadowExperimentServiceGetShadowExperiment operation.
/// </summary>
public sealed record ShadowExperimentServiceGetShadowExperimentRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public required string Id { get; init; }
}
