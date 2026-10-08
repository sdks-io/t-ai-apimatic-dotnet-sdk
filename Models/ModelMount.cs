using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record ModelMount
{
    /// <summary>
    /// Model registry identifier (<c>ml_...</c>) whose weights are mounted.
    /// </summary>
    [JsonPropertyName("model_id")]
    public required string ModelId { get; init; }

    /// <summary>
    /// Container path where model weights are mounted, such as <c>/models</c>.
    /// </summary>
    [JsonPropertyName("mount_path")]
    public required string MountPath { get; init; }

    /// <summary>
    /// Optional validated revision identifier (<c>rv_...</c>) to pin; defaults to the latest validated revision.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("revision_id")]
    public string? RevisionId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
