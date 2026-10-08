namespace TogetherApIs.Requests.FineTuning;

/// <summary>
/// The inputs of the ListJobEvents operation.
/// </summary>
public sealed record ListJobEventsRequest
{
    public required string Id { get; init; }
}
