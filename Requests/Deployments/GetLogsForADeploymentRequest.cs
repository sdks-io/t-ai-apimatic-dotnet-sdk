namespace TogetherApIs.Requests.Deployments;

/// <summary>
/// The inputs of the GetLogsForADeployment operation.
/// </summary>
public sealed record GetLogsForADeploymentRequest
{
    public required string Id { get; init; }

    public string? ReplicaId { get; init; }

    public string? Version { get; init; }

    public string? Revision { get; init; }
}
