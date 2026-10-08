using TogetherApIs.Models;

namespace TogetherApIs.Requests.GpuClusterService;

/// <summary>
/// The inputs of the GPuClusterServiceUpdate operation.
/// </summary>
public sealed record GPuClusterServiceUpdateRequest
{
    public required string ClusterId { get; init; }

    public required GpuClusterUpdateRequest Body { get; init; }
}
