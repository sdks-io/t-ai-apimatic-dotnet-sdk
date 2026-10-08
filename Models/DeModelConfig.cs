using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Immutable, user-facing configuration revision that defines how a compatible model runs, including engine and hardware selectors.
/// </summary>
public record DeModelConfig
{
    /// <summary>
    /// Config revision identifier.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Model, hardware, and runtime combinations certified for this config revision.
    /// </summary>
    [JsonPropertyName("certifications")]
    public required IReadOnlyList<DeCertification> Certifications { get; init; }

    /// <summary>
    /// Deprecated. Use <c>referenceModel</c>. Reference model identifier.
    /// </summary>
    [JsonPropertyName("referenceModelId")]
    public required string ReferenceModelId { get; init; }

    /// <summary>
    /// Hardware and runtime selectors used to place and configure replicas.
    /// </summary>
    [JsonPropertyName("selectors")]
    public required IReadOnlyList<DeSelector> Selectors { get; init; }

    /// <summary>
    /// ID of the project that owns the config revision. Public configs may be owned by a different project than the deployment.
    /// </summary>
    [JsonPropertyName("projectId")]
    public required string ProjectId { get; init; }

    /// <summary>
    /// Resource name of the referenced model, using <c>projects/{modelProject}/models/{modelId}</c>.
    /// </summary>
    [JsonPropertyName("referenceModel")]
    public required string ReferenceModel { get; init; }

    /// <summary>
    /// Resource name of the draft model, using <c>projects/{draftProject}/models/{modelId}</c>; empty when speculative decoding is not enabled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("draftModel")]
    public string? DraftModel { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
