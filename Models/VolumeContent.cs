using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Content currently available on a volume version.
/// </summary>
public record VolumeContent
{
    /// <summary>
    /// Files is the list of files to preload into the volume, if the volume content type is "files".
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("files")]
    public IReadOnlyList<FileInfo>? Files { get; init; }

    /// <summary>
    /// External source Together copied into this volume version.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("origin")]
    public VolumeOrigin1? Origin { get; init; }

    /// <summary>
    /// SourcePrefix is the file path prefix for the content to be preloaded into the volume
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("source_prefix")]
    public string? SourcePrefix { get; init; }

    /// <summary>
    /// Type is the content type (currently only "files" is supported which allows preloading files uploaded via Files API into the volume)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type16? Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
