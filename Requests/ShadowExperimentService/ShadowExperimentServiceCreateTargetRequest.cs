using TogetherApIs.Models;

namespace TogetherApIs.Requests.ShadowExperimentService;

/// <summary>
/// The inputs of the ShadowExperimentServiceCreateTarget operation.
/// </summary>
public sealed record ShadowExperimentServiceCreateTargetRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public required string ExperimentId { get; init; }

    public required DeCreateShadowExperimentTargetRequest Body { get; init; }
}
