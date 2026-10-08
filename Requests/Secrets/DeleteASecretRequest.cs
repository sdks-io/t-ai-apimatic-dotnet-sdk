namespace TogetherApIs.Requests.Secrets;

/// <summary>
/// The inputs of the DeleteASecret operation.
/// </summary>
public sealed record DeleteASecretRequest
{
    public required string Id { get; init; }
}
