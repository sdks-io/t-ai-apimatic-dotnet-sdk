namespace TogetherApIs.Requests.DeploymentService;

/// <summary>
/// The inputs of the DeploymentServiceListAdapters operation.
/// </summary>
public sealed record DeploymentServiceListAdaptersRequest
{
    public required string ProjectId { get; init; }

    public required string EndpointId { get; init; }

    public required string DeploymentId { get; init; }

    public int? Limit { get; init; }

    public string? After { get; init; }
}
