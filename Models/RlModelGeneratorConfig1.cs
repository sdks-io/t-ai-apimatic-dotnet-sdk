using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Inference config for this GPU type. Set when the model can be provisioned with generator replicas on this GPU type.
/// </summary>
public record RlModelGeneratorConfig1
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
