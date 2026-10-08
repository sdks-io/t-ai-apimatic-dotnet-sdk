using TogetherApIs.Models;

namespace TogetherApIs.Requests.QueueApi;

/// <summary>
/// The inputs of the ClearQueue operation.
/// </summary>
public sealed record ClearQueueRequest
{
    /// <summary>
    /// Clear request
    /// </summary>
    public required QueueClearRequest Body { get; init; }
}
