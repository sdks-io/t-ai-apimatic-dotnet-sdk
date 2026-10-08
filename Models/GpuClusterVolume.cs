using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record GpuClusterVolume
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
    /// Current status of the volume.
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
