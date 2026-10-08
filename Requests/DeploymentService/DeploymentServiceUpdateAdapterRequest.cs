using TogetherApIs.Models;

namespace TogetherApIs.Requests.DeploymentService;

/// <summary>
/// The inputs of the DeploymentServiceUpdateAdapter operation.
/// </summary>
public sealed record DeploymentServiceUpdateAdapterRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public required string DeploymentId { get; init; }

    public required string Id { get; init; }

    public required DeUpdateAdapterRequest Body { get; init; }
}
