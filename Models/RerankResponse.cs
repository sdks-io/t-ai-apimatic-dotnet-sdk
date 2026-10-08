using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record RerankResponse
{
    /// <summary>
    /// The object type, which is always <c>rerank</c>.
    /// </summary>
    [JsonPropertyName("object")]
    public string Object { get; } = "rerank";

    /// <summary>
    /// Request ID
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The model to be used for the rerank request.
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; init; }

    [JsonPropertyName("results")]
    public required IReadOnlyList<Result> Results { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usage")]
    public UsageData? Usage { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
