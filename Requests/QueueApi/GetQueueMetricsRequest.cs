namespace TogetherApIs.Requests.QueueApi;

/// <summary>
/// The inputs of the GetQueueMetrics operation.
/// </summary>
public sealed record GetQueueMetricsRequest
{
    public required string Model { get; init; }
}
