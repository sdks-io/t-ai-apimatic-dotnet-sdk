using TogetherApIs.Models.Enums;

namespace TogetherApIs.Requests.FineTuning;

/// <summary>
/// The inputs of the DownloadModel operation.
/// </summary>
public sealed record DownloadModelRequest
{
    public required string FtId { get; init; }

    public int? CheckpointStep { get; init; }

    public Checkpoint1? Checkpoint { get; init; }
}
