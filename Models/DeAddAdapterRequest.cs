using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Configuration for attaching a LoRA adapter to a deployment that has adapter loading enabled.
/// </summary>
public record DeAddAdapterRequest
{
    /// <summary>
    /// Adapter model identifier to attach.
    /// </summary>
    [JsonPropertyName("adapterModelId")]
    public required string AdapterModelId { get; init; }

    /// <summary>
    /// Optional adapter revision to pin. If omitted, the latest revision is resolved at request time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("adapterRevisionId")]
    public string? AdapterRevisionId { get; init; }

    /// <summary>
    /// Whether to evict the oldest adapter if the deployment is at adapter capacity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("force")]
    public bool? Force { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
