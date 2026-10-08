using TogetherApIs.Models;

namespace TogetherApIs.Requests.Secrets;

/// <summary>
/// The inputs of the UpdateASecret operation.
/// </summary>
public sealed record UpdateASecretRequest
{
    public required string Id { get; init; }

    /// <summary>
    /// Updated secret configuration
    /// </summary>
    public required UpdateSecretRequest Body { get; init; }
}
