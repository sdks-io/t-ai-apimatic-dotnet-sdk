namespace TogetherApIs.Requests.DeploymentsStorage;

/// <summary>
/// The inputs of the GetAFileDownloadUrl operation.
/// </summary>
public sealed record GetAFileDownloadUrlRequest
{
    public required string Filename { get; init; }
}
