using TogetherApIs.Models;

namespace TogetherApIs.Requests.Deployments;

/// <summary>
/// The inputs of the RollBackADeploymentToAPreviousRevision operation.
/// </summary>
public sealed record RollBackADeploymentToAPreviousRevisionRequest
{
    public required string Id { get; init; }

    /// <summary>
    /// Revision identifier (revision number or UUID)
    /// </summary>
    public required RollbackDeploymentRequest Body { get; init; }
}
