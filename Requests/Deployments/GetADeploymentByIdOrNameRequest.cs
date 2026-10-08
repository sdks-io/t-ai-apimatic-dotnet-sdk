namespace TogetherApIs.Requests.Deployments;

/// <summary>
/// The inputs of the GetADeploymentByIdOrName operation.
/// </summary>
public sealed record GetADeploymentByIdOrNameRequest
{
    public required string Id { get; init; }
}
