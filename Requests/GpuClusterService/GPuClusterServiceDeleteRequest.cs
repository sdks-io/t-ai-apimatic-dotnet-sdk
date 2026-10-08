namespace TogetherApIs.Requests.GpuClusterService;

/// <summary>
/// The inputs of the GPuClusterServiceDelete operation.
/// </summary>
public sealed record GPuClusterServiceDeleteRequest
{
    public required string ClusterId { get; init; }
}
