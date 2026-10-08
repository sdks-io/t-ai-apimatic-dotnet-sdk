using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record VolumeMount
{
    /// <summary>
    /// MountPath is the path in the container where the volume mounts (e.g., "/data").
    /// </summary>
    [JsonPropertyName("mount_path")]
    public required string MountPath { get; init; }

    /// <summary>
    /// Name is the name of the volume to mount. Must reference an existing volume by name or ID
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Version is the volume version to mount. On create, defaults to the latest version. On update, defaults to the currently mounted version.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version")]
    public int? Version { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
