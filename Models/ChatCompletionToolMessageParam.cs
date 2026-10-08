using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record ChatCompletionToolMessageParam
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("role")]
    public string Role { get; } = "tool";

    [JsonPropertyName("content")]
    public required string Content { get; init; }

    [JsonPropertyName("tool_call_id")]
    public required string ToolCallId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
