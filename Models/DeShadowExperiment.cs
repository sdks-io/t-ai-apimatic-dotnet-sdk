using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Experiment that mirrors sampled endpoint requests to target deployments without changing client responses.
/// </summary>
public record DeShadowExperiment
{
    /// <summary>
    /// Output only. Unique shadow experiment identifier.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Output only. Project that owns the parent endpoint.
    /// </summary>
    [JsonPropertyName("projectId")]
    public required string ProjectId { get; init; }

    /// <summary>
    /// Output only. Endpoint whose traffic this experiment samples.
    /// </summary>
    [JsonPropertyName("endpointId")]
    public required string EndpointId { get; init; }

    /// <summary>
    /// Human-readable shadow experiment name, unique within the endpoint. At most 256 characters.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// User defined description.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Endpoint source and sampling configuration for mirrored requests.
    /// </summary>
    [JsonPropertyName("source")]
    public required DeShadowExperimentSourceResponse Source { get; init; }

    /// <summary>
    /// Target deployments that receive mirrored traffic.
    /// </summary>
    [JsonPropertyName("targets")]
    public required IReadOnlyList<DeShadowExperimentTarget> Targets { get; init; }

    /// <summary>
    /// Identifier of the principal that created the experiment.
    /// </summary>
    [JsonPropertyName("createdBy")]
    public required string CreatedBy { get; init; }

    /// <summary>
    /// Timestamp when the experiment was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// Timestamp when the experiment was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTimeOffset UpdatedAt { get; init; }

    /// <summary>
    /// Opaque version tag for optimistic concurrency control. Returned on read; set it on update or delete requests for consistent read-modify-write.
    /// </summary>
    [JsonPropertyName("etag")]
    public required string Etag { get; init; }

    /// <summary>
    /// Derived serving state, active when the experiment has at least one target.
    /// </summary>
    [JsonPropertyName("state")]
    public required State5 State { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
