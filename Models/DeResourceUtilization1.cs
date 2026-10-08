using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Average CPU, GPU, memory, and network utilization.
/// </summary>
public record DeResourceUtilization1
{
    /// <summary>
    /// Average CPU utilization across replicas, as a percentage.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cpuUtilization")]
    public double? CpuUtilization { get; init; }

    /// <summary>
    /// Average GPU compute utilization across replicas, as a percentage.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gpuUtilization")]
    public double? GpuUtilization { get; init; }

    /// <summary>
    /// Average system memory utilization across replicas, as a percentage.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("memoryUtilization")]
    public double? MemoryUtilization { get; init; }

    /// <summary>
    /// Average GPU memory utilization across replicas, as a percentage.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gpuMemoryUtilization")]
    public double? GpuMemoryUtilization { get; init; }

    /// <summary>
    /// Average network throughput across replicas, in megabits per second.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("networkBandwidthMbps")]
    public double? NetworkBandwidthMbps { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
