using TogetherApIs.Models;

namespace TogetherApIs.Requests.QueueApi;

/// <summary>
/// The inputs of the SubmitQueueJob operation.
/// </summary>
public sealed record SubmitQueueJobRequest
{
    /// <summary>
    /// Job request
    /// </summary>
    public required QueueJobRequest Body { get; init; }
}
