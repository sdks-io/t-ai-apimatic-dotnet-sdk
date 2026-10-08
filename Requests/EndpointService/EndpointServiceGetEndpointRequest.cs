namespace TogetherApIs.Requests.EndpointService;

/// <summary>
/// The inputs of the EndpointServiceGetEndpoint operation.
/// </summary>
public sealed record EndpointServiceGetEndpointRequest
{
    public required string ProjectId { get; init; }

    public required string Id { get; init; }
}
