namespace TogetherApIs.Requests.InstanceClusterAddOnService;

/// <summary>
/// The inputs of the InstanceClusterAddOnServiceList operation.
/// </summary>
public sealed record InstanceClusterAddOnServiceListRequest
{
    public required string ClusterId { get; init; }
}
