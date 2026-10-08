using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record GpuClusterDeleteResponse
{
    [JsonPropertyName("cluster_id")]
    public required string ClusterId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
