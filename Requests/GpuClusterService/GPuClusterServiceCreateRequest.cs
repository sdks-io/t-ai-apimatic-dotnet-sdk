using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Requests.GpuClusterService;

/// <summary>
/// The inputs of the GPuClusterServiceCreate operation.
/// </summary>
public sealed record GPuClusterServiceCreateRequest
{
    public required GpuClusterCreateRequest2 Body { get; init; }
}
