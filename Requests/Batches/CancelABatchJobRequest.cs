namespace TogetherApIs.Requests.Batches;

/// <summary>
/// The inputs of the CancelABatchJob operation.
/// </summary>
public sealed record CancelABatchJobRequest
{
    public required string Id { get; init; }
}
