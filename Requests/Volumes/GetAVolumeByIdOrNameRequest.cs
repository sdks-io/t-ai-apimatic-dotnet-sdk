namespace TogetherApIs.Requests.Volumes;

/// <summary>
/// The inputs of the GetAVolumeByIdOrName operation.
/// </summary>
public sealed record GetAVolumeByIdOrNameRequest
{
    public required string Id { get; init; }

    public int? Version { get; init; }
}
