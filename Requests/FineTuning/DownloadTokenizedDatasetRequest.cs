namespace TogetherApIs.Requests.FineTuning;

/// <summary>
/// The inputs of the DownloadTokenizedDataset operation.
/// </summary>
public sealed record DownloadTokenizedDatasetRequest
{
    public required string Id { get; init; }
}
