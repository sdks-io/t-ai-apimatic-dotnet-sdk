using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record GpuClustersSharedVolumes
{
    [JsonPropertyName("volumes")]
    public required IReadOnlyList<GpuClustersSharedVolume> Volumes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
