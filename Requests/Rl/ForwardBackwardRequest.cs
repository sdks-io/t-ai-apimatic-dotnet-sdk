using TogetherApIs.Models;

namespace TogetherApIs.Requests.Rl;

/// <summary>
/// The inputs of the ForwardBackward operation.
/// </summary>
public sealed record ForwardBackwardRequest
{
    public required string SessionId { get; init; }

    public required string IdempotencyKey { get; init; }

    public required RlForwardBackwardBody Body { get; init; }
}
