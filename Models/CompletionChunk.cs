using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.Enums;

namespace TogetherApIs.Models;

public record CompletionChunk
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    [JsonPropertyName("token")]
    public required CompletionToken Token { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created")]
    public int? Created { get; init; }

    /// <summary>
    /// The object type, which is always <c>completion.chunk</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("object")]
    public Object1? Object { get; init; }

    [JsonPropertyName("choices")]
    public required IReadOnlyList<CompletionChoice> Choices { get; init; }

    [JsonPropertyName("usage")]
    public required UsageData? Usage { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("seed")]
    public int? Seed { get; init; }

    [JsonPropertyName("finish_reason")]
    public required FinishReason? FinishReason { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
