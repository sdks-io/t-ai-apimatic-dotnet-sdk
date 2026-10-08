using TogetherApIs.Models;

namespace TogetherApIs.Requests.ShadowExperimentService;

/// <summary>
/// The inputs of the ShadowExperimentServiceUpdateTarget operation.
/// </summary>
public sealed record ShadowExperimentServiceUpdateTargetRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public required string ExperimentId { get; init; }

    public required string Id { get; init; }

    public required string UpdateMask { get; init; }

    public required DeUpdateShadowExperimentTargetRequest Body { get; init; }
}
