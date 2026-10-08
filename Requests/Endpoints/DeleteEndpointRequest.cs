namespace TogetherApIs.Requests.Endpoints;

/// <summary>
/// The inputs of the DeleteEndpoint operation.
/// </summary>
public sealed record DeleteEndpointRequest
{
    public required string EndpointId { get; init; }
}
