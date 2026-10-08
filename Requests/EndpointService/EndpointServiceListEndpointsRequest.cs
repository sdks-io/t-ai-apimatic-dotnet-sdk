namespace TogetherApIs.Requests.EndpointService;

/// <summary>
/// The inputs of the EndpointServiceListEndpoints operation.
/// </summary>
public sealed record EndpointServiceListEndpointsRequest
{
    public required string ProjectId { get; init; }

    public int Limit { get; init; } = 50;

    public string? After { get; init; }

    public string? OrderBy { get; init; }

    public string? Filter { get; init; }
}
