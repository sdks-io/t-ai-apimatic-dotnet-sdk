using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Controller-reported load state for an adapter on one deployment cluster.
/// </summary>
public record DeDeploymentAdapterStatus
{
    /// <summary>
    /// Adapter model identifier for this status row.
    /// </summary>
    [JsonPropertyName("adapterModelId")]
    public required string AdapterModelId { get; init; }

    /// <summary>
    /// Cluster reporting this adapter status.
    /// </summary>
    [JsonPropertyName("clusterId")]
    public required string ClusterId { get; init; }

    /// <summary>
    /// Adapter revision currently loaded on pods in this cluster.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("realizedRevisionId")]
    public string? RealizedRevisionId { get; init; }

    /// <summary>
    /// Adapter row etag observed by the controller when it wrote this status.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("realizedEtag")]
    public string? RealizedEtag { get; init; }

    /// <summary>
    /// Current adapter load state in this cluster.
    /// </summary>
    [JsonPropertyName("state")]
    public required State2 State { get; init; }

    /// <summary>
    /// Stable reason code for the current adapter state.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }

    /// <summary>
    /// Human-readable details about the current adapter state.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("message")]
    public string? Message { get; init; }

    /// <summary>
    /// Number of pods with the adapter ready to serve.
    /// </summary>
    [JsonPropertyName("readyPodCount")]
    public required int ReadyPodCount { get; init; }

    /// <summary>
    /// Number of pods that failed to load the adapter.
    /// </summary>
    [JsonPropertyName("failedPodCount")]
    public required int FailedPodCount { get; init; }

    /// <summary>
    /// Total pods expected to report adapter load state.
    /// </summary>
    [JsonPropertyName("totalPodCount")]
    public required int TotalPodCount { get; init; }

    /// <summary>
    /// Time when the adapter first reached READY in this cluster.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("loadedAt")]
    public DateTimeOffset? LoadedAt { get; init; }

    /// <summary>
    /// Time when this adapter status was last updated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? UpdatedAt { get; init; }

    /// <summary>
    /// Resource name of the adapter model, using projects/{projectId}/models/{adapterModelId}.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adapterModel")]
    public string? AdapterModel { get; init; }

    /// <summary>
    /// Resource name of the adapter model revision currently loaded in this cluster, using projects/{projectId}/models/{adapterModelId}/revisions/{revisionId}.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("realizedRevision")]
    public string? RealizedRevision { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
