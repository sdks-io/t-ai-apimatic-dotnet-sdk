using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// AddOnInfo is returned in cluster responses and add-on CRUD operations.
/// </summary>
public record AddOnInfo
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonPropertyName("add_on_type")]
    public required string AddOnType { get; init; }

    /// <summary>
    /// Configuration for a cluster add-on.
    /// </summary>
    [JsonPropertyName("config")]
    public required AddOnConfig Config { get; init; }

    /// <summary>
    /// State for a cluster add-on.
    /// </summary>
    [JsonPropertyName("state")]
    public required AddOnState State { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
