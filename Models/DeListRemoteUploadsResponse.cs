using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

/// <summary>
/// Remote model import jobs and pagination metadata.
/// </summary>
public record DeListRemoteUploadsResponse
{
    /// <summary>
    /// Remote upload jobs.
    /// </summary>
    [JsonPropertyName("data")]
    public required IReadOnlyList<DeRemoteUpload> Data { get; init; }

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
