using TogetherApIs.Models;

namespace TogetherApIs.Requests.Volumes;

/// <summary>
/// The inputs of the UpdateAVolume operation.
/// </summary>
public sealed record UpdateAVolumeRequest
{
    public required string Id { get; init; }

    /// <summary>
    /// Updated volume configuration
    /// </summary>
    public required UpdateVolumeRequest Body { get; init; }
}
