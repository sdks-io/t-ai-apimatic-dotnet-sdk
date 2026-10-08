using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Files and aggregate size information for one model revision.
/// </summary>
public record DeListFilesResponse
{
    /// <summary>
    /// Files in the selected model revision.
    /// </summary>
    [JsonPropertyName("data")]
    public required IReadOnlyList<DeListFilesResponseFile> Data { get; init; }

    /// <summary>
    /// Cursor for the next page. Null if there are no more results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("next_cursor")]
    public string? NextCursor { get; init; }

    [JsonPropertyName("object")]
    public string Object { get; } = "list";

    /// <summary>
    /// ID of the model revision whose files are listed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("revisionId")]
    public string? RevisionId { get; init; }

    /// <summary>
    /// Time when the listed model revision was created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("revisionCreatedAt")]
    public DateTimeOffset? RevisionCreatedAt { get; init; }

    /// <summary>
    /// Total size of all files in the revision, in bytes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("totalSizeBytes")]
    public string? TotalSizeBytes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
