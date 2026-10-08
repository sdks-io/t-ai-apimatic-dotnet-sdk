namespace TogetherApIs.Requests.FineTuning;

/// <summary>
/// The inputs of the CancelJob operation.
/// </summary>
public sealed record CancelJobRequest
{
    public required string Id { get; init; }
}
