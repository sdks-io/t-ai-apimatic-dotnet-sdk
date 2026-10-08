namespace TogetherApIs.Requests.Jobs;

/// <summary>
/// The inputs of the GetJob operation.
/// </summary>
public sealed record GetJobRequest
{
    public required string JobId { get; init; }
}
