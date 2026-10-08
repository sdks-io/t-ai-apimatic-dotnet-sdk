namespace TogetherApIs.Requests.FineTuning;

/// <summary>
/// The inputs of the ListJob operation.
/// </summary>
public sealed record ListJobRequest
{
    public required string Id { get; init; }
}
