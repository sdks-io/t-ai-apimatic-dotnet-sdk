using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Compute layout provisioned for the resource.
/// </summary>
public record RlComputeConfig1
{
    /// <summary>
    /// Number of generator replicas. 0 means the resource runs the trainer only, with no generator.
    /// </summary>
    [JsonPropertyName("num_generator_replicas")]
    public required int NumGeneratorReplicas { get; init; }

    /// <summary>
    /// GPU type selected for this resource.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gpu_type")]
    public GpuType? GpuType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
