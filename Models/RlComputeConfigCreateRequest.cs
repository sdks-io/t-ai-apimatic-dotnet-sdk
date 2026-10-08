using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Compute layout to provision for a model resource
/// </summary>
public record RlComputeConfigCreateRequest
{
    /// <summary>
    /// Number of generator replicas. 0 runs the trainer only, with no generator.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("num_generator_replicas")]
    public int? NumGeneratorReplicas { get; init; } = 1;

    /// <summary>
    /// GPU type to provision. Omit to use the model's default GPU type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("gpu_type")]
    public GpuType1? GpuType { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
