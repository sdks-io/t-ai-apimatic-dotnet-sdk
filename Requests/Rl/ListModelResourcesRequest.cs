using System.Collections.Generic;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Requests.Rl;

/// <summary>
/// The inputs of the ListModelResources operation.
/// </summary>
public sealed record ListModelResourcesRequest
{
    public IReadOnlyList<Status12>? Status { get; init; }

    public int Limit { get; init; } = 20;

    public string? After { get; init; }

    public string? CreatedBy { get; init; }
}
