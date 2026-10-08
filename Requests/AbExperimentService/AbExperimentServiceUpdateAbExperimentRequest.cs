using TogetherApIs.Models;

namespace TogetherApIs.Requests.AbExperimentService;

/// <summary>
/// The inputs of the AbExperimentServiceUpdateAbExperiment operation.
/// </summary>
public sealed record AbExperimentServiceUpdateAbExperimentRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public required string Id { get; init; }

    public string? UpdateMask { get; init; }

    public required DeUpdateAbExperimentRequest Body { get; init; }
}
