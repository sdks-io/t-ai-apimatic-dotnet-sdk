using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

/// <summary>
/// Content specifies the new content to preload to this volume.
/// </summary>
public record VolumeContentRequest
{
    /// <summary>
    /// External source Together copies into a new volume version; mutually exclusive with source_prefix.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("origin")]
    public VolumeOrigin3? Origin { get; init; }

    /// <summary>
    /// SourcePrefix is the file path prefix for the content to be preloaded into the volume. Mutually exclusive with Origin
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
