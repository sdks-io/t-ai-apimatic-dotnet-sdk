namespace TogetherApIs.Requests.VolumeService;

/// <summary>
/// The inputs of the VolumeServiceDeleteModel operation.
/// </summary>
public sealed record VolumeServiceDeleteModelRequest
{
    public required string ProjectId { get; init; }

    public required string Id { get; init; }
}
