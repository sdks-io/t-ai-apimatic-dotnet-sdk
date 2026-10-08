using TogetherApIs.Models;

namespace TogetherApIs.Requests.Endpoints;

/// <summary>
/// The inputs of the RemoveAdapter operation.
/// </summary>
public sealed record RemoveAdapterRequest
{
    /// <summary>
    /// The endpoint ID
    /// </summary>
    public required string EndpointId { get; init; }

    public required EndpointsAdaptersRequest Body { get; init; }
}
