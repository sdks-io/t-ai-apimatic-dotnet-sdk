using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Hardware instance types available for inference deployments.
/// </summary>
public record DeListInferenceInstanceTypesResponse
{
    /// <summary>
    /// Instance types available for inference.
    /// </summary>
    [JsonPropertyName("data")]
    public required IReadOnlyList<DeInferenceInstanceType> Data { get; init; }

    /// <summary>
    /// Cursor for the next page. Always null today because this catalog is returned in full.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("next_cursor")]
    public string? NextCursor { get; init; }

    /// <summary>
    /// Object type. Always <c>list</c>.
    /// </summary>
    [JsonPropertyName("object")]
    public string Object { get; } = "list";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
