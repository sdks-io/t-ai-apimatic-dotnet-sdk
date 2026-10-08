using System.Collections.Generic;
using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record ChatCompletionChunk
{
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The object type, which is always <c>chat.completion.chunk</c>.
    /// </summary>
    [JsonPropertyName("object")]
    public string Object { get; } = "chat.completion.chunk";

    [JsonPropertyName("created")]
    public required int Created { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("system_fingerprint")]
    public string? SystemFingerprint { get; init; }

    [JsonPropertyName("model")]
    public required string Model { get; init; }

    [JsonPropertyName("choices")]
    public required IReadOnlyList<ChatCompletionChoice2> Choices { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("usage")]
    public UsageData? Usage { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("warnings")]
    public IReadOnlyList<InferenceWarning>? Warnings { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
