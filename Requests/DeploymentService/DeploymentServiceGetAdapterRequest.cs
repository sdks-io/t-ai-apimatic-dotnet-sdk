namespace TogetherApIs.Requests.DeploymentService;

/// <summary>
/// The inputs of the DeploymentServiceGetAdapter operation.
/// </summary>
public sealed record DeploymentServiceGetAdapterRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public required string DeploymentId { get; init; }

    public required string Id { get; init; }
}
