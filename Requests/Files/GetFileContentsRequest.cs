namespace TogetherApIs.Requests.Files;

/// <summary>
/// The inputs of the GetFileContents operation.
/// </summary>
public sealed record GetFileContentsRequest
{
    public required string Id { get; init; }
}
