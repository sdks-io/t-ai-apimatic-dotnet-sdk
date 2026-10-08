using TogetherApIs.Models;

namespace TogetherApIs.Requests.FineTuning;

/// <summary>
/// The inputs of the CreateJob operation.
/// </summary>
public sealed record CreateJobRequest
{
    public required FineTunesRequest Body { get; init; }
}
