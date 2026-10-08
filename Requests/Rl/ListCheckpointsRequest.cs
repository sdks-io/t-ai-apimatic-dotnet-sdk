namespace TogetherApIs.Requests.Rl;

/// <summary>
/// The inputs of the ListCheckpoints operation.
/// </summary>
public sealed record ListCheckpointsRequest
{
    public string? SessionId { get; init; }

    public string? BaseModel { get; init; }

    public int Limit { get; init; } = 20;

    public string? After { get; init; }
}
