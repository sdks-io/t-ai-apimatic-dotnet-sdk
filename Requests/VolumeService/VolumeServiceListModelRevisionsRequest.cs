namespace TogetherApIs.Requests.VolumeService;

/// <summary>
/// The inputs of the VolumeServiceListModelRevisions operation.
/// </summary>
public sealed record VolumeServiceListModelRevisionsRequest
{
    public required string ProjectId { get; init; }

    public required string Id { get; init; }
}
