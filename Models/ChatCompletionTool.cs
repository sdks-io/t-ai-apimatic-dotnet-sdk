using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record ChatCompletionTool
{
    [JsonPropertyName("type")]
    public string Type { get; } = "function";

    [JsonPropertyName("function")]
    public required Function1 Function { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
