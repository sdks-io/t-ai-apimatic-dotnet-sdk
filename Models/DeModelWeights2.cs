using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Architecture, size, precision, and speculative-decoding metadata derived from the model files.
/// </summary>
public record DeModelWeights2
{
    /// <summary>
    /// Role of the weights: full model, speculative draft model, or LoRA adapter.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type3? Type { get; init; }

    /// <summary>
    /// Speculative decoding mechanism for speculator weights.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("speculatorMechanism")]
    public SpeculatorMechanism? SpeculatorMechanism { get; init; }

    /// <summary>
    /// Draft-model speculator family for draft speculative decoding.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("draftSpeculatorType")]
    public DraftSpeculatorType? DraftSpeculatorType { get; init; }

    /// <summary>
    /// Model architecture detected from the weight metadata.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("architecture")]
    public string? Architecture { get; init; }

    /// <summary>
    /// Maximum context length reported by the model metadata.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("contextLength")]
    public string? ContextLength { get; init; }

    /// <summary>
    /// Total parameter count and breakdown by numerical data type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("parameters")]
    public DeModelParameters2? Parameters { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
