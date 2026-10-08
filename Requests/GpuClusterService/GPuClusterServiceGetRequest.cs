namespace TogetherApIs.Requests.GpuClusterService;

/// <summary>
/// The inputs of the GPuClusterServiceGet operation.
/// </summary>
public sealed record GPuClusterServiceGetRequest
{
    public required string ClusterId { get; init; }
}
