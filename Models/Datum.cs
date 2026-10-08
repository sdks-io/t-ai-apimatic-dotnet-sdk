using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record Datum
{
    /// <summary>
    /// The object type, which is always <c>embedding</c>.
    /// </summary>
    [JsonPropertyName("object")]
    public string Object { get; } = "embedding";

    [JsonPropertyName("embedding")]
    public required IReadOnlyList<double> Embedding { get; init; }

    [JsonPropertyName("index")]
    public required int Index { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
