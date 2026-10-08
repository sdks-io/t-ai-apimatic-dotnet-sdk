namespace TogetherApIs.Requests.VolumeService;

/// <summary>
/// The inputs of the VolumeServiceGetModel operation.
/// </summary>
public sealed record VolumeServiceGetModelRequest
{
    public required string ProjectId { get; init; }

    public required string Id { get; init; }
}
