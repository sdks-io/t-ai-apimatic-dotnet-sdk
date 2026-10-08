using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record CreateVolumeRequest
{
    /// <summary>
    /// Content specifies the content configuration for this volume
    /// </summary>
    [JsonPropertyName("content")]
    public required VolumeContentRequest Content { get; init; }

    /// <summary>
    /// Name is the unique identifier for the volume within the project
    /// </summary>
    [JsonPropertyName("name")]
    [StringLength(100, MinimumLength = 1)]
    public required string Name { get; init; }

    /// <summary>
    /// Type is the volume type (currently only "readOnly" is supported)
    /// </summary>
    [JsonPropertyName("type")]
    public required VolumeType Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
