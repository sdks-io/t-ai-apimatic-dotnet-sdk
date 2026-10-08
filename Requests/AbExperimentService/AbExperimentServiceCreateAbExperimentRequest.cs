using TogetherApIs.Models;

namespace TogetherApIs.Requests.AbExperimentService;

/// <summary>
/// The inputs of the AbExperimentServiceCreateAbExperiment operation.
/// </summary>
public sealed record AbExperimentServiceCreateAbExperimentRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public required DeCreateAbExperimentRequest Body { get; init; }
}
