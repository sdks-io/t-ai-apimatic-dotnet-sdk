using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record EndpointsAdaptersRequest
{
    /// <summary>
    /// Combined identifier in format "endpoint_name:adapter_model_name".
    /// </summary>
    [JsonPropertyName("model_id")]
    public required string ModelId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
