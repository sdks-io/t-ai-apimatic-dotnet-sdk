using System;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Asynchronous job that imports remote files into a registered model and creates a model revision.
/// </summary>
public record DeRemoteUpload
{
    /// <summary>
    /// Unique ID of the remote model import job.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// ID of the project that owns the import job.
    /// </summary>
    [JsonPropertyName("projectId")]
    public required string ProjectId { get; init; }

    /// <summary>
    /// ID of the registered model receiving the imported files.
    /// </summary>
    [JsonPropertyName("modelId")]
    public required string ModelId { get; init; }

    /// <summary>
    /// Hugging Face repository or presigned URL being imported.
    /// </summary>
    [JsonPropertyName("remoteUrl")]
    public required string RemoteUrl { get; init; }

    /// <summary>
    /// Current lifecycle state of the asynchronous import job.
    /// </summary>
    [JsonPropertyName("status")]
    public required Status Status { get; init; }

    /// <summary>
    /// Human-readable progress or failure detail for the current status.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("statusMessage")]
    public string? StatusMessage { get; init; }

    /// <summary>
    /// Number of times the import worker has restarted this job.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("restartCount")]
    public int? RestartCount { get; init; }

    /// <summary>
    /// Maximum worker restarts allowed before the job fails permanently.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maxRestarts")]
    public int? MaxRestarts { get; init; }

    /// <summary>
    /// Time when the import job was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>
    /// Time when the import job was last updated.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? UpdatedAt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
