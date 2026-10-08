namespace TogetherApIs.Requests.ShadowExperimentService;

/// <summary>
/// The inputs of the ShadowExperimentServiceDeleteShadowExperiment operation.
/// </summary>
public sealed record ShadowExperimentServiceDeleteShadowExperimentRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public required string Id { get; init; }

    public string? Etag { get; init; }
}
