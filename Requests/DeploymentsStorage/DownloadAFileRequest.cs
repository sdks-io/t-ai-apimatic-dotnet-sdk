namespace TogetherApIs.Requests.DeploymentsStorage;

/// <summary>
/// The inputs of the DownloadAFile operation.
/// </summary>
public sealed record DownloadAFileRequest
{
    public required string Filename { get; init; }
}
