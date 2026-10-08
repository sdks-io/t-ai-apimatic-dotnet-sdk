namespace TogetherApIs.Requests.EndpointService;

/// <summary>
/// The inputs of the EndpointServiceListOrganizationEndpoints operation.
/// </summary>
public sealed record EndpointServiceListOrganizationEndpointsRequest
{
    public required string OrganizationId { get; init; }

    public int? Limit { get; init; }

    public string? After { get; init; }

    public string? OrderBy { get; init; }

    public string? Filter { get; init; }
}
