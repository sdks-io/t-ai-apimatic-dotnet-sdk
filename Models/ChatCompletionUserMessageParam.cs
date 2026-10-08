using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;
using TogetherApIs.Models.AnyOf;

namespace TogetherApIs.Models;

public record ChatCompletionUserMessageParam
{
    /// <summary>
    /// The content of the message, which can either be a simple string or a structured format.
    /// </summary>
    [JsonPropertyName("content")]
    public required ChatCompletionUserMessageContent Content { get; init; }

    [JsonPropertyName("role")]
    public string Role { get; } = "user";

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
