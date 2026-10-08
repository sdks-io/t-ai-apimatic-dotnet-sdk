namespace TogetherApIs.Requests.AbExperimentService;

/// <summary>
/// The inputs of the AbExperimentServiceDeleteAbExperiment operation.
/// </summary>
public sealed record AbExperimentServiceDeleteAbExperimentRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public required string Id { get; init; }

    public string? Etag { get; init; }
}
