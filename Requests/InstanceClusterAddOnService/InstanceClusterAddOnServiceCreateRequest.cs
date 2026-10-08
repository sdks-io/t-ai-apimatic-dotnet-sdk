using TogetherApIs.Models;

namespace TogetherApIs.Requests.InstanceClusterAddOnService;

/// <summary>
/// The inputs of the InstanceClusterAddOnServiceCreate operation.
/// </summary>
public sealed record InstanceClusterAddOnServiceCreateRequest
{
    public required string ClusterId { get; init; }

    public required ClusterAddOnCreateRequest Body { get; init; }
}
