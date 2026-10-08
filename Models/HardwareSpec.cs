using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Detailed specifications of a hardware configuration
/// </summary>
public record HardwareSpec
{
    /// <summary>
    /// The type/model of GPU
    /// </summary>
    [JsonPropertyName("gpu_type")]
    public required string GpuType { get; init; }

    /// <summary>
    /// The GPU interconnect technology
    /// </summary>
    [JsonPropertyName("gpu_link")]
    public required string GpuLink { get; init; }

    /// <summary>
    /// Amount of GPU memory in GB
    /// </summary>
    [JsonPropertyName("gpu_memory")]
    public required double GpuMemory { get; init; }

    /// <summary>
    /// Number of GPUs in this configuration
    /// </summary>
    [JsonPropertyName("gpu_count")]
    public required int GpuCount { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
