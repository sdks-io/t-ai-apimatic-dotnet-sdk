using TogetherApIs.Models;

namespace TogetherApIs.Requests.DeploymentService;

/// <summary>
/// The inputs of the DeploymentServiceCreateDeployment operation.
/// </summary>
public sealed record DeploymentServiceCreateDeploymentRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public bool? ValidateOnly { get; init; }

    public required DeCreateDeploymentRequest Body { get; init; }
}
