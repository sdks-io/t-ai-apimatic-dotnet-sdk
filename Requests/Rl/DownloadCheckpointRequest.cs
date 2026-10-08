using TogetherApIs.Models.Enums;

namespace TogetherApIs.Requests.Rl;

/// <summary>
/// The inputs of the DownloadCheckpoint operation.
/// </summary>
public sealed record DownloadCheckpointRequest
{
    public required string Id { get; init; }

    public RlCheckpointVariant1 Variant { get; init; } = RlCheckpointVariant1.CheckpointVariantUnspecified;
}
