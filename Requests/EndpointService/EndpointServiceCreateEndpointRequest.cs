using TogetherApIs.Models;

namespace TogetherApIs.Requests.EndpointService;

/// <summary>
/// The inputs of the EndpointServiceCreateEndpoint operation.
/// </summary>
public sealed record EndpointServiceCreateEndpointRequest
{
    public required string ProjectId { get; init; }

    public required DeCreateEndpointRequest Body { get; init; }
}
