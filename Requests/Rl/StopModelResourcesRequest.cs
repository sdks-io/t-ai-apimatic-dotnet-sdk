namespace TogetherApIs.Requests.Rl;

/// <summary>
/// The inputs of the StopModelResources operation.
/// </summary>
public sealed record StopModelResourcesRequest
{
    public required string ModelResourcesId { get; init; }

    public bool Force { get; init; } = false;
}
