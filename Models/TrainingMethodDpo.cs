using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record TrainingMethodDpo
{
    [JsonPropertyName("method")]
    public string Method { get; } = "dpo";

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dpo_beta")]
    public double? DpoBeta { get; init; } = 0.1d;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rpo_alpha")]
    public double? RpoAlpha { get; init; } = 0d;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dpo_normalize_logratios_by_length")]
    public bool? DpoNormalizeLogratiosByLength { get; init; } = false;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dpo_reference_free")]
    public bool? DpoReferenceFree { get; init; } = false;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("simpo_gamma")]
    public double? SimpoGamma { get; init; } = 0d;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
