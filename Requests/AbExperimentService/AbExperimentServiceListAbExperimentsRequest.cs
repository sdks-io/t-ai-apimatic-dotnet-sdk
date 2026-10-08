namespace TogetherApIs.Requests.AbExperimentService;

/// <summary>
/// The inputs of the AbExperimentServiceListAbExperiments operation.
/// </summary>
public sealed record AbExperimentServiceListAbExperimentsRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public int? Limit { get; init; }

    public string? After { get; init; }
}
