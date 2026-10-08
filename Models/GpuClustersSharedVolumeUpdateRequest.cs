using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record GpuClustersSharedVolumeUpdateRequest
{
    /// <summary>
    /// ID of the volume.
    /// </summary>
    [JsonPropertyName("volume_id")]
    public required string VolumeId { get; init; }

    /// <summary>
    /// Size of the volume in TiB.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("size_tib")]
    public int? SizeTib { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
