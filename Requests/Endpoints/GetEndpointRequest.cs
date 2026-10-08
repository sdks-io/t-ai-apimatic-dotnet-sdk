namespace TogetherApIs.Requests.Endpoints;

/// <summary>
/// The inputs of the GetEndpoint operation.
/// </summary>
public sealed record GetEndpointRequest
{
    public required string EndpointId { get; init; }
}
