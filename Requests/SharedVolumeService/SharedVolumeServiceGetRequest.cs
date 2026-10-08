namespace TogetherApIs.Requests.SharedVolumeService;

/// <summary>
/// The inputs of the SharedVolumeServiceGet operation.
/// </summary>
public sealed record SharedVolumeServiceGetRequest
{
    public required string VolumeId { get; init; }
}
