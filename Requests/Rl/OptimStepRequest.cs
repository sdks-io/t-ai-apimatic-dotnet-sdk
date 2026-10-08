using TogetherApIs.Models;

namespace TogetherApIs.Requests.Rl;

/// <summary>
/// The inputs of the OptimStep operation.
/// </summary>
public sealed record OptimStepRequest
{
    public required string SessionId { get; init; }

    public required string IdempotencyKey { get; init; }

    public required RlOptimStepBody Body { get; init; }
}
