using TogetherApIs.Models;

namespace TogetherApIs.Requests.Rl;

/// <summary>
/// The inputs of the WeightsSync operation.
/// </summary>
public sealed record WeightsSyncRequest
{
    public required string SessionId { get; init; }

    public required string IdempotencyKey { get; init; }

    public required RlWeightsSyncBody Body { get; init; }
}
