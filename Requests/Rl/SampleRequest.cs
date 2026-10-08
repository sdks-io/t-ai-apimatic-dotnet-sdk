using TogetherApIs.Models;

namespace TogetherApIs.Requests.Rl;

/// <summary>
/// The inputs of the Sample operation.
/// </summary>
public sealed record SampleRequest
{
    public required string SessionId { get; init; }

    public required string IdempotencyKey { get; init; }

    public required RlSampleBody Body { get; init; }
}
