namespace TogetherApIs.Requests.Files;

/// <summary>
/// The inputs of the RetrieveFileMetadata operation.
/// </summary>
public sealed record RetrieveFileMetadataRequest
{
    public required string Id { get; init; }
}
