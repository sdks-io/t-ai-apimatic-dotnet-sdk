using TogetherApIs.Models;

namespace TogetherApIs.Requests.InstanceClusterAddOnService;

/// <summary>
/// The inputs of the InstanceClusterAddOnServiceUpdate operation.
/// </summary>
public sealed record InstanceClusterAddOnServiceUpdateRequest
{
    public required string ClusterId { get; init; }

    public required string AddonId { get; init; }

    public required ClusterAddOnUpdateRequest Body { get; init; }
}
