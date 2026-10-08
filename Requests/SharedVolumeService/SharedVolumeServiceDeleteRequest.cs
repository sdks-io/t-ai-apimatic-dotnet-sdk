namespace TogetherApIs.Requests.SharedVolumeService;

/// <summary>
/// The inputs of the SharedVolumeServiceDelete operation.
/// </summary>
public sealed record SharedVolumeServiceDeleteRequest
{
    public required string VolumeId { get; init; }
}
