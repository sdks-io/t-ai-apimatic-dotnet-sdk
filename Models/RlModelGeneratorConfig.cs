using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Inference capabilities and limits for a model on one GPU type. If present, the model can be provisioned with one or more generator replicas.
/// </summary>
public record RlModelGeneratorConfig
{
    /// <summary>
    /// Maximum tokens in a single inference request (prompt + completion)
    /// </summary>
    [JsonPropertyName("context_length")]
    public required int ContextLength { get; init; }

    /// <summary>
    /// Default sampling parameters used for sample requests.
    /// </summary>
    [JsonPropertyName("sampling_defaults")]
    public required RlModelSamplingDefaults1 SamplingDefaults { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
