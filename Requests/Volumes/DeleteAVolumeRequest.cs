namespace TogetherApIs.Requests.Volumes;

/// <summary>
/// The inputs of the DeleteAVolume operation.
/// </summary>
public sealed record DeleteAVolumeRequest
{
    public required string Id { get; init; }
}
