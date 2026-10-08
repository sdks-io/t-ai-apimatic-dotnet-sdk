namespace TogetherApIs.Requests.VolumeService;

/// <summary>
/// The inputs of the VolumeServiceListModelFiles operation.
/// </summary>
public sealed record VolumeServiceListModelFilesRequest
{
    public required string ProjectId { get; init; }

    public required string Id { get; init; }

    public string? RevisionId { get; init; }
}
