using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Certification result for a model, config, and optional draft-model combination.
/// </summary>
public record DeCertification
{
    /// <summary>
    /// Product or serving environment for which the combination was evaluated.
    /// </summary>
    [JsonPropertyName("target")]
    public required Target Target { get; init; }

    /// <summary>
    /// Whether the model and config combination passed certification.
    /// </summary>
    [JsonPropertyName("certificationType")]
    public required CertificationType CertificationType { get; init; }

    /// <summary>
    /// Time when the certification decision was recorded.
    /// </summary>
    [JsonPropertyName("certifiedAt")]
    public required DateTimeOffset CertifiedAt { get; init; }

    /// <summary>
    /// Service or reviewer that recorded the certification.
    /// </summary>
    [JsonPropertyName("certifiedBy")]
    public required string CertifiedBy { get; init; }

    /// <summary>
    /// Human-readable certification notes or limitations.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notes")]
    public string? Notes { get; init; }

    /// <summary>
    /// Resource name of the certified model.
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; init; }

    /// <summary>
    /// Revision identifier of the certified model.
    /// </summary>
    [JsonPropertyName("modelRevisionId")]
    public required string ModelRevisionId { get; init; }

    /// <summary>
    /// Resource name of the certified draft model.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("draftModel")]
    public string? DraftModel { get; init; }

    /// <summary>
    /// Revision identifier of the certified draft model.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("draftModelRevisionId")]
    public string? DraftModelRevisionId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
