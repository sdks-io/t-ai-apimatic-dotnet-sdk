namespace TogetherApIs.Requests.InstanceClusterAddOnService;

/// <summary>
/// The inputs of the InstanceClusterAddOnServiceGet operation.
/// </summary>
public sealed record InstanceClusterAddOnServiceGetRequest
{
    public required string ClusterId { get; init; }

    public required string AddonId { get; init; }
}
