using TogetherApIs.Models;

namespace TogetherApIs.Requests.VolumeService;

/// <summary>
/// The inputs of the VolumeServiceCreateModel operation.
/// </summary>
public sealed record VolumeServiceCreateModelRequest
{
    public required string ProjectId { get; init; }

    public required DeCreateModelRequest Body { get; init; }
}
