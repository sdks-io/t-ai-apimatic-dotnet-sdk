using TogetherApIs.Models;

namespace TogetherApIs.Requests.Deployments;

/// <summary>
/// The inputs of the UpdateADeployment operation.
/// </summary>
public sealed record UpdateADeploymentRequest
{
    public required string Id { get; init; }

    /// <summary>
    /// Updated deployment configuration
    /// </summary>
    public required UpdateDeploymentRequest Body { get; init; }
}
