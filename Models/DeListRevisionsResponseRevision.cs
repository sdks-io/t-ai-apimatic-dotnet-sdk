using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Revision metadata for a volume object.
/// </summary>
public record DeListRevisionsResponseRevision
{
    /// <summary>
    /// Revision identifier.
    /// </summary>
    [JsonPropertyName("revisionId")]
    public required string RevisionId { get; init; }

    /// <summary>
    /// Timestamp when the revision was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// Current validation status for the revision.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("validationStatus")]
    public ValidationStatus? ValidationStatus { get; init; }

    /// <summary>
    /// Timestamp when validation most recently ran for the revision.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lastValidatedAt")]
    public DateTimeOffset? LastValidatedAt { get; init; }

    /// <summary>
    /// Validation errors reported for the revision.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("validationErrors")]
    public IReadOnlyList<DeRevisionValidationError>? ValidationErrors { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
