namespace TogetherApIs.Requests.QueueApi;

/// <summary>
/// The inputs of the GetQueueJobStatus operation.
/// </summary>
public sealed record GetQueueJobStatusRequest
{
    public required string RequestId { get; init; }

    public required string Model { get; init; }
}
