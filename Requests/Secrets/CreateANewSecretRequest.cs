using TogetherApIs.Models;

namespace TogetherApIs.Requests.Secrets;

/// <summary>
/// The inputs of the CreateANewSecret operation.
/// </summary>
public sealed record CreateANewSecretRequest
{
    /// <summary>
    /// Secret configuration
    /// </summary>
    public required CreateSecretRequest Body { get; init; }
}
