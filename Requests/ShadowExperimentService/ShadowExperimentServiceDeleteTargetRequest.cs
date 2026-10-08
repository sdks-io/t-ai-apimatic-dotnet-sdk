namespace TogetherApIs.Requests.ShadowExperimentService;

/// <summary>
/// The inputs of the ShadowExperimentServiceDeleteTarget operation.
/// </summary>
public sealed record ShadowExperimentServiceDeleteTargetRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public required string ExperimentId { get; init; }

    public required string Id { get; init; }

    public string? Etag { get; init; }
}
