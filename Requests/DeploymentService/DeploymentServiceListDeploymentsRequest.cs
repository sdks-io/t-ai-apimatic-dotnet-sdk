namespace TogetherApIs.Requests.DeploymentService;

/// <summary>
/// The inputs of the DeploymentServiceListDeployments operation.
/// </summary>
public sealed record DeploymentServiceListDeploymentsRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public int? Limit { get; init; }

    public string? After { get; init; }

    public string? OrderBy { get; init; }

    public string? Filter { get; init; }
}
