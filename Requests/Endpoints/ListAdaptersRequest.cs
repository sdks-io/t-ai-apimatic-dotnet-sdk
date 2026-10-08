namespace TogetherApIs.Requests.Endpoints;

/// <summary>
/// The inputs of the ListAdapters operation.
/// </summary>
public sealed record ListAdaptersRequest
{
    /// <summary>
    /// The endpoint ID
    /// </summary>
    public required string EndpointId { get; init; }
}
