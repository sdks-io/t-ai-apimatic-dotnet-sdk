namespace TogetherApIs.Requests.EndpointService;

/// <summary>
/// The inputs of the EndpointServiceDeleteEndpoint operation.
/// </summary>
public sealed record EndpointServiceDeleteEndpointRequest
{
    public required string ProjectId { get; init; }

    public required string Id { get; init; }

    public string? Etag { get; init; }
}
