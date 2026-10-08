using TogetherApIs.Models;

namespace TogetherApIs.Requests.DeploymentsVolumes;

/// <summary>
/// The inputs of the CreateANewVolume operation.
/// </summary>
public sealed record CreateANewVolumeRequest
{
    /// <summary>
    /// Volume configuration
    /// </summary>
    public required CreateVolumeRequest Body { get; init; }
}
