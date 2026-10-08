namespace TogetherApIs.Requests.GpuClusterService;

/// <summary>
/// The inputs of the GPuClusterServiceList operation.
/// </summary>
public sealed record GPuClusterServiceListRequest
{
    public string? ProjectId { get; init; }
}
