using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Metadata for a previous volume version.
/// </summary>
public record VersionHistoryItem
{
    /// <summary>
    /// Content configuration used to create this version.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("content")]
    public VolumeContentRequest1? Content { get; init; }

    /// <summary>
    /// Deployment IDs currently mounting this version.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mounted_by")]
    public IReadOnlyList<string>? MountedBy { get; init; }

    /// <summary>
    /// Status of this volume version.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public VolumeStatus1? Status { get; init; }

    /// <summary>
    /// Message explaining why this volume version failed, when applicable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status_message")]
    public string? StatusMessage { get; init; }

    /// <summary>
    /// Numeric version identifier for this volume content.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
