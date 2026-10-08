using TogetherApIs.Models;

namespace TogetherApIs.Requests.Batches;

/// <summary>
/// The inputs of the CreateABatchJob operation.
/// </summary>
public sealed record CreateABatchJobRequest
{
    public required CreateBatchRequest Body { get; init; }
}
