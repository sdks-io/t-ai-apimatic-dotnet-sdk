using TogetherApIs.Models.Enums;

namespace TogetherApIs.Requests.Endpoints;

/// <summary>
/// The inputs of the ListEndpoints operation.
/// </summary>
public sealed record ListEndpointsRequest
{
    public Type18? Type { get; init; }

    public UsageType? UsageType { get; init; }

    public bool? Mine { get; init; }
}
