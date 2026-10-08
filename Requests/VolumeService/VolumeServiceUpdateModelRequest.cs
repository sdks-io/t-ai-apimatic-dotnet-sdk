using TogetherApIs.Models;

namespace TogetherApIs.Requests.VolumeService;

/// <summary>
/// The inputs of the VolumeServiceUpdateModel operation.
/// </summary>
public sealed record VolumeServiceUpdateModelRequest
{
    public required string ProjectId { get; init; }

    public required string Id { get; init; }

    public string? UpdateMask { get; init; }

    public required DeUpdateModelRequest Body { get; init; }
}
