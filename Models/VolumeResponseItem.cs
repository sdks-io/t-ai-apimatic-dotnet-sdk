using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record VolumeResponseItem
{
    /// <summary>
    /// Content currently available on a volume version.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("content")]
    public VolumeContent? Content { get; init; }

    /// <summary>
    /// CreatedAt is the ISO8601 timestamp when this volume was created
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }

    /// <summary>
    /// CurrentVersion is the current version number of this volume
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("current_version")]
    public int? CurrentVersion { get; init; }

    /// <summary>
    /// ID is the unique identifier for this volume
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// MountedBy is the list of deployment IDs currently mounting current volume version
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mounted_by")]
    public IReadOnlyList<string>? MountedBy { get; init; }

    /// <summary>
    /// Name is the name of the volume
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Object is the type identifier for this response (always "volume")
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object")]
    public string? Object { get; init; }

    /// <summary>
    /// Status of the current volume version.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public VolumeStatus3? Status { get; init; }

    /// <summary>
    /// Message explaining why the current volume version failed, when applicable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status_message")]
    public string? StatusMessage { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public VolumeType? Type { get; init; }

    /// <summary>
    /// UpdatedAt is the ISO8601 timestamp when this volume was last updated
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; init; }

    /// <summary>
    /// VersionHistory contains previous versions of this volume, keyed by version number
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version_history")]
    public IReadOnlyDictionary<string, VersionHistoryItem>? VersionHistory { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
