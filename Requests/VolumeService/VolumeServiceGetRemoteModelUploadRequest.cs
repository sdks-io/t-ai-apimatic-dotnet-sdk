namespace TogetherApIs.Requests.VolumeService;

/// <summary>
/// The inputs of the VolumeServiceGetRemoteModelUpload operation.
/// </summary>
public sealed record VolumeServiceGetRemoteModelUploadRequest
{
    public required string ProjectId { get; init; }

    public required string Id { get; init; }
}
