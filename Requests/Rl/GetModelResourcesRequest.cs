namespace TogetherApIs.Requests.Rl;

/// <summary>
/// The inputs of the GetModelResources operation.
/// </summary>
public sealed record GetModelResourcesRequest
{
    public required string ModelResourcesId { get; init; }
}
