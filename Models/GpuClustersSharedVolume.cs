using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record GpuClustersSharedVolume
{
    /// <summary>
    /// ID of the volume.
    /// </summary>
    [JsonPropertyName("volume_id")]
    public required string VolumeId { get; init; }

    /// <summary>
    /// User provided name of the volume.
    /// </summary>
    [JsonPropertyName("volume_name")]
    public required string VolumeName { get; init; }

    /// <summary>
    /// Size of the volume in TiB.
    /// </summary>
    [JsonPropertyName("size_tib")]
    public required int SizeTib { get; init; }

    /// <summary>
    /// Current status of the shared volume.
    /// </summary>
    [JsonPropertyName("status")]
    public required Status3 Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
