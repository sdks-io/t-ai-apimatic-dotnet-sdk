using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record EndpointsResponse
{
    /// <summary>
    /// The object type, which is always <c>list</c>.
    /// </summary>
    [JsonPropertyName("object")]
    public string Object { get; } = "list";

    [JsonPropertyName("data")]
    public required IReadOnlyList<ListEndpoint> Data { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
