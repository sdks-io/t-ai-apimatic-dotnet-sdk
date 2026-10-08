using TogetherApIs.Models;

namespace TogetherApIs.Requests.Rl;

/// <summary>
/// The inputs of the CreateModelResources operation.
/// </summary>
public sealed record CreateModelResourcesRequest
{
    public required RlCreateModelResourcesRequest Body { get; init; }
}
