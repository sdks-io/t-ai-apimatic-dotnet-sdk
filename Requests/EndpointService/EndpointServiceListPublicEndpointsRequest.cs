namespace TogetherApIs.Requests.EndpointService;

/// <summary>
/// The inputs of the EndpointServiceListPublicEndpoints operation.
/// </summary>
public sealed record EndpointServiceListPublicEndpointsRequest
{
    public int? Limit { get; init; }

    public string? After { get; init; }

    public string? OrderBy { get; init; }

    public string? Filter { get; init; }
}
