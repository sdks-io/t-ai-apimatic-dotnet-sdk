using TogetherApIs.Models;

namespace TogetherApIs.Requests.VolumeService;

/// <summary>
/// The inputs of the VolumeServiceCreateRemoteModelUpload operation.
/// </summary>
public sealed record VolumeServiceCreateRemoteModelUploadRequest
{
    public required string ProjectId { get; init; }

    public required DeCreateRemoteUploadSpec Body { get; init; }
}
