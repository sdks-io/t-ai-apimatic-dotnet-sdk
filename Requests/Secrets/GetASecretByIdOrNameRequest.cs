namespace TogetherApIs.Requests.Secrets;

/// <summary>
/// The inputs of the GetASecretByIdOrName operation.
/// </summary>
public sealed record GetASecretByIdOrNameRequest
{
    public required string Id { get; init; }
}
