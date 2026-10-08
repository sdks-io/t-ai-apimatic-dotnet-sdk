using TogetherApIs.Models;

namespace TogetherApIs.Requests.ShadowExperimentService;

/// <summary>
/// The inputs of the ShadowExperimentServiceUpdateShadowExperiment operation.
/// </summary>
public sealed record ShadowExperimentServiceUpdateShadowExperimentRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public required string Id { get; init; }

    public required string UpdateMask { get; init; }

    public required DeUpdateShadowExperimentRequest Body { get; init; }
}
