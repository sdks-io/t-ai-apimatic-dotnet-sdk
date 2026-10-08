namespace TogetherApIs.Requests.DeploymentService;

/// <summary>
/// The inputs of the DeploymentServiceRemoveAdapter operation.
/// </summary>
public sealed record DeploymentServiceRemoveAdapterRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public required string DeploymentId { get; init; }

    public required string Id { get; init; }

    public required string Etag { get; init; }
}
