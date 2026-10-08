using System.Text.Json.Serialization;
using TogetherApIs.Core.Models;

namespace TogetherApIs.Models;

public record Pricing
{
    [JsonPropertyName("base")]
    public required double Base { get; init; }

    [JsonPropertyName("finetune")]
    public required double Finetune { get; init; }

    [JsonPropertyName("hourly")]
    public required double Hourly { get; init; }

    [JsonPropertyName("input")]
    public required double Input { get; init; }

    [JsonPropertyName("output")]
    public required double Output { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cached_input")]
    public double? CachedInput { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
