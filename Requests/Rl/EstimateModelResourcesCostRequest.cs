using TogetherApIs.Models;

namespace TogetherApIs.Requests.Rl;

/// <summary>
/// The inputs of the EstimateModelResourcesCost operation.
/// </summary>
public sealed record EstimateModelResourcesCostRequest
{
    public required RlCreateModelResourcesRequest Body { get; init; }
}
