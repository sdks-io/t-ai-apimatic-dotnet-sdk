namespace TogetherApIs.Requests.Files;

/// <summary>
/// The inputs of the DeleteAFile operation.
/// </summary>
public sealed record DeleteAFileRequest
{
    public required string Id { get; init; }
}
