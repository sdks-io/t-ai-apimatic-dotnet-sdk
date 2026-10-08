using TogetherApIs.Models;

namespace TogetherApIs.Requests.SharedVolumeService;

/// <summary>
/// The inputs of the SharedVolumeServiceUpdate operation.
/// </summary>
public sealed record SharedVolumeServiceUpdateRequest
{
    public required GpuClustersSharedVolumeUpdateRequest Body { get; init; }
}
