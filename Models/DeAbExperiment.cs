using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Managed cohort split that subdivides a control deployment's live traffic among the control and one or more variants.
/// </summary>
public record DeAbExperiment
{
    /// <summary>
    /// Output only. Unique A/B experiment identifier.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Output only. Project that owns the parent endpoint.
    /// </summary>
    [JsonPropertyName("projectId")]
    public required string ProjectId { get; init; }

    /// <summary>
    /// Output only. Endpoint this A/B experiment belongs to.
    /// </summary>
    [JsonPropertyName("endpointId")]
    public required string EndpointId { get; init; }

    /// <summary>
    /// Human-readable A/B experiment name, unique within the endpoint.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Optional free-form description.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Two to 20 participating deployments with exactly one control and percentages that add up to 100.
    /// </summary>
    [JsonPropertyName("members")]
    public required IReadOnlyList<DeAbExperimentMember> Members { get; init; }

    /// <summary>
    /// Output only. Identifier of the principal that created the A/B experiment.
    /// </summary>
    [JsonPropertyName("createdBy")]
    public required string CreatedBy { get; init; }

    /// <summary>
    /// Output only. Timestamp when the A/B experiment was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// Output only. Timestamp when the A/B experiment was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTimeOffset UpdatedAt { get; init; }

    /// <summary>
    /// Optional opaque version tag for optimistic concurrency control.
    /// </summary>
    [JsonPropertyName("etag")]
    public required string Etag { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
