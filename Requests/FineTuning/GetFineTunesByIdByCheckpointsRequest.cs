namespace TogetherApIs.Requests.FineTuning;

/// <summary>
/// The inputs of the GetFineTunesByIdByCheckpoints operation.
/// </summary>
public sealed record GetFineTunesByIdByCheckpointsRequest
{
    public required string Id { get; init; }
}
