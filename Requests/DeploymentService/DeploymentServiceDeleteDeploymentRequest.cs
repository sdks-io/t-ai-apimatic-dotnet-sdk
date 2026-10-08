namespace TogetherApIs.Requests.DeploymentService;

/// <summary>
/// The inputs of the DeploymentServiceDeleteDeployment operation.
/// </summary>
public sealed record DeploymentServiceDeleteDeploymentRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public required string Id { get; init; }

    public string? Etag { get; init; }
}
