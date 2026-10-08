using TogetherApIs.Models;

namespace TogetherApIs.Requests.Endpoints;

/// <summary>
/// The inputs of the CreateEndpoint operation.
/// </summary>
public sealed record CreateEndpointOperationRequest
{
    public required CreateEndpointRequest Body { get; init; }
}
