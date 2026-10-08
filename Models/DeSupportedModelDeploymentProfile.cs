using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Certified deployment profile for a supported model.
/// </summary>
public record DeSupportedModelDeploymentProfile
{
    /// <summary>
    /// Stable profile identifier, usually the certified config id.
    /// </summary>
    [JsonPropertyName("profileId")]
    public required string ProfileId { get; init; }

    /// <summary>
    /// Certified configuration revision identifier.
    /// </summary>
    [JsonPropertyName("certifiedConfigRevisionId")]
    public required string CertifiedConfigRevisionId { get; init; }

    /// <summary>
    /// Certified model weight revision identifier, if available.
    /// </summary>
    [JsonPropertyName("certifiedModelRevisionId")]
    public required string CertifiedModelRevisionId { get; init; }

    /// <summary>
    /// GPU instance type for the profile.
    /// </summary>
    [JsonPropertyName("gpuType")]
    public required string GpuType { get; init; }

    /// <summary>
    /// Number of GPUs required by the profile.
    /// </summary>
    [JsonPropertyName("gpuCount")]
    public required int GpuCount { get; init; }

    /// <summary>
    /// Quantization method for the profile, if available.
    /// </summary>
    [JsonPropertyName("quantization")]
    public required string Quantization { get; init; }

    /// <summary>
    /// Deprecated. Use <c>parallelism</c>. Legacy tensor-parallel shard count for the profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tensorParallelSize")]
    public int? TensorParallelSize { get; init; }

    /// <summary>
    /// Performance benchmarks for the profile, if available.
    /// </summary>
    [JsonPropertyName("performanceBenchmarks")]
    public required DeSupportedModelPerformanceBenchmarks2 PerformanceBenchmarks { get; init; }

    /// <summary>
    /// Certified config revision in the form <c>projects/{projectId}/configs/{configRevisionId}</c>. Omitted when the profile does not pin a config.
    /// </summary>
    [JsonPropertyName("config")]
    public required string Config { get; init; }

    /// <summary>
    /// Deployable model resource in the form <c>projects/{projectId}/models/{modelId}[/revisions/{revisionId}]</c>. Omitted when the profile does not pin model weights.
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; init; }

    /// <summary>
    /// Free-form parallelism spec for the profile, such as TP8, TP4, EP, or PD; supersedes tensor_parallel_size.
    /// </summary>
    [JsonPropertyName("parallelism")]
    public required string Parallelism { get; init; }

    /// <summary>
    /// Fully-qualified deploy model name in the form <c>{projectSlug}/{modelName}</c>, such as <c>Qwen/Qwen3.5-9B-FP8</c>; empty when no public model is linked.
    /// </summary>
    [JsonPropertyName("modelName")]
    public required string ModelName { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
