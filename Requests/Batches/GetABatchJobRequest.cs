namespace TogetherApIs.Requests.Batches;

/// <summary>
/// The inputs of the GetABatchJob operation.
/// </summary>
public sealed record GetABatchJobRequest
{
    public required string Id { get; init; }
}
