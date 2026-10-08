namespace TogetherApIs.Requests.Deployments;

/// <summary>
/// The inputs of the DeleteADeployment operation.
/// </summary>
public sealed record DeleteADeploymentRequest
{
    public required string Id { get; init; }
}
