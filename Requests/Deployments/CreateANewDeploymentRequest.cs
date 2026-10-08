using TogetherApIs.Models;

namespace TogetherApIs.Requests.Deployments;

/// <summary>
/// The inputs of the CreateANewDeployment operation.
/// </summary>
public sealed record CreateANewDeploymentRequest
{
    /// <summary>
    /// Deployment configuration
    /// </summary>
    public required CreateDeploymentRequest Body { get; init; }
}
