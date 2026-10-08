using TogetherApIs.Models;

namespace TogetherApIs.Requests.ShadowExperimentService;

/// <summary>
/// The inputs of the ShadowExperimentServiceCreateShadowExperiment operation.
/// </summary>
public sealed record ShadowExperimentServiceCreateShadowExperimentRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public required DeCreateShadowExperimentRequest Body { get; init; }
}
