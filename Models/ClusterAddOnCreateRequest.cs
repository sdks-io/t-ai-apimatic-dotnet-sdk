using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record ClusterAddOnCreateRequest
{
    /// <summary>
    /// Human-readable name for this add-on instance.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Type of add-on. Valid values: 'dashboard', 'ingress', 'torchpass', 'headlamp'.
    /// </summary>
    [JsonPropertyName("add_on_type")]
    public required string AddOnType { get; init; }

    /// <summary>
    /// Configuration for a cluster add-on.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("config")]
    public AddOnConfig? Config { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
