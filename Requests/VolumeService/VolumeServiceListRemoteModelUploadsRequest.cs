namespace TogetherApIs.Requests.VolumeService;

/// <summary>
/// The inputs of the VolumeServiceListRemoteModelUploads operation.
/// </summary>
public sealed record VolumeServiceListRemoteModelUploadsRequest
{
    public required string ProjectId { get; init; }

    public int? Limit { get; init; }

    public string? After { get; init; }
}
