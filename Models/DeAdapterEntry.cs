using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Adapter attached to a deployment with desired revision and observed load state.
/// </summary>
public record DeAdapterEntry
{
    /// <summary>
    /// Adapter model identifier attached to the deployment.
    /// </summary>
    [JsonPropertyName("adapterModelId")]
    public required string AdapterModelId { get; init; }

    /// <summary>
    /// Adapter revision pinned on the deployment.
    /// </summary>
    [JsonPropertyName("desiredRevisionId")]
    public required string DesiredRevisionId { get; init; }

    /// <summary>
    /// Per-cluster adapter load state reported by the controller.
    /// </summary>
    [JsonPropertyName("perCluster")]
    public required IReadOnlyList<DeDeploymentAdapterStatus> PerCluster { get; init; }

    /// <summary>
    /// Row-level etag required for UpdateAdapter and RemoveAdapter.
    /// </summary>
    [JsonPropertyName("etag")]
    public required string Etag { get; init; }

    /// <summary>
    /// Resource name of the adapter model, using projects/{projectId}/models/{adapterModelId}.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adapterModel")]
    public string? AdapterModel { get; init; }

    /// <summary>
    /// Resource name of the adapter model revision pinned on the deployment, using projects/{projectId}/models/{adapterModelId}/revisions/{revisionId}.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("desiredRevision")]
    public string? DesiredRevision { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
