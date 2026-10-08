namespace TogetherApIs.Requests.InstanceClusterAddOnService;

/// <summary>
/// The inputs of the InstanceClusterAddOnServiceDelete operation.
/// </summary>
public sealed record InstanceClusterAddOnServiceDeleteRequest
{
    public required string ClusterId { get; init; }

    public required string AddonId { get; init; }
}
