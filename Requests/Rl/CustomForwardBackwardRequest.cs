using TogetherApIs.Models;

namespace TogetherApIs.Requests.Rl;

/// <summary>
/// The inputs of the CustomForwardBackward operation.
/// </summary>
public sealed record CustomForwardBackwardRequest
{
    public required string SessionId { get; init; }

    public required string IdempotencyKey { get; init; }

    public required RlCustomForwardBackwardBody Body { get; init; }
}
