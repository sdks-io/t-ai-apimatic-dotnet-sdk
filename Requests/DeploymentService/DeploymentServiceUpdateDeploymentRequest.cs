using TogetherApIs.Models;

namespace TogetherApIs.Requests.DeploymentService;

/// <summary>
/// The inputs of the DeploymentServiceUpdateDeployment operation.
/// </summary>
public sealed record DeploymentServiceUpdateDeploymentRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public required string Id { get; init; }

    public string? UpdateMask { get; init; }

    public required DeUpdateDeploymentRequest Body { get; init; }
}
