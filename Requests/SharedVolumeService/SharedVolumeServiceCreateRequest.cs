using TogetherApIs.Models;

namespace TogetherApIs.Requests.SharedVolumeService;

/// <summary>
/// The inputs of the SharedVolumeServiceCreate operation.
/// </summary>
public sealed record SharedVolumeServiceCreateRequest
{
    public required GpuClustersSharedVolumeCreateRequest Body { get; init; }
}
