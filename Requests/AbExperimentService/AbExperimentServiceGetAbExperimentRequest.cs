namespace TogetherApIs.Requests.AbExperimentService;

/// <summary>
/// The inputs of the AbExperimentServiceGetAbExperiment operation.
/// </summary>
public sealed record AbExperimentServiceGetAbExperimentRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public required string Id { get; init; }
}
