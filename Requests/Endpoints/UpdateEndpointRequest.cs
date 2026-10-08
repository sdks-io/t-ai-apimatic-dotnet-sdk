using TogetherApIs.Models;

namespace TogetherApIs.Requests.Endpoints;

/// <summary>
/// The inputs of the UpdateEndpoint operation.
/// </summary>
public sealed record UpdateEndpointRequest
{
    public required string EndpointId { get; init; }

    public required EndpointsRequest Body { get; init; }
}
