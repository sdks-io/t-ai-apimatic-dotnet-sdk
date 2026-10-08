using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Stable inference entry point that groups deployments and routes requests among them.
/// </summary>
public record DeEndpoint
{
    /// <summary>
    /// Unique endpoint identifier.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// ID of the project that owns the endpoint.
    /// </summary>
    [JsonPropertyName("projectId")]
    public required string ProjectId { get; init; }

    /// <summary>
    /// Project-qualified endpoint name in the form <c>&lt;project_slug&gt;/&lt;endpoint_name&gt;</c>.
    /// Pass this value as <c>model</c> in inference requests. Create and update requests
    /// may use either a bare endpoint name or the qualified form; a supplied project
    /// slug must match the project in the request path.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Timestamp when the endpoint was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// Output only. Timestamp when the endpoint was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTimeOffset UpdatedAt { get; init; }

    /// <summary>
    /// Opaque version tag for optimistic concurrency control.
    /// Supply on update/delete to ensure consistent read-modify-write.
    /// If not set, the write overwrites based on current state.
    /// </summary>
    [JsonPropertyName("etag")]
    public required string Etag { get; init; }

    /// <summary>
    /// Deployments eligible for live traffic and their capacity weights. An empty list leaves the endpoint unrouted.
    /// </summary>
    [JsonPropertyName("trafficSplit")]
    public required IReadOnlyList<DeTrafficSplitEntry> TrafficSplit { get; init; }

    /// <summary>
    /// Who can discover the endpoint. <c>VISIBILITY_PRIVATE</c> restricts it to the project; <c>VISIBILITY_INTERNAL</c> shares it with the organization.
    /// </summary>
    [JsonPropertyName("visibility")]
    public Visibility Visibility { get; init; } = Visibility.VisibilityPrivate;

    /// <summary>
    /// Serving class of the endpoint. Reserved endpoints use reserved capacity.
    /// </summary>
    [JsonPropertyName("endpointType")]
    public required EndpointType EndpointType { get; init; }

    /// <summary>
    /// Lightweight summaries of deployments under this endpoint.
    /// Retrieve a deployment through the endpoint's deployment API for full details.
    /// </summary>
    [JsonPropertyName("deployments")]
    public required IReadOnlyList<DeDeploymentSummary> Deployments { get; init; }

    /// <summary>
    /// ID of the currently active rollout in an in-flight state, including paused.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("activeRolloutId")]
    public string? ActiveRolloutId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
