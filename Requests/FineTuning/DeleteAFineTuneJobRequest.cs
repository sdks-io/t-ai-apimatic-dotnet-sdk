namespace TogetherApIs.Requests.FineTuning;

/// <summary>
/// The inputs of the DeleteAFineTuneJob operation.
/// </summary>
public sealed record DeleteAFineTuneJobRequest
{
    public required string Id { get; init; }

    public bool Force { get; init; } = false;
}
