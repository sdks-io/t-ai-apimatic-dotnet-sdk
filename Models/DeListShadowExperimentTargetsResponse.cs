using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Response containing shadow experiment targets and pagination metadata.
/// </summary>
public record DeListShadowExperimentTargetsResponse
{
    /// <summary>
    /// Target deployments under the shadow experiment.
    /// </summary>
    [JsonPropertyName("data")]
    public required IReadOnlyList<DeShadowExperimentTarget> Data { get; init; }

    /// <summary>
    /// Cursor for the next page. Null if there are no more results.
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
