using TogetherApIs.Models;

namespace TogetherApIs.Requests.DeploymentService;

/// <summary>
/// The inputs of the DeploymentServiceAddAdapter operation.
/// </summary>
public sealed record DeploymentServiceAddAdapterRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public required string DeploymentId { get; init; }

    public required DeAddAdapterRequest Body { get; init; }
}
