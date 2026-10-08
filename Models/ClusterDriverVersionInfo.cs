using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// NVIDIA software configuration available in the region.
/// </summary>
public record ClusterDriverVersionInfo
{
    /// <summary>
    /// Semantic CUDA version without operating system text.
    /// </summary>
    [JsonPropertyName("cuda_version")]
    public required string CudaVersion { get; init; }

    /// <summary>
    /// NVIDIA driver version.
    /// </summary>
    [JsonPropertyName("nvidia_driver_version")]
    public required string NvidiaDriverVersion { get; init; }

    /// <summary>
    /// Region-specific NVIDIA catalog ID to send as nvidia_version_id when creating a cluster.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Operating system image family for this catalog entry.
    /// </summary>
    [JsonPropertyName("os")]
    public required string Os { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
