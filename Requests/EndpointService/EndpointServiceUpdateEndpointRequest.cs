using TogetherApIs.Models;

namespace TogetherApIs.Requests.EndpointService;

/// <summary>
/// The inputs of the EndpointServiceUpdateEndpoint operation.
/// </summary>
public sealed record EndpointServiceUpdateEndpointRequest
{
    public required string ProjectId { get; init; }

    public required string Id { get; init; }

    public string? UpdateMask { get; init; }

    public required DeEndpointUpdate Body { get; init; }
}
