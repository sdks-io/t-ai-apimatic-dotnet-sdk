using TogetherApIs.Models;

namespace TogetherApIs.Requests.QueueApi;

/// <summary>
/// The inputs of the CancelQueueJob operation.
/// </summary>
public sealed record CancelQueueJobRequest
{
    /// <summary>
    /// Cancel request
    /// </summary>
    public required QueueCancelRequest Body { get; init; }
}
