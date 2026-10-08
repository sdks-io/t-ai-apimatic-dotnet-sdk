using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record GpuClustersSharedVolumeDeleteResponse
{
    [JsonPropertyName("success")]
    public required bool Success { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
